using DataLayer;
using IEnumerableExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyBin2 {
    public partial class frmFundos : DataForm {
        private readonly ToolStripComboBox _cbxGrafico;

        private IEnumerable<Fundo> FundosSelecionados =>
            dgvFundos.SelectedRows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow).OrderBy(r => r.Index)
                .Select(r => (Fundo)r.DataBoundItem);

        public frmFundos() {
            InitializeComponent();
            toolStripMenu.Items.Add(new ToolStripLabel("Gráfico:"));

            _cbxGrafico = new ToolStripComboBox() {
                Items = { "Mês", "Ano", "12 Meses" },
                Width = 20,
                SelectedIndex = 0
            };

            toolStripMenu.Items.Add(_cbxGrafico);

            _ctx.Fundos.Load();
            bsFundos.DataSource = _ctx.Fundos.Local.ToObservableListSource();
            _mainBindingSource = bsFundos;

            dgvFundos.FormatColumnByHeader("Nome", null, 200);
            dgvFundos.FormatColumnByHeader("CNPJ", null, 160);
            dgvFundos.FormatColumnByHeader("Apelido", null, 200);
            dgvFundos.FormatColumnByHeader("Tipo", null, 70);

            dgvMeses.FormatColumnByHeader("Mês", dgvMeses.StyleMMMAndYear, 90);
            dgvMeses.FormatColumnByHeader("Valor Cota", dgvMeses.StyleNumber(6), 90);
            dgvMeses.FormatColumnByHeader("Rend. Mês", dgvMeses.StyleNumber(6), 90);
            dgvMeses.FormatColumnByHeader("Rend. Ano", dgvMeses.StyleNumber(6), 90);
            dgvMeses.FormatColumnByHeader("Rend. 12 Meses", dgvMeses.StyleNumber(6), 90);

            _cbxGrafico.SelectedIndexChanged += CbxOnSelectedIndexChanged;

            EnableSaveButtons();
        }

        private void CbxOnSelectedIndexChanged(object sender, EventArgs eventArgs) {
            GerarGrafico();
        }

        protected override void tsbSave_Click(object sender, System.EventArgs e) {
            base.tsbSave_Click(sender, e);
            dgvFundos.Refresh();
        }

        protected override void tsbRevert_Click(object sender, System.EventArgs e) {
            base.tsbRevert_Click(sender, e);
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

                foreach (var s in GetChartData(fundo.Meses.OrderBy(m => m.Mes))) {
                    serie.Points.AddXY(s.Mes, s.Rendimento);
                }
            }
            chart.SetYAxisMinMax(0.05);
            chart.Visible = true;
        }

        private IEnumerable<ChartData> GetChartData(IEnumerable<FundoMes> Meses) {
            switch ((string)_cbxGrafico.SelectedItem) {
                case "Ano":
                    return Meses.Select(m => new ChartData(m.Mes, m.RendimentoAno));
                case "12 Meses":
                    return Meses.Select(m => new ChartData(m.Mes, m.Rendimento12Meses));
                case "Mês":
                default:
                    return Meses.Select(m => new ChartData(m.Mes, m.RendimentoMes));
            }
        }

        private void dgvFundos_SelectionChanged(object sender, System.EventArgs e) {
            GerarGrafico();
            dgvMeses.Sort(dgvMeses.Columns[0], ListSortDirection.Descending);
        }
    }

    public class ChartData {
        public DateTime Mes { get; }
        public decimal Rendimento { get; }

        public ChartData(DateTime mes, decimal rend) {
            Mes = mes;
            Rendimento = rend;
        }
    }
}
