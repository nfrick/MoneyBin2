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

            dgvRegras.FormatColumnByHeader("Regra", null, 450);
            dgvRegras.FormatColumnByHeader("Afeta Saldo", null, 40);
            dgvRegras.FormatColumnByHeader("Grupo", null, 150);
            dgvRegras.FormatColumnByHeader("Categoria", null, 150);
            dgvRegras.FormatColumnByHeader("SubCategoria", null, 150);
            dgvRegras.FormatColumnByHeader("Descrição", null, 150);
            dgvRegras.FormatColumnByHeader("Add", null, 40);
            dgvRegras.FormatColumnByHeader("Ocorr.", dgvRegras.StyleInteger, 60);

            dgvBalance.FormatColumnByHeader("Data", dgvBalance.StyleDateShort, 80);
            dgvBalance.FormatColumnByHeader("Histórico", null, 400);
            dgvBalance.FormatColumnByHeader("Valor", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumnByHeader("Grupo", null, 120);
            dgvBalance.FormatColumnByHeader("Categoria", null, 120);
            dgvBalance.FormatColumnByHeader("SubCategoria", null, 200);
            dgvBalance.FormatColumnByHeader("Descrição", null, 200);

            ResizeForm(dgvRegras);

            statusStrip.Items.Add(_pbar);

            ImportToolStrip(toolStripRegras);
            toolStripContainer.TopToolStripPanel.Controls.Remove(toolStripRegras);
        }

        private void tsbNovaRegra_Click(object sender, EventArgs e) {
            dgvRegras.Rows[dgvRegras.NewRowIndex].Cells[0].Selected = true;
            dgvRegras.FirstDisplayedScrollingRowIndex = dgvRegras.NewRowIndex;
        }

        protected override void tsbSave_Click(object sender, EventArgs e) {
            if (!dgvRegras.EndEdit()) {
                return;
            }
            base.tsbSave_Click(sender, e);
        }

        protected override void tsbRevert_Click(object sender, EventArgs e) {
            base.tsbRevert_Click(sender, e);
            dgvRegras.Refresh();
        }

        private void tsbTestar_Click(object sender, EventArgs e) {
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

        private void tsbOcorrencias_Click(object sender, EventArgs e) {
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