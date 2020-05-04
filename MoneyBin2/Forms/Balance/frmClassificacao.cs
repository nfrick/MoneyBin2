using DataLayer;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmClassificacao : Form {
        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private Classificacao ClassifAtual => (Classificacao) bsClassificacao.Current; //dgvClassificacao.CurrentRow.DataBoundItem;

        public frmClassificacao() {
            InitializeComponent();

            PopulateClassificacao();

            dgvClassificacao.FormatColumn("Grupo", null, 150);
            dgvClassificacao.FormatColumn("Categoria", null, 150);
            dgvClassificacao.FormatColumn("SubCategoria", null, 250);

            dgvBalance.FormatColumn("Conta", null, 80);
            dgvBalance.FormatColumn("Data", dgvBalance.StyleDateShort, 80);
            dgvBalance.FormatColumn("Histórico", null, 300);
            dgvBalance.FormatColumn("Valor", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumn("Afeta Saldo", null, 40);
            dgvBalance.FormatColumn("Grupo", null, 120);
            dgvBalance.FormatColumn("Categoria", null, 140);
            dgvBalance.FormatColumn("SubCategoria", null, 200);
            dgvBalance.FormatColumn("Descrição", null, 200);
        }

        private void PopulateClassificacao() {
            bsClassificacao.DataSource = 
                new ObservableListSource<Classificacao>(_ctx.spClassificacao()).ToBindingList();
            dgvClassificacao.Refresh();
        }

        private void frmClassificacao_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_ctx.ModifiedAny) {
                return;
            }

            var alteracao = _ctx.ModifiedCount == 1 ?
                "Existe 1 alteração pendente" :
                $"Existem {_ctx.ModifiedCount} alterações pendentes";
            switch (MessageBox.Show($"{alteracao}. Salvar?",
                this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    _ctx.SaveChanges();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        #region DATAGRIDVIEW ----------------------------------
        private void dgvClassificacao_SelectionChanged(object sender, System.EventArgs e) {
            bsBalance.DataSource = new ObservableListSource<BalanceItem>(
                _ctx.Balance.Include("Conta")
                    .Where(b => b.Grupo == ClassifAtual.Grupo && 
                        b.Categoria == ClassifAtual.Categoria && 
                        b.SubCategoria == ClassifAtual.SubCategoria)).ToBindingList();
            dgvBalance.Refresh();

            textBoxGrupoNovo.Text = ClassifAtual.Grupo;
            textBoxCategoriaNova.Text = ClassifAtual.Categoria;
            textBoxSubCategoriaNova.Text = ClassifAtual.SubCategoria;
        }

        private void dgvBalance_RowValidated(object sender, DataGridViewCellEventArgs e) {
            buttonSave.Text = _ctx.TextoSalvar();
            buttonSave.Visible = buttonDesfazer.Visible = _ctx.ModifiedAny;
        }

        private void dgvBalance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            ClassifTools.EditingControlShowing(sender, e);
        }

        private void dgvBalance_MouseClick(object sender, MouseEventArgs e) {
            ClassifTools.PopupOptions(sender, e, cmsPopMenu);
        }

        #endregion DATAGRIDVIEW ----------------------------------

        private void buttonUpdate_Click(object sender, System.EventArgs e) {
            var listOfIDs = string.Empty;
            if (((Button)sender).Text == "Selecionados") {
                listOfIDs = " AND ID IN (" + string.Join(
                                ",", dgvBalance.SelectedRows.Cast<DataGridViewRow>()
                                    .Select(r => ((BalanceItem)r.DataBoundItem).ID)
                                    .ToArray()) + ")";
            }

            _ctx.spBalanceUpdateByGrupoCatSubCat(
                ClassifAtual.Grupo,
                ClassifAtual.Categoria,
                ClassifAtual.SubCategoria,
                EmptyToNull(textBoxGrupoNovo.Text),
                EmptyToNull(textBoxCategoriaNova.Text),
                EmptyToNull(textBoxSubCategoriaNova.Text),
                listOfIDs);

            PopulateClassificacao();
        }

        private static string EmptyToNull(string texto) {
            return string.IsNullOrEmpty(texto) ? null : texto;
        }
        
        private void buttonSave_Click(object sender, System.EventArgs e) {
            _ctx.SaveChanges();
            buttonSave.Visible = buttonDesfazer.Visible = _ctx.ModifiedAny;
            PopulateClassificacao();
        }

        private void buttonDesfazer_Click(object sender, System.EventArgs e) {
            _ctx.RevertChanges();
            buttonSave.Visible = buttonDesfazer.Visible = _ctx.ModifiedAny;
            dgvBalance.Refresh();
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ClassifTools.PopupItemClicked(sender, e, dgvBalance);
        }
    }
}
