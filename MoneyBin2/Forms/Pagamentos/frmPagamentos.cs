using DataLayer;
using MoneyBin2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace MoneyBin2 {
    public partial class frmPagamentos : DataForm {

        private Pagamento PagtoAtual => (Pagamento)dgvPagamentos.CurrentRow?.DataBoundItem;

        private IEnumerable<CheckBox> CheckBoxesMeses =>
            splitContainer.Panel2
                .Controls.Cast<Control>()
                .Where(c => (string)c.Tag == "Mes")
                .Cast<CheckBox>();

        public frmPagamentos() {
            InitializeComponent();

            splitContainer.Panel2Collapsed = true;

            dgvPagamentos.FormatColumn("Grupo", null, 100);
            dgvPagamentos.FormatColumn("Categoria", null, 200);
            dgvPagamentos.FormatColumn("SubCategoria", null, 150);
            dgvPagamentos.FormatColumn("Descrição", null, 150);
            dgvPagamentos.FormatColumn("Dia", dgvPagamentos.StyleInteger, 50);
            dgvPagamentos.FormatColumn("Valor", dgvPagamentos.StyleCurrency, 80);
            for (var col = 7; col < dgvPagamentos.ColumnCount; col++) {
                dgvPagamentos.Columns[col].Width = 50;
            }

            ResizeForm(dgvPagamentos);

            chkbtnMeses.BackgroundColorChecked = Color.LightGreen;
            chkbtnMeses.CheckedChanged += (sender, args) => {
                foreach (var control in CheckBoxesMeses) {
                    control.Visible = chkbtnMeses.Checked;
                }
            };

            comboBoxGrupo.Items.AddRange(ClassifTools.GetListOfGrupos(-1).ToArray());

            ImportToolStrip(toolStripPagamentos);

            _ctx.Pagamentos.Load();
            bsPagamentos.DataSource = _ctx.Pagamentos.Local.ToBindingList();
            _mainBindingSource = bsPagamentos;
            EnableSaveButtons();
        }

        protected override void DataForm_FormClosing(object sender, FormClosingEventArgs e) {
            dgvPagamentos.EndEdit();
            base.DataForm_FormClosing(sender, e);
        }

        #region DATAGRIDVIEW -------------------
        private void dgvPagamentos_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            EnableSaveButtons();
        }

        private void dgvPagamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var dgv = (DataGridView)sender;
            if (dgv.RowCount == 0 ||
                !((Pagamento)dgv.Rows[e.RowIndex].DataBoundItem).Inativo) {
                return;
            }

            e.CellStyle.ForeColor = Color.DarkGray;
        }

        private void dgvPagamentos_DoubleClick(object sender, EventArgs e) {
            if (dgvPagamentos.RowCount == 0) {
                NovoPagamento();
            }
            ToggleEdit();
        }

        private void dgvPagamentos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            //FormUtils.EditingControlShowing(sender, e);
        }

        private void dgvPagamentos_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Right) {
                return;
            }

            var mouseOverRow = dgvPagamentos.HitTest(e.X, e.Y).RowIndex;
            var mouseOverCol = dgvPagamentos.HitTest(e.X, e.Y).ColumnIndex;

            var Novo = mouseOverRow == -1;
            cmsPopMenu.Items.Clear();

            if (!Novo) {
                dgvPagamentos.CurrentCell = dgvPagamentos.Rows[mouseOverRow].Cells[mouseOverCol];
                dgvPagamentos.Rows[mouseOverRow].Selected = true;
                cmsPopMenu.Items.Add("Editar");
            }
            cmsPopMenu.Items.Add("Novo", Resources.Add_24);
            cmsPopMenu.Show(Cursor.Position);
        }
        #endregion DATAGRIDVIEW -------------------

        #region TOOLSTRIP -------------------
        protected override void toolStripButtonSave_Click(object sender, EventArgs e) {
            dgvPagamentos.EndEdit();
            base.toolStripButtonSave_Click(sender, e);
        }

        protected override void toolStripButtonRevert_Click(object sender, EventArgs e) {
            base.toolStripButtonRevert_Click(sender, e);
            dgvPagamentos.Refresh();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e) {
            NovoPagamento();
            ToggleEdit();
        }
        #endregion TOOLSTRIP -------------------

        #region EDITING -------------------
        private void ToggleEdit() {
            toolStripPagamentos.Enabled = !toolStripPagamentos.Enabled;
            splitContainer.Panel2Collapsed = !splitContainer.Panel2Collapsed;
            dgvPagamentos.Enabled = !dgvPagamentos.Enabled;
            buttonOK.Enabled = !buttonOK.Enabled;
            if (dgvPagamentos.Enabled) {
                EnableSaveButtons();
            }
            else {
                chkbtnMeses.Checked = PagtoAtual.AlgunsMeses;
                chkbtnAnoInteiro.Checked = PagtoAtual.AnoInteiro;
                chkbtnInativo.Checked = PagtoAtual.Inativo;
            }
        }

        private void NovoPagamento() {
            bsPagamentos.Add(new Pagamento());
            bsPagamentos.ResetBindings(true);
            bsPagamentos.MoveLast();
            dgvPagamentos.Refresh();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            ToggleEdit();
            dgvPagamentos.Refresh();
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem.Text == "Novo") {
                NovoPagamento();
            }

            ToggleEdit();
        }

        private void chkbtnAnoInteiro_Click(object sender, EventArgs e) {
            chkbtnAnoInteiro.ToggleCheck();
            CheckMeses(chkbtnAnoInteiro.Checked);
            PagtoAtual.AnoInteiro = chkbtnAnoInteiro.Checked;
            if (chkbtnAnoInteiro.Checked) {
                chkbtnInativo.Checked = false;
            }
        }

        private void chkbtnInativo_Click(object sender, EventArgs e) {
            chkbtnInativo.ToggleCheck();
            PagtoAtual.Inativo = chkbtnInativo.Checked;
            if (chkbtnInativo.Checked) {
                CheckMeses(false);
                chkbtnAnoInteiro.Checked = false;
            }
        }

        private void CheckMeses(bool check) {
            foreach (var control in CheckBoxesMeses) {
                control.Checked = check;
            }
        }

        private void chkbtnMeses_Click(object sender, EventArgs e) {
            chkbtnMeses.ToggleCheck();
        }

        private void checkBoxMes_CheckedChanged(object sender, EventArgs e) {
            chkbtnAnoInteiro.Checked = CheckBoxesMeses.All(c => c.Checked);
            chkbtnInativo.Checked = !CheckBoxesMeses.Any(c => c.Checked);
        }

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e) {
            comboBoxCategoria.Items.Clear();
            comboBoxCategoria.Items.AddRange(ClassifTools.GetListOfCategorias(comboBoxGrupo.Text, -1).ToArray());
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e) {
            comboBoxSubCategoria.Items.Clear();
            comboBoxSubCategoria.Items.AddRange(
                ClassifTools.GetListOfSubCategorias(comboBoxGrupo.Text, comboBoxCategoria.Text, -1).ToArray());
        }

        private void comboBox_Validating(object sender, CancelEventArgs e) {
            var ctl = (ComboBox)sender;
            var campo = ctl.Name.Substring(8);
            if (string.IsNullOrEmpty(ctl.Text)) {
                errorProvider.SetError(ctl, $"'{campo}' é um campo obrigatório.");
                e.Cancel = true;
            }
            else {
                errorProvider.SetError(ctl, "");
            }
        }

        private void textBoxDescricao_Validating(object sender, CancelEventArgs e) {
            var ctl = (TextBox)sender;
            var campo = ctl.Name.Substring(8);
            if (string.IsNullOrEmpty(ctl.Text)) {
                errorProvider.SetError(ctl, $"'{campo}' é um campo obrigatório.");
                e.Cancel = true;
            }
            else {
                errorProvider.SetError(ctl, "");
            }
        }
        #endregion EDITING -------------------
    }

    public class CheckableButton : Button, INotifyPropertyChanged {
        private bool _checked;
        public bool Checked {
            get => _checked;
            set {
                if (value == _checked) {
                    return;
                }

                _checked = value;
                BackColor = _checked ? BackgroundColorChecked : BackgroundColorUnChecked;
                //OnPropertyChanged();
                OnCheckedChanged(new EventArgs());
            }
        }
        public Color BackgroundColorChecked = Color.FromArgb(255, 255, 192, 128);
        public Color BackgroundColorUnChecked = Color.Silver;

        protected void OnPropertyChanged(PropertyChangedEventArgs e) {
            var handler = PropertyChanged;
            handler?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnCheckedChanged(EventArgs e) {
            var handler = CheckedChanged;
            handler?.Invoke(this, e);
        }

        public event EventHandler CheckedChanged;

        protected void OnPropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public void ToggleCheck() {
            Checked = !Checked;
        }
    }
}
