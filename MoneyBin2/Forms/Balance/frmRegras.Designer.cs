using SuperGrid;

namespace MoneyBin2 {
    partial class frmRegras {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegras));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvRegras = new SuperGrid.SuperDGV();
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToDatabaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ocorrenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRegras = new System.Windows.Forms.BindingSource(this.components);
            this.tlpBalance = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBalance = new SuperGrid.SuperDGV();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBalance = new System.Windows.Forms.BindingSource(this.components);
            this.panelEdit = new System.Windows.Forms.Panel();
            this.labelTesteResultado = new System.Windows.Forms.Label();
            this.labelTesteFechar = new System.Windows.Forms.Label();
            this.toolStripRegras = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNovaRegra = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTestar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOcorrencias = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegras)).BeginInit();
            this.tlpBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.toolStripRegras.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1308, 508);
            this.toolStripContainer.Size = new System.Drawing.Size(1308, 585);
            this.toolStripContainer.TopToolStripPanelVisible = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.dgvRegras);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer.Panel2.Controls.Add(this.tlpBalance);
            this.splitContainer.Size = new System.Drawing.Size(1308, 508);
            this.splitContainer.SplitterDistance = 247;
            this.splitContainer.TabIndex = 2;
            // 
            // dgvRegras
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRegras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegras.AutoGenerateColumns = false;
            this.dgvRegras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegras.BackgroundColor = System.Drawing.Color.Black;
            this.dgvRegras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textoDataGridViewTextBoxColumn,
            this.afetaSaldoDataGridViewCheckBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subCategoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.addToDatabaseDataGridViewCheckBoxColumn,
            this.ocorrenciasDataGridViewTextBoxColumn});
            this.dgvRegras.DataSource = this.bsRegras;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegras.EnableHeadersVisualStyles = false;
            this.dgvRegras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRegras.Location = new System.Drawing.Point(0, 0);
            this.dgvRegras.Name = "dgvRegras";
            this.dgvRegras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegras.RowHeadersWidth = 20;
            this.dgvRegras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegras.Size = new System.Drawing.Size(1308, 247);
            this.dgvRegras.TabIndex = 2;
            this.dgvRegras.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegras_RowValidated);
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "Texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "Regra";
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            // 
            // afetaSaldoDataGridViewCheckBoxColumn
            // 
            this.afetaSaldoDataGridViewCheckBoxColumn.DataPropertyName = "AfetaSaldo";
            this.afetaSaldoDataGridViewCheckBoxColumn.HeaderText = "Afeta Saldo";
            this.afetaSaldoDataGridViewCheckBoxColumn.Name = "afetaSaldoDataGridViewCheckBoxColumn";
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // subCategoriaDataGridViewTextBoxColumn
            // 
            this.subCategoriaDataGridViewTextBoxColumn.DataPropertyName = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn.HeaderText = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn.Name = "subCategoriaDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // addToDatabaseDataGridViewCheckBoxColumn
            // 
            this.addToDatabaseDataGridViewCheckBoxColumn.DataPropertyName = "AddToDatabase";
            this.addToDatabaseDataGridViewCheckBoxColumn.HeaderText = "Add";
            this.addToDatabaseDataGridViewCheckBoxColumn.Name = "addToDatabaseDataGridViewCheckBoxColumn";
            // 
            // ocorrenciasDataGridViewTextBoxColumn
            // 
            this.ocorrenciasDataGridViewTextBoxColumn.DataPropertyName = "Ocorrencias";
            this.ocorrenciasDataGridViewTextBoxColumn.HeaderText = "Ocorr.";
            this.ocorrenciasDataGridViewTextBoxColumn.Name = "ocorrenciasDataGridViewTextBoxColumn";
            // 
            // bsRegras
            // 
            this.bsRegras.DataSource = typeof(DataLayer.Regra);
            // 
            // tlpBalance
            // 
            this.tlpBalance.ColumnCount = 1;
            this.tlpBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBalance.Controls.Add(this.dgvBalance, 0, 1);
            this.tlpBalance.Controls.Add(this.panelEdit, 0, 0);
            this.tlpBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBalance.Location = new System.Drawing.Point(0, 0);
            this.tlpBalance.Name = "tlpBalance";
            this.tlpBalance.RowCount = 2;
            this.tlpBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.40892F));
            this.tlpBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.59108F));
            this.tlpBalance.Size = new System.Drawing.Size(1308, 257);
            this.tlpBalance.TabIndex = 1;
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBalance.AutoGenerateColumns = false;
            this.dgvBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBalance.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.afetaSaldoDataGridViewCheckBoxColumn1,
            this.grupoDataGridViewTextBoxColumn1,
            this.categoriaDataGridViewTextBoxColumn1,
            this.subCategoriaDataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn1});
            this.dgvBalance.DataSource = this.bsBalance;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalance.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalance.EnableHeadersVisualStyles = false;
            this.dgvBalance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBalance.Location = new System.Drawing.Point(3, 29);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.ReadOnly = true;
            this.dgvBalance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBalance.RowHeadersWidth = 20;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(1302, 225);
            this.dgvBalance.TabIndex = 0;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            this.historicoDataGridViewTextBoxColumn.DataPropertyName = "Historico";
            this.historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            this.historicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.historicoDataGridViewTextBoxColumn.Width = 250;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // afetaSaldoDataGridViewCheckBoxColumn1
            // 
            this.afetaSaldoDataGridViewCheckBoxColumn1.DataPropertyName = "AfetaSaldo";
            this.afetaSaldoDataGridViewCheckBoxColumn1.HeaderText = "Afeta Saldo";
            this.afetaSaldoDataGridViewCheckBoxColumn1.Name = "afetaSaldoDataGridViewCheckBoxColumn1";
            this.afetaSaldoDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.afetaSaldoDataGridViewCheckBoxColumn1.Width = 50;
            // 
            // grupoDataGridViewTextBoxColumn1
            // 
            this.grupoDataGridViewTextBoxColumn1.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn1.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn1.Name = "grupoDataGridViewTextBoxColumn1";
            this.grupoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn1
            // 
            this.categoriaDataGridViewTextBoxColumn1.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn1.Name = "categoriaDataGridViewTextBoxColumn1";
            this.categoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn1.Width = 200;
            // 
            // subCategoriaDataGridViewTextBoxColumn1
            // 
            this.subCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn1.HeaderText = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn1.Name = "subCategoriaDataGridViewTextBoxColumn1";
            this.subCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subCategoriaDataGridViewTextBoxColumn1.Width = 200;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn1.Width = 200;
            // 
            // bsBalance
            // 
            this.bsBalance.AllowNew = false;
            this.bsBalance.DataSource = typeof(DataLayer.BalanceItem);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.labelTesteResultado);
            this.panelEdit.Controls.Add(this.labelTesteFechar);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdit.Location = new System.Drawing.Point(3, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1302, 20);
            this.panelEdit.TabIndex = 1;
            // 
            // labelTesteResultado
            // 
            this.labelTesteResultado.AutoSize = true;
            this.labelTesteResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTesteResultado.Location = new System.Drawing.Point(-5, -5);
            this.labelTesteResultado.Name = "labelTesteResultado";
            this.labelTesteResultado.Size = new System.Drawing.Size(119, 28);
            this.labelTesteResultado.TabIndex = 1;
            this.labelTesteResultado.Text = "Ocorrências:";
            // 
            // labelTesteFechar
            // 
            this.labelTesteFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTesteFechar.AutoSize = true;
            this.labelTesteFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTesteFechar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTesteFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTesteFechar.Location = new System.Drawing.Point(1274, 0);
            this.labelTesteFechar.Name = "labelTesteFechar";
            this.labelTesteFechar.Size = new System.Drawing.Size(21, 23);
            this.labelTesteFechar.TabIndex = 0;
            this.labelTesteFechar.Text = "X";
            this.labelTesteFechar.Click += new System.EventHandler(this.labelTesteFechar_Click);
            // 
            // toolStripRegras
            // 
            this.toolStripRegras.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripRegras.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripRegras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNovaRegra,
            this.toolStripButtonTestar,
            this.toolStripButtonOcorrencias});
            this.toolStripRegras.Location = new System.Drawing.Point(6, 0);
            this.toolStripRegras.Name = "toolStripRegras";
            this.toolStripRegras.Size = new System.Drawing.Size(246, 27);
            this.toolStripRegras.TabIndex = 0;
            // 
            // toolStripButtonNovaRegra
            // 
            this.toolStripButtonNovaRegra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNovaRegra.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNovaRegra.Image")));
            this.toolStripButtonNovaRegra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNovaRegra.Name = "toolStripButtonNovaRegra";
            this.toolStripButtonNovaRegra.Size = new System.Drawing.Size(91, 24);
            this.toolStripButtonNovaRegra.Text = "Nova Regra";
            this.toolStripButtonNovaRegra.Click += new System.EventHandler(this.toolStripButtonNovaRegra_Click);
            // 
            // toolStripButtonTestar
            // 
            this.toolStripButtonTestar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripButtonTestar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTestar.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonTestar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTestar.Image")));
            this.toolStripButtonTestar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTestar.Name = "toolStripButtonTestar";
            this.toolStripButtonTestar.Size = new System.Drawing.Size(52, 24);
            this.toolStripButtonTestar.Text = "Testar";
            this.toolStripButtonTestar.Click += new System.EventHandler(this.toolStripButtonTestar_Click);
            // 
            // toolStripButtonOcorrencias
            // 
            this.toolStripButtonOcorrencias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOcorrencias.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonOcorrencias.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOcorrencias.Image")));
            this.toolStripButtonOcorrencias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOcorrencias.Name = "toolStripButtonOcorrencias";
            this.toolStripButtonOcorrencias.Size = new System.Drawing.Size(91, 24);
            this.toolStripButtonOcorrencias.Text = "Ocorrências";
            this.toolStripButtonOcorrencias.Click += new System.EventHandler(this.toolStripButtonOcorrencias_Click);
            // 
            // frmRegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1308, 585);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegras";
            this.Text = "Regras";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegras)).EndInit();
            this.tlpBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.toolStripRegras.ResumeLayout(false);
            this.toolStripRegras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperDGV dgvBalance;
        private System.Windows.Forms.BindingSource bsBalance;

        private System.Windows.Forms.ToolStrip toolStripRegras;
        private System.Windows.Forms.ToolStripButton toolStripButtonNovaRegra;
        private System.Windows.Forms.ToolStripButton toolStripButtonTestar;

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOcorrencias;
        private System.Windows.Forms.TableLayoutPanel tlpBalance;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label labelTesteResultado;
        private System.Windows.Forms.Label labelTesteFechar;
        private SuperDGV dgvRegras;
        private System.Windows.Forms.BindingSource bsRegras;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToDatabaseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocorrenciasDataGridViewTextBoxColumn;
    }
}