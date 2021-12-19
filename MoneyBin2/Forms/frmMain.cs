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
        private Boolean _salvarConfiguracoes;

        public frmMain() {
            InitializeComponent();
            CarregaConfiguracoes();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            Controls.OfType<MdiClient>().First().BackColor = this.BackColor;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (_salvarConfiguracoes && MessageBox.Show("Salvar Configurações?", Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SalvaConfiguracoes();
        }

        public void CarregaConfiguracoes() {
            tsmiToolbarVisivel.Checked = Settings.Default.MainBarraFerramentasVisivel;
            tsmiToolbarImagemApenas.Checked = Settings.Default.MainBarraFerramentasImagem;
            tsmiBackgroundVisivel.Checked = Settings.Default.MainBackgroundVisivel;
            tsmiBackgroundRodizio.Checked = Settings.Default.MainBackgroundRod;
            timerBackground.Interval = Settings.Default.MainBackgroundTempo * 1000;
        }

        private void SalvaConfiguracoes() {
            Settings.Default.MainBarraFerramentasVisivel = tsmiToolbarVisivel.Checked;
            Settings.Default.MainBarraFerramentasImagem = tsmiToolbarImagemApenas.Checked;
            Settings.Default.MainBackgroundVisivel = tsmiBackgroundVisivel.Checked;
            Settings.Default.MainBackgroundRod = tsmiBackgroundRodizio.Checked;
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
        private void tsbContas_Click(object sender, EventArgs e) {
            var frm = new frmBancosContas() { MdiParent = this };
            frm.Show();
        }

        private void tsbRegras_Click(object sender, EventArgs e) {
            var frm = new frmRegras() { MdiParent = this };
            frm.Show();
        }

        private void tsbLeitor_Click(object sender, EventArgs e) {
            var frm = new frmLeitor() { MdiParent = this };
            if (frm.HasData) {
                frm.Show();
            }
        }

        private void tsbBalance_Click(object sender, EventArgs e) {
            var frm = new frmBalanceSF { MdiParent = this };
            frm.Show();
        }

        private void tsbBalanceAntigo_Click(object sender, EventArgs e) {
            var frm = new frmBalance() { MdiParent = this };
            frm.Show();
        }
        private void tsbPesquisa_Click(object sender, EventArgs e) {
            var frm = new frmPesquisa() { MdiParent = this };
            frm.Show();
        }

        private void tsbClassificacao_Click(object sender, EventArgs e) {
            var frm = new frmClassificacao { MdiParent = this };
            frm.Show();
        }

        private void tsbExportar_Click(object sender, EventArgs e) {
            var frm = new frmExport { MdiParent = this };
            frm.Show();
        }

        private void tsbRelatorios_Click(object sender, EventArgs e) {
            var frm = new frmReport { MdiParent = this };
            frm.Show();
        }
        #endregion EXTRATO -----------------

        #region PAGAMENTOS ----------
        private void tsbPagamentos_Click(object sender, EventArgs e) {
            var frm = new frmPagamentos { MdiParent = this };
            frm.Show();
        }
        private void tsbCalendario_Click(object sender, EventArgs e) {
            var frm = new frmCalendario { MdiParent = this };
            frm.Show();
        }
        #endregion PAGAMENTOS ----------

        #region FERRAMENTAS -----------------
        private void tsbConfig_Click(object sender, EventArgs e) {
            var frm = new frmConfig { MdiParent = this };
            frm.Show();
        }

        private void tsmiToolbarVisivel_CheckedChanged(object sender, EventArgs e) {
            toolStripMain.Visible = tsmiToolbarVisivel.Checked;
            _salvarConfiguracoes = true;
        }

        private void tsmiToolbarImagemApenas_CheckedChanged(object sender, EventArgs e) {
            foreach (ToolStripButton tsb in toolStripMain.Items)
                tsb.DisplayStyle = tsmiToolbarImagemApenas.Checked ? ToolStripItemDisplayStyle.Image : ToolStripItemDisplayStyle.ImageAndText;
        }

        private void tsmiBackgroundRodízio_CheckedChanged(object sender, EventArgs e) {
            tsmiBackgroundVisivel.Checked |= tsmiBackgroundRodizio.Checked;
            timerBackground.Enabled = tsmiBackgroundRodizio.Checked;
            _salvarConfiguracoes = true;
        }

        private void tsmiBackgroundVisível_CheckedChanged(object sender, EventArgs e) {
            if (tsmiBackgroundVisivel.Checked)
                NewBackground();
            else {
                tsmiBackgroundRodizio.Checked = false;
                timerBackground.Enabled = false;
                BackgroundImage = null;
            }
            
        }

        #endregion FERRAMENTAS -----------------

        private void tsbSerieHistorica_Click(object sender, EventArgs e) {
            var frm = new frmSerieHistorica() { MdiParent = this };
            frm.Show();
        }

        private void tsbInvestimentos_Click(object sender, EventArgs e) {
            var frm = new frmInvestimentos() { MdiParent = this };
            frm.Show();
        }

        private void tsmiFundos_Click(object sender, EventArgs e) {
            var frm = new frmFundos() { MdiParent = this };
            frm.Show();
        }
    }
}
