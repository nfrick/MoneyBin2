using DataLayer;
using IEnumerableExtensions;
using SuperPrompt;
//using Settings;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Cotacoes.Properties;
using Tulpep.NotificationWindow;

// How to use async and parallel - https://www.youtube.com/watch?v=ZTKGRJy5P2M&t=1474s

namespace Cotacoes {
    public partial class frmCotacoes : Form {
        private System.Threading.Timer _updateTimer;

        private Conta ContaAtual => (Conta)bsContas.Current;

        Point? _prevPosition = null;
        readonly ToolTip _tooltip = new ToolTip();

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private ObservableListSource<ContaAtivo> _acoes = new ObservableListSource<ContaAtivo>();

        #region FORM
        public frmCotacoes() {
            InitializeComponent();

            _ctx.Contas
                .Include("Acoes.Entradas.Associacoes")
                .Include("Acoes.Saidas.Associacoes").Load();

            bsContas.DataSource = _ctx.Contas.Local
                .Where(c => c.PossuiAcoes)
                .OrderBy(c => c.Apelido).ToObservableListSource();

            var cbx = toolStripComboBoxConta.ComboBox;
            cbx.DataSource = bsContas;
            cbx.DisplayMember = "Apelido";
            cbx.ValueMember = "ID";
            cbx.SelectedIndex = 0;
        }

        private void frmCotacoes_Load(object sender, EventArgs e) {
            dgvCotacoes.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            dgvCotacoes.FormatColumn("Ativo", null, 100);
            dgvCotacoes.FormatColumn("Last Trade Date", dgvCotacoes.StyleDayAndTime, 100);
            dgvCotacoes.FormatColumn("S", dgvCotacoes.StyleTrend, 20);
            dgvCotacoes.FormatColumn("Change %", dgvCotacoes.StylePercent, 65);

            dgvCotacoes.FormatColumn("Qtd", dgvCotacoes.StyleInteger, 65);
            dgvCotacoes.FormatColumn("Qtd Vendável", dgvCotacoes.StyleInteger, 65);

            dgvCotacoes.FormatColumn("Last Trade", dgvCotacoes.StyleCurrency, 80);
            dgvCotacoes.FormatColumn("Previous Close", dgvCotacoes.StyleCurrency, 80);
            dgvCotacoes.FormatColumn("Open", dgvCotacoes.StyleCurrency, 80);
            dgvCotacoes.FormatColumn("Day Low", dgvCotacoes.StyleCurrency, 80);
            dgvCotacoes.FormatColumn("Day High", dgvCotacoes.StyleCurrency, 80);
            dgvCotacoes.FormatColumn("VM Compra", dgvCotacoes.StyleCurrency, 80);

            dgvCotacoes.FormatColumn("Patrimônio", dgvCotacoes.StyleCurrency, 90);
            dgvCotacoes.FormatColumn("Lucro Real", dgvCotacoes.StyleCurrency, 90);
            dgvCotacoes.FormatColumn("Lucro Imediato", dgvCotacoes.StyleCurrency, 85);

            dgvTotal.FormatAsTotal(dgvCotacoes);

            foreach (ToolStripItem i in toolStripDropDownButtonFrequencia.DropDownItems) {
                i.Click += FrequenciaButtonsClick;
            }

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor =
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = dgvCotacoes.GridColor;
            Width = 25 + dgvCotacoes.GridVisibleWidth();
        }

        private void frmCotacoes_Resize(object sender, EventArgs e) {
            if (WindowState != FormWindowState.Minimized) {
                return;
            }

            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
            ShowInTaskbar = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e) {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void frmCotacoes_FormClosing(object sender, FormClosingEventArgs e) {
            //SettingsManager.SetSetting("Conta", toolStripComboBoxConta.SelectedIndex.ToString());
        }
        #endregion FORM

        #region TIMER ----------------------------
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (DesignMode) {
                return;
            }

            var agora = DateTime.Now;
            if (toolStripMenuItemDesligado.Checked ||
                     agora.Hour < 10 || agora.Hour > 17 ||
                     agora.DayOfWeek == DayOfWeek.Saturday ||
                     agora.DayOfWeek == DayOfWeek.Sunday) {
                DefinirFrequencia(toolStripMenuItemDesligado);
                CarregarDados(true);
            }
            else {
                DefinirFrequencia(toolStripMenuItem5minutos);
            }
        }

        private async void AtualizarDados(object state) {
            // do your stuff here
            try {
                var ativos = (ObservableListSource<ContaAtivo>)bsCotacoes.DataSource;
                var progress = CreateProgress();
                toolStripStatusLabelDuracao.Text = await AtualizarCotacoes(ativos, progress);
                ResultadoAtualizacao = true;
            }
            catch (Exception) {
                ResultadoAtualizacao = false;
            }
            // do not access control directly, use BeginInvoke!
        }

        public int Erros { get; set; }

        private bool ResultadoAtualizacao {
            set {
                if (InvokeRequired) {
                    BeginInvoke(new Action(() =>
                    {
                        CarregarDados();
                        if (!value) {
                            Erros++;
                        }
                        else if (DateTime.Now.Hour >= 17 && DateTime.Now.Minute >= 12) {
                            DefinirFrequencia(toolStripMenuItemDesligado);
                        }
                    }));
                }
            }
        }

        /// <summary>
        /// Acerta a frequencia para o valor do botão indicado
        /// </summary>
        /// <param name="botao">Botão a ser selecionado</param>
        private void DefinirFrequencia(ToolStripMenuItem botao = null) {
            var frequencias = toolStripDropDownButtonFrequencia
                .DropDownItems.OfType<ToolStripMenuItem>().ToList();

            if (botao == null) {
                foreach (var frequencia in frequencias) {
                    if (frequencia.Checked) {
                        botao = frequencia;
                    }
                }
            }

            foreach (var frequencia in frequencias) {
                frequencia.Checked = (frequencia == botao);
            }

            AjustarTimer(Convert.ToInt32(botao.Tag));
            toolStripDropDownButtonFrequencia.Text = $@"Frequência: {botao.Text}";
            if ((string)botao.Tag == "0") {
                AtualizarGrafico();
            }
        }

        private void AjustarTimer(int period) {
            period = period == 0 ? Timeout.Infinite : period * 60 * 1000;
            var dueTime = period == Timeout.Infinite ? Timeout.Infinite : 0;
            if (_updateTimer == null) {
                _updateTimer = new System.Threading.Timer(AtualizarDados, null, dueTime, period);
            }
            else {
                _updateTimer.Change(dueTime, period);
            }
        }

        #endregion TIMER -------------------------

        #region DADOS E ATUALIZAÇÕES
        private void CarregarDados(bool recarregarListaDeAtivos = false) {
            if (ContaAtual == null) {
                return;
            }

            if (recarregarListaDeAtivos) {
                _acoes.Remove(a => a.ContaId > 0);
                _acoes.AddRange(ContaAtual.AcoesNaoZerado);
                bsCotacoes.DataSource = _acoes;
            }
            else {
                dgvCotacoes.Refresh();
            }
            dgvTotal.Refresh();

            AtualizarGrafico();

            toolStripStatusLabelAtualizadoEm.Text = $@"Atualizado em: {DateTime.Now}";
            toolStripStatusLabelErros.Text = $@"Erros: {Erros}";

            // Alerta de venda
            if (_acoes.Any(a => a.AlertaVenda >= 1.00m && a.AlertaVenda < 1.004m)) {
                var x = _acoes.Where(a => a.AlertaVenda > 1.00m && a.AlertaVenda < 1.004m)
                    .Select(a => $"{a.Codigo} - Compra: {a.ValorMedioCompra:c2} - Atual: {a.LastTrade:c2}");
                var popup = new PopupNotifier
                {
                    Size = new Size(450, 75 * x.Count()),
                    Delay = 10000,
                    Image = Resources.alert_icon,
                    HeaderColor = Color.Red,
                    TitleColor = Color.Red,
                    TitleFont = new Font("Segoe UI Semibold", 18),
                    TitlePadding = new Padding(10),
                    TitleText = "Alerta de Venda de Ações",
                    ContentFont = new Font("Segoe UI", 14),
                    ContentText = x.Aggregate((current, next) => current + "\n" + next),
                    ContentPadding = new Padding(10)
                };
                popup.Popup();
            }

            // Resize if number of Ativos changes
            var oldHeight = (int)tableLayoutPanel1.RowStyles[0].Height;
            var newHeight = dgvCotacoes.ColumnHeadersHeight +
                (dgvCotacoes.RowTemplate.Height + 2) *
                Math.Min(10, bsCotacoes.Count);

            if (oldHeight == newHeight) {
                return;
            }

            tableLayoutPanel1.RowStyles[0].Height = newHeight;
            Height = Height - oldHeight + newHeight;
        }

        private void AtualizarGrafico() {
            chart1.Series.Clear();

            double chartMax = 0;
            double chartMin = 1000;

            var rows = dgvCotacoes.SelectedRows.Count == 0
                ? dgvCotacoes.SelectedCells.Cast<DataGridViewCell>()
                    .Select(r => r.OwningRow)
                : dgvCotacoes.SelectedRows.Cast<DataGridViewRow>();

            foreach (var row in rows) {
                AtualizarGraficoAcao(row, ref chartMin, ref chartMax);
            }

            chart1.SetYAxisMinMax(chartMin, chartMax);
            //            dgvTotal.Refresh();
        }

        private void AtualizarGraficoAcao(DataGridViewRow row, ref double chartMin, ref double chartMax) {
            var codigo = row.Cells[0].Value.ToString();
            var ativo = _acoes.First(a => a.Codigo == codigo);
            if (!ativo.HasTrades) {
                ativo.AtualizarCotacao();
            }

            var serie = chart1.Series.Add(codigo);
            serie.ChartType = SeriesChartType.Line;
            foreach (var trade in ativo.Cotacoes) {
                serie.Points.AddXY(trade.Key, trade.Value.close);
            }
            chartMax = Math.Max(chartMax, ativo.DayHigh);
            chartMin = Math.Min(chartMin, ativo.DayLow);
        }

        private void FrequenciaButtonsClick(object sender, EventArgs e) {
            DefinirFrequencia((ToolStripMenuItem)sender);
        }
        #endregion DADOS E ATUALIZAÇÕES

        #region TOOLBAR
        private void toolStripButtonAdicionarAcao_Click(object sender, EventArgs e) {
            var acoesEmExibicao = _acoes.Select(a => a.Codigo);
            var lista = _ctx.Ativos.Select(a => a.Codigo).Except(acoesEmExibicao).ToArray();
            if (PromptDialog.InputListMulti(Text, "Adicionar Ações", lista, out var codigos) ==
                DialogResult.Cancel) {
                return;
            }

            _acoes.AddRange(codigos.Select(c => new ContaAtivo() { ContaId = 0, Codigo = c }));
            CarregarDados(true);
        }

        private void toolStripComboBoxConta_SelectedIndexChanged(object sender, EventArgs e) {
            bsContas.Position = toolStripComboBoxConta.SelectedIndex;
            CarregarDados(true);
        }

        private async void toolStripButtonAtualizar_Click(object sender, EventArgs e) {
            var botao = (ToolStripButton)sender;
            botao.Enabled = false;

            var ativosAAtualizar = botao.Name.Contains("Todos") ?
                _acoes :
                dgvCotacoes.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => (ContaAtivo)r.DataBoundItem).ToObservableListSource();

            var progress = CreateProgress();
            toolStripStatusLabelDuracao.Text = await AtualizarCotacoes(ativosAAtualizar, progress);
            CarregarDados();
            toolStripProgressBar1.Value = 0;
            botao.Enabled = true;
        }

        private Progress<ProgressUpdate> CreateProgress() {
            var progress = new Progress<ProgressUpdate>();
            progress.ProgressChanged += ReportProgress;
            return progress;
        }

