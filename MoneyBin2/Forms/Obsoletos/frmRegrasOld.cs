using DataLayer;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmRegrasOld : Form {

        MoneyBinEntities _ctx = new MoneyBinEntities();

        public frmRegrasOld() {
            InitializeComponent();

            _ctx.Regras.Load();
            bsRegras.DataSource = _ctx.Regras.Local.ToBindingList();

            splitContainer1.Panel2Collapsed = true;

            dgvRegras.FormatColumn("Regra", null, 450);
            dgvRegras.FormatColumn("Afeta Saldo", null, 40);
            dgvRegras.FormatColumn("Grupo", null, 150);
            dgvRegras.FormatColumn("Categoria", null, 150);
            dgvRegras.FormatColumn("SubCategoria", null, 150);
            dgvRegras.FormatColumn("Descrição", null, 150);
            dgvRegras.FormatColumn("Add", null, 40);
            dgvRegras.FormatColumn("Ocorr.", dgvRegras.StyleInteger, 60);

            dgvBalance.FormatColumn("Data", dgvBalance.StyleDateShort, 80);
            dgvBalance.FormatColumn("Histórico", null, 400);
            dgvBalance.FormatColumn("Valor", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumn("Grupo", null, 120);
            dgvBalance.FormatColumn("Categoria", null, 120);
            dgvBalance.FormatColumn("SubCategoria", null, 200);
            dgvBalance.FormatColumn("Descrição", null, 200);
        }

        private void toolStripButtonNovaRegra_Click(object sender, EventArgs e) {
            dgvRegras.Rows[dgvRegras.NewRowIndex].Cells[0].Selected = true;
            dgvRegras.FirstDisplayedScrollingRowIndex = dgvRegras.NewRowIndex;
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e) {
            if (!dgvRegras.EndEdit()) {
                return;
            }

            _ctx.SaveChanges();
            FormUtils.EnableSaveButtons(_ctx, toolStripRegras);
        }

        private void toolStripButtonDesfazer_Click(object sender, EventArgs e) {
            _ctx.RevertChanges();
            FormUtils.EnableSaveButtons(_ctx, toolStripRegras);
            dgvRegras.Refresh();
        }

        private void toolStripButtonTestar_Click(object sender, EventArgs e) {
            if (dgvRegras.CurrentRow == null) {
                return;
            }
            splitContainer1.Panel2Collapsed = false;

            var regra = (Regra)dgvRegras.CurrentRow.DataBoundItem;
            regra.Initialize();
            bsBalance.DataSource = _ctx.Balance.ToList().Where(bal => regra.Matches(bal));
            labelTesteResultado.Text = $"Ocorrências: {bsBalance.Count}";
            dgvBalance.Refresh();
        }

        private void labelTesteFechar_Click(object sender, EventArgs e) {
            splitContainer1.Panel2Collapsed = true;
        }

        private void toolStripButtonOcorrencias_Click(object sender, EventArgs e) {
            var progressDialog = new frmProgressBar();
            var backgroundThread = new Thread(
                () => {
                        progressDialog.UpdateProgress("Verificando ocorrências \u2026");
                        progressDialog.Maximum = dgvRegras.RowCount;
                        for (var row = 0; row < dgvRegras.RowCount - 1; row++) {
                            progressDialog.UpdateProgress();
                            var regra = (Regra)dgvRegras.Rows[row].DataBoundItem;
                            regra.Initialize();
                            regra.Ocorrencias =
                                _ctx.Balance.ToList().Count(bal => regra.Matches(bal));
                        }
                    progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                }
            );
            backgroundThread.Start();
            progressDialog.ShowDialog();
        }
        
        private void dgvRegras_RowValidated(object sender, DataGridViewCellEventArgs e) {
            FormUtils.EnableSaveButtons(_ctx, toolStripRegras);
        }
    }
}