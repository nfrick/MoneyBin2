using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmBaseEdit : Form {
        protected const string AnyCharAccentDigitSeparator = @"[a-zA-Zà-úÀ-Ú0-9]|-|_|\s";
        protected const string AnyCharDigitSeparator = @"[a-zA-Z0-9]|-|_|\s";
        protected const string AnyCharDigit = @"[a-zA-Z0-9]";
        protected const string AnyDigit = @"[0-9]";
        protected const string DigitX = @"[0-9|x|X]";
        protected const string Telefone = @"[0-9]|-|(|)";

        public frmBaseEdit() {
            InitializeComponent();
        }

        private void frmBaseEdit_Load(object sender, EventArgs e) {

        }

        protected void Validate(TextBoxBase txtbox, string expr, int min, int max) {
            txtbox.Text = txtbox.Text.Trim();
            var str = $"^({expr}){{{min},{max}}}$";
            var regex = new Regex(str);
            errorProvider1.SetError(txtbox, regex.IsMatch(txtbox.Text) ? "" :
                $"{txtbox.Tag} deve ter entre {min} e {max} caracteres");
            EnableOKButton();
        }

        protected void ValidateEMail(TextBoxBase txtbox, int max) {
            txtbox.Text = txtbox.Text.Trim();
            if (txtbox.Text.Length > max) {
                errorProvider1.SetError(txtbox, $"{txtbox.Tag} deve ter no máximo {max} caracteres");
                return;
            }
            try {
                var m = new MailAddress(txtbox.Text);
                errorProvider1.SetError(txtbox, "");
            }
            catch (FormatException) {
                errorProvider1.SetError(txtbox, $"{txtbox.Tag} inválido");
            }
            finally {
                EnableOKButton();
            }
        }

        protected void EnableOKButton() {
            var textboxes = GetAllControls(this, typeof(TextBoxBase));
            if (textboxes.Any(txtbox => errorProvider1.GetError(txtbox).Length != 0)) {
                buttonOK.Enabled = false;
                return;
            }
            buttonOK.Enabled = true;
        }

        protected IEnumerable<Control> GetAllControls(Control control, Type type) {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }
    }
}