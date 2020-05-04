using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmBancosContasOld : Form {
        readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private Banco BancoAtual => (Banco)dgvBancos.CurrentRow?.DataBoundItem;
        private Conta ContaAtual => (Conta)dgvContas.CurrentRow?.DataBoundItem;

        protected const string regexAnyCharAccentDigitSeparator = @"[a-zA-Zà-úÀ-Ú0-9]|-|_|\s";
        protected const string regexAnyCharDigitSeparator = @"[a-zA-Z0-9]|-|_|\s";
        protected const string regexAnyCharDigit = @"[a-zA-Z0-9]";
        protected const string regexAnyDigit = @"[0-9]";
        protected const string regexDigitX = @"[0-9|x|X]";
        protected const string regexTelefone = @"[0-9]|-|(|)";

        public frmBancosContasOld() {
            InitializeComponent();

            _ctx.Bancos.Load();
            bsBancos.DataSource = _ctx.Bancos.Local.ToBindingList();

            dgvBancos.FormatColumn("Nome", null, 250);
            dgvBancos.FormatColumn("Sigla", null, 80);
            dgvBancos.FormatColumn("Ext. Extrato", null, 70);
            dgvBancos.FormatColumn("Ext. Fundos", null, 70);

            dgvContas.FormatColumn("Apelido", null, 80);
            dgvContas.FormatColumn("Dono", null, 80);
            dgvContas.FormatColumn("Agência", null, 70);
            dgvContas.FormatColumn("Conta", null, 85);
            dgvContas.FormatColumn("Op.", null, 40);
            dgvContas.FormatColumn("Gerente", null, 180);
            dgvContas.FormatColumn("Telefone", null, 90);
            dgvContas.FormatColumn("Celular", null, 90);
            dgvContas.FormatColumn("E-Mail", null, 150);
            dgvContas.FormatColumn("Data Min", dgvContas.StyleDateShort, 80);
            dgvContas.FormatColumn("Data Max", dgvContas.StyleDateShort, 80);
            dgvContas.FormatColumn("Saldo", dgvContas.StyleCurrency, 80);

            splitContainerBancos.Panel2Collapsed = true;
            splitContainerContas.Panel2Collapsed = true;
        }

        private void frmBancosContas_Load(object sender, EventArgs e) {
            if (dgvBancos.RowCount > 0) {
                dgvBancos.Sort(dgvBancos.Columns[0], ListSortDirection.Ascending);
            }
        }

        #region TOOLSTRIP ---------------------------
        private void toolStripSalvar_Click(object sender, EventArgs e) {
            if (!_ctx.SaveChanges(out string message)) {
                MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            FormUtils.EnableSaveButtons(_ctx, toolStripMenu);
        }

        private void toolStripButtonDesfazer_Click(object sender, EventArgs e) {
            _ctx.RevertChanges();
            dgvBancos.Refresh();
            dgvContas.Refresh();
            FormUtils.EnableSaveButtons(_ctx, toolStripMenu);
        }

        private void toolStripButtonNovoBanco_Click(object sender, EventArgs e) {
            bsBancos.Add(new Banco());
            bsBancos.ResetBindings(true);
            bsBancos.MoveLast();
            dgvBancos.Refresh();
            BancoToggleEdit();
        }

        private void toolStripButtonNovaConta_Click(object sender, EventArgs e) {
            var novaConta = new Conta() { Banco = BancoAtual };
            BancoAtual.Contas.Add(novaConta);
            dgvContas.Refresh();

            var lastRow = dgvContas.RowCount - 1;
            dgvContas.ClearSelection();
            dgvContas.CurrentRow.Selected = false;
            dgvContas.Rows[lastRow].Cells[0].Selected = true;
            dgvContas.FirstDisplayedScrollingRowIndex = lastRow;

            ContaAtual.SaveCopy();
            ContaToggleEdit();
        }

        #endregion TOOLSTRIP ---------------------------


        #region BANCO ---------------------------------
        private void dgvBancos_DoubleClick(object sender, EventArgs e) {
            BancoAtual.SaveCopy();
            BancoToggleEdit();
        }

        private void BancoToggleEdit() {
            toolStripMenu.Enabled = !toolStripMenu.Enabled;
            splitContainerBancos.Panel2Collapsed = !splitContainerBancos.Panel2Collapsed;
            dgvBancos.Enabled = !dgvBancos.Enabled;
            dgvContas.Enabled = !dgvContas.Enabled;
            buttonBancoOK.Enabled = false;
            FormUtils.EnableSaveButtons(_ctx, toolStripMenu);
        }

        private void buttonBanco_Click(object sender, EventArgs e) {
            if (((Button)sender).Text == "û") {  // cancel
                if (BancoAtual == null) { // novo banco
                    var changedEntriesCopy = _ctx.ChangeTracker.Entries()
                        .Where(entry => entry.State == EntityState.Added)
                        .ToList();

                    foreach (var entry in changedEntriesCopy) {
                        entry.State = EntityState.Detached;
                    }

                    dgvBancos.Refresh();
                }
                else {
                    BancoAtual.Reset();
                    foreach (var ctl in GetAllControlsOfTag(splitContainerBancos.Panel2, textBoxNome)) {
                        var @base = ctl as TextBoxBase;
                        @base?.Undo();
                    }
                }
            }
            errorProvider.Clear();
            BancoToggleEdit();
            dgvBancos.AllowUserToAddRows = false;
        }

        private void textBoxNome_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxNome, regexAnyCharAccentDigitSeparator, 3, 25);
        }

        private void textBoxSigla_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxSigla, regexAnyCharAccentDigitSeparator, 2, 3);
        }

        private void textBoxExtensao_Validating(object sender, CancelEventArgs e) {
            Validate((TextBox)sender, regexAnyCharDigit, 3, 4);
        }
        #endregion BANCO ------------------------------


        #region CONTA -------------------------
        private void dgvContas_DoubleClick(object sender, EventArgs e) {
            ContaAtual.SaveCopy();
            ContaToggleEdit();
        }

        private void ContaToggleEdit() {
            toolStripMenu.Enabled = !toolStripMenu.Enabled;
            splitContainerContas.Panel2Collapsed = !splitContainerContas.Panel2Collapsed;
            dgvBancos.Enabled = !dgvBancos.Enabled;
            dgvContas.Enabled = !dgvContas.Enabled;
            buttonContaOK.Enabled = false;
            FormUtils.EnableSaveButtons(_ctx, toolStripMenu);
        }

        private void buttonConta_Click(object sender, EventArgs e) {
            if (((Button)sender).Text == "û") {  // cancel
                if (ContaAtual.ID == 0) {  // nova conta
                    BancoAtual.Contas.Remove(ContaAtual);
                    ContaAtual.ID = -1; // para distinguir de outras contas adicionadas na mesma sessão
                    var changedEntriesCopy = _ctx.ChangeTracker.Entries()
                        .Where(entry => entry.State == EntityState.Added
                            && ((Conta)entry.Entity).ID == -1)
                        .ToList();

                    foreach (var entry in changedEntriesCopy) {
                        entry.State = EntityState.Detached;
                    }

                    //edsBancosContas.Refresh();
                    dgvContas.Refresh();
                }
                else {
                    ContaAtual.Reset();
                    foreach (var ctl in GetAllControlsOfTag(splitContainerContas.Panel2, textBoxDono)) {
                        var @base = ctl as TextBoxBase;
                        @base?.Undo();
                    }
                }
            }
            errorProvider.Clear();
            ContaToggleEdit();
        }

        private void textBoxApelido_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxApelido, regexAnyCharAccentDigitSeparator, 3, 10);
        }

        private void textBoxDono_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxDono, regexAnyCharAccentDigitSeparator, 3, 10);
        }

        private void maskedTextBoxAgencia_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxAgencia, regexAnyDigit, 4, 10);
        }

        private void maskedTextBoxAgenciaDV_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxAgenciaDV, regexAnyDigit, 0, 1);
        }

        private void maskedTextBoxContaCorrente_Validating(object sender, CancelEventArgs e) {
            Validate(maskedTextBoxContaCorrente, regexAnyDigit, 4, 10);
        }

        private void textBoxContaCorrenteDV_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxContaCorrenteDV, regexDigitX, 1, 1);
        }

        private void maskedTextBoxOperacao_Validating(object sender, CancelEventArgs e) {
            if (maskedTextBoxOperacao.Text.Trim().Length > 0) {
                Validate(maskedTextBoxOperacao, regexAnyDigit, 3, 3);
            }
        }

        private void textBoxGerente_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxGerente, regexAnyCharAccentDigitSeparator, 3, 20);
        }

        private void textBoxTelefone_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxTelefone, regexAnyCharAccentDigitSeparator, 1, 10);
        }

        private void textBoxCelular_Validating(object sender, CancelEventArgs e) {
            Validate(textBoxCelular, regexAnyCharAccentDigitSeparator, 1, 11);
        }

        private void textBoxEMail_Validating(object sender, CancelEventArgs e) {
            ValidateEMail(textBoxEMail, 60);
        }
        #endregion CONTA ----------------------


        #region VALIDATION --------------------------
        protected void Validate(TextBoxBase txtbox, string expr, int min, int max) {
            txtbox.Text = txtbox.Text.Trim();
            var str = $"^({expr}){{{min},{max}}}$";
            var regex = new Regex(str);
            errorProvider.SetError(txtbox, regex.IsMatch(txtbox.Text) ? "" :
                $"Deve ter entre {min} e {max} caracteres");
            EnableOKButton(txtbox);
        }

        protected void ValidateEMail(TextBoxBase txtbox, int max) {
            txtbox.Text = txtbox.Text.Trim();
            if (txtbox.Text.Length < 11 || txtbox.Text.Length > max) {
                errorProvider.SetError(txtbox, $"Deve ter entre 12 e {max} caracteres");
                return;
            }
            try {
                var m = new MailAddress(txtbox.Text);
                errorProvider.SetError(txtbox, "");
            }
            catch (FormatException) {
                errorProvider.SetError(txtbox, $"{txtbox.Tag} inválido");
            }
            finally {
                EnableOKButton(txtbox);
            }
        }
        #endregion VALIDATION -----------------------


        #region CONTROL HANDLING --------------------
        private void EnableOKButton(Control callerControl) {
            var editControls = GetAllControlsOfTag(this, callerControl);
            var button = GetButton(callerControl);
            button.Enabled = editControls.All(txtbox => errorProvider.GetError(txtbox).Length == 0);
        }

        private IEnumerable<Control> GetAllControls(Control parentControl) {
            var controls = parentControl.Controls.Cast<Control>();
            return controls.SelectMany(GetAllControls).Concat(controls);
        }

        private IEnumerable<Control> GetAllControlsOfType(Control parentControl, Type type) {
            return GetAllControls(parentControl).Where(c => c.GetType() == type);
        }

        private IEnumerable<Control> GetAllControlsOfTag(Control parentControl, Control control) {
            return GetAllControls(parentControl).Where(c => (string)c.Tag == (string)control.Tag);
        }

        private Button GetButton(Control txtbox) {
            return (Button)GetAllControlsOfType(this, typeof(Button)).First(b => b.Name == (string)txtbox.Tag);
        }
        #endregion CONTROL HANDLING -----------------

    }
}