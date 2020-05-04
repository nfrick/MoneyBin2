using SuperGrid;

namespace MoneyBin2 {
    partial class frmLeitor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeitor));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelConta = new System.Windows.Forms.Label();
            this.checkBoxAfetaSaldo = new System.Windows.Forms.CheckBox();
            this.bsExtrato = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxAddToDB = new System.Windows.Forms.CheckBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxSubcategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.labelHistorico = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.dgvExtrato = new SuperGrid.SuperDGV();
            this.addToDBDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLerArquivo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.cmsPopMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExtrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1395, 573);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1395, 600);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelConta);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxAfetaSaldo);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxAddToDB);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxSubcategoria);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxGrupo);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLast);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNext);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPrevious);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFirst);
            this.splitContainer1.Panel1.Controls.Add(this.labelHistorico);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDescricao);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvExtrato);
            this.splitContainer1.Size = new System.Drawing.Size(1395, 573);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelConta
            // 
            this.labelConta.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelConta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelConta.Location = new System.Drawing.Point(20, 22);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(198, 35);
            this.labelConta.TabIndex = 15;
            this.labelConta.Text = "Conta";
            this.labelConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConta.DoubleClick += new System.EventHandler(this.labelConta_DoubleClick);
            // 
            // checkBoxAfetaSaldo
            // 
            this.checkBoxAfetaSaldo.AutoSize = true;
            this.checkBoxAfetaSaldo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsExtrato, "AfetaSaldo", true));
            this.checkBoxAfetaSaldo.Location = new System.Drawing.Point(24, 195);
            this.checkBoxAfetaSaldo.Name = "checkBoxAfetaSaldo";
            this.checkBoxAfetaSaldo.Size = new System.Drawing.Size(135, 32);
            this.checkBoxAfetaSaldo.TabIndex = 2;
            this.checkBoxAfetaSaldo.Text = "Afeta Saldo";
            this.checkBoxAfetaSaldo.UseVisualStyleBackColor = true;
            // 
            // bsExtrato
            // 
            this.bsExtrato.DataSource = typeof(DataLayer.BalanceItem);
            // 
            // checkBoxAddToDB
            // 
            this.checkBoxAddToDB.AutoSize = true;
            this.checkBoxAddToDB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsExtrato, "AddToDB", true));
            this.checkBoxAddToDB.Location = new System.Drawing.Point(25, 162);
            this.checkBoxAddToDB.Name = "checkBoxAddToDB";
            this.checkBoxAddToDB.Size = new System.Drawing.Size(175, 32);
            this.checkBoxAddToDB.TabIndex = 1;
            this.checkBoxAddToDB.Text = "Adicionar ao DB";
            this.checkBoxAddToDB.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExtrato, "Categoria", true));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(24, 329);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(193, 36);
            this.comboBoxCategoria.TabIndex = 6;
            this.comboBoxCategoria.Validated += new System.EventHandler(this.comboBoxCategoria_Validated);
            // 
            // comboBoxSubcategoria
            // 
            this.comboBoxSubcategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExtrato, "SubCategoria", true));
            this.comboBoxSubcategoria.FormattingEnabled = true;
            this.comboBoxSubcategoria.Location = new System.Drawing.Point(24, 397);
            this.comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            this.comboBoxSubcategoria.Size = new System.Drawing.Size(193, 36);
            this.comboBoxSubcategoria.TabIndex = 8;
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExtrato, "Grupo", true));
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.Location = new System.Drawing.Point(24, 259);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(193, 36);
            this.comboBoxGrupo.TabIndex = 4;
            this.comboBoxGrupo.Validated += new System.EventHandler(this.comboBoxGrupo_Validated);
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonLast.ForeColor = System.Drawing.Color.Black;
            this.buttonLast.Location = new System.Drawing.Point(170, 513);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(40, 34);
            this.buttonLast.TabIndex = 14;
            this.buttonLast.Text = ":";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.navigationButtons_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonNext.ForeColor = System.Drawing.Color.Black;
            this.buttonNext.Location = new System.Drawing.Point(124, 513);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(40, 34);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "4";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.navigationButtons_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious.Location = new System.Drawing.Point(78, 514);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(40, 34);
            this.buttonPrevious.TabIndex = 12;
            this.buttonPrevious.Text = "3";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.navigationButtons_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonFirst.ForeColor = System.Drawing.Color.Black;
            this.buttonFirst.Location = new System.Drawing.Point(32, 514);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(40, 34);
            this.buttonFirst.TabIndex = 11;
            this.buttonFirst.Text = "9";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.navigationButtons_Click);
            // 
            // labelHistorico
            // 
            this.labelHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelHistorico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExtrato, "Historico", true));
            this.labelHistorico.ForeColor = System.Drawing.Color.Lime;
            this.labelHistorico.Location = new System.Drawing.Point(20, 67);
            this.labelHistorico.Name = "labelHistorico";
            this.labelHistorico.Size = new System.Drawing.Size(198, 80);
            this.labelHistorico.TabIndex = 0;
            this.labelHistorico.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "SubCategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExtrato, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(24, 465);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(197, 34);
            this.textBoxDescricao.TabIndex = 10;
            // 
            // dgvExtrato
            // 
            this.dgvExtrato.AllowUserToAddRows = false;
            this.dgvExtrato.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExtrato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExtrato.AutoGenerateColumns = false;
            this.dgvExtrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExtrato.BackgroundColor = System.Drawing.Color.Black;
            this.dgvExtrato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExtrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addToDBDataGridViewCheckBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.Documento,
            this.valorDataGridViewTextBoxColumn,
            this.afetaSaldoDataGridViewCheckBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subCategoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvExtrato.DataSource = this.bsExtrato;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExtrato.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExtrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExtrato.EnableHeadersVisualStyles = false;
            this.dgvExtrato.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvExtrato.Location = new System.Drawing.Point(0, 0);
            this.dgvExtrato.MultiSelect = false;
            this.dgvExtrato.Name = "dgvExtrato";
            this.dgvExtrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExtrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExtrato.RowHeadersWidth = 20;
            this.dgvExtrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtrato.Size = new System.Drawing.Size(1125, 573);
            this.dgvExtrato.TabIndex = 0;
            this.dgvExtrato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvExtrato_CellFormatting);
            this.dgvExtrato.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvExtrato_EditingControlShowing);
            this.dgvExtrato.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtrato_RowEnter);
            this.dgvExtrato.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvExtrato_RowStateChanged);
            this.dgvExtrato.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvExtrato_MouseClick);
            // 
            // addToDBDataGridViewCheckBoxColumn
            // 
            this.addToDBDataGridViewCheckBoxColumn.DataPropertyName = "AddToDB";
            this.addToDBDataGridViewCheckBoxColumn.HeaderText = "Add";
            this.addToDBDataGridViewCheckBoxColumn.Name = "addToDBDataGridViewCheckBoxColumn";
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
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSalvar,
            this.toolStripButtonLerArquivo,
            this.toolStripButtonRemove});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonSalvar
            // 
            this.toolStripButtonSalvar.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButtonSalvar.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonSalvar.Image = global::MoneyBin2.Properties.Resources.OK;
            this.toolStripButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            this.toolStripButtonSalvar.Size = new System.Drawing.Size(73, 24);
            this.toolStripButtonSalvar.Text = "Salvar";
            this.toolStripButtonSalvar.Click += new System.EventHandler(this.toolStripButtonSalvar_Click);
            // 
            // toolStripButtonLerArquivo
            // 
            this.toolStripButtonLerArquivo.BackColor = System.Drawing.Color.Wheat;
            this.toolStripButtonLerArquivo.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonLerArquivo.Image = global::MoneyBin2.Properties.Resources.Oculos;
            this.toolStripButtonLerArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLerArquivo.Name = "toolStripButtonLerArquivo";
            this.toolStripButtonLerArquivo.Size = new System.Drawing.Size(109, 24);
            this.toolStripButtonLerArquivo.Text = "Ler Arquivo";
            this.toolStripButtonLerArquivo.Click += new System.EventHandler(this.toolStripButtonLerArquivo_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.BackColor = System.Drawing.Color.SeaShell;
            this.toolStripButtonRemove.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonRemove.Image = global::MoneyBin2.Properties.Resources.Delete;
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(92, 24);
            this.toolStripButtonRemove.Text = "Remover";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // cmsPopMenu
            // 
            this.cmsPopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPopMenu.Name = "cmsPopMenu";
            this.cmsPopMenu.ShowImageMargin = false;
            this.cmsPopMenu.Size = new System.Drawing.Size(36, 4);
            this.cmsPopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPopMenu_ItemClicked);
            // 
            // frmLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1395, 600);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLeitor_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsExtrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bsExtrato;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private SuperDGV dgvExtrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHistorico;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxSubcategoria;
        private System.Windows.Forms.CheckBox checkBoxAfetaSaldo;
        private System.Windows.Forms.CheckBox checkBoxAddToDB;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLerArquivo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ContextMenuStrip cmsPopMenu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToDBDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}