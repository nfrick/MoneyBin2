using DataLayer;
using MoneyBin2;
using NFExtensions;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
//using Settings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NF_sfDataGridExtensions;

// How to use async and parallel - https://www.youtube.com/watch?v=ZTKGRJy5P2M&t=1474s

namespace Analisador {
    public partial class frmAnalisador : Form {
        private Carteira CarteiraAtual => (Carteira)bsCarteiras.Current;

        Point? _prevPosition = null;
        readonly ToolTip _tooltip = new ToolTip();

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private readonly ToolStripDateTimePicker _dtpInicio =
            new ToolStripDateTimePicker("dtpInicio", DateTime.Today.AddMonths(-1), DateTimePickerFormat.Short) {
                Width = 100
            };

        private readonly ToolStripDateTimePicker _dtpTermino =
            new ToolStripDateTimePicker("dtpTermino", DateTime.Today, DateTimePickerFormat.Short) { Width = 100 };

        private readonly ToolStripCheckbox _chkData =
            new ToolStripCheckbox("_chkData", "Usar datas", false);


        #region FORM
        public frmAnalisador() {
            InitializeComponent();

            dgvCotacoes.AutoGenerateColumns = false;

            _ctx.Carteiras.Load();

            bsCarteiras.DataSource = _ctx.Carteiras.Local.OrderBy(c => c.Nome).ToList();

            var cbx = toolStripComboBoxCarteira.ComboBox;
            cbx.DataSource = bsCarteiras;
            cbx.DisplayMember = "Nome";
            cbx.ValueMember = "ID";
            cbx.SelectedIndex = 0;

            #region DATAS

            toolStripMenu.Items.Add(new ToolStripSeparator());
            var lblInicio = new ToolStripLabel("Início:") { DoubleClickEnabled = true };
            lblInicio.DoubleClick += (sender, args) => {
                _dtpInicio.Value = DateTime.Today.AddDays(-30);
                if (_dtpInicio.Value > _dtpTermino.Value) {
                    _dtpTermino.Value = _dtpInicio.Value.AddMonths(3);
                }
            };
            toolStripMenu.Items.Add(lblInicio);
            toolStripMenu.Items.Add(_dtpInicio);
            _dtpInicio.ValueChanged += DateTimePickerChanged;

            var lblTermino = new ToolStripLabel("Término:") { DoubleClickEnabled = true };
            lblTermino.DoubleClick += (sender, args) => {
                _dtpTermino.Value = DateTime.Today;
                if (_dtpInicio.Value > _dtpTermino.Value) {
                    _dtpInicio.Value = _dtpTermino.Value.AddMonths(-3);
                }
            };
            toolStripMenu.Items.Add(lblTermino);
            toolStripMenu.Items.Add(_dtpTermino);
            _dtpTermino.ValueChanged += DateTimePickerChanged;

            toolStripMenu.Items.Add(_chkData);
            _chkData.CheckedChanged += DateTimePickerChanged;

            #endregion DATAS
        }

        private void frmAnalisador_Load(object sender, EventArgs e) {
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
            dgvCotacoes.Columns.Add(new GridDateTimeColumn { MappingName = "Data", Format = "dd/MM/yy", Width = 80, HeaderText = "Início", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridDateTimeColumn { MappingName = "FirstTradeDate", Format = "dd/MM/yy", Width = 80, HeaderText = "First Trade", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "FirstOpen", Width = 80, Format = "N2", HeaderText = "First Open", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridDateTimeColumn { MappingName = "LastTradeDate", Format = "dd/MM/yy", Width = 80, HeaderText = "Last Trade", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "LastClose", Width = 80, Format = "N2", HeaderText = "Last Close", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "RangeChangePercent", Width = 80, Format = "P2", HeaderText = "Change %", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "RangeLow", Width = 80, Format = "N2", HeaderText = "Lowest", AllowHeaderTextWrapping = true });
            dgvCotacoes.Columns.Add(new GridNumericColumn { MappingName = "RangeHigh", Width = 80, Format = "N2", HeaderText = "Highest", AllowHeaderTextWrapping = true });


            dgvCotacoes.ColumnHeaderContextMenu = new ContextMenuStrip();
            dgvCotacoes.ColumnHeaderContextMenu.Items.Add("Colunas", null, ColumnPicker_Click);

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor =
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DimGray;

            chart1.Series.Clear();
            CarregarDados();
        }

        private void frmAnalisador_Resize(object sender, EventArgs e) {
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

        #endregion FORM

        #region DADOS E ATUALIZAÇÕES

        private void DateTimePickerChanged(object sender, EventArgs e) {
            CarteiraAtual.Filtrar(_dtpInicio.Value, _dtpTermino.Value, _chkData.Checked);
            dgvCotacoes.Refresh();

            if (chart1.Series.Count == 0) {
                return;
            }

            var ativosNoGrafico = chart1.Series.Select(s => s.Name);
            var ativos = _ctx.Carteiras.Local
                .SelectMany(c => c.Ativos)
                .Where(a => ativosNoGrafico.Contains(a.Codigo)).ToList();

            AtualizarGrafico(ativos, ativos);
        }

        private void CarregarDados() {
            if (CarteiraAtual == null) {
                return;
            }

            //CarteiraAtual.ObterCotacoes();
            //CarteiraAtual.Filtrar(_dtpInicio.Value, _dtpTermino.Value, _chkData.Checked);

            dgvCotacoes.DataSource = CarteiraAtual.Ativos;

            toolStripStatusLabelAtualizadoEm.Text = $@"Atualizado em: {DateTime.Now}";

            //tableLayoutPanel1.RowStyles[0].Height = (float)dgvCotacoes.TableControl.RowHeights.TotalExtent + 30;
            Width = (int)dgvCotacoes.TableControl.ColumnWidths.TotalExtent + 25;
        }

        private void AtualizarGrafico(IEnumerable<CarteiraAtivo> added, IEnumerable<CarteiraAtivo> removed) {
            if (removed != null) {
                foreach (var ativo in removed) {
                    var serie = chart1.Series.FindByName(ativo.Codigo);
                    if (serie != null) {
                        chart1.Series.Remove(serie);
                    }
                }
            }

            foreach (var ativo in added.Where(a => a.Status == Cotacao.LoadStatus.Loaded)) {
                var serie = chart1.Series.FindByName(ativo.Codigo);
                if (serie == null) {
                    AtualizarGraficoAcao(ativo);
                }
            }

            chart1.SetYAxisMinMax();
        }

        private void AtualizarGraficoAcao(CarteiraAtivo ativo) {
            var serie = chart1.Series.Add(ativo.Codigo);
            serie.ChartType = SeriesChartType.Line;
            foreach (var trade in ativo.CotacoesFiltradas) {
                serie.Points.AddXY(trade.Key, trade.Value.close);
            }
            chart1.Refresh();
        }

        #endregion DADOS E ATUALIZAÇÕES

        #region TOOLBAR
        private void toolStripButtonLoad_Click(object sender, EventArgs e) {
            var ativos = dgvCotacoes.SelectedItems.Cast<CarteiraAtivo>()
                .Where(a => a.Status != Cotacao.LoadStatus.Loaded).ToArray();
            foreach (var ativo in ativos) {
                ativo.ObterCotacoes(_dtpInicio.Value, _dtpTermino.Value, _chkData.Checked);
            }
            if (ativos.Length == 1) {
                AtualizarGrafico(ativos, null);
            }
        }

        private void toolStripComboBoxConta_SelectedIndexChanged(object sender, EventArgs e) {
            bsCarteiras.Position = toolStripComboBoxCarteira.SelectedIndex;
            CarregarDados();
        }

        #endregion TOOLBAR

        #region DATAGRIDVIEW

        private void sfDataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            AtualizarGrafico(e.AddedItems.Cast<CarteiraAtivo>(), e.RemovedItems.Cast<CarteiraAtivo>());
        }

        private void sfDataGrid1_QueryRowStyle(object sender, QueryRowStyleEventArgs e) {
            sfDataGridExtensions.QueryRowStyle(sender, e);
        }

        private void sfDataGrid1_QueryCellStyle(object sender, QueryCellStyleEventArgs e) {
            var item = (CarteiraAtivo)e.DataRow.RowData;
            if (e.Column.MappingName == "Codigo") {
                switch (item.Status) {
                    case Cotacao.LoadStatus.Error:
                        e.Style.TextColor = Color.OrangeRed;
                        break;
                    case Cotacao.LoadStatus.Loaded:
                        e.Style.TextColor = Color.White;
                        break;
                    case Cotacao.LoadStatus.NotLoaded:
                        e.Style.TextColor = Color.Gray;
                        break;
                    case Cotacao.LoadStatus.NoData:
                        e.Style.TextColor = Color.Yellow;
                        break;
                }
            }
            else
            if (e.Column.MappingName == "RangeChangePercent") {

                if (item.RangeChangePercent < 0) {
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

        private void toolStripButtonClearSeries_Click(object sender, EventArgs e) {
            chart1.Series.Clear();
        }
    }
}