using ChartLibrary;
using DataLayer;
using IEnumerableExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyBin2 {
    public partial class frmSerieHistorica : Form {

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();
        private Point? _prevPosition = null;
        private readonly ToolTip _tooltip = new ToolTip();

        private readonly ToolStripDateTimePicker _dtpickerInicio = new ToolStripDateTimePicker("dtpInicio", DateTime.Today.AddYears(-2),
            DateTimePickerFormat.Short);

        private readonly ToolStripDateTimePicker _dtpickerTermino = new ToolStripDateTimePicker("dtpTermino", DateTime.Today,
            DateTimePickerFormat.Short);

        private Ativo AtivoAtual => (Ativo)bsAtivos.Current;

        private IEnumerable<Ativo> AtivosSelecionados =>
            dgvAtivos.SelectedRows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow).OrderBy(r => r.Index)
                .Select(r => (Ativo)r.DataBoundItem);

        public frmSerieHistorica() {
            InitializeComponent();

            dgvAtivos.SetFont(12);

            dgvSelecionados.FormatColumn("Código", null, 55);
            dgvSelecionados.FormatColumn("Min", dgvSelecionados.StyleCurrency, 45);
            dgvSelecionados.FormatColumn("Max", dgvSelecionados.StyleCurrency, 45);
            dgvSelecionados.FormatColumn("Var", dgvSelecionados.StylePercent1, 55);
            
            dgvSerieHistorica.SetFont(12);
            dgvSerieHistorica.FormatColumn("Data", dgvSerieHistorica.StyleDateLong, 100);
            dgvSerieHistorica.FormatColumn("Abertura", dgvSerieHistorica.StyleCurrency, 70);
            dgvSerieHistorica.FormatColumn("Máximo", dgvSerieHistorica.StyleCurrency, 70);
            dgvSerieHistorica.FormatColumn("Mínimo", dgvSerieHistorica.StyleCurrency, 70);
            dgvSerieHistorica.FormatColumn("Médio", dgvSerieHistorica.StyleCurrency, 70);
            dgvSerieHistorica.FormatColumn("Último", dgvSerieHistorica.StyleCurrency, 70);
            dgvSerieHistorica.FormatColumn("M.O. Compra", dgvSerieHistorica.StyleCurrency, 70);
            dgvSerieHistorica.FormatColumn("M.O. Venda", dgvSerieHistorica.StyleCurrency, 70);

            for (var col = 0; col < dgvSerieHistorica.Columns.Count; col++) {
                dgvSelectedDates.Columns[col].HeaderText = dgvSerieHistorica.Columns[col].HeaderText;
                dgvSelectedDates.Columns[col].DataPropertyName = dgvSerieHistorica.Columns[col].DataPropertyName;
            }
            dgvSelectedDates.CopyFormatFrom(dgvSerieHistorica);
            dgvSelectedDates.Columns[0].Visible = true;

            _ctx.Configuration.LazyLoadingEnabled = false;
            _ctx.Ativos.Load();
            bsAtivos.DataSource = _ctx.Ativos.Local.ToBindingList();

            _dtpickerInicio.Width = _dtpickerTermino.Width = 100;
            toolStripMenu.Items.Insert(3, _dtpickerInicio);
            toolStripMenu.Items.Add(_dtpickerTermino);
            SetDates();
            _dtpickerInicio.ValueChanged += toolStripDates_SelectedIndexChanged;
            _dtpickerTermino.ValueChanged += toolStripDates_SelectedIndexChanged;
        }

        private void SetDates() {
            var dates = _ctx.spSerieHistoricaDateRange().First();
            monthCalendarDatas.MinDate = dates.MinDate;
            monthCalendarDatas.MaxDate = dates.MaxDate;

            _dtpickerTermino.MaxDate = dates.MaxDate;
            _dtpickerTermino.MinDate = dates.MinDate;
            _dtpickerTermino.Value = dates.MaxDate;

            _dtpickerInicio.MaxDate = dates.MaxDate;
            _dtpickerInicio.MinDate = dates.MinDate;
            _dtpickerInicio.Value = dates.MaxDate.AddYears(-2);
        }

        private void frmSerieHistorica_Load(object sender, EventArgs e) {
            // 55 = vertical scroll bar width
            Width = 55 + dgvAtivos.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) +
                    55 + dgvSerieHistorica.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
        }

        private void toolStripDates_SelectedIndexChanged(object sender, EventArgs e) {
            ResetCotacoes();
        }

        private void RefreshSerieHistorica() {
            if (AtivoAtual.Cotacoes == null) {
                AtivoAtual.Cotacoes = _ctx.spSerieHistorica(
                AtivoAtual.Codigo, _dtpickerInicio.Value, _dtpickerTermino.Value).ToObservableListSource();
            }
            bsSerieHistorica.DataSource = AtivoAtual.Cotacoes.ToBindingList();
            bsSelecionados.DataSource = AtivosSelecionados.ToList();
            dgvSerieHistorica.Columns[0].Visible = false;
            GerarGrafico(this.chart);
        }

        private void dgvAtivos_SelectionChanged(object sender, EventArgs e) {
            if (AtivoAtual == null) {
                return;
            }
            RefreshSerieHistorica();
            PopulateSelectedDates();
        }

        private void ResetCotacoes() {
            foreach (var ativo in dgvAtivos.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow).Select(r => (Ativo)r.DataBoundItem)
                .Where(a => a.Cotacoes != null)) {
                ativo.ResetCotacoes();
            }
            RefreshSerieHistorica();
        }

        #region LER ARQUIVOS

        private void toolStripButtonLerSerie_Click(object sender, EventArgs e) {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = @"Arquivos|*.zip;*.txt";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            bgWorker.RunWorkerAsync(ofd.FileNames);
            if (MessageBox.Show(@"Deletar arquivo(s)?", @"Ler Série", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes) {
                foreach (var arquivo in ofd.FileNames) {
                    File.Delete(arquivo);
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            var arquivos = e.Argument as string[];
            var linhas = new List<string>();
            foreach (var arquivo in arquivos) {
                //bgWorker.ReportProgress(1, arquivo);
                if (arquivo.EndsWith(".txt", StringComparison.InvariantCultureIgnoreCase)) {
                    linhas.AddRange(File.ReadLines(arquivo));
                }
                else {
                    using (var archive = ZipFile.OpenRead(arquivo)) {
                        foreach (var entry in archive.Entries) {
                            linhas.AddRange(ReadAllLinesFromZippedTextFile(entry));
                        }
                    }
                }
            }
            LerLinhasParaDatabase(linhas);
        }

        private void LerLinhasParaDatabase(IEnumerable<string> linhas) {
            var ativos = _ctx.Ativos;
            var serie = from linha in linhas.Where(l => l.StartsWith("01") && l.Substring(24, 3) == "010")
                        join ativo in ativos
                        on linha.Substring(12, 12).Trim() equals ativo.Codigo
                        select new SerieHistorica(linha);

            _ctx.SeriesHistoricas.AddRange(serie.Except(_ctx.SeriesHistoricas));
            if (_ctx.AddedAny) {
                _ctx.SaveChanges();
            }
        }

        //https://stackoverflow.com/questions/23989677/file-readalllines-or-stream-reader
        private static IEnumerable<string> ReadAllLinesFromZippedTextFile(ZipArchiveEntry entry) {
            var lines = new List<string>();
            using (var stream = entry.Open()) {
                using (var sr = new StreamReader(stream)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        lines.Add(line);
                    }
                }
            }
            return lines;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            SetDates();
            ResetCotacoes();
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            //var arquivo = Path.GetFileName((string)e.UserState);
        }

        #endregion

        #region CHART
        private void GerarGrafico(SuperChart ch) {
            if (dgvAtivos.SelectedRows.Count == 0) {
                chart.Visible = false;
                return;
            }

            ch.Series.Clear();
            foreach (var ativo in AtivosSelecionados.Where(a => a.TemCotacoes)) {
                var serie = ch.Series.Add(ativo.Codigo);
                serie.ChartType = SeriesChartType.Line;
                foreach (var s in ativo.Cotacoes) {
                    serie.Points.AddXY(s.Data, s.PrecoUltimo);
                }
            }
            ch.SetYAxisMinMax(0.05);
            ch.Visible = true;
        }

        private void chart_DoubleClick(object sender, EventArgs e) {
            var frm = new frmGrafico();
            GerarGrafico(frm.chart);
            frm.Show();
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
                var dia = (new DateTime(1899, 12, 31)).AddDays(xVal).ToString("dd/MM/yy");

                _tooltip.Show($"{dia} - {yVal:C2}", this.chart, pos.X, pos.Y - 15);
            }
        }
        #endregion

        #region DATAS SELECIONADAS ----------------

        private void monthCalendarDatas_MouseDown(object sender, MouseEventArgs e) {
            MonthCalendar.HitTestInfo info = monthCalendarDatas.HitTest(e.Location);
            if (info.HitArea != MonthCalendar.HitArea.Date) {
                return;
            }

            if (monthCalendarDatas.BoldedDates.Contains(info.Time)) {
                monthCalendarDatas.RemoveBoldedDate(info.Time);
            }
            else {
                monthCalendarDatas.AddBoldedDate(info.Time);
            }

            monthCalendarDatas.UpdateBoldedDates();
            PopulateSelectedDates();
        }

        private void buttonDatesClear_Click(object sender, EventArgs e) {
            monthCalendarDatas.RemoveAllBoldedDates();
            PopulateSelectedDates();
        }

        private void PopulateSelectedDates() {
            var datas = monthCalendarDatas.BoldedDates.ToArray();
            if (!datas.Any()) {
                bsSelectedDates.DataSource = null;
                return;
            }

            bsSelectedDates.DataSource = AtivosSelecionados
                .SelectMany(a => a.Cotacoes.Where(c => datas.Contains(c.Data)))
                .ToObservableListSource();
        }

        #endregion DATAS SELECIONADAS ----------------
    }
}
