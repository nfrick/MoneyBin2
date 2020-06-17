using ChartLibrary;
using SuperGrid;

namespace Cotacoes {
    partial class frmCotacoes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotacoes));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelAtualizadoEm = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDuracao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelErros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTotal = new SuperGrid.SuperDGV();
            this.bsContas = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new ChartLibrary.SuperChart();
            this.dgvCotacoes = new SuperGrid.SuperDGV();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTradeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousCloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changePercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patrimonioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMedioCompraReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdVendavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroImediato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCotacoes = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxConta = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonAdicionarAcao = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonFrequencia = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1minuto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5minutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10minutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15minutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDesligado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAtualizarSelecionados = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAtualizarTodos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLerExtrato = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotacoesPatrimonio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotacoesLucroReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotacoesLucroImediato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotacoes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelAtualizadoEm,
            this.toolStripStatusLabelDuracao,
            this.toolStripStatusLabelErros,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1283, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelAtualizadoEm
            // 
            this.toolStripStatusLabelAtualizadoEm.Name = "toolStripStatusLabelAtualizadoEm";
            this.toolStripStatusLabelAtualizadoEm.Size = new System.Drawing.Size(109, 20);
            this.toolStripStatusLabelAtualizadoEm.Text = "Atualizado em:";
            // 
            // toolStripStatusLabelDuracao
            // 
            this.toolStripStatusLabelDuracao.Name = "toolStripStatusLabelDuracao";
            this.toolStripStatusLabelDuracao.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabelDuracao.Text = "Duração:";
            // 
            // toolStripStatusLabelErros
            // 
            this.toolStripStatusLabelErros.Name = "toolStripStatusLabelErros";
            this.toolStripStatusLabelErros.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabelErros.Text = "Erros: 0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1283, 748);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1283, 801);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTotal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvCotacoes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 748);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotal.AutoGenerateColumns = false;
            this.dgvTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTotal.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTotal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.ColumnHeadersVisible = false;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.CotacoesPatrimonio,
            this.Column11,
            this.CotacoesLucroReal,
            this.Column13,
            this.CotacoesLucroImediato});
            this.dgvTotal.DataSource = this.bsContas;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotal.EnableHeadersVisualStyles = false;
            this.dgvTotal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTotal.Location = new System.Drawing.Point(4, 304);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTotal.RowHeadersWidth = 25;
            this.dgvTotal.RowTemplate.Height = 24;
            this.dgvTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTotal.Size = new System.Drawing.Size(1275, 26);
            this.dgvTotal.TabIndex = 2;
            this.dgvTotal.SelectionChanged += new System.EventHandler(this.dgvTotal_SelectionChanged);
            // 
            // bsContas
            // 
            this.bsContas.DataSource = typeof(DataLayer.Conta);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm";
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.Format = "N2";
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 337);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1275, 407);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // dgvCotacoes
            // 
            this.dgvCotacoes.AllowUserToAddRows = false;
            this.dgvCotacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCotacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCotacoes.AutoGenerateColumns = false;
            this.dgvCotacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCotacoes.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCotacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCotacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.lastTradeDateDataGridViewTextBoxColumn,
            this.previousCloseDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.trendDataGridViewTextBoxColumn,
            this.lastTradeDataGridViewTextBoxColumn,
            this.changePercentDataGridViewTextBoxColumn,
            this.dayLowDataGridViewTextBoxColumn,
            this.dayHighDataGridViewTextBoxColumn,
            this.Qtd,
            this.patrimonioDataGridViewTextBoxColumn,
            this.ValorMedioCompraReal,
            this.LucroReal,
            this.QtdVendavel,
            this.LucroImediato});
            this.dgvCotacoes.DataSource = this.bsCotacoes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCotacoes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCotacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCotacoes.EnableHeadersVisualStyles = false;
            this.dgvCotacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCotacoes.Location = new System.Drawing.Point(4, 4);
            this.dgvCotacoes.Name = "dgvCotacoes";
            this.dgvCotacoes.ReadOnly = true;
            this.dgvCotacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCotacoes.RowHeadersWidth = 20;
            this.dgvCotacoes.RowTemplate.Height = 24;
            this.dgvCotacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCotacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCotacoes.Size = new System.Drawing.Size(1275, 293);
            this.dgvCotacoes.TabIndex = 0;
            this.dgvCotacoes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCotacoes_CellFormatting);
            this.dgvCotacoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCotacoes_CellMouseClick);
            this.dgvCotacoes.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvCotacoes_ColumnWidthChanged);
            this.dgvCotacoes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCotacoes_DataError);
            this.dgvCotacoes.SelectionChanged += new System.EventHandler(this.dgvCotacoes_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // lastTradeDateDataGridViewTextBoxColumn
            // 
            this.lastTradeDateDataGridViewTextBoxColumn.DataPropertyName = "LastTradeDate";
            this.lastTradeDateDataGridViewTextBoxColumn.HeaderText = "Last Trade Date";
            this.lastTradeDateDataGridViewTextBoxColumn.Name = "lastTradeDateDataGridViewTextBoxColumn";
            this.lastTradeDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastTradeDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // previousCloseDataGridViewTextBoxColumn
            // 
            this.previousCloseDataGridViewTextBoxColumn.DataPropertyName = "PreviousClose";
            this.previousCloseDataGridViewTextBoxColumn.HeaderText = "Previous Close";
            this.previousCloseDataGridViewTextBoxColumn.Name = "previousCloseDataGridViewTextBoxColumn";
            this.previousCloseDataGridViewTextBoxColumn.ReadOnly = true;
            this.previousCloseDataGridViewTextBoxColumn.Width = 70;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            this.openDataGridViewTextBoxColumn.HeaderText = "Open";
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            this.openDataGridViewTextBoxColumn.Width = 70;
            // 
            // trendDataGridViewTextBoxColumn
            // 
            this.trendDataGridViewTextBoxColumn.DataPropertyName = "Trend";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.trendDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.trendDataGridViewTextBoxColumn.HeaderText = "S";
            this.trendDataGridViewTextBoxColumn.Name = "trendDataGridViewTextBoxColumn";
            this.trendDataGridViewTextBoxColumn.ReadOnly = true;
            this.trendDataGridViewTextBoxColumn.Width = 5;
            // 
            // lastTradeDataGridViewTextBoxColumn
            // 
            this.lastTradeDataGridViewTextBoxColumn.DataPropertyName = "LastTrade";
            this.lastTradeDataGridViewTextBoxColumn.HeaderText = "Last Trade";
            this.lastTradeDataGridViewTextBoxColumn.Name = "lastTradeDataGridViewTextBoxColumn";
            this.lastTradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastTradeDataGridViewTextBoxColumn.Width = 70;
            // 
            // changePercentDataGridViewTextBoxColumn
            // 
            this.changePercentDataGridViewTextBoxColumn.DataPropertyName = "ChangePercent";
            this.changePercentDataGridViewTextBoxColumn.HeaderText = "Change %";
            this.changePercentDataGridViewTextBoxColumn.Name = "changePercentDataGridViewTextBoxColumn";
            this.changePercentDataGridViewTextBoxColumn.ReadOnly = true;
            this.changePercentDataGridViewTextBoxColumn.Width = 70;
            // 
            // dayLowDataGridViewTextBoxColumn
            // 
            this.dayLowDataGridViewTextBoxColumn.DataPropertyName = "DayLow";
            this.dayLowDataGridViewTextBoxColumn.HeaderText = "Day Low";
            this.dayLowDataGridViewTextBoxColumn.Name = "dayLowDataGridViewTextBoxColumn";
            this.dayLowDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayLowDataGridViewTextBoxColumn.Width = 70;
            // 
            // dayHighDataGridViewTextBoxColumn
            // 
            this.dayHighDataGridViewTextBoxColumn.DataPropertyName = "DayHigh";
            this.dayHighDataGridViewTextBoxColumn.HeaderText = "Day High";
            this.dayHighDataGridViewTextBoxColumn.Name = "dayHighDataGridViewTextBoxColumn";
            this.dayHighDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayHighDataGridViewTextBoxColumn.Width = 70;
            // 
            // Qtd
            // 
            this.Qtd.DataPropertyName = "Qtd";
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            // 
            // patrimonioDataGridViewTextBoxColumn
            // 
            this.patrimonioDataGridViewTextBoxColumn.DataPropertyName = "Patrimonio";
            this.patrimonioDataGridViewTextBoxColumn.HeaderText = "Patrimônio";
            this.patrimonioDataGridViewTextBoxColumn.Name = "patrimonioDataGridViewTextBoxColumn";
            this.patrimonioDataGridViewTextBoxColumn.ReadOnly = true;
            this.patrimonioDataGridViewTextBoxColumn.Width = 70;
            // 
            // ValorMedioCompraReal
            // 
            this.ValorMedioCompraReal.DataPropertyName = "ValorMedioCompraReal";
            this.ValorMedioCompraReal.HeaderText = "VM Compra";
            this.ValorMedioCompraReal.Name = "ValorMedioCompraReal";
            this.ValorMedioCompraReal.ReadOnly = true;
            this.ValorMedioCompraReal.Width = 70;
            // 
            // LucroReal
            // 
            this.LucroReal.DataPropertyName = "LucroReal";
            this.LucroReal.HeaderText = "Lucro Real";
            this.LucroReal.Name = "LucroReal";
            this.LucroReal.ReadOnly = true;
            this.LucroReal.Width = 70;
            // 
            // QtdVendavel
            // 
            this.QtdVendavel.DataPropertyName = "QtdVendavel";
            this.QtdVendavel.HeaderText = "Qtd Vendável";
            this.QtdVendavel.Name = "QtdVendavel";
            this.QtdVendavel.ReadOnly = true;
            this.QtdVendavel.Width = 70;
            // 
            // LucroImediato
            // 
            this.LucroImediato.DataPropertyName = "LucroImediato";
            this.LucroImediato.HeaderText = "Lucro Imediato";
            this.LucroImediato.Name = "LucroImediato";
            this.LucroImediato.ReadOnly = true;
            this.LucroImediato.Width = 70;
            // 
            // bsCotacoes
            // 
            this.bsCotacoes.AllowNew = false;
            this.bsCotacoes.DataSource = typeof(DataLayer.ContaAtivo);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBoxConta,
            this.toolStripButtonAdicionarAcao,
            this.toolStripDropDownButtonFrequencia,
            this.toolStripButtonAtualizarSelecionados,
            this.toolStripButtonAtualizarTodos,
            this.toolStripButtonLerExtrato});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 28);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 25);
            this.toolStripLabel1.Text = "Conta:";
            // 
            // toolStripComboBoxConta
            // 
            this.toolStripComboBoxConta.AutoSize = false;
            this.toolStripComboBoxConta.Name = "toolStripComboBoxConta";
            this.toolStripComboBoxConta.Size = new System.Drawing.Size(90, 28);
            this.toolStripComboBoxConta.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxConta_SelectedIndexChanged);
            // 
            // toolStripButtonAdicionarAcao
            // 
            this.toolStripButtonAdicionarAcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripButtonAdicionarAcao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdicionarAcao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdicionarAcao.Image")));
            this.toolStripButtonAdicionarAcao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdicionarAcao.Name = "toolStripButtonAdicionarAcao";
            this.toolStripButtonAdicionarAcao.Size = new System.Drawing.Size(115, 25);
            this.toolStripButtonAdicionarAcao.Text = "Adicionar Ação";
            this.toolStripButtonAdicionarAcao.Click += new System.EventHandler(this.toolStripButtonAdicionarAcao_Click);
            // 
            // toolStripDropDownButtonFrequencia
            // 
            this.toolStripDropDownButtonFrequencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripDropDownButtonFrequencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFrequencia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1minuto,
            this.toolStripMenuItem5minutos,
            this.toolStripMenuItem10minutos,
            this.toolStripMenuItem15minutos,
            this.toolStripSeparator1,
            this.toolStripMenuItemDesligado});
            this.toolStripDropDownButtonFrequencia.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFrequencia.Image")));
            this.toolStripDropDownButtonFrequencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFrequencia.Name = "toolStripDropDownButtonFrequencia";
            this.toolStripDropDownButtonFrequencia.Size = new System.Drawing.Size(167, 25);
            this.toolStripDropDownButtonFrequencia.Text = "Frequência: 5 minutos";
            this.toolStripDropDownButtonFrequencia.ToolTipText = "Frequência de atualização";
            // 
            // toolStripMenuItem1minuto
            // 
            this.toolStripMenuItem1minuto.Name = "toolStripMenuItem1minuto";
            this.toolStripMenuItem1minuto.Size = new System.Drawing.Size(157, 26);
            this.toolStripMenuItem1minuto.Tag = "1";
            this.toolStripMenuItem1minuto.Text = "1 minuto";
            // 
            // toolStripMenuItem5minutos
            // 
            this.toolStripMenuItem5minutos.Name = "toolStripMenuItem5minutos";
            this.toolStripMenuItem5minutos.Size = new System.Drawing.Size(157, 26);
            this.toolStripMenuItem5minutos.Tag = "5";
            this.toolStripMenuItem5minutos.Text = "5 minutos";
            // 
            // toolStripMenuItem10minutos
            // 
            this.toolStripMenuItem10minutos.Name = "toolStripMenuItem10minutos";
            this.toolStripMenuItem10minutos.Size = new System.Drawing.Size(157, 26);
            this.toolStripMenuItem10minutos.Tag = "10";
            this.toolStripMenuItem10minutos.Text = "10 minutos";
            // 
            // toolStripMenuItem15minutos
            // 
            this.toolStripMenuItem15minutos.Name = "toolStripMenuItem15minutos";
            this.toolStripMenuItem15minutos.Size = new System.Drawing.Size(157, 26);
            this.toolStripMenuItem15minutos.Tag = "15";
            this.toolStripMenuItem15minutos.Text = "15 minutos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripMenuItemDesligado
            // 
            this.toolStripMenuItemDesligado.Name = "toolStripMenuItemDesligado";
            this.toolStripMenuItemDesligado.Size = new System.Drawing.Size(157, 26);
            this.toolStripMenuItemDesligado.Tag = "0";
            this.toolStripMenuItemDesligado.Text = "Desligado";
            // 
            // toolStripButtonAtualizarSelecionados
            // 
            this.toolStripButtonAtualizarSelecionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripButtonAtualizarSelecionados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAtualizarSelecionados.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAtualizarSelecionados.Image")));
            this.toolStripButtonAtualizarSelecionados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAtualizarSelecionados.Name = "toolStripButtonAtualizarSelecionados";
            this.toolStripButtonAtualizarSelecionados.Size = new System.Drawing.Size(205, 25);
            this.toolStripButtonAtualizarSelecionados.Text = "Atualizar ativos selecionados";
            this.toolStripButtonAtualizarSelecionados.Click += new System.EventHandler(this.toolStripButtonAtualizar_Click);
            // 
            // toolStripButtonAtualizarTodos
            // 
            this.toolStripButtonAtualizarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripButtonAtualizarTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAtualizarTodos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAtualizarTodos.Image")));
            this.toolStripButtonAtualizarTodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAtualizarTodos.Name = "toolStripButtonAtualizarTodos";
            this.toolStripButtonAtualizarTodos.Size = new System.Drawing.Size(176, 25);
            this.toolStripButtonAtualizarTodos.Text = "Atualizar todos os ativos";
            this.toolStripButtonAtualizarTodos.Click += new System.EventHandler(this.toolStripButtonAtualizar_Click);
            // 
            // toolStripButtonLerExtrato
            // 
            this.toolStripButtonLerExtrato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLerExtrato.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLerExtrato.Image")));
            this.toolStripButtonLerExtrato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLerExtrato.Name = "toolStripButtonLerExtrato";
            this.toolStripButtonLerExtrato.Size = new System.Drawing.Size(84, 25);
            this.toolStripButtonLerExtrato.Text = "Ler Extrato";
            this.toolStripButtonLerExtrato.Visible = false;
            this.toolStripButtonLerExtrato.Click += new System.EventHandler(this.toolStripButtonLerExtrato_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Recebendo cotações de ações BOVESPA";
            this.notifyIcon1.BalloonTipTitle = "Cotações";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cotações";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ContaCorrente";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // CotacoesPatrimonio
            // 
            this.CotacoesPatrimonio.DataPropertyName = "CotacoesPatrimonio";
            this.CotacoesPatrimonio.HeaderText = "CotacoesPatrimonio";
            this.CotacoesPatrimonio.Name = "CotacoesPatrimonio";
            this.CotacoesPatrimonio.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // CotacoesLucroReal
            // 
            this.CotacoesLucroReal.DataPropertyName = "CotacoesLucroReal";
            this.CotacoesLucroReal.HeaderText = "CotacoesLucroReal";
            this.CotacoesLucroReal.Name = "CotacoesLucroReal";
            this.CotacoesLucroReal.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // CotacoesLucroImediato
            // 
            this.CotacoesLucroImediato.DataPropertyName = "CotacoesLucroImediato";
            this.CotacoesLucroImediato.HeaderText = "CotacoesLucroImediato";
            this.CotacoesLucroImediato.Name = "CotacoesLucroImediato";
            this.CotacoesLucroImediato.ReadOnly = true;
            // 
            // frmCotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 801);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCotacoes";
            this.Text = "Cotações em Tempo Real";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCotacoes_FormClosing);
            this.Load += new System.EventHandler(this.frmCotacoes_Load);
            this.Resize += new System.EventHandler(this.frmCotacoes_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotacoes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCotacoes;
        private SuperDGV dgvCotacoes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAtualizadoEm;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource bsContas;
        private SuperDGV dgvTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelErros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxConta;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFrequencia;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5minutos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1minuto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDesligado;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10minutos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15minutos;
        private System.Windows.Forms.ToolStripButton toolStripButtonAtualizarTodos;
        private System.Windows.Forms.ToolStripButton toolStripButtonAtualizarSelecionados;
        private System.Windows.Forms.ToolStripButton toolStripButtonLerExtrato;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDuracao;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private SuperChart chart1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdicionarAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTradeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousCloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changePercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn patrimonioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMedioCompraReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdVendavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroImediato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotacoesPatrimonio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotacoesLucroReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotacoesLucroImediato;
    }
}

