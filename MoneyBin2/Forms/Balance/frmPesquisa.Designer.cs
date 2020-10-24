namespace MoneyBin2 {
    partial class frmPesquisa {
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
            this.dgvPesquisa = new SuperGrid.SuperDGV();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPesquisa = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxHistorico = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.checkedListBoxCategoria = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxGrupo = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxContas = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currencyTextBoxValor2 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.radioButtonBetween = new System.Windows.Forms.RadioButton();
            this.currencyTextBoxValor1 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.radioButtonLesser = new System.Windows.Forms.RadioButton();
            this.checkBoxAfetaSaldo = new System.Windows.Forms.CheckBox();
            this.radioButtonGreater = new System.Windows.Forms.RadioButton();
            this.labelValor_e = new System.Windows.Forms.Label();
            this.radioButtonEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSentido3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSentido2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSentido1 = new System.Windows.Forms.CheckBox();
            this.comboBoxOrdem3 = new System.Windows.Forms.ComboBox();
            this.comboBoxOrdem2 = new System.Windows.Forms.ComboBox();
            this.comboBoxOrdem1 = new System.Windows.Forms.ComboBox();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisa)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tlpMain);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1428, 642);
            this.toolStripContainer.Size = new System.Drawing.Size(1428, 719);
            this.toolStripContainer.TopToolStripPanelVisible = true;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesquisa.AutoGenerateColumns = false;
            this.dgvPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPesquisa.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apelido,
            this.dataDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.afetaSaldoDataGridViewCheckBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subCategoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvPesquisa.DataSource = this.bsPesquisa;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesquisa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisa.EnableHeadersVisualStyles = false;
            this.dgvPesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPesquisa.Location = new System.Drawing.Point(3, 3);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPesquisa.RowHeadersWidth = 20;
            this.dgvPesquisa.RowTemplate.Height = 24;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(1422, 356);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPesquisa_CellFormatting);
            // 
            // Apelido
            // 
            this.Apelido.DataPropertyName = "Apelido";
            this.Apelido.HeaderText = "Conta";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
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
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.afetaSaldoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCategoriaDataGridViewTextBoxColumn
            // 
            this.subCategoriaDataGridViewTextBoxColumn.DataPropertyName = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn.HeaderText = "SubCategoria";
            this.subCategoriaDataGridViewTextBoxColumn.Name = "subCategoriaDataGridViewTextBoxColumn";
            this.subCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPesquisa
            // 
            this.bsPesquisa.AllowNew = false;
            this.bsPesquisa.DataSource = typeof(DataLayer.Pesquisa);
            this.bsPesquisa.DataSourceChanged += new System.EventHandler(this.bsPesquisa_DataSourceChanged);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.dgvPesquisa, 0, 0);
            this.tlpMain.Controls.Add(this.tlpSearch, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tlpMain.Size = new System.Drawing.Size(1428, 642);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 8;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearch.Controls.Add(this.panel4, 5, 0);
            this.tlpSearch.Controls.Add(this.checkedListBoxCategoria, 3, 0);
            this.tlpSearch.Controls.Add(this.checkedListBoxGrupo, 2, 0);
            this.tlpSearch.Controls.Add(this.checkedListBoxContas, 1, 0);
            this.tlpSearch.Controls.Add(this.panel2, 0, 0);
            this.tlpSearch.Controls.Add(this.groupBox1, 4, 0);
            this.tlpSearch.Controls.Add(this.groupBox2, 6, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(3, 365);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(1422, 274);
            this.tlpSearch.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(828, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 268);
            this.panel4.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxHistorico);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(3, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 80);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histórico";
            // 
            // textBoxHistorico
            // 
            this.textBoxHistorico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistorico.Location = new System.Drawing.Point(10, 33);
            this.textBoxHistorico.Name = "textBoxHistorico";
            this.textBoxHistorico.Size = new System.Drawing.Size(189, 30);
            this.textBoxHistorico.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDescricao);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 78);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(10, 36);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(189, 30);
            this.textBoxDescricao.TabIndex = 11;
            // 
            // checkedListBoxCategoria
            // 
            this.checkedListBoxCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCategoria.FormattingEnabled = true;
            this.checkedListBoxCategoria.Location = new System.Drawing.Point(448, 3);
            this.checkedListBoxCategoria.Name = "checkedListBoxCategoria";
            this.checkedListBoxCategoria.Size = new System.Drawing.Size(144, 268);
            this.checkedListBoxCategoria.TabIndex = 7;
            // 
            // checkedListBoxGrupo
            // 
            this.checkedListBoxGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxGrupo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGrupo.FormattingEnabled = true;
            this.checkedListBoxGrupo.Location = new System.Drawing.Point(298, 3);
            this.checkedListBoxGrupo.Name = "checkedListBoxGrupo";
            this.checkedListBoxGrupo.Size = new System.Drawing.Size(144, 268);
            this.checkedListBoxGrupo.TabIndex = 6;
            // 
            // checkedListBoxContas
            // 
            this.checkedListBoxContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxContas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxContas.FormattingEnabled = true;
            this.checkedListBoxContas.Location = new System.Drawing.Point(148, 3);
            this.checkedListBoxContas.Name = "checkedListBoxContas";
            this.checkedListBoxContas.Size = new System.Drawing.Size(144, 268);
            this.checkedListBoxContas.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 268);
            this.panel2.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpTermino);
            this.groupBox3.Controls.Add(this.dtpInicio);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 268);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data entre";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(8, 70);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(119, 30);
            this.dtpTermino.TabIndex = 1;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(8, 34);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(119, 30);
            this.dtpInicio.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currencyTextBoxValor2);
            this.groupBox1.Controls.Add(this.radioButtonBetween);
            this.groupBox1.Controls.Add(this.currencyTextBoxValor1);
            this.groupBox1.Controls.Add(this.radioButtonLesser);
            this.groupBox1.Controls.Add(this.checkBoxAfetaSaldo);
            this.groupBox1.Controls.Add(this.radioButtonGreater);
            this.groupBox1.Controls.Add(this.labelValor_e);
            this.groupBox1.Controls.Add(this.radioButtonEqual);
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(598, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 268);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor";
            // 
            // currencyTextBoxValor2
            // 
            this.currencyTextBoxValor2.BeforeTouchSize = new System.Drawing.Size(95, 30);
            this.currencyTextBoxValor2.CurrencySymbol = "";
            this.currencyTextBoxValor2.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyTextBoxValor2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyTextBoxValor2.Location = new System.Drawing.Point(119, 194);
            this.currencyTextBoxValor2.Name = "currencyTextBoxValor2";
            this.currencyTextBoxValor2.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currencyTextBoxValor2.Size = new System.Drawing.Size(95, 30);
            this.currencyTextBoxValor2.TabIndex = 12;
            this.currencyTextBoxValor2.Text = " 0,00";
            this.currencyTextBoxValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBoxValor2.Visible = false;
            // 
            // radioButtonBetween
            // 
            this.radioButtonBetween.AutoSize = true;
            this.radioButtonBetween.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBetween.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonBetween.Location = new System.Drawing.Point(6, 162);
            this.radioButtonBetween.Name = "radioButtonBetween";
            this.radioButtonBetween.Size = new System.Drawing.Size(71, 27);
            this.radioButtonBetween.TabIndex = 18;
            this.radioButtonBetween.Text = "entre";
            this.radioButtonBetween.UseVisualStyleBackColor = true;
            this.radioButtonBetween.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // currencyTextBoxValor1
            // 
            this.currencyTextBoxValor1.BeforeTouchSize = new System.Drawing.Size(95, 30);
            this.currencyTextBoxValor1.CurrencySymbol = "";
            this.currencyTextBoxValor1.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyTextBoxValor1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyTextBoxValor1.Location = new System.Drawing.Point(6, 194);
            this.currencyTextBoxValor1.Name = "currencyTextBoxValor1";
            this.currencyTextBoxValor1.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currencyTextBoxValor1.Size = new System.Drawing.Size(95, 30);
            this.currencyTextBoxValor1.TabIndex = 11;
            this.currencyTextBoxValor1.Text = " 0,00";
            this.currencyTextBoxValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBoxValor1.Visible = false;
            // 
            // radioButtonLesser
            // 
            this.radioButtonLesser.AutoSize = true;
            this.radioButtonLesser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLesser.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonLesser.Location = new System.Drawing.Point(6, 129);
            this.radioButtonLesser.Name = "radioButtonLesser";
            this.radioButtonLesser.Size = new System.Drawing.Size(43, 27);
            this.radioButtonLesser.TabIndex = 17;
            this.radioButtonLesser.Tag = "<=";
            this.radioButtonLesser.Text = "≤";
            this.radioButtonLesser.UseVisualStyleBackColor = true;
            this.radioButtonLesser.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // checkBoxAfetaSaldo
            // 
            this.checkBoxAfetaSaldo.AutoSize = true;
            this.checkBoxAfetaSaldo.Checked = true;
            this.checkBoxAfetaSaldo.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxAfetaSaldo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAfetaSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxAfetaSaldo.Location = new System.Drawing.Point(6, 235);
            this.checkBoxAfetaSaldo.Name = "checkBoxAfetaSaldo";
            this.checkBoxAfetaSaldo.Size = new System.Drawing.Size(119, 27);
            this.checkBoxAfetaSaldo.TabIndex = 5;
            this.checkBoxAfetaSaldo.Text = "Afeta Saldo";
            this.checkBoxAfetaSaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxAfetaSaldo.ThreeState = true;
            this.checkBoxAfetaSaldo.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreater
            // 
            this.radioButtonGreater.AutoSize = true;
            this.radioButtonGreater.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGreater.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonGreater.Location = new System.Drawing.Point(6, 96);
            this.radioButtonGreater.Name = "radioButtonGreater";
            this.radioButtonGreater.Size = new System.Drawing.Size(43, 27);
            this.radioButtonGreater.TabIndex = 16;
            this.radioButtonGreater.Tag = ">=";
            this.radioButtonGreater.Text = "≥";
            this.radioButtonGreater.UseVisualStyleBackColor = true;
            this.radioButtonGreater.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // labelValor_e
            // 
            this.labelValor_e.AutoSize = true;
            this.labelValor_e.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor_e.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValor_e.Location = new System.Drawing.Point(101, 196);
            this.labelValor_e.Name = "labelValor_e";
            this.labelValor_e.Size = new System.Drawing.Size(19, 23);
            this.labelValor_e.TabIndex = 9;
            this.labelValor_e.Text = "e";
            this.labelValor_e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValor_e.Visible = false;
            // 
            // radioButtonEqual
            // 
            this.radioButtonEqual.AutoSize = true;
            this.radioButtonEqual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonEqual.Location = new System.Drawing.Point(6, 63);
            this.radioButtonEqual.Name = "radioButtonEqual";
            this.radioButtonEqual.Size = new System.Drawing.Size(43, 27);
            this.radioButtonEqual.TabIndex = 15;
            this.radioButtonEqual.Tag = "=";
            this.radioButtonEqual.Text = "=";
            this.radioButtonEqual.UseVisualStyleBackColor = true;
            this.radioButtonEqual.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 33);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(99, 27);
            this.radioButtonAll.TabIndex = 14;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "qualquer";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.checkBoxSentido3);
            this.groupBox2.Controls.Add(this.checkBoxSentido2);
            this.groupBox2.Controls.Add(this.checkBoxSentido1);
            this.groupBox2.Controls.Add(this.comboBoxOrdem3);
            this.groupBox2.Controls.Add(this.comboBoxOrdem2);
            this.groupBox2.Controls.Add(this.comboBoxOrdem1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(1051, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 166);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem";
            // 
            // checkBoxSentido3
            // 
            this.checkBoxSentido3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSentido3.AutoSize = true;
            this.checkBoxSentido3.BackColor = System.Drawing.Color.Black;
            this.checkBoxSentido3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBoxSentido3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.checkBoxSentido3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSentido3.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.checkBoxSentido3.Image = global::MoneyBin2.Properties.Resources.Arrow_up_24;
            this.checkBoxSentido3.Location = new System.Drawing.Point(191, 117);
            this.checkBoxSentido3.Name = "checkBoxSentido3";
            this.checkBoxSentido3.Size = new System.Drawing.Size(30, 30);
            this.checkBoxSentido3.TabIndex = 19;
            this.checkBoxSentido3.UseVisualStyleBackColor = false;
            this.checkBoxSentido3.Visible = false;
            this.checkBoxSentido3.CheckedChanged += new System.EventHandler(this.checkBoxSentido_CheckedChanged);
            // 
            // checkBoxSentido2
            // 
            this.checkBoxSentido2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSentido2.AutoSize = true;
            this.checkBoxSentido2.BackColor = System.Drawing.Color.Black;
            this.checkBoxSentido2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBoxSentido2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.checkBoxSentido2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSentido2.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.checkBoxSentido2.Image = global::MoneyBin2.Properties.Resources.Arrow_up_24;
            this.checkBoxSentido2.Location = new System.Drawing.Point(191, 75);
            this.checkBoxSentido2.Name = "checkBoxSentido2";
            this.checkBoxSentido2.Size = new System.Drawing.Size(30, 30);
            this.checkBoxSentido2.TabIndex = 18;
            this.checkBoxSentido2.UseVisualStyleBackColor = false;
            this.checkBoxSentido2.Visible = false;
            this.checkBoxSentido2.CheckedChanged += new System.EventHandler(this.checkBoxSentido_CheckedChanged);
            // 
            // checkBoxSentido1
            // 
            this.checkBoxSentido1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSentido1.AutoSize = true;
            this.checkBoxSentido1.BackColor = System.Drawing.Color.Black;
            this.checkBoxSentido1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBoxSentido1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.checkBoxSentido1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSentido1.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.checkBoxSentido1.Image = global::MoneyBin2.Properties.Resources.Arrow_up_24;
            this.checkBoxSentido1.Location = new System.Drawing.Point(191, 35);
            this.checkBoxSentido1.Name = "checkBoxSentido1";
            this.checkBoxSentido1.Size = new System.Drawing.Size(30, 30);
            this.checkBoxSentido1.TabIndex = 17;
            this.checkBoxSentido1.UseVisualStyleBackColor = false;
            this.checkBoxSentido1.Visible = false;
            this.checkBoxSentido1.CheckedChanged += new System.EventHandler(this.checkBoxSentido_CheckedChanged);
            // 
            // comboBoxOrdem3
            // 
            this.comboBoxOrdem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdem3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdem3.FormattingEnabled = true;
            this.comboBoxOrdem3.Location = new System.Drawing.Point(9, 119);
            this.comboBoxOrdem3.Name = "comboBoxOrdem3";
            this.comboBoxOrdem3.Size = new System.Drawing.Size(179, 31);
            this.comboBoxOrdem3.TabIndex = 2;
            this.comboBoxOrdem3.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOrdem1_SelectionChangeCommitted);
            // 
            // comboBoxOrdem2
            // 
            this.comboBoxOrdem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdem2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdem2.FormattingEnabled = true;
            this.comboBoxOrdem2.Location = new System.Drawing.Point(9, 77);
            this.comboBoxOrdem2.Name = "comboBoxOrdem2";
            this.comboBoxOrdem2.Size = new System.Drawing.Size(179, 31);
            this.comboBoxOrdem2.TabIndex = 1;
            this.comboBoxOrdem2.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOrdem1_SelectionChangeCommitted);
            // 
            // comboBoxOrdem1
            // 
            this.comboBoxOrdem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdem1.FormattingEnabled = true;
            this.comboBoxOrdem1.Location = new System.Drawing.Point(9, 35);
            this.comboBoxOrdem1.Name = "comboBoxOrdem1";
            this.comboBoxOrdem1.Size = new System.Drawing.Size(179, 31);
            this.comboBoxOrdem1.TabIndex = 0;
            this.comboBoxOrdem1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOrdem1_SelectionChangeCommitted);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.ClientSize = new System.Drawing.Size(1428, 719);
            this.Name = "frmPesquisa";
            this.Text = "Balance";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisa)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGrid.SuperDGV dgvPesquisa;
        private System.Windows.Forms.BindingSource bsPesquisa;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.CheckedListBox checkedListBoxContas;
        private System.Windows.Forms.CheckedListBox checkedListBoxGrupo;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategoria;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAfetaSaldo;
        private System.Windows.Forms.Label labelValor_e;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBoxValor1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBoxValor2;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxHistorico;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxOrdem3;
        private System.Windows.Forms.ComboBox comboBoxOrdem2;
        private System.Windows.Forms.ComboBox comboBoxOrdem1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSentido3;
        private System.Windows.Forms.CheckBox checkBoxSentido2;
        private System.Windows.Forms.CheckBox checkBoxSentido1;
        private System.Windows.Forms.RadioButton radioButtonBetween;
        private System.Windows.Forms.RadioButton radioButtonLesser;
        private System.Windows.Forms.RadioButton radioButtonGreater;
        private System.Windows.Forms.RadioButton radioButtonEqual;
        private System.Windows.Forms.RadioButton radioButtonAll;
    }
}
