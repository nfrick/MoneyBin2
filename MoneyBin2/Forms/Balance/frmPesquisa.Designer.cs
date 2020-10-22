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
            this.checkedListBoxContas = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxGrupo = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxCategoria = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHistorico = new System.Windows.Forms.TextBox();
            this.labelHistorico = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currencyTextBoxValor2 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.currencyTextBoxValor1 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.radioButtonBetween = new System.Windows.Forms.RadioButton();
            this.radioButtonSmallerThan = new System.Windows.Forms.RadioButton();
            this.radioButtonGreaterThan = new System.Windows.Forms.RadioButton();
            this.radioButtonEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.checkBoxAfetaSaldo = new System.Windows.Forms.CheckBox();
            this.labelValor_e = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.labelDatasEntre = new System.Windows.Forms.Label();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisa)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tlpMain);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1428, 611);
            this.toolStripContainer.Size = new System.Drawing.Size(1428, 688);
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
            this.dgvPesquisa.Location = new System.Drawing.Point(378, 3);
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
            this.dgvPesquisa.Size = new System.Drawing.Size(1047, 605);
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
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpMain.Controls.Add(this.dgvPesquisa, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1428, 611);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 2;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tlpSearch.Controls.Add(this.checkedListBoxContas, 0, 0);
            this.tlpSearch.Controls.Add(this.checkedListBoxGrupo, 0, 1);
            this.tlpSearch.Controls.Add(this.checkedListBoxCategoria, 0, 2);
            this.tlpSearch.Controls.Add(this.panel1, 1, 0);
            this.tlpSearch.Controls.Add(this.panel3, 1, 2);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(3, 3);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 3;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearch.Size = new System.Drawing.Size(369, 605);
            this.tlpSearch.TabIndex = 12;
            // 
            // checkedListBoxContas
            // 
            this.checkedListBoxContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxContas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxContas.FormattingEnabled = true;
            this.checkedListBoxContas.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxContas.Name = "checkedListBoxContas";
            this.checkedListBoxContas.Size = new System.Drawing.Size(158, 188);
            this.checkedListBoxContas.TabIndex = 0;
            // 
            // checkedListBoxGrupo
            // 
            this.checkedListBoxGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxGrupo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGrupo.FormattingEnabled = true;
            this.checkedListBoxGrupo.Location = new System.Drawing.Point(3, 197);
            this.checkedListBoxGrupo.Name = "checkedListBoxGrupo";
            this.checkedListBoxGrupo.Size = new System.Drawing.Size(158, 188);
            this.checkedListBoxGrupo.TabIndex = 6;
            // 
            // checkedListBoxCategoria
            // 
            this.checkedListBoxCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCategoria.FormattingEnabled = true;
            this.checkedListBoxCategoria.Location = new System.Drawing.Point(3, 391);
            this.checkedListBoxCategoria.Name = "checkedListBoxCategoria";
            this.checkedListBoxCategoria.Size = new System.Drawing.Size(158, 189);
            this.checkedListBoxCategoria.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.textBoxHistorico);
            this.panel1.Controls.Add(this.labelHistorico);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.labelDescricao);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.labelDatasEntre);
            this.panel1.Controls.Add(this.dtpTermino);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(167, 3);
            this.panel1.Name = "panel1";
            this.tlpSearch.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(215, 577);
            this.panel1.TabIndex = 8;
            // 
            // textBoxHistorico
            // 
            this.textBoxHistorico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistorico.Location = new System.Drawing.Point(3, 539);
            this.textBoxHistorico.Name = "textBoxHistorico";
            this.textBoxHistorico.Size = new System.Drawing.Size(199, 30);
            this.textBoxHistorico.TabIndex = 14;
            // 
            // labelHistorico
            // 
            this.labelHistorico.AutoSize = true;
            this.labelHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHistorico.Location = new System.Drawing.Point(3, 508);
            this.labelHistorico.Name = "labelHistorico";
            this.labelHistorico.Size = new System.Drawing.Size(91, 28);
            this.labelHistorico.TabIndex = 15;
            this.labelHistorico.Text = "Histórico";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(3, 475);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(199, 30);
            this.textBoxDescricao.TabIndex = 11;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDescricao.Location = new System.Drawing.Point(3, 444);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(96, 28);
            this.labelDescricao.TabIndex = 13;
            this.labelDescricao.Text = "Descrição";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currencyTextBoxValor2);
            this.groupBox1.Controls.Add(this.currencyTextBoxValor1);
            this.groupBox1.Controls.Add(this.radioButtonBetween);
            this.groupBox1.Controls.Add(this.radioButtonSmallerThan);
            this.groupBox1.Controls.Add(this.radioButtonGreaterThan);
            this.groupBox1.Controls.Add(this.radioButtonEqual);
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Controls.Add(this.checkBoxAfetaSaldo);
            this.groupBox1.Controls.Add(this.labelValor_e);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 322);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor";
            // 
            // currencyTextBoxValor2
            // 
            this.currencyTextBoxValor2.BeforeTouchSize = new System.Drawing.Size(78, 34);
            this.currencyTextBoxValor2.CurrencySymbol = "";
            this.currencyTextBoxValor2.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyTextBoxValor2.Location = new System.Drawing.Point(113, 220);
            this.currencyTextBoxValor2.Name = "currencyTextBoxValor2";
            this.currencyTextBoxValor2.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currencyTextBoxValor2.Size = new System.Drawing.Size(78, 34);
            this.currencyTextBoxValor2.TabIndex = 12;
            this.currencyTextBoxValor2.Text = " 0,00";
            this.currencyTextBoxValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBoxValor2.Visible = false;
            // 
            // currencyTextBoxValor1
            // 
            this.currencyTextBoxValor1.BeforeTouchSize = new System.Drawing.Size(78, 34);
            this.currencyTextBoxValor1.CurrencySymbol = "";
            this.currencyTextBoxValor1.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyTextBoxValor1.Location = new System.Drawing.Point(10, 220);
            this.currencyTextBoxValor1.Name = "currencyTextBoxValor1";
            this.currencyTextBoxValor1.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currencyTextBoxValor1.Size = new System.Drawing.Size(78, 34);
            this.currencyTextBoxValor1.TabIndex = 11;
            this.currencyTextBoxValor1.Text = " 0,00";
            this.currencyTextBoxValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyTextBoxValor1.Visible = false;
            // 
            // radioButtonBetween
            // 
            this.radioButtonBetween.AutoSize = true;
            this.radioButtonBetween.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonBetween.Location = new System.Drawing.Point(10, 186);
            this.radioButtonBetween.Name = "radioButtonBetween";
            this.radioButtonBetween.Size = new System.Drawing.Size(78, 32);
            this.radioButtonBetween.TabIndex = 4;
            this.radioButtonBetween.Text = "entre";
            this.radioButtonBetween.UseVisualStyleBackColor = true;
            this.radioButtonBetween.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // radioButtonSmallerThan
            // 
            this.radioButtonSmallerThan.AutoSize = true;
            this.radioButtonSmallerThan.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonSmallerThan.Location = new System.Drawing.Point(10, 148);
            this.radioButtonSmallerThan.Name = "radioButtonSmallerThan";
            this.radioButtonSmallerThan.Size = new System.Drawing.Size(47, 32);
            this.radioButtonSmallerThan.TabIndex = 3;
            this.radioButtonSmallerThan.Text = "≤";
            this.radioButtonSmallerThan.UseVisualStyleBackColor = true;
            this.radioButtonSmallerThan.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // radioButtonGreaterThan
            // 
            this.radioButtonGreaterThan.AutoSize = true;
            this.radioButtonGreaterThan.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonGreaterThan.Location = new System.Drawing.Point(10, 110);
            this.radioButtonGreaterThan.Name = "radioButtonGreaterThan";
            this.radioButtonGreaterThan.Size = new System.Drawing.Size(47, 32);
            this.radioButtonGreaterThan.TabIndex = 2;
            this.radioButtonGreaterThan.Text = "≥";
            this.radioButtonGreaterThan.UseVisualStyleBackColor = true;
            this.radioButtonGreaterThan.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // radioButtonEqual
            // 
            this.radioButtonEqual.AutoSize = true;
            this.radioButtonEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonEqual.Location = new System.Drawing.Point(10, 72);
            this.radioButtonEqual.Name = "radioButtonEqual";
            this.radioButtonEqual.Size = new System.Drawing.Size(47, 32);
            this.radioButtonEqual.TabIndex = 1;
            this.radioButtonEqual.Text = "=";
            this.radioButtonEqual.UseVisualStyleBackColor = true;
            this.radioButtonEqual.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonAll.Location = new System.Drawing.Point(10, 34);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(111, 32);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "qualquer";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // checkBoxAfetaSaldo
            // 
            this.checkBoxAfetaSaldo.AutoSize = true;
            this.checkBoxAfetaSaldo.Checked = true;
            this.checkBoxAfetaSaldo.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxAfetaSaldo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAfetaSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxAfetaSaldo.Location = new System.Drawing.Point(10, 279);
            this.checkBoxAfetaSaldo.Name = "checkBoxAfetaSaldo";
            this.checkBoxAfetaSaldo.Size = new System.Drawing.Size(119, 27);
            this.checkBoxAfetaSaldo.TabIndex = 5;
            this.checkBoxAfetaSaldo.Text = "Afeta Saldo";
            this.checkBoxAfetaSaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxAfetaSaldo.ThreeState = true;
            this.checkBoxAfetaSaldo.UseVisualStyleBackColor = true;
            // 
            // labelValor_e
            // 
            this.labelValor_e.AutoSize = true;
            this.labelValor_e.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValor_e.Location = new System.Drawing.Point(89, 224);
            this.labelValor_e.Name = "labelValor_e";
            this.labelValor_e.Size = new System.Drawing.Size(22, 28);
            this.labelValor_e.TabIndex = 9;
            this.labelValor_e.Text = "e";
            this.labelValor_e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValor_e.Visible = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(3, 33);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(117, 30);
            this.dtpInicio.TabIndex = 2;
            // 
            // labelDatasEntre
            // 
            this.labelDatasEntre.AutoSize = true;
            this.labelDatasEntre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDatasEntre.Location = new System.Drawing.Point(3, 2);
            this.labelDatasEntre.Name = "labelDatasEntre";
            this.labelDatasEntre.Size = new System.Drawing.Size(57, 28);
            this.labelDatasEntre.TabIndex = 10;
            this.labelDatasEntre.Text = "Entre";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(3, 69);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(117, 30);
            this.dtpTermino.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 16);
            this.panel3.TabIndex = 10;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.ClientSize = new System.Drawing.Size(1428, 688);
            this.Name = "frmPesquisa";
            this.Text = "Balance";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisa)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBoxValor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGrid.SuperDGV dgvPesquisa;
        private System.Windows.Forms.BindingSource bsPesquisa;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.CheckedListBox checkedListBoxContas;
        private System.Windows.Forms.CheckedListBox checkedListBoxGrupo;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label labelDatasEntre;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBetween;
        private System.Windows.Forms.RadioButton radioButtonSmallerThan;
        private System.Windows.Forms.RadioButton radioButtonGreaterThan;
        private System.Windows.Forms.RadioButton radioButtonEqual;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.CheckBox checkBoxAfetaSaldo;
        private System.Windows.Forms.Label labelValor_e;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.TextBox textBoxHistorico;
        private System.Windows.Forms.Label labelHistorico;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBoxValor1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBoxValor2;
    }
}
