using DataLayer;
using IEnumerableExtensions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyBin2 {
    public partial class frmFundos : DataForm {

        private IEnumerable<Fundo> FundosSelecionados =>
            dgvFundos.SelectedRows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow).OrderBy(r => r.Index)
                .Select(r => (Fundo)r.DataBoundItem);

        public frmFundos() {
            InitializeComponent();
            _ctx.Fundos.Load();
            bsFundos.DataSource = _ctx.Fundos.Local.ToObservableListSource();
            _mainBindingSource = bsFundos;

            dgvFundos.FormatColumn("Nome", null, 200);
            dgvFundos.FormatColumn("CNPJ", null, 160);
            dgvFundos.FormatColumn("Apelido", null, 200);

            dgvMeses.FormatColumn("Mês", dgvMeses.StyleMMMAndYear, 90);
            dgvMeses.FormatColumn("Valor Cota", dgvMeses.StyleNumber(6), 90);
            dgvMeses.FormatColumn("Rend. Mês", dgvMeses.StyleNumber(6), 90);
            dgvMeses.FormatColumn("Rend. Ano", dgvMeses.StyleNumber(6), 90);
            dgvMeses.FormatColumn("Rend. 12 Meses", dgvMeses.StyleNumber(6), 90);



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

        private void GerarGrafico() {
            if (dgvFundos.SelectedRows.Count == 0) {
                chart.Visible = false;
                return;
            }

            chart.Series.Clear();
            foreach (var fundo in FundosSelecionados) {
                var serie = chart.Series.Add(fundo.Apelido);
                serie.ChartType = SeriesChartType.Line;
                foreach (var s in fundo.Meses.OrderBy(m => m.Mes)) {
                    serie.Points.AddXY(s.Mes, s.RendimentoMes);
                }
            }
            chart.SetYAxisMinMax(0.05);
            chart.Visible = true;
        }

        private void dgvFundos_SelectionChanged(object sender, System.EventArgs e) {
            GerarGrafico();
        }
    }
}