        private void ReportProgress(object sender, ProgressUpdate e) {
            toolStripProgressBar1.Value = e.PercentageDone;
        }

        public static async Task<string> AtualizarCotacoes(ObservableListSource<ContaAtivo> ativos,
            IProgress<ProgressUpdate> progress) {
            var prog = new ProgressUpdate(ativos.Count());
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await Task.Run(() =>
            {
                Parallel.ForEach<ContaAtivo>(ativos, (ativo) =>
                {
                    ativo.AtualizarCotacao();
                    prog.Increment();
                    progress.Report(prog);
                });
            });

            watch.Stop();
            return $"Duração: {watch.ElapsedMilliseconds / 1000:F2} s";
        }

        private void toolStripButtonLerExtrato_Click(object sender, EventArgs e) {
            OFD.DefaultExt = "csv";
            OFD.Filter = @"CSV iles|*.csv";
            OFD.Multiselect = true;
            if (OFD.ShowDialog() != DialogResult.OK) {
                return;
            }

            foreach (var fileName in OFD.FileNames) {
                //FinanceData.AtualizarPorExtrato(fileName);
            }
        }

        #endregion TOOLBAR

        #region DATAGRIDVIEW
        private void dgvCotacoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            try {
                var row = dgvCotacoes.Rows[e.RowIndex];
                var cell = row.Cells[e.ColumnIndex];

                var acao = (ContaAtivo)row.DataBoundItem;

                var forecolor = e.RowIndex % 2 == 0 ? dgvCotacoes.DefaultCellStyle.ForeColor : dgvCotacoes.AlternatingRowsDefaultCellStyle.ForeColor;
                switch (e.ColumnIndex) {
                    case 4: // Trend
                        var s = cell.Value as string;
                        cell.Style.ForeColor = s == ContaAtivo.TrendUp ? Color.LightGreen : (s == ContaAtivo.TrendDown ? Color.OrangeRed : Color.Gray);
                        break;
                    case 5 when acao.AlertaVenda < 1.004m: // Last Trade
                        cell.Style.ForeColor = Color.White;
                        cell.Style.BackColor = acao.AlertaVenda < 1.002m ? Color.Tomato : Color.Goldenrod;
                        break;
                    case 6: // Change %
                    case 12: // Lucro Real
                        cell.Style.ForeColor = Convert.ToDecimal(cell.Value) < 0 ? Color.OrangeRed : forecolor;
                        break;
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }

        private void dgvCotacoes_SelectionChanged(object sender, EventArgs e) {
            AtualizarGrafico();
        }

        private void dgvTotal_SelectionChanged(object sender, EventArgs e) {
            dgvTotal.ClearSelection();
        }

        private void dgvCotacoes_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e) {
            dgvTotal.Columns[e.Column.Index].Width = e.Column.Width;
        }

        private void dgvCotacoes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            AtualizarGrafico();
        }

        #endregion DATAGRIDVIEW

        private void chart1_MouseMove(object sender, MouseEventArgs e) {
            var pos = e.Location;
            if (_prevPosition.HasValue && pos == _prevPosition.Value) {
                return;
            }

            _tooltip.RemoveAll();
            _prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                ChartElementType.DataPoint);  //.PlottingArea);
            foreach (var result in results) {
                if (result.ChartElementType != ChartElementType.DataPoint) {
                    continue;
                }

                var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                var hora = (new DateTime(1899, 12, 31)).AddDays(xVal).ToString("hh:mm");

                _tooltip.Show($"{hora} - {yVal:C2}", this.chart1, pos.X, pos.Y - 15);
            }
        }

        private void dgvCotacoes_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }

    public class ProgressUpdate {
        public int Count { get; set; } = 0;
        public int Done { get; set; } = 0;

        public ProgressUpdate(int count) {
            Count = count;
        }

        public void Increment() {
            Done++;
        }

        public int PercentageDone => 100 * Done / Count;
    }
}
