using DataLayer;
using SuperPrompt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MoneyBin2 {
    public partial class frmCalendario : DataForm {
        private readonly string _folder = Properties.Settings.Default.CalendarioPastaPagamentos;
        private int _previousIndex = -1;

        #region FORM ------------------------------------
        public frmCalendario() {
            InitializeComponent();
            _mainBindingSource = bsCalendar;
            toolStripMenu.Items.Add(tsbPrevMonth);
            toolStripMenu.Items.Add(toolStripComboBoxMes);
            toolStripMenu.Items.Add(tsbNextMonth);
            toolStripMenu.Items.Add(toolStripEncontrarPagamentos);

            dgvCalendario.FormatColumnByHeader("Dia", dgvCalendario.StyleInteger, 40);
            dgvCalendario.FormatColumnByHeader("Descrição", null, 180);
            dgvCalendario.FormatColumnByHeader("Agendado?", null, 70);
            dgvCalendario.FormatColumnByHeader("Pago?", null, 70);
            dgvCalendario.FormatColumnByHeader("Data", dgvCalendario.StyleDateTimeShort, 110);
            dgvCalendario.FormatColumnByHeader("Valor", dgvCalendario.StyleCurrency, 90);

            var meses = _ctx.spCalendarioMeses().ToList();

            if (!meses.Any()) {
                _previousIndex = 0;
                meses.Insert(0, new CalendarioMes());
            }
            meses.Insert(0, meses[0].ProximoMes);

            toolStripComboBoxMes.ComboBox.ValueMember = "MesAno";
            toolStripComboBoxMes.ComboBox.DisplayMember = "MesAno";
            toolStripComboBoxMes.ComboBox.DataSource = meses;

            _previousIndex = 1;
            toolStripComboBoxMes.SelectedIndex = 1;

            SetHeight();
            //ResizeForm(dgvCalendario);
            UpdateToolbarButtons();
        }

        protected override void DataForm_FormClosing(object sender, FormClosingEventArgs e) {
            dgvCalendario.EndEdit();
            base.DataForm_FormClosing(sender, e);
        }

        private void SetHeight() {
            Height = 10 + toolStripMenu.Height + statusStrip.Height +
                     dgvCalendario.ColumnHeadersHeight +
                     dgvCalendario.RowCount * (8 + dgvCalendario.RowTemplate.Height);
        }
        #endregion FORM ---------------------------------

        #region DATAGRIDVIEW ------------------------------------
        private void dgvCalendario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var cal = (CalendarioItem)dgvCalendario.Rows[e.RowIndex].DataBoundItem;
            if (cal.Pago) {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }

        private void dgvCalendario_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1 || dgvCalendario.Columns[e.ColumnIndex].Name != "Agendado") {
                return;
            }
            var item = (CalendarioItem)dgvCalendario.CurrentRow.DataBoundItem;
            if (item.Agendado) {
                ProcurarAgendamento(item);
            }
            else {
                item.AgendadoData = null;
                item.PagamentoData = null;
                item.Valor = null;
            }
            dgvCalendario.Refresh();
        }

        private void dgvCalendario_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            UpdateToolbarButtons();
        }

        private void dgvCalendario_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            var row = dgvCalendario.CurrentRow.Index;
            var col = dgvCalendario.CurrentCell.ColumnIndex;
            if (row == -1 || dgvCalendario.Columns[col].Name != "Agendado") {
                return;
            }
            dgvCalendario.EndEdit();
        }
        #endregion DATAGRIDVIEW ---------------------------------

        #region TOOLBAR ------------------------------------
        private void toolStripComboBoxMes_SelectedIndexChanged(object sender, EventArgs e) {
            if (_previousIndex == -1) {
                return;
            }

            var reload = false;
            if (toolStripComboBoxMes.SelectedIndex == 0) {
                var novoMes = (CalendarioMes)toolStripComboBoxMes.Items[0];
                if (MessageBox.Show($"Mês {novoMes.Mes12} não existe. Cria?", Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                    reload = true;
                }
                else {
                    var pagamentos = _ctx.Pagamentos
                        .Where(p => (p.Meses & novoMes.Mes) == novoMes.Mes)
                        .ToList() // ToList() é necessário
                        .Select(p => new CalendarioItem()
                        {
                            Mes = novoMes.Mes,
                            Ano = novoMes.Ano,
                            PagamentoID = p.ID,
                            Pago = false
                        });
                    _ctx.Calendario.AddRange(pagamentos);
                    _ctx.SaveChanges();
                }
            }
            if (reload) {
                toolStripComboBoxMes.SelectedIndex = _previousIndex;
            }

            var mes = (CalendarioMes)toolStripComboBoxMes.SelectedItem;
            bsCalendar.DataSource = _ctx.spCalendarioRefresh(mes.Ano, mes.Mes);
            SetHeight();
            _previousIndex = toolStripComboBoxMes.SelectedIndex;
            EnableNavigationButtons();
            UpdateToolbarButtons();
        }

        protected override void tsbSave_Click(object sender, EventArgs e) {
            dgvCalendario.EndEdit();
            base.tsbSave_Click(sender, e);
        }

        protected override void tsbRevert_Click(object sender, EventArgs e) {
            dgvCalendario.EndEdit();
            base.tsbRevert_Click(sender, e);
            dgvCalendario.Refresh();
        }

        private void tsbMonth_Click(object sender, EventArgs e) {
            var btn = sender as ToolStripButton;
            toolStripComboBoxMes.ComboBox.SelectedIndex += int.Parse((string)btn.Tag);
            EnableNavigationButtons();
        }

        private void UpdateToolbarButtons() {
            EnableSaveButtons();
            toolStripEncontrarPagamentos.Visible =
                dgvCalendario.Rows.OfType<DataGridViewRow>()
                    .Select(r => (CalendarioItem)r.DataBoundItem)
                    .Any(r =>
                        !r.Agendado && r.Data <= DateTime.Today ||
                        (r.Agendado && !r.Pago && r.PagamentoData <= DateTime.Today &&
                        (r.Pagamento.Descricao != null || r.Pagamento.Valor != null || r.Valor != null)));
        }

        private void EnableNavigationButtons() {
            var cbx = toolStripComboBoxMes.ComboBox;
            tsbPrevMonth.Enabled = cbx.SelectedIndex < cbx.Items.Count - 1;
            tsbNextMonth.Enabled = cbx.SelectedIndex > 0;
        }

        private void tsbEncontrarPagamentos_Click(object sender, EventArgs e) {
            ProcurarAgendamentos();
            ProcurarPagamentos();
            dgvCalendario.Refresh();
            UpdateToolbarButtons();
        }

        private void ProcurarAgendamentos() {
            SuperMsgBox.ColorButtons();
            foreach (var item in
                dgvCalendario.Rows.OfType<DataGridViewRow>()
                .Select(r => (CalendarioItem)r.DataBoundItem)
                .Where(r => !r.Agendado)
                .OrderBy(r => r.Data)) {
                if (!ProcurarAgendamento(item)) {
                    break;
                }
            }
            SuperMsgBox.Reset();
        }

        private bool ProcurarAgendamento(CalendarioItem item) {
            const string header = "Procurar Agendamento";
            var mes = (CalendarioMes)toolStripComboBoxMes.SelectedItem;
            var itemFolder = Path.Combine(_folder, item.Pagamento.ToString());
            if (Directory.Exists(itemFolder)) {
                var files = GetComprovanteFiles(itemFolder, mes);
                if (files.Any()) {
                    var frm = new frmComprovantePDF(item.Descricao, _folder, files);
                    var resp = frm.ShowDialog();
                    if (resp != DialogResult.Yes) {
                        return resp != DialogResult.Cancel;
                    }

                    item.Agendado = true;
                    item.AgendadoData = frm.Comprovante.Agendamento;
                    item.PagamentoData = frm.Comprovante.Pagamento;
                    item.Valor = frm.Comprovante.Valor;
                    return resp != DialogResult.Cancel;
                }
                else {
                    var resp = SuperMsgBox.Show($"{item.Descricao}:\n\n\tComprovante de agendamento não encontrado.\n\nMarcar como agendado?",
                        header, SuperMsgBox.Buttons.YesNoCancel, SuperMsgBox.Icon.Question);

                    item.Agendado = resp == DialogResult.Yes;
                    return resp != DialogResult.Cancel;
                }
            }
            if (SuperMsgBox.Show($"Folder para '{item.Pagamento}' não existe.\n\n{itemFolder}\n\nCria?",
                header, SuperMsgBox.Buttons.YesNo,
                SuperMsgBox.Icon.Question) == DialogResult.Yes) {
                Directory.CreateDirectory(itemFolder);
            }
            return true;
        }

        private string[] GetComprovanteFiles(string itemFolder, CalendarioMes mes) {
            var regex = new Regex("conta|boleto");
            return Directory.GetFiles(itemFolder, $@"{mes.AnoMes}*.pdf")
                .Where(f => !regex.IsMatch(f))
                .ToArray();
        }

        private void ProcurarPagamentos() {
            const string header = "Procurar Pagamento";
            var mes = (CalendarioMes)toolStripComboBoxMes.SelectedItem;
            var pagamentos = _ctx.Balance.Where(b => b.Valor < 0
                                                     && b.Data.Year == mes.Ano
                                                     && b.Data.Month == mes.Mes12).ToList();
            var naoPagos = dgvCalendario.Rows.OfType<DataGridViewRow>()
                .Select(r => (CalendarioItem)r.DataBoundItem)
                .Where(r => r.Agendado && !r.Pago && r.PagamentoData <= DateTime.Today &&
                (r.Pagamento.Descricao != null || r.Pagamento.Valor != null || r.Valor != null))
                .OrderBy(r => r.Data);

            SuperMsgBox.ColorButtons();

            foreach (var item in naoPagos) {
                var ip = item.Pagamento;
                var valor = -1 * (item.Valor == null || item.Valor == 1 ? ip.Valor : item.Valor);
                IEnumerable<BalanceItem> found;
                if (item.Descricao != null && valor != null) {
                    found = pagamentos.Where(p => p.Grupo == ip.Grupo &&
                        p.Categoria == ip.Categoria &&
                        p.SubCategoria == ip.SubCategoria &&
                        p.Valor == valor);
                }
                else if (item.Descricao != null) {
                    found = pagamentos.Where(p => p.Grupo == ip.Grupo &&
                                                  p.Categoria == ip.Categoria &&
                                                  p.SubCategoria == ip.SubCategoria);
                }
                else {
                    found = pagamentos.Where(p => p.Valor == valor);
                }
                if (!found.Any()) {
                    SuperMsgBox.SetColors(Color.White, Color.FromArgb(255, 48, 0, 0), Color.FromArgb(255, 32, 0, 0));
                    SuperMsgBox.SetButtonText("OK", "Continue");
                    if (SuperMsgBox.Show($"{item.Descricao}:\n\n\tPagamento não encontrado.",
                                header,
                                SuperMsgBox.Buttons.OKCancel,
                                SuperMsgBox.Icon.Question) == DialogResult.Cancel) {
                        break;
                    }

                    continue;
                }

                var text = found.Select(f => f.ToString())
                    .Aggregate((i, j) => "\t" + i.ToString() + "\n" + j.ToString());
                SuperMsgBox.ResetColors();
                if (SuperMsgBox.Show($"{item.Descricao}:\n\n{text}\n\nConfirma?",
                        header, SuperMsgBox.Buttons.YesNo, SuperMsgBox.Icon.Question) ==
                            DialogResult.No) {
                    continue;
                }

                item.Pago = true;
                item.Valor = valor ?? 1;
            }
            SuperMsgBox.Reset();
        }


        #endregion TOOLBAR ---------------------------------
    }
}