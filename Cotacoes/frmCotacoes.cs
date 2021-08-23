using DataLayer;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NF_sfDataGridExtensions;

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

            dgvCotacoes.AutoGenerateColumns = false;

            _ctx.Contas
                .Include("Acoes.Entradas.Associacoes")
                .Include("Acoes.Saidas.Associacoes").Load();

            bsContas.DataSource = _ctx.Contas.Local
                .Where(c => c.PossuiAcoes)
                .OrderBy(c => c.Apelido).ToList();

            var cbx = toolStripComboBoxConta.ComboBox;
            cbx.DataSource = bsContas;
            cbx.DisplayMember = "Apelido";
            cbx.ValueMember = "ID";
            cbx.SelectedIndex = 0;
        }

        private void frmCotacoes_Load(object sender, EventArgs e) {
            sfDataGridExtensions.FormatGrid(dgvCotacoes);

            dgvCotacoes.AllowDraggingColumns = true;
            dgvCotacoes.FrozenColumnCount = 1;
            dgvCotacoes.AddNewRowPosition = RowPosition.None;
            dgvCotacoes.ShowRowHeader = false;
            dgvCotacoes.SearchController.AllowFiltering = true;
            dgvCotacoes.AllowDraggingColumns = false;
            dgvCotacoes.AllowFiltering = false;

            sfDataGridExtensions.SelectionColumn(dgvCotacoes);
            dgvCotacoes.Columns.Add(new GridTextColumn { MappingName = "Codigo", HeaderText = "Ativo", Width = 80, AllowGrouping = true, Visible = true });
            dgvCotacoes.Columns.Add(new GridDateTimeColumn { MappingName = "LastTradeDate", Format = "dd/MM/yy", Width = 80, HeaderText = "Last Trade", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "PreviousClose", Width = 70, Format = "N2", HeaderText = "Last Trade", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "LastOpen", Width = 70, Format = "N2", HeaderText = "Last Open", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "LastClose", Width = 70, Format = "N2", HeaderText = "Last Close", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridTextColumn { MappingName = "Trend", Width = 30, HeaderText = "" });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "DayLow", Width = 70, Format = "N2", HeaderText = "Day Low", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "DayHigh", Width = 70, Format = "N2", HeaderText = "Day High", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "RangeLow", Width = 70, Format = "N2", HeaderText = "Range Low", AllowHeaderTextWrapping = true, Visible = false });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "RangeHigh", Width = 70, Format = "N2", HeaderText = "Range High", AllowHeaderTextWrapping = true, Visible = false });

            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "Qtd", Width = 70, Format = "N0" });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "Patrimonio", Width = 130, Format = "N2", HeaderText = "Patrimônio" });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "ValorMedioCompra", Width = 70, Format = "N2", HeaderText = "VM Nominal", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "ValorMedioCompraReal", Width = 70, Format = "N2", HeaderText = "VM Real", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "LucroReal", Width = 120, Format = "N2", HeaderText = "Lucro Real", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "QtdVendavel", Width = 70, Format = "N0", HeaderText = "Qtd Vendavel", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "LucroImediato", Width = 120, Format = "N2", HeaderText = "Lucro Imediato", AllowHeaderTextWrapping = true });

            dgvCotacoes.Style.TableSummaryRowStyle.HorizontalAlignment = HorizontalAlignment.Right;

            var tableSummaryRow1 = new GridTableSummaryRow
            {
                Name = "TableSummary",
                ShowSummaryInRow = false,
                Position = VerticalPosition.Bottom
            };

            var summaryColumnPatrimonio = new GridSummaryColumn
            {
                Name = "TotalPatrimonio",
                SummaryType = SummaryType.DoubleAggregate,
                Format = "{Sum:N2}",
                MappingName = "Patrimonio"
            };

            var summaryColumnLucroReal = new GridSummaryColumn
            {
                Name = "TotalLucroReal",
                SummaryType = SummaryType.DoubleAggregate,
                Format = "{Sum:N2}",
                MappingName = "LucroReal"
            };

            var summaryColumnLucroImediato = new GridSummaryColumn
            {
                Name = "TotalLucroImediato",
                SummaryType = SummaryType.DoubleAggregate,
                Format = "{Sum:N2}",
                MappingName = "LucroImediato"
            };

            tableSummaryRow1.SummaryColumns.Add(summaryColumnPatrimonio);
            tableSummaryRow1.SummaryColumns.Add(summaryColumnLucroReal);
            tableSummaryRow1.SummaryColumns.Add(summaryColumnLucroImediato);

            this.dgvCotacoes.TableSummaryRows.Add(tableSummaryRow1);
            dgvCotacoes.SummaryCalculationMode = CalculationMode.OnDemandCaptionSummary;

            dgvCotacoes.ColumnHeaderContextMenu = new ContextMenuStrip();
            dgvCotacoes.ColumnHeaderContextMenu.Items.Add("Colunas", null, ColumnPicker_Click);

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor =
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DimGray;

            chart1.Series.Clear();
            CarregarDados();
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

        #region DADOS E ATUALIZAÇÕES

        private void CarregarDados() {
            if (ContaAtual == null) {
                return;
            }

            foreach (var acao in ContaAtual.AcoesNaoZerado) {
                acao.ObterCotacoes();
                acao.FiltrarCotacoes();
            }

            dgvCotacoes.DataSource = ContaAtual.AcoesNaoZerado;

            toolStripStatusLabelAtualizadoEm.Text = $@"Atualizado em: {DateTime.Now}";

            tableLayoutPanel1.RowStyles[0].Height = (float)dgvCotacoes.TableControl.RowHeights.TotalExtent + 30;
            Width = (int)dgvCotacoes.TableControl.ColumnWidths.TotalExtent + 25;
        }

        private void AtualizarGrafico(IEnumerable<ContaAtivo> added, IEnumerable<ContaAtivo> removed) {

            foreach (var ativo in removed) {
                var serie = chart1.Series.FindByName(ativo.Codigo);
                if (serie != null) {
                    chart1.Series.Remove(serie);
                }
            }
            foreach (var ativo in added) {
                if (!ativo.HasTrades) {
                    ativo.ObterCotacoes();
                    ativo.FiltrarCotacoes();
                }

                var serie = chart1.Series.FindByName(ativo.Codigo);
                if (serie == null) {
                    AtualizarGraficoAcao(ativo);
                }
            }

            chart1.SetYAxisMinMax();
        }

        private void AtualizarGraficoAcao(ContaAtivo ativo) {
            var serie = chart1.Series.Add(ativo.Codigo);
            serie.ChartType = SeriesChartType.Line;
            foreach (var trade in ativo.Cotacoes) {
                serie.Points.AddXY(trade.Key, trade.Value.close);
            }
        }
        #endregion DADOS E ATUALIZAÇÕES

        #region TOOLBAR
        private void toolStripComboBoxConta_SelectedIndexChanged(object sender, EventArgs e) {
            bsContas.Position = toolStripComboBoxConta.SelectedIndex;
            CarregarDados();
        }
        #endregion TOOLBAR

        #region DATAGRIDVIEW

        private void sfDataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            AtualizarGrafico(e.AddedItems.Cast<ContaAtivo>(), e.RemovedItems.Cast<ContaAtivo>());
        }

        private void sfDataGrid1_QueryRowStyle(object sender, QueryRowStyleEventArgs e) {
            sfDataGridExtensions.QueryRowStyle(sender, e);
        }

        private void sfDataGrid1_QueryCellStyle(object sender, QueryCellStyleEventArgs e) {
            if (e.Column.MappingName == "Trend")
            {
                e.Style.Font.Facename = "WingDings";
                switch (e.DisplayText)
                {
                    case ContaAtivo.TrendDown:
                        e.Style.TextColor = Color.OrangeRed;
                        break;
                    case ContaAtivo.TrendNeutral:
                        e.Style.TextColor = Color.BurlyWood;
                        break;
                    case ContaAtivo.TrendNone:
                        e.Style.TextColor = Color.DarkGray;
                        break;
                }
            }
            else if (e.Column.MappingName == "LucroReal") {
                var item = (ContaAtivo)e.DataRow.RowData;
                if (item.LucroReal < 0) {
                    e.Style.TextColor = Color.OrangeRed;
                }
            }
        }

        private void ColumnPicker_Click(object sender, EventArgs e) {
            sfDataGridExtensions.ColumnPicker(dgvCotacoes);
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
                var hora = (new DateTime(1899, 12, 31)).AddDays(xVal).ToString("dd-MM-yy");

                _tooltip.Show($"{hora} - {yVal:C2}", this.chart1, pos.X, pos.Y - 15);
            }
        }
    }
}