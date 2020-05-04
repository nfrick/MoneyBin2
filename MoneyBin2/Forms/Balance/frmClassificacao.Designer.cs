namespace MoneyBin2 {
    partial class frmClassificacao {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassificacao));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.dgvClassificacao = new SuperGrid.SuperDGV();
            this.grupoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClassificacao = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubcategoriaAtual = new System.Windows.Forms.TextBox();
            this.textBoxCategoriaAtual = new System.Windows.Forms.TextBox();
            this.textBoxGrupoAtual = new System.Windows.Forms.TextBox();
            this.buttonReclassSelected = new System.Windows.Forms.Button();
            this.textBoxSubCategoriaNova = new System.Windows.Forms.TextBox();
            this.buttonReclassAll = new System.Windows.Forms.Button();
            this.textBoxCategoriaNova = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.textBoxGrupoNovo = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelSubCategoria = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDesfazer = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dgvBalance = new SuperGrid.SuperDGV();
            this.bsBalance = new System.Windows.Forms.BindingSource(this.components);
            this.ContaCorrente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsPopMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contaCorrenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClassificacao)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainerMain);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1251, 579);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1251, 604);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTop);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMain.Size = new System.Drawing.Size(1251, 579);
            this.splitContainerMain.SplitterDistance = 228;
            this.splitContainerMain.SplitterWidth = 7;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.dgvClassificacao);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.panel2);
            this.splitContainerTop.Size = new System.Drawing.Size(1251, 228);
            this.splitContainerTop.SplitterDistance = 589;
            this.splitContainerTop.TabIndex = 1;
            // 
            // dgvClassificacao
            // 
            this.dgvClassificacao.AllowUserToAddRows = false;
            this.dgvClassificacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClassificacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassificacao.AutoGenerateColumns = false;
            this.dgvClassificacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClassificacao.BackgroundColor = System.Drawing.Color.Black;
            this.dgvClassificacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassificacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupoDataGridViewTextBoxColumn1,
            this.categoriaDataGridViewTextBoxColumn1,
            this.subCategoriaDataGridViewTextBoxColumn1});
            this.dgvClassificacao.DataSource = this.bsClassificacao;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassificacao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClassificacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassificacao.EnableHeadersVisualStyles = false;
            this.dgvClassificacao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClassificacao.Location = new System.Drawing.Point(0, 0);
            this.dgvClassificacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClassificacao.Name = "dgvClassificacao";
            this.dgvClassificacao.ReadOnly = true;
            this.dgvClassificacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassificacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClassificacao.RowHeadersWidth = 20;
            this.dgvClassificacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassificacao.Size = new System.Drawing.Size(589, 228);
            this.dgvClassificacao.TabIndex = 0;
            this.dgvClassificacao.SelectionChanged += new System.EventHandler(this.dgvClassificacao_SelectionChanged);
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
            // 
            // subCategoriaDataGridViewTextBoxColumn1
            // 
            this.subCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn1.HeaderText = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn1.Name = "subCategoriaDataGridViewTextBoxColumn1";
            this.subCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsClassificacao
            // 
            this.bsClassificacao.DataSource = typeof(DataLayer.Classificacao);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxSubcategoriaAtual);
            this.panel2.Controls.Add(this.textBoxCategoriaAtual);
            this.panel2.Controls.Add(this.textBoxGrupoAtual);
            this.panel2.Controls.Add(this.buttonReclassSelected);
            this.panel2.Controls.Add(this.textBoxSubCategoriaNova);
            this.panel2.Controls.Add(this.buttonReclassAll);
            this.panel2.Controls.Add(this.textBoxCategoriaNova);
            this.panel2.Controls.Add(this.labelGrupo);
            this.panel2.Controls.Add(this.textBoxGrupoNovo);
            this.panel2.Controls.Add(this.labelCategoria);
            this.panel2.Controls.Add(this.labelSubCategoria);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 228);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "RECLASSIFICAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSubcategoriaAtual
            // 
            this.textBoxSubcategoriaAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSubcategoriaAtual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClassificacao, "SubCategoria", true));
            this.textBoxSubcategoriaAtual.ForeColor = System.Drawing.Color.White;
            this.textBoxSubcategoriaAtual.Location = new System.Drawing.Point(45, 137);
            this.textBoxSubcategoriaAtual.Name = "textBoxSubcategoriaAtual";
            this.textBoxSubcategoriaAtual.ReadOnly = true;
            this.textBoxSubcategoriaAtual.Size = new System.Drawing.Size(255, 34);
            this.textBoxSubcategoriaAtual.TabIndex = 10;
            this.textBoxSubcategoriaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCategoriaAtual
            // 
            this.textBoxCategoriaAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCategoriaAtual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClassificacao, "Categoria", true));
            this.textBoxCategoriaAtual.ForeColor = System.Drawing.Color.White;
            this.textBoxCategoriaAtual.Location = new System.Drawing.Point(45, 97);
            this.textBoxCategoriaAtual.Name = "textBoxCategoriaAtual";
            this.textBoxCategoriaAtual.ReadOnly = true;
            this.textBoxCategoriaAtual.Size = new System.Drawing.Size(255, 34);
            this.textBoxCategoriaAtual.TabIndex = 9;
            this.textBoxCategoriaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGrupoAtual
            // 
            this.textBoxGrupoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxGrupoAtual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClassificacao, "Grupo", true));
            this.textBoxGrupoAtual.ForeColor = System.Drawing.Color.White;
            this.textBoxGrupoAtual.Location = new System.Drawing.Point(45, 55);
            this.textBoxGrupoAtual.Name = "textBoxGrupoAtual";
            this.textBoxGrupoAtual.ReadOnly = true;
            this.textBoxGrupoAtual.Size = new System.Drawing.Size(255, 34);
            this.textBoxGrupoAtual.TabIndex = 8;
            this.textBoxGrupoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonReclassSelected
            // 
            this.buttonReclassSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonReclassSelected.ForeColor = System.Drawing.Color.White;
            this.buttonReclassSelected.Location = new System.Drawing.Point(465, 179);
            this.buttonReclassSelected.Name = "buttonReclassSelected";
            this.buttonReclassSelected.Size = new System.Drawing.Size(138, 37);
            this.buttonReclassSelected.TabIndex = 7;
            this.buttonReclassSelected.Text = "Selecionados";
            this.buttonReclassSelected.UseVisualStyleBackColor = false;
            this.buttonReclassSelected.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSubCategoriaNova
            // 
            this.textBoxSubCategoriaNova.Location = new System.Drawing.Point(345, 137);
            this.textBoxSubCategoriaNova.Name = "textBoxSubCategoriaNova";
            this.textBoxSubCategoriaNova.Size = new System.Drawing.Size(255, 34);
            this.textBoxSubCategoriaNova.TabIndex = 5;
            // 
            // buttonReclassAll
            // 
            this.buttonReclassAll.BackColor = System.Drawing.Color.Navy;
            this.buttonReclassAll.ForeColor = System.Drawing.Color.White;
            this.buttonReclassAll.Location = new System.Drawing.Point(321, 178);
            this.buttonReclassAll.Name = "buttonReclassAll";
            this.buttonReclassAll.Size = new System.Drawing.Size(138, 37);
            this.buttonReclassAll.TabIndex = 6;
            this.buttonReclassAll.Text = "Todos";
            this.buttonReclassAll.UseVisualStyleBackColor = false;
            this.buttonReclassAll.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxCategoriaNova
            // 
            this.textBoxCategoriaNova.Location = new System.Drawing.Point(345, 97);
            this.textBoxCategoriaNova.Name = "textBoxCategoriaNova";
            this.textBoxCategoriaNova.Size = new System.Drawing.Size(255, 34);
            this.textBoxCategoriaNova.TabIndex = 4;
            // 
            // labelGrupo
            // 
            this.labelGrupo.BackColor = System.Drawing.Color.Transparent;
            this.labelGrupo.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelGrupo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelGrupo.Location = new System.Drawing.Point(304, 55);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(35, 34);
            this.labelGrupo.TabIndex = 0;
            this.labelGrupo.Text = "è";
            this.labelGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxGrupoNovo
            // 
            this.textBoxGrupoNovo.Location = new System.Drawing.Point(345, 55);
            this.textBoxGrupoNovo.Name = "textBoxGrupoNovo";
            this.textBoxGrupoNovo.Size = new System.Drawing.Size(255, 34);
            this.textBoxGrupoNovo.TabIndex = 3;
            // 
            // labelCategoria
            // 
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCategoria.Location = new System.Drawing.Point(304, 97);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(35, 34);
            this.labelCategoria.TabIndex = 1;
            this.labelCategoria.Text = "è";
            this.labelCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubCategoria
            // 
            this.labelSubCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelSubCategoria.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelSubCategoria.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSubCategoria.Location = new System.Drawing.Point(304, 137);
            this.labelSubCategoria.Name = "labelSubCategoria";
            this.labelSubCategoria.Size = new System.Drawing.Size(35, 34);
            this.labelSubCategoria.TabIndex = 2;
            this.labelSubCategoria.Text = "è";
            this.labelSubCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBalance, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.48352F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.51649F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 344);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDesfazer);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 46);
            this.panel1.TabIndex = 0;
            // 
            // buttonDesfazer
            // 
            this.buttonDesfazer.BackColor = System.Drawing.Color.Khaki;
            this.buttonDesfazer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesfazer.Image = global::MoneyBin2.Properties.Resources.Revert_24;
            this.buttonDesfazer.Location = new System.Drawing.Point(195, -4);
            this.buttonDesfazer.Name = "buttonDesfazer";
            this.buttonDesfazer.Size = new System.Drawing.Size(193, 42);
            this.buttonDesfazer.TabIndex = 1;
            this.buttonDesfazer.Text = "Desfazer";
            this.buttonDesfazer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDesfazer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDesfazer.UseVisualStyleBackColor = false;
            this.buttonDesfazer.Visible = false;
            this.buttonDesfazer.Click += new System.EventHandler(this.buttonDesfazer_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::MoneyBin2.Properties.Resources.OK_24;
            this.buttonSave.Location = new System.Drawing.Point(-4, -4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(193, 42);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.contaCorrenteDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn1,
            this.historicoDataGridViewTextBoxColumn1,
            this.valorDataGridViewTextBoxColumn1,
            this.afetaSaldoDataGridViewCheckBoxColumn1,
            this.grupoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subCategoriaDataGridViewTextBoxColumn,
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
            this.dgvBalance.Location = new System.Drawing.Point(3, 59);
            this.dgvBalance.Name = "dgvBalance";
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
            this.dgvBalance.RowTemplate.Height = 24;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(1245, 282);
            this.dgvBalance.TabIndex = 1;
            this.dgvBalance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBalance_EditingControlShowing);
            this.dgvBalance.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalance_RowValidated);
            this.dgvBalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBalance_MouseClick);
            // 
            // bsBalance
            // 
            this.bsBalance.DataSource = typeof(DataLayer.BalanceItem);
            // 
            // ContaCorrente
            // 
            this.ContaCorrente.DataPropertyName = "ContaCorrente";
            this.ContaCorrente.HeaderText = "Conta";
            this.ContaCorrente.Name = "ContaCorrente";
            this.ContaCorrente.ReadOnly = true;
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
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // cmsPopMenu
            // 
            this.cmsPopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPopMenu.Name = "cmsPopMenu";
            this.cmsPopMenu.Size = new System.Drawing.Size(61, 4);
            this.cmsPopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPopMenu_ItemClicked);
            // 
            // contaCorrenteDataGridViewTextBoxColumn
            // 
            this.contaCorrenteDataGridViewTextBoxColumn.DataPropertyName = "ContaCorrente";
            this.contaCorrenteDataGridViewTextBoxColumn.HeaderText = "Conta";
            this.contaCorrenteDataGridViewTextBoxColumn.Name = "contaCorrenteDataGridViewTextBoxColumn";
            this.contaCorrenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            // 
            // historicoDataGridViewTextBoxColumn1
            // 
            this.historicoDataGridViewTextBoxColumn1.DataPropertyName = "Historico";
            this.historicoDataGridViewTextBoxColumn1.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn1.Name = "historicoDataGridViewTextBoxColumn1";
            // 
            // valorDataGridViewTextBoxColumn1
            // 
            this.valorDataGridViewTextBoxColumn1.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn1.Name = "valorDataGridViewTextBoxColumn1";
            // 
            // afetaSaldoDataGridViewCheckBoxColumn1
            // 
            this.afetaSaldoDataGridViewCheckBoxColumn1.DataPropertyName = "AfetaSaldo";
            this.afetaSaldoDataGridViewCheckBoxColumn1.HeaderText = "Afeta Saldo";
            this.afetaSaldoDataGridViewCheckBoxColumn1.Name = "afetaSaldoDataGridViewCheckBoxColumn1";
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
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            // 
            // frmClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 604);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClassificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClassificacao_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClassificacao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private SuperGrid.SuperDGV dgvClassificacao;
        private System.Windows.Forms.BindingSource bsClassificacao;
        private SuperGrid.SuperDGV dgvBalance;
        private System.Windows.Forms.BindingSource bsBalance;
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.TextBox textBoxGrupoNovo;
        private System.Windows.Forms.TextBox textBoxCategoriaNova;
        private System.Windows.Forms.TextBox textBoxSubCategoriaNova;
        private System.Windows.Forms.Button buttonReclassAll;
        private System.Windows.Forms.Button buttonReclassSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSubcategoriaAtual;
        private System.Windows.Forms.TextBox textBoxCategoriaAtual;
        private System.Windows.Forms.TextBox textBoxGrupoAtual;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelSubCategoria;
        private System.Windows.Forms.ContextMenuStrip cmsPopMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaCorrente;
        private System.Windows.Forms.Button buttonDesfazer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaCorrenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
    }
}