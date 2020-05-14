using IEnumerableExtensions;
using System.Data.Entity;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmFundos : DataForm {

        public frmFundos() {
            InitializeComponent();
            _ctx.Fundos.Load();
            bsFundos.DataSource = _ctx.Fundos.Local.ToObservableListSource();
            _mainBindingSource = bsFundos;
            EnableSaveButtons();
        }

        protected override void toolStripButtonSave_Click(object sender, System.EventArgs e) {
            base.toolStripButtonSave_Click(sender, e);
            dgvFundos.Refresh();
        }

        protected override void toolStripButtonRevert_Click(object sender, System.EventArgs e) {
            base.toolStripButtonRevert_Click(sender, e);
            dgvFundos.Refresh();
        }

        private void dgvFundos_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            EnableSaveButtons();
        }
    }
}
