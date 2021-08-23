using MoneyBin2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmMain : Form {
        private readonly List<string> _lastBackgrounds = new List<string>();
        public frmMain() {
            InitializeComponent();
            AtualizaConfiguracoes();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            Controls.OfType<MdiClient>().First().BackColor = this.BackColor;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            SalvaConfiguracoes();
        }

        public void AtualizaConfiguracoes() {
            toolbarVisivelToolStripMenuItem.Checked = Settings.Default.MainBarraFerramentasVisivel;
            toolbarImagemApenasToolStripMenuItem.Checked = Settings.Default.MainBarraFerramentasImagem;
            backgroundVisívelToolStripMenuItem.Checked = Settings.Default.MainBackgroundVisivel;
            backgroundRodízioToolStripMenuItem.Checked = Settings.Default.MainBackgroundRod;
            timerBackground.Interval = Settings.Default.MainBackgroundTempo * 1000;
        }

        private void SalvaConfiguracoes() {
            Settings.Default.MainBarraFerramentasVisivel = toolbarVisivelToolStripMenuItem.Checked;
            Settings.Default.MainBarraFerramentasImagem = toolbarImagemApenasToolStripMenuItem.Checked;
            Settings.Default.MainBackgroundVisivel = backgroundVisívelToolStripMenuItem.Checked;
            Settings.Default.MainBackgroundRod = backgroundRodízioToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        #region BACKGROUND ------------------
        private void NewBackground() {
            var _imgPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Backgrounds\\Reduzidas";
            var files = Directory.GetFiles(_imgPath, "*.jpg");
            if (_lastBackgrounds.Count == files.Length) {
                _lastBackgrounds.RemoveAt(0);
            }

            string file;
            var rnd = new Random();
            do {
                file = Path.GetFileName(files[rnd.Next(0, files.Length)]);
            } while (_lastBackgrounds.Contains(file));
            BackgroundImage = Image.FromFile($"{_imgPath}\\{file}");
            _lastBackgrounds.Add(Path.GetFileName(file));
        }

        private void timer1_Tick(object sender, EventArgs e) {
            NewBackground();
        }
        #endregion BACKGROUND ------------------

        #region EXTRATO -----------------
        private void toolStripButtonContas_Click(object sender, EventArgs e) {
            var frm = new frmBancosContas() { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonRegras_Click(object sender, EventArgs e) {
            var frm = new frmRegras() { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonLeitor_Click(object sender, EventArgs e) {
            var frm = new frmLeitor() { MdiParent = this };
            if (frm.HasData) {
                frm.Show();
            }
        }

        private void toolStripButtonBalance_Click(object sender, EventArgs e) {
            var frm = new frmBalanceSF { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonBalanceAntigo_Click(object sender, EventArgs e) {
            var frm = new frmBalance() { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonClassificacao_Click(object sender, EventArgs e) {
            var frm = new frmClassificacao { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonExportar_Click(object sender, EventArgs e) {
            var frm = new frmExport { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonRelatorios_Click(object sender, EventArgs e) {
            var frm = new frmReport { MdiParent = this };
            frm.Show();
        }
        #endregion EXTRATO -----------------

        #region PAGAMENTOS ----------
        private void toolStripButtonPagamentos_Click(object sender, EventArgs e) {
            var frm = new frmPagamentos { MdiParent = this };
            frm.Show();
        }
        private void toolStripButtonCalendario_Click(object sender, EventArgs e) {
            var frm = new frmCalendario { MdiParent = this };
            frm.Show();
        }
        #endregion PAGAMENTOS ----------

        #region FERRAMENTAS -----------------
        private void toolStripButtonConfig_Click(object sender, EventArgs e) {
            var frm = new frmConfig { MdiParent = this };
            frm.Show();
        }

        private void toolbarVisivelToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            toolStripMain.Visible = toolbarVisivelToolStripMenuItem.Checked;
            SalvaConfiguracoes();
        }

        private void toolbarImagemApenasToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            foreach (ToolStripButton item in toolStripMain.Items) {
                item.DisplayStyle = toolbarImagemApenasToolStripMenuItem.Checked
                    ? ToolStripItemDisplayStyle.Image
                    : ToolStripItemDisplayStyle.ImageAndText;
            }
            SalvaConfiguracoes();
        }

        private void backgroundRodízioToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            timerBackground.Enabled = backgroundRodízioToolStripMenuItem.Checked;
            SalvaConfiguracoes();
        }

        private void backgroundVisívelToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            if (backgroundVisívelToolStripMenuItem.Checked) {
                NewBackground();
            }
            else {
                BackgroundImage = null;
            }
            SalvaConfiguracoes();
        }
        #endregion FERRAMENTAS -----------------

        private void toolStripButtonSerieHistorica_Click(object sender, EventArgs e) {
            var frm = new frmSerieHistorica() { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonInvestimentos_Click(object sender, EventArgs e) {
            var frm = new frmInvestimentos() { MdiParent = this };
            frm.Show();
        }

        private void fundosToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmFundos() { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonPesquisa_Click(object sender, EventArgs e) {
            var frm = new frmPesquisa() { MdiParent = this };
            frm.Show();
        }
    }
}
