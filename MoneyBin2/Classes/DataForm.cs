using DataLayer;
using Syncfusion.WinForms.DataGrid;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class DataForm : Form {
        protected readonly MoneyBinEntities _ctx = new MoneyBinEntities();
        protected BindingSource _mainBindingSource;

        public DataForm() {
            InitializeComponent();
        }

        protected virtual void DataForm_FormClosing(object sender, FormClosingEventArgs e) {
            switch (AskIfSave()) {
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    e.Cancel = Save();
                    break;
            }
            if (!e.Cancel) {
                _ctx.Dispose();
            }
        }

        protected void ResizeForm(DataGridView dgv) {
            Width = 20 + dgv.RowHeadersWidth +
                        dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            if (MdiParent != null) {
                Location = new Point((MdiParent.Width - this.Width) / 2,
                (MdiParent.Height - Height) / 2);
            }
        }

        protected void ResizeForm(SfDataGrid dgv) {

        }

        protected string SaveQuestion =>
             $"Salvar {_ctx.ChangesCount} alteraç" + (_ctx.ChangesCount == 1 ? "ão" : "ões");

        protected DialogResult AskIfSave() {
            var alteracoes = _ctx.ChangesCount;
            return alteracoes == 0
                ? DialogResult.No
                : MessageBox.Show($"{SaveQuestion}?", this.Text,
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
        }

        protected void EnableSaveButtons() {
            var items = toolStripMenu.Items.Cast<ToolStripItem>()
                .Where(i => (string)i.Tag == "Save");
            foreach (var item in items) {
                item.Visible = _ctx.ChangeTracker.HasChanges();
                if (item.Text.StartsWith("Salvar")) {
                    item.Text = SaveQuestion;
                }
            }
            UpdateStatusBar();
        }

        protected void UpdateStatusBar() {
            toolStripStatusLabelRecords.Text = $"Registros: {_mainBindingSource.Count}";

            toolStripStatusLabelAdded.Visible = _ctx.AddedAny;
            toolStripStatusLabelAdded.Text = $"Novos: {_ctx.AddedCount}";

            toolStripStatusLabelUpdated.Visible = _ctx.ModifiedAny;
            toolStripStatusLabelUpdated.Text = $"Atualizados: {_ctx.ModifiedCount}";

            toolStripStatusLabelDeleted.Visible = _ctx.DeletedAny;
            toolStripStatusLabelDeleted.Text = $"Deletados: {_ctx.DeletedCount}";
        }

        protected void EnableSaveButtons(SfDataGrid dgv) {
            var items = toolStripMenu.Items.Cast<ToolStripItem>()
                .Where(i => (string)i.Tag == "Save");
            foreach (var item in items) {
                item.Visible = _ctx.ChangeTracker.HasChanges();
                if (item.Text.StartsWith("Salvar")) {
                    item.Text = SaveQuestion;
                }
            }
            UpdateStatusBar(dgv);
        }

        protected void UpdateStatusBar(SfDataGrid dgv) {
            toolStripStatusLabelRecords.Text = $@"Registros: {dgv.View.Records.Count}";

            toolStripStatusLabelAdded.Visible = _ctx.AddedAny;
            toolStripStatusLabelAdded.Text = $@"Novos: {_ctx.AddedCount}";

            toolStripStatusLabelUpdated.Visible = _ctx.ModifiedAny;
            toolStripStatusLabelUpdated.Text = $@"Atualizados: {_ctx.ModifiedCount}";

            toolStripStatusLabelDeleted.Visible = _ctx.DeletedAny;
            toolStripStatusLabelDeleted.Text = $@"Deletados: {_ctx.DeletedCount}";
        }

        protected virtual void toolStripButtonSave_Click(object sender, System.EventArgs e) {
            Save();
            EnableSaveButtons();
        }

        protected virtual bool Save() {
            if (_ctx.SaveChanges(out var message)) {
                return true;
            }

            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        protected virtual void toolStripButtonRevert_Click(object sender, System.EventArgs e) {
            var alteracoes = _ctx.ChangesCount;
            var pergunta = $"{alteracoes} alteraç" + (alteracoes == 1 ?
            "ão será desfeita" : "ões serão desfeitas") + ". Confirma?";
            if (MessageBox.Show(pergunta, this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes) {
                _ctx.RevertChanges();
            }
            EnableSaveButtons();
        }

        protected void ImportToolStrip(ToolStrip local) {
            var items = local.Items.Cast<ToolStripItem>().ToArray();
            toolStripMenu.Items.AddRange(items);
            local.Visible = false;
            toolStripMenu.Location = new Point(3, 0);
        }
    }
}