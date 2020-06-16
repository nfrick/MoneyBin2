using DataLayer;
using SuperPrompt;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmLeitor : Form {
        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();
        private const string DialogTitle = @"Leitor de Extratos";
        private Conta _conta;

        public bool HasData => _conta != null && _conta.ExtratoHasData;

        #region FORM -------------------------
        public frmLeitor(Conta conta = null) {
            InitializeComponent();

            if (conta == null) {
                if (!GetConta()) {
                    Load += (s, e) => Close();
                    return;
                }
            }
            else {
                _conta = conta;
            }
            labelConta.Text = _conta.Apelido.ToUpper();

            OFD.Multiselect = true;
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OFD.Title = @"Selecione arquivo(s) de extrato:";

            if (!LerExtratos()) {
                Load += (s, e) => Close();
            }

            dgvExtrato.FormatColumn("Add", null, 40);
            dgvExtrato.FormatColumn("Data", dgvExtrato.StyleDateShort, 80);
            dgvExtrato.FormatColumn("Histórico", null, 300);
            dgvExtrato.FormatColumn("Documento", null, 120);
            dgvExtrato.FormatColumn("Valor", dgvExtrato.StyleCurrency, 80);
            dgvExtrato.FormatColumn("Afeta Saldo", null, 40);
            dgvExtrato.FormatColumn("Grupo", null, 90);
            dgvExtrato.FormatColumn("Categoria", null, 90);
            dgvExtrato.FormatColumn("SubCategoria", null, 110);
            dgvExtrato.FormatColumn("Descrição", null, 120);
        }

        private void frmLeitor_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !SalvarExtratoLido();
        }
        #endregion FORM -------------------------

        #region TOOLSTRIP -------------------------
        private void toolStripButtonSalvar_Click(object sender, EventArgs e) {
            SalvarExtratoLido();
        }

        private void toolStripButtonLerArquivo_Click(object sender, EventArgs e) {
            LerExtratos();
        }

        private void labelConta_DoubleClick(object sender, EventArgs e) {
            SalvarExtratoLido();
            if (GetConta()) {
                LerExtratos();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e) {
            _conta.Extrato.RemoveAll(b => !b.AddToDB);
            bsExtrato.ResetBindings(true);
            SelectRow(0);
        }

        #endregion TOOLSTRIP -------------------------

        private bool GetConta() {
            if (PromptDialog.InputList(DialogTitle, "Selecione a conta:",
                    _ctx.Contas.Where(c=>c.Ativa)
                    .Select(c => c.Apelido).OrderBy(a => a).ToArray(),
                    out var apelido) == DialogResult.Cancel) {
                return false;
            }
            _conta = _ctx.Contas.First(c => c.Apelido == apelido);
            labelConta.Text = apelido.ToUpper();
            return true;
        }

        public bool LerExtratos() {
            OFD.Filter = $@"Arquivos de extrato|*.{_conta.Banco.ExtensaoExtrato}|Todos os arquivos|*.*";
            OFD.FileName = null;

            if (OFD.ShowDialog(this) != DialogResult.OK) {
                return false;
            }

            OFD.InitialDirectory = Path.GetDirectoryName(OFD.FileNames[0]);
            var getAll = MessageBox.Show(@"Incluir todos os itens?", DialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            _conta.LerExtratos(OFD.FileNames, getAll, _ctx.Regras.OrderByDescending(r => r.Ocorrencias));

            if (!_conta.ExtratoHasData) {
                MessageBox.Show("Extrato não contém movimentos.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            dgvExtrato.RowStateChanged -= dgvExtrato_RowStateChanged;
            bsExtrato.DataSource = _conta.Extrato;
            dgvExtrato.Refresh();
            dgvExtrato.RowStateChanged += dgvExtrato_RowStateChanged;
            SelectRow(0);
            return true;
        }

        private bool SalvarExtratoLido() {
            if (!_conta.ExtratoHasAddToDB) {
                return true;
            }
            var retorno = true;
            switch (MessageBox.Show($"Salvar {_conta.ExtratoAddToDBCount} itens?",
                "Leitor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    try {
                        _conta.ExtratoParaBalance();
                        _ctx.SaveChanges();
                    }
                    catch {
                        // Ignore exception
                    }
                    bsExtrato.ResetBindings(false);
                    toolStripButtonSalvar.Enabled = false;

                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    retorno = false;
                    break;
            }
            if (retorno) {
                _conta.Extrato.Clear();
            }

            return retorno;
        }

        #region DATAGRIDVIEW ---------------------

        private void dgvExtrato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var bal = (BalanceItem)dgvExtrato.Rows[e.RowIndex].DataBoundItem;
            if (!bal.AddToDB) {
                e.CellStyle.ForeColor = Color.DimGray;
            }
            else if (!bal.AfetaSaldo) {
                e.CellStyle.ForeColor = Color.LightGray;
            }
            if (e.ColumnIndex == 6 && bal.AddToDB && string.IsNullOrEmpty(bal.Grupo)) {
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.BackColor = Color.Goldenrod;
            }
        }

        private void dgvExtrato_RowEnter(object sender, DataGridViewCellEventArgs e) {
            toolStripButtonSalvar.Enabled = _conta.ExtratoHasAddToDB;
        }

        private void dgvExtrato_SelectionChanged(object sender, EventArgs e) {
            if (dgvExtrato.SelectedRows.Count == 0) {
                return;
            }

            EnableNavigationButtons(dgvExtrato.SelectedRows[0].Index);
        }

        private void dgvExtrato_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            ClassifTools.EditingControlShowing(sender, e);
        }

        #endregion DATAGRIDVIEW ---------------------

        #region CLASSIFICACAO -------------
        private void navigationButtons_Click(object sender, System.EventArgs e) {
            var btn = sender as Button;
            var row = 0;
            switch (btn.Name) {
                case "buttonFirst":
                    row = 0;
                    break;
                case "buttonPrevious":
                    row = dgvExtrato.CurrentRow.Index - 1;
                    break;
                case "buttonNext":
                    row = dgvExtrato.CurrentRow.Index + 1;
                    break;
                case "buttonLast":
                    row = dgvExtrato.RowCount - 1;
                    break;
            }
            SelectRow(row);
            EnableNavigationButtons(row);
        }

        private void EnableNavigationButtons(int row) {
            buttonFirst.Enabled = buttonPrevious.Enabled = (row != 0);
            buttonNext.Enabled = buttonLast.Enabled = (row != (dgvExtrato.RowCount - 1));
        }

        private void SelectRow(int row) {
            if (dgvExtrato.RowCount == 0) {
                return;
            }

            dgvExtrato.ClearSelection();
            dgvExtrato.CurrentCell = dgvExtrato.Rows[row].Cells[0];
            dgvExtrato.Rows[row].Selected = true;
        }

        private void dgvExtrato_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
            if (e.StateChanged != DataGridViewElementStates.Selected) {
                return;
            }

            PopulateGrupos();
            PopulateCategorias();
            PopulateSubCategorias();
        }

        private void comboBoxGrupo_Validated(object sender, System.EventArgs e) {
            PopulateCategorias();
        }

        private void comboBoxCategoria_Validated(object sender, System.EventArgs e) {
            PopulateSubCategorias();
        }

        private void PopulateGrupos() {
            comboBoxGrupo.Items.Clear();
            comboBoxGrupo.Items.AddRange(ClassifTools.GetListOfGrupos(dgvExtrato).ToArray());
        }

        private BalanceItem ItemAtual() {
            var rowsCount = dgvExtrato.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) {
                return null;
            }

            var row = dgvExtrato.SelectedRows[0];
            return (BalanceItem)row?.DataBoundItem;
        }

        private void PopulateCategorias() {
            var itemAtual = ItemAtual();
            if (itemAtual == null) {
                return;
            }
            comboBoxCategoria.Items.Clear();
            comboBoxCategoria.Items
                .AddRange(ClassifTools.GetListOfCategorias(dgvExtrato, itemAtual).ToArray());
        }

        private void PopulateSubCategorias() {
            var itemAtual = ItemAtual();
            if (itemAtual == null) {
                return;
            }

            comboBoxSubcategoria.Items.Clear();
            comboBoxSubcategoria.Items.AddRange(
                ClassifTools.GetListOfSubCategorias(dgvExtrato, itemAtual).ToArray());
        }
        #endregion CLASSIFICACAO -------------

        #region POPUP MENU -----------------
        private void dgvExtrato_MouseClick(object sender, MouseEventArgs e) {
            ClassifTools.PopupOptions(sender, e, cmsPopMenu);
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ClassifTools.PopupItemClicked(sender, e, dgvExtrato);
        }
        #endregion POPUP MENU -----------------
    }
}