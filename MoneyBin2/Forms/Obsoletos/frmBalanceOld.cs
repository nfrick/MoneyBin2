using DataLayer;
using MoneyBin2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmBalanceOld : Form {
        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private Conta ContaAtual => (Conta)toolStripComboBoxConta.SelectedItem;
        private IEnumerable<int> ColunasVisiveis => dgvBalance.Columns.Cast<DataGridViewColumn>()
            .Where(c => c.Visible).Select(c => c.Index).ToArray();

        private ListSortDirection _sort = ListSortDirection.Descending;

        private readonly ToolStripDateTimePicker _dtpInicio = new ToolStripDateTimePicker("dtpInicio", DateTime.Today.AddDays(-60), DateTimePickerFormat.Short);
        private readonly ToolStripDateTimePicker _dtpTermino = new ToolStripDateTimePicker("dtpTermino", DateTime.Today, DateTimePickerFormat.Short);

        private readonly ToolStripCheckbox _chkboxAutoMode = new ToolStripCheckbox("chkboxAutoMode", "Auto", true);
        private readonly ToolStripCheckbox _chkboxRegex = new ToolStripCheckbox("chkboxRegex", "Regex", false);
        private readonly ToolStripCheckbox _chkboxDocumento = new ToolStripCheckbox("chkboxDocumento", "Coluna 'Documento'", false);

        private readonly ToolStripItem[] saveMenuItens;

        public frmBalanceOld() {
            InitializeComponent();

            _dtpInicio.Width = 100;
            _dtpTermino.Width = 100;
            toolStripBalance.Items.Insert(15, _chkboxDocumento);
            toolStripBalance.Items.Insert(15, _chkboxRegex);
            toolStripBalance.Items.Insert(6, new ToolStripSeparator());
            toolStripBalance.Items.Insert(7, _chkboxAutoMode);
            toolStripBalance.Items.Insert(5, _dtpTermino);
            toolStripBalance.Items.Insert(5, new ToolStripLabel("Término:"));
            toolStripBalance.Items.Insert(5, _dtpInicio);

            _chkboxDocumento.ToolTipText = "Exibe coluna 'Documento'";
            _chkboxRegex.ToolTipText = "Usar Regular Expressions nas pesquisas";
            _chkboxAutoMode.ToolTipText = "Atualiza Balance automaticamente quando parãmetros são alterados (pode ser lento)";

            var font = toolStripComboBoxConta.Font;
            foreach (ToolStripItem item in toolStripBalance.Items) {
                if (item.Font.Name == "Segoe UI") {
                    item.Font = font;
                }
            }

            _dtpInicio.ValueChanged += FilterItemChanged;
            _dtpTermino.ValueChanged += FilterItemChanged;
            _chkboxAutoMode.CheckedChanged += ToggleAutoMode;
            _chkboxDocumento.CheckedChanged += ShowDocumento;

            toolStripComboBoxConta.ComboBox.Items.AddRange(_ctx.Contas.OrderBy(c => c.Apelido).ToArray());
            toolStripComboBoxConta.ComboBox.DisplayMember = "Apelido";

            toolStripComboBoxConta.ComboBox.SelectedItem =
                Settings.Default.BalanceUsarContaPadrao
                    ? _ctx.Contas.Find(Settings.Default.BalanceContaPadrao)
                    : _ctx.Contas.Find(Settings.Default.BalanceUltimaConta);

            saveMenuItens = new ToolStripItem[] { toolStripButtonSalvar, toolStripButtonDesfazer,
                toolStripSeparator1, toolStripSeparatorSalvar, toolStripSeparatorDesfazer };

            dgvBalance.FormatColumn("Data", dgvBalance.StyleDateShort, 80);
            dgvBalance.FormatColumn("Histórico", null, 300);
            dgvBalance.FormatColumn("Documento", null, 120);
            dgvBalance.FormatColumn("Valor", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumn("Afeta Saldo", null, 40);
            dgvBalance.FormatColumn("Saldo", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumn("Grupo", null, 120);
            dgvBalance.FormatColumn("Categoria", null, 140);
            dgvBalance.FormatColumn("SubCategoria", null, 200);
            dgvBalance.FormatColumn("Descrição", null, 200);
            dgvBalance.Columns[2].Visible = false;

            FormUtils.ResizeForm(this, dgvBalance);

            QueryDatabase();

            toolStripComboBoxGrupo.SelectedIndexChanged += FilterItemChanged;
        }

        #region TOOLSTRIP ---------------------------
        private void FilterItemChanged(object sender, EventArgs e) {
            if (((ToolStripItem)sender).Name == "toolStripComboBoxConta") {
                toolStripComboBoxGrupo.ComboBox.Items.Clear();
                toolStripComboBoxGrupo.ComboBox.Items.Add("Todos");
                toolStripComboBoxGrupo.ComboBox.Items.AddRange(ContaAtual.Grupos.ToArray());
                toolStripComboBoxGrupo.ComboBox.SelectedIndex = 0;
            }
            if (((ToolStripItem)sender).Name == "toolStripButtonSelecionar" ||
                _chkboxAutoMode.Checked) {
                QueryDatabase();
            }

            var grupo = toolStripComboBoxGrupo.SelectedIndex == 0
                ? ""
                : $"Grupo = '{toolStripComboBoxGrupo.SelectedItem}' e ";
            toolStripButtonSelecionar.ToolTipText =
                $"Selecionar itens com {grupo}data entre {_dtpInicio.Value:d} e {_dtpTermino.Value:d}";
        }

        private void QueryDatabase() {
            dgvBalance.Columns[0].HeaderText = _sort == ListSortDirection.Ascending ? "Data    ▲" : "Data    ▼";

            var balance = ContaAtual.BalanceFiltrado(
                _dtpInicio.Value, _dtpTermino.Value,
                (string)toolStripComboBoxGrupo.SelectedItem,
                true, _sort);

            bsBalance.DataSource = balance.Any() ? balance : null;
        }

        private void ToggleAutoMode(object sender, EventArgs e) {
            toolStripButtonSelecionar.Visible = !_chkboxAutoMode.Checked;
        }

        private void ShowDocumento(object sender, EventArgs e) {
            dgvBalance.Columns[2].Visible = _chkboxDocumento.Checked;
            FormUtils.ResizeForm(this, dgvBalance);
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e) {
            dgvBalance.EndEdit();
            _ctx.SaveChanges();
            FormUtils.EnableSaveButtons(_ctx, toolStripBalance);
        }

        private void toolStripButtonDesfazer_Click(object sender, EventArgs e) {
            _ctx.RevertChanges();
            dgvBalance.Refresh();
            FormUtils.EnableSaveButtons(_ctx, toolStripBalance);
        }

        private void toolStripButtonSalvar_VisibleChanged(object sender, EventArgs e) {
            toolStripButtonDesfazer.Visible =
                toolStripSeparatorDesfazer.Visible =
                toolStripSeparatorSalvar.Visible =
                toolStripButtonSalvar.Visible;
        }

        #region PROCURAR ----------------
        private void toolStripTextBoxProcurar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(toolStripTextBoxProcurar.Text)) {
                return;
            }
            SelectFirstRow();
            Procurar();
        }

        private void toolStripTextBoxProcurar_Validated(object sender, EventArgs e) {
            SelectFirstRow();
        }

        private void toolStripTextBoxProcurar_TextChanged(object sender, EventArgs e) {
            toolStripButtonProcurar.Visible = !string.IsNullOrEmpty(toolStripTextBoxProcurar.Text);
        }

        private void SelectFirstRow() {
            dgvBalance.ClearSelection();
            dgvBalance.CurrentCell = dgvBalance.Rows[0].Cells[0];
            dgvBalance.Rows[0].Selected = true;
        }

        private void toolStripButtonProcurar_Click(object sender, EventArgs e) {
            Procurar();
        }

        private void Procurar() {
            var targetRegex = new Regex(toolStripTextBoxProcurar.Text);
            var target = toolStripTextBoxProcurar.Text.ToLower();
            var row = dgvBalance.CurrentRow.Index;
            var startCol = dgvBalance.CurrentCell.ColumnIndex;

            while (row < dgvBalance.RowCount) {
                var Row = dgvBalance.Rows[row];
                foreach (var col in ColunasVisiveis.Where(c => c > startCol)) {
                    var found = _chkboxRegex.Checked ? targetRegex.IsMatch(Row.Cells[col].FormattedValue.ToString()) : Row.Cells[col].FormattedValue.ToString().ToLower().Contains(target);
                    if (!found) {
                        continue;
                    }

                    dgvBalance.CurrentCell = Row.Cells[col];
                    return;
                }
                ++row;
                startCol = -1;
            }
            MessageBox.Show($"'{targetRegex}' não encontrado", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion PROCURAR ----------------

        #endregion TOOLSTRIP ---------------------------

        #region DATAGRIDVIEW ---------------------------
        private void dgvBalance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var x = dgvBalance.Rows[e.RowIndex].DataBoundItem;
            try {
                var item = (BalanceItem)dgvBalance.Rows[e.RowIndex].DataBoundItem;
                if (!item.AfetaSaldo) {
                    e.CellStyle.ForeColor = Color.DarkGray;
                }

                if ((e.ColumnIndex == 3 || e.ColumnIndex == 5) && (decimal)e.Value < 0) {
                    e.CellStyle.ForeColor = Color.LightCoral;
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                //throw;
            }
        }

        private void dgvBalance_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            FormUtils.EnableSaveButtons(_ctx, toolStripBalance);
        }

        private void dgvBalance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            ClassifTools.EditingControlShowing(sender, e);
        }

        private void dgvBalance_MouseClick(object sender, MouseEventArgs e) {
            ClassifTools.PopupOptions(sender, e, cmsPopMenu);
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ClassifTools.PopupItemClicked(sender, e, dgvBalance);
            FormUtils.EnableSaveButtons(_ctx, toolStripBalance);
        }

        private void dgvBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1 || dgvBalance.Columns[e.ColumnIndex].Name !=
                "afetaSaldoDataGridViewCheckBoxColumn") {
                return;
            }
            ContaAtual.CalculaBalance();
            dgvBalance.Refresh();
        }

        private void dgvBalance_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.ColumnIndex != 0) {
                return;
            }
            _sort = _sort == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
            QueryDatabase();
        }
        #endregion DATAGRIDVIEW ------------------------

        private void frmBalance_FormClosing(object sender, FormClosingEventArgs e) {
            Settings.Default.BalanceUltimaConta = ((Conta)toolStripComboBoxConta.ComboBox.SelectedItem).ID;
            Settings.Default.Save();
        }
    }
}
