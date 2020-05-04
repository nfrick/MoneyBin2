using ChartLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyBin2 {
    public partial class frmGrafico : Form {
        Point? _prevPosition = null;
        readonly ToolTip _tooltip = new ToolTip();

        public frmGrafico() {
            InitializeComponent();
        }

        private void frmGrafico_Load(object sender, EventArgs e) {
            foreach (var serie in chart.Series) {
                var ctl = new ToolStripMenuItem($"Change {serie.Name}") { Tag = serie };
                ctl.Click += changeColorToolStripMenuItem_Click;
                contextMenu.Items.Add(ctl);
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e) {
            var item = (ToolStripMenuItem)sender;
            var serie = (Series)item.Tag;
            ColorDialog.Color = serie.Color;
            if (ColorDialog.ShowDialog() == DialogResult.OK) {
                serie.Color = ColorDialog.Color;
            }
        }

        private void invertBackgroundToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (var axis in chart.ChartAreas[0].Axes) {
                axis.LineColor = ColorFunctions.InvertColor(axis.LineColor);
                axis.MajorGrid.LineColor = ColorFunctions.InvertColor(axis.LineColor);
                axis.MinorGrid.LineColor = ColorFunctions.InvertColor(axis.LineColor);
                axis.LabelStyle.ForeColor = ColorFunctions.InvertColor(axis.LabelStyle.ForeColor);
            }
            foreach (var legend in chart.Legends) {
                legend.ForeColor = ColorFunctions.InvertColor(legend.ForeColor);
            }
            chart.BackColor = ColorFunctions.InvertColor(chart.BackColor);
        }

        private void saveAsPNGToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveDialog.DefaultExt = "png";
            SaveDialog.Filter = @"PNG Files|*.png";
            SaveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (SaveDialog.ShowDialog() == DialogResult.OK) {
                chart.SaveImage(SaveDialog.FileName, ChartImageFormat.Png);
            }
        }

        private void toolStripMenuItemCustomize_Click(object sender, EventArgs e) {
            var frm = new frmCustomizeChart() {
                chart = chart
            };
            frm.Location = new Point(Location.X + Width - 10, Location.Y + Height - frm.Height);
            frm.ShowDialog();
        }

        private void chart_MouseMove(object sender, MouseEventArgs e) {
            var pos = e.Location;
            if (_prevPosition.HasValue && pos == _prevPosition.Value) {
                return;
            }

            _tooltip.RemoveAll();
            _prevPosition = pos;
            var results = chart.HitTest(pos.X, pos.Y, false,
                ChartElementType.DataPoint);  //.PlottingArea);
            foreach (var result in results) {
                if (result.ChartElementType != ChartElementType.DataPoint) {
                    continue;
                }

                var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                var hora = (new DateTime(1899, 12, 31)).AddDays(xVal).ToString("dd/MM/yy");

                _tooltip.Show($"{hora} - {yVal:C2}", this.chart, pos.X, pos.Y - 15);
            }
        }
    }
}
