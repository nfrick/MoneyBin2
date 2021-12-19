using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmBancosContas : MoneyBin2.DataForm {
        private Banco BancoAtual => (Banco)bsBancos.Current;
        private Conta ContaAtual => (Conta)bsContas.Current;

        protected const string RegexAnyCharAccentDigitSeparator = @"[a-zA-Zà-úÀ-Ú0-9]|-|_|\s";
        protected const string RegexAnyCharDigitSeparator = @"[a-zA-Z0-9]|-|_|\s";
        protected const string RegexAnyCharDigit = @"[a-zA-Z0-9]";
        protected const string RegexAnyDigit = @"[0-9]";
        protected const string RegexDigitX = @"[0-9|x|X]";
        protected const string RegexTelefone = @"[0-9]|-|(|)";

        public frmBancosContas() {
            InitializeComponent();
            _ctx.Bancos.Load();
            bsBancos.DataSource = _ctx.Bancos.Local.ToBindingList();
            _mainBindingSource = bsBancos;
            EnableSaveButtons();

            dgvBancos.FormatColumnByHeader("Nome", null, 250);
            dgvBancos.FormatColumnByHeader("Sigla", null, 80);
            dgvBancos.FormatColumnByHeader("Ext. Extrato", null, 70);
            dgvBancos.FormatColumnByHeader("Ext. Fundos", null, 70);

            dgvContas.FormatColumnByHeader("Apelido", null, 80);
            dgvContas.FormatColumnByHeader("Dono", null, 80);
            dgvContas.FormatColumnByHeader("Agência", null, 70);
            dgvContas.FormatColumnByHeader("Conta", null, 80);
            dgvContas.FormatColumnByHeader("Op.", null, 40);
            dgvContas.FormatColumnByHeader("Gerente", null, 180);
            dgvContas.FormatColumnByHeader("Telefone", null, 90);
            dgvContas.FormatColumnByHeader("Celular", null, 90);
            dgvContas.FormatColumnByHeader("E-Mail", null, 150);
            dgvContas.FormatColumnByHeader("Data Min", dgvContas.StyleDateShort, 80);
            dgvContas.FormatColumnByHeader("Data Max", dgvContas.StyleDateShort, 80);
            dgvContas.FormatColumnByHeader("Saldo", dgvContas.StyleCurrency, 80);

            ResizeForm(dgvContas);

            var tsbBanco = new ToolStripButton {
                Image = global::MoneyBin2.Properties.Resources.Banco,
                ImageTransparentColor = System.Drawing.Color.Magenta,
                Name = "tsbBanco",
                Size = new System.Drawing.Size(114, 24),
                Text = "Novo Banco"
            };
            tsbBanco.Click += tsbNovoBanco_Click;
            toolStripMenu.Items.Add(tsbBanco);

            var tsbConta = new ToolStripButton {
                Image = global::MoneyBin2.Properties.Resources.Carteira,
                ImageTransparentColor = System.Drawing.Color.Magenta,
                Name = "tsbConta",
                Size = new System.Drawing.Size(111, 24),
                Text = "Nova Conta"
            };
            tsbConta.Click += tsbNovaConta_Click;
            toolStripMenu.Items.Add(tsbConta);

            splitContainerBanco.Panel2Collapsed = true;
            splitContainerConta.Panel2Collapsed = true;
        }

        private void frmBancos_Load(object sender, EventArgs e) {
            if (dgvBancos.RowCount > 0) {
                dgvBancos.Sort(dgvBancos.Columns[0], ListSortDirection.Ascending);
            }
        }


        #region TOOLSTRIP ---------------------------
        private void tsbNovoBanco_Click(object sender, EventArgs e) {
            bsBancos.Add(new Banco());
            bsBancos.ResetBindings(true);
            bsBancos.MoveLast();
            dgvBancos.Refresh();
            BancoToggleEdit();
        }

        private void tsbNovaConta_Click(object sender, EventArgs e) {
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
            splitContainerBanco.Panel2Collapsed = !splitContainerBanco.Panel2Collapsed;
            dgvBancos.Enabled = !dgvBancos.Enabled;
            dgvContas.Enabled = !dgvContas.Enabled;
            buttonBancoOK.Enabled = false;
            EnableSaveButtons();
        }

        private void buttonBanco_Click(object sender, EventArgs e) {
            if (((Button)sender).Text == "û") {  // cancel
                if (BancoAtual.ID == 0) { // novo banco
                    var addedEntries = _ctx.ChangeTracker.Entries<Banco>()
                        .Where(entry => entry.State == EntityState.Added &&
                        entry.Entity.Nome == BancoAtual.Nome);

                    foreach (var entry in addedEntries) {
                        entry.State = EntityState.Detached;
                    }
                }
                else {
                    var modifiedEntry = _ctx.ChangeTracker.Entries<Banco>()
                        .FirstOrDefault(entry => entry.State == EntityState.Modified
                        && entry.Entity.ID == BancoAtual.ID);
                    if (modifiedEntry != null) {
                        modifiedEntry.State = EntityState.Unchanged;
                    }

                    foreach (var ctl in GetAllControlsOfTag(splitContainerBanco.Panel2, nomeTextBox)) {
                        var @base = ctl as TextBoxBase;
                        @base?.Undo();
                    }
                }
            }
            errorProvider.Clear();
            BancoToggleEdit();

            dgvBancos.Refresh();
            dgvBancos.AllowUserToAddRows = false;
            
        }

        //object GetPrimaryKeyValue(DbEntityEntry entry) {
        //    var objectStateEntry = ((IObjectContextAdapter)_ctx).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
        //    return objectStateEntry.EntityKey.EntityKeyValues[0].Value;
        //}

        private void nomeTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(nomeTextBox, RegexAnyCharAccentDigitSeparator, 3, 25);
        }

        private void siglaTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(siglaTextBox, RegexAnyCharAccentDigitSeparator, 2, 3);
        }

        private void extensaoTextBox_Validating(object sender, CancelEventArgs e) {
            Validate((TextBox)sender, RegexAnyCharDigit, 3, 4);
        }
        #endregion BANCO ------------------------------


        #region CONTA -------------------------
        private void dgvContas_DoubleClick(object sender, EventArgs e) {
            ContaAtual.SaveCopy();
            ContaToggleEdit();
        }

        private void ContaToggleEdit() {
            toolStripMenu.Enabled = !toolStripMenu.Enabled;
            splitContainerConta.Panel2Collapsed = !splitContainerConta.Panel2Collapsed;
            dgvBancos.Enabled = !dgvBancos.Enabled;
            dgvContas.Enabled = !dgvContas.Enabled;
            buttonContaOK.Enabled = false;
            EnableSaveButtons();
        }

        private void buttonConta_Click(object sender, EventArgs e) {
            if (((Button)sender).Text == "û") {  // cancel
                var ContasAlteradas = _ctx.ChangeTracker.Entries<Conta>();
                if (ContaAtual.ID == 0) {  // nova conta
                    BancoAtual.Contas.Remove(ContaAtual);
                    ContaAtual.ID = -1; // para distinguir de outras contas adicionadas na mesma sessão
                    var addedEntries = ContasAlteradas
                        .Where(entry => entry.State == EntityState.Added
                                        && entry.Entity.ID == -1);

                    foreach (var entry in addedEntries) {
                        entry.State = EntityState.Detached;
                    }
                }
                else {
                    var modifiedEntry = _ctx.ChangeTracker.Entries<Conta>()
                        .FirstOrDefault(entry => entry.State == EntityState.Modified
                                             && entry.Entity.ID == ContaAtual.ID);
                    if (modifiedEntry != null) {
                        modifiedEntry.State = EntityState.Unchanged;
                    }


                    foreach (var ctl in GetAllControlsOfTag(splitContainerConta.Panel2, donoTextBox)) {
                        var @base = ctl as TextBoxBase;
                        @base?.Undo();
                    }
                }
                dgvContas.Refresh();
            }
            errorProvider.Clear();
            ContaToggleEdit();
        }

        private void apelidoTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(apelidoTextBox, RegexAnyCharAccentDigitSeparator, 3, 10);
        }

        private void donoTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(donoTextBox, RegexAnyCharAccentDigitSeparator, 3, 10);
        }

        private void agenciaTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(agenciaTextBox, RegexAnyDigit, 4, 10);
        }

        private void agenciaDVTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(agenciaDVTextBox, RegexAnyDigit, 0, 1);
        }

        private void contaCorrenteTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(contaCorrenteTextBox, RegexAnyDigit, 4, 10);
        }

        private void contaCorrenteDVTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(contaCorrenteDVTextBox, RegexDigitX, 1, 1);
        }

        private void operacaoTextBox_Validating(object sender, CancelEventArgs e) {
            if (operacaoTextBox.Text.Trim().Length > 0) {
                Validate(operacaoTextBox, RegexAnyDigit, 3, 3);
            }
        }

        private void gerenteTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(gerenteTextBox, RegexAnyCharAccentDigitSeparator, 3, 20);
        }

        private void telefoneTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(telefoneTextBox, RegexAnyCharAccentDigitSeparator, 1, 10);
        }

        private void celularTextBox_Validating(object sender, CancelEventArgs e) {
            Validate(celularTextBox, RegexAnyCharAccentDigitSeparator, 1, 11);
        }

        private void eMailTextBox_Validating(object sender, CancelEventArgs e) {
            ValidateEMail(eMailTextBox, 60);
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

        private void dgvContas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var conta = (Conta) dgvContas.Rows[e.RowIndex].DataBoundItem;
            if (!conta.Ativa)
                e.CellStyle.ForeColor = Color.DarkGray;
        }
    }
}
