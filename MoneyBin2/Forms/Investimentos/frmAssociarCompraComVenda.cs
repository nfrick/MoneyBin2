using DataLayer;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace MoneyBin2 {
    public partial class frmAssociarCompraComVenda : Form {
        public Saida Saida { get; set; }
        public ContaAtivo AcaoAtual { get; set; }
        private Point _cellInError = new Point(-2, -2);

        public frmAssociarCompraComVenda() {
            InitializeComponent();
        }

        private void AssociarCompraComVenda_Load(object sender, EventArgs e) {
            dgvAssociadas.FormatColumn("Data", dgvAssociadas.StyleDateTimeShort, 115);
            dgvAssociadas.FormatColumn("Qtd", dgvAssociadas.StyleInteger, 65);
            dgvAssociadas.FormatColumn("Tipo", dgvAssociadas.StyleBase, 100);
            dgvAssociadas.FormatColumn("Associado", dgvAssociadas.StyleInteger, 65);
            dgvAssociadas.FormatColumn("Disponível", dgvAssociadas.StyleInteger, 65);
            dgvAssociadas.FormatColumn("Valor", dgvAssociadas.StyleCurrency, 60);

            dgvDisponiveis.FormatColumn("Data", dgvDisponiveis.StyleDateTimeShort, 115);
            dgvDisponiveis.FormatColumn("Qtd", dgvDisponiveis.StyleInteger, 65);
            dgvDisponiveis.FormatColumn("Tipo", dgvDisponiveis.StyleBase, 100);
            dgvDisponiveis.FormatColumn("Associado", dgvDisponiveis.StyleInteger, 65);
            dgvDisponiveis.FormatColumn("Disponível", dgvDisponiveis.StyleInteger, 65);
            dgvDisponiveis.FormatColumn("Valor", dgvDisponiveis.StyleCurrency, 60);

            bsAssociadas.DataSource = Saida.Associacoes;
            bsDisponiveis.DataSource = AcaoAtual.EntradasDisponiveis(Saida);

            labelAtivo.Text = Saida.Codigo;
            labelData.Text = Saida.Data.ToString("dd/MM/yyyy");
            labelValor.Text = Saida.Valor.ToString("C2");
            labelVenda.Text = Saida.Qtd.ToString("N0");
            AtualizarLabels();
        }

        private void CarregarBindingSources() {
            dgvAssociadas.Refresh();

            bsDisponiveis.DataSource = AcaoAtual.EntradasDisponiveis(Saida);
            dgvDisponiveis.Refresh();

            dgvToggleEnable(true);
            AtualizarLabels();
        }

        private void AtualizarLabels() {
            labelAssociacoes.Text = Saida.QtdAssociada.ToString("N0");
            labelPendente.Text = Saida.QtdPendente.ToString("N0");
            dgvDisponiveis.Enabled = Saida.QtdPendente > 0;
        }

        private void dgvToggleEnable(bool enable) {
            dgvAssociadas.Enabled = enable && Saida.Associacoes.Count > 0;
            dgvDisponiveis.Enabled = enable && Saida.QtdAssociada != Saida.Qtd;
        }

        private void nudSetup(int max, int rowToBind) {
            nudQtdAssociada.Maximum = max;
            nudQtdAssociada.Increment = max > 100 ? max / 100 * 10 : 10;
            while (nudQtdAssociada.DataBindings.Count > 0) {
                nudQtdAssociada.DataBindings.RemoveAt(0);
            }
            // The code binds column index 5 to the nud control
            nudQtdAssociada.DataBindings.Add(new Binding("Value",
                dgvAssociadas[5, rowToBind], "Value", false));

            var associacao = (Associacao)dgvAssociadas.Rows[rowToBind].DataBoundItem;
            labelQtdVendida.Text = $"{Saida.Qtd:N0}";
            labelQtdComprada.Text = $"{Saida.QtdAssociada - associacao.QtdAssociada:N0}";
            panelEditar.Visible = true;
            nudQtdAssociada.Focus();
        }

        #region ASSOCIADAS ------------------------

        private void dgvAssociadas_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex > 1 || e.RowIndex < 0) {
                return;
            }

            var associacao = (Associacao)bsAssociadas.Current;
            switch (e.ColumnIndex) {
                case 0:
                    dgvToggleEnable(false);
                    nudSetup(associacao.QtdAssociada +
                             Math.Min(Saida.QtdPendente, associacao.QtdDisponivel), e.RowIndex);
                    break;
                case 1:
                    RemoverAssociacao(associacao);
                    CarregarBindingSources();
                    break;
                default:
                    break;
            }
        }

        private void dgvAssociadas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if (e.ColumnIndex != 5) {
                return;
            }

            var dgv = (DataGridView)sender;
            if (!dgv.IsCurrentCellDirty) {
                return;
            }

            var cell = dgv[e.ColumnIndex, e.RowIndex];
            var qtdEntrada = (int)dgv.Rows[e.RowIndex].Cells[4].Value;
            var formattedValue = e.FormattedValue.ToString();
            var oldQtd = (int)cell.Value;
            var limite = Math.Min(Saida.QtdPendente + oldQtd, qtdEntrada);

            if (cell.Tag == null) {
                cell.Tag = cell.Style.Padding;
                cell.Style.Padding = new Padding(0, 0, 18, 0);
                _cellInError = new Point(e.ColumnIndex, e.RowIndex);
            }

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(formattedValue)) {
                cell.ErrorText = @"Preencha a quantidade associada.";
                e.Cancel = true;
            }
            else if (!int.TryParse(formattedValue, System.Globalization.NumberStyles.Any,
                CultureInfo.CurrentCulture, out int newQtd)) {
                cell.ErrorText = @"Quantidade deve ser um número!";
                e.Cancel = true;
            }
            else if (newQtd == 0) {
                switch (MessageBox.Show(@"Quantidade igual a zero irá remover a associação. Confirma?",
                    this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                    case DialogResult.Cancel:
                        dgv.CancelEdit();
                        break;
                    case DialogResult.No:
                        cell.ErrorText = $"Quantidade deve ser um número entre 1 e {limite}";
                        e.Cancel = true;
                        break;
                }
            }

            else if (newQtd < 1 || newQtd > limite) {
                cell.ErrorText = $"Quantidade deve ser um número entre 1 e {limite}";
                e.Cancel = true;
            }
        }

        private void dgvAssociadas_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var dgv = (DataGridView)sender;
            var cell = dgv[e.ColumnIndex, e.RowIndex];
            cell.ErrorText = string.Empty;
            _cellInError = new Point(-2, -2);
            cell.Style.Padding = (Padding)cell.Tag;
            cell.Tag = null;
            CarregarBindingSources();
        }

        private void dgvAssociadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            var dgv = (DataGridView)sender;
            if (!dgv.IsCurrentCellDirty || string.IsNullOrEmpty(e.ErrorText)) {
                return;
            }

            e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~(DataGridViewPaintParts.ErrorIcon));
            var container = e.Graphics.BeginContainer();
            e.Graphics.TranslateTransform(18, 0);
            e.Paint(ClientRectangle, DataGridViewPaintParts.ErrorIcon);
            e.Graphics.EndContainer(container);
            e.Handled = true;
        }

        private void dgvAssociadas_CellValidated(object sender, DataGridViewCellEventArgs e) {
            if (Saida.Associacoes.Count == 0) {
                return;
            }

            var associacao = (Associacao)bsAssociadas.Current;
            if (associacao.QtdAssociada != 0) {
                return;
            }

            RemoverAssociacao(associacao);
            dgvAssociadas.Refresh();
        }

        private void RemoverAssociacao(Associacao associacao) {
            var entrada = associacao.Entrada;
            entrada.Associacoes.Remove(associacao);
            Saida.Associacoes.Remove(associacao);
        }

        #endregion ASSOCIADAS ---------------------

        #region DISPONÍVEIS ------------------------

        private Associacao GetAssociacao(Entrada entrada) {
            var associacao = Saida.Associacoes.FirstOrDefault(a => a.Entrada.OperacaoId == entrada.OperacaoId) ??
                new Associacao {
                    Saida = Saida,
                    SaidaId = Saida.OperacaoId,
                    Entrada = entrada,
                    EntradaId = entrada.OperacaoId
                };
            associacao.QtdAssociada += Math.Min(entrada.QtdDisponivel, Saida.QtdPendente);
            return associacao;
        }

        private void buttonAssociarOK_Click(object sender, EventArgs e) {
            panelEditar.Visible = false;
            CarregarBindingSources();
        }

        private void numericUpDownQtdAAssociar_ValueChanged(object sender, EventArgs e) {
            if (int.TryParse(labelQtdComprada.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var diferenca)) {
                labelSaldo.Text = $"{Saida.Qtd - diferenca - nudQtdAssociada.Value:N0}";
            }
        }

        private void dgvDisponiveis_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var dgv = (DataGridView)sender;
            var col = dgv.Columns[e.ColumnIndex];
            if (!(col is DataGridViewButtonColumn) || e.RowIndex < 0) {
                return;
            }

            var entrada = (Entrada)bsDisponiveis.Current;
            var associacao = GetAssociacao(entrada);
            Saida.Associacoes.Add(associacao);
            entrada.Associacoes.Add(associacao);
            CarregarBindingSources();

            if (col.Name == "btnAssociarDireto") {
                return;
            }

            dgvToggleEnable(false);
            var row = dgvAssociadas.Rows
                .Cast<DataGridViewRow>()
                .First(r => (int)r.Cells["EntradaId"].Value == associacao.EntradaId);
            dgvAssociadas.Rows[row.Index].Selected = true;

            nudSetup(associacao.QtdAssociada, row.Index);
        }

        #endregion DISPONÍVEIS ---------------------

        private void dgvAssociadas_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            var x = e;
        }
    }
}
