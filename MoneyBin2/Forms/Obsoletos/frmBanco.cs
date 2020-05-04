using DataLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmBanco : frmBaseEdit {
        public Banco banco;

        public frmBanco() {
            InitializeComponent();
            buttonOK.Click += buttonOK_Click;
            buttonCancel.Click += buttonCancel_Click;
            this.FormClosing += frmBanco_FormClosing;
        }

        private void frmBanco_Load(object sender, EventArgs e) {
            textBoxNome.Text = banco.Nome;
            textBoxSigla.Text = banco.Sigla;
            textBoxExtrato.Text = banco.ExtensaoExtrato;
            textBoxFundos.Text = banco.ExtensaoFundos;
        }

        private void textBoxNome_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxNome, AnyCharAccentDigitSeparator, 3, 25);
        }

        private void textBoxSigla_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxSigla, AnyCharAccentDigitSeparator, 2, 3);
        }

        private void textBoxExtensao_Validating(object sender, CancelEventArgs e) {
            Validate((TextBox)sender, AnyCharDigit, 3, 4);
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            SaveChanges();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SaveChanges() {
            banco.Nome = textBoxNome.Text;
            banco.Sigla = textBoxSigla.Text;
            banco.ExtensaoExtrato = textBoxExtrato.Text;
            banco.ExtensaoFundos = textBoxFundos.Text;
        }

        private void frmBanco_FormClosing(object sender, FormClosingEventArgs e) {
            if (banco.Nome == textBoxNome.Text && banco.Sigla == textBoxSigla.Text &&
                banco.ExtensaoExtrato == textBoxExtrato.Text && banco.ExtensaoFundos == textBoxFundos.Text) {
                return;
            }

            switch (MessageBox.Show(@"Salvar alterações?",
                @"Banco", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    SaveChanges();
                    break;
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}