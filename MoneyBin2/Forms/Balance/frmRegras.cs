using DataLayer;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmRegras : DataForm {

        private ToolStripProgressBar _pbar = new ToolStripProgressBar("pbar") { Visible = false };

        public frmRegras() {
            InitializeComponent();

            _ctx.Regras.Load();
            bsRegras.DataSource = _ctx.Regras.Local.ToBindingList();
            _mainBindingSource = bsRegras;
            EnableSaveButtons();

            splitContainer.Panel2Collapsed = true;

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

            ResizeForm(dgvRegras);

            statusStrip.Items.Add(_pbar);

            ImportToolStrip(toolStripRegras);
            toolStripContainer.TopToolStripPanel.Controls.Remove(toolStripRegras);
        }

        private void toolStripButtonNovaRegra_Click(object sender, EventArgs e) {
            dgvRegras.Rows[dgvRegras.NewRowIndex].Cells[0].Selected = true;
            dgvRegras.FirstDisplayedScrollingRowIndex = dgvRegras.NewRowIndex;
        }

        protected override void toolStripButtonSave_Click(object sender, EventArgs e) {
            if (!dgvRegras.EndEdit()) {
                return;
            }
            base.toolStripButtonSave_Click(sender, e);
        }

        protected override void toolStripButtonRevert_Click(object sender, EventArgs e) {
            base.toolStripButtonRevert_Click(sender, e);
            dgvRegras.Refresh();
        }

        private void toolStripButtonTestar_Click(object sender, EventArgs e) {
            if (dgvRegras.CurrentRow == null) {
                return;
            }
            splitContainer.Panel2Collapsed = false;

            var regra = (Regra)dgvRegras.CurrentRow.DataBoundItem;
            regra.Initialize();
            bsBalance.DataSource = _ctx.Balance.ToList().Where(bal => regra.Matches(bal));
            labelTesteResultado.Text = $"Ocorrências: {bsBalance.Count}";
            dgvBalance.Refresh();
        }

        private void labelTesteFechar_Click(object sender, EventArgs e) {
            splitContainer.Panel2Collapsed = true;
        }

        private void toolStripButtonOcorrencias_Click(object sender, EventArgs e) {
            var progressDialog = new frmProgressBar();
            var backgroundThread = new Thread(
                () => {
                    progressDialog.UpdateProgress("Verificando ocorrências \u2026");
                    progressDialog.Maximum = dgvRegras.RowCount;

                    this.Invoke((MethodInvoker)delegate {
                        _pbar.Value = 0;
                        _pbar.Maximum = dgvRegras.RowCount;
                        _pbar.Visible = true;
                    });

                    for (var row = 0; row < dgvRegras.RowCount - 1; row++) {

                        this.Invoke((MethodInvoker)delegate {
                            _pbar.Value++;
                        });

                        progressDialog.UpdateProgress();
                        var regra = (Regra)dgvRegras.Rows[row].DataBoundItem;
                        regra.Initialize();
                        regra.Ocorrencias =
                            _ctx.Balance.ToList().Count(bal => regra.Matches(bal));
                    }
                    this.Invoke((MethodInvoker)delegate {
                        _pbar.Visible = false;
                    });
                    progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                }
            );
            backgroundThread.Start();
            progressDialog.ShowDialog();
        }

        private void dgvRegras_RowValidated(object sender, DataGridViewCellEventArgs e) {
            EnableSaveButtons();
        }
    }
}