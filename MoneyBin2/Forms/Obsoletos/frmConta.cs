using DataLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmConta : frmBaseEdit {
        public Conta conta;

        public frmConta() {
            InitializeComponent();
            buttonOK.Click += buttonOK_Click;
            buttonCancel.Click += buttonCancel_Click;
            this.FormClosing += frmConta_FormClosing;
        }

        private void frmConta_Load(object sender, EventArgs e) {
            labelBanco.Text = conta.Banco.Nome;
            textBoxApelido.Text = conta.Apelido;
            textBoxDono.Text = conta.Dono;
            maskedTextBoxAgencia.Text = conta.Agencia;
            maskedTextBoxAgenciaDV.Text = conta.AgenciaDV;
            maskedTextBoxContaCorrente.Text = conta.ContaCorrente;
            textBoxContaCorrenteDV.Text = conta.ContaCorrenteDV;
            maskedTextBoxOperacao.Text = conta.Operacao;
            textBoxGerente.Text = conta.Gerente;
            textBoxTelefone.Text = conta.Telefone;
            textBoxCelular.Text = conta.Celular;
            textBoxEMail.Text = conta.EMail;
        }

        #region VALIDATION ----------------------------
        private void textBoxApelido_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxApelido, AnyCharAccentDigitSeparator, 3, 10);
        }

        private void textBoxDono_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxDono, AnyCharAccentDigitSeparator, 3, 10);
        }

        private void maskedTextBoxAgencia_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxAgencia, AnyDigit, 4, 10);
        }

        private void maskedTextBoxAgenciaDV_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxAgenciaDV, AnyDigit, 0, 1);
        }

        private void maskedTextBoxContaCorrente_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxContaCorrente, AnyDigit, 4, 10);
        }

        private void textBoxContaCorrenteDV_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxContaCorrenteDV, DigitX, 1, 1);
        }

        private void maskedTextBoxOperacao_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxOperacao, AnyDigit, 3, 3);
        }

        private void textBoxGerente_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxGerente, AnyCharAccentDigitSeparator, 1, 20);
        }

        private void textBoxTelefone_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxTelefone, AnyCharAccentDigitSeparator, 1, 10);
        }

        private void textBoxCelular_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxCelular, AnyCharAccentDigitSeparator, 1, 11);
        }

        private void textBoxEMail_Validating(object sender, CancelEventArgs e) {
            ValidateEMail(textBoxEMail, 60);
        }
        #endregion VALIDATION ----------------------------

        private void buttonOK_Click(object sender, EventArgs e) {
            SaveChanges();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SaveChanges() {
            conta.Apelido = textBoxApelido.Text;
            conta.Dono = textBoxDono.Text;
            conta.Agencia = maskedTextBoxAgencia.Text;
            conta.AgenciaDV = maskedTextBoxAgenciaDV.Text;
            conta.ContaCorrente = maskedTextBoxContaCorrente.Text;
            conta.ContaCorrenteDV = textBoxContaCorrenteDV.Text;
            conta.Operacao = maskedTextBoxOperacao.Text;
            conta.Gerente = textBoxGerente.Text;
            conta.Telefone = textBoxTelefone.Text;
            conta.Celular = textBoxCelular.Text;
            conta.EMail = textBoxEMail.Text;
        }

        private void frmConta_FormClosing(object sender, FormClosingEventArgs e) {
            if (conta.Apelido == null || 
                (conta.Apelido == textBoxApelido.Text &&
                conta.Dono == textBoxDono.Text &&
                conta.Agencia == maskedTextBoxAgencia.Text &&
                conta.AgenciaDV == maskedTextBoxAgenciaDV.Text &&
                conta.ContaCorrente == maskedTextBoxContaCorrente.Text &&
                conta.ContaCorrenteDV == textBoxContaCorrenteDV.Text &&
                conta.Operacao == maskedTextBoxOperacao.Text &&
                conta.Gerente == textBoxGerente.Text &&
                conta.Telefone == textBoxTelefone.Text &&
                conta.Celular == textBoxCelular.Text &&
                conta.EMail == textBoxEMail.Text)) {
                return;
            }

            switch (MessageBox.Show(@"Salvar alterações?",
                @"Conta Corrente", MessageBoxButtons.YesNoCancel,
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
