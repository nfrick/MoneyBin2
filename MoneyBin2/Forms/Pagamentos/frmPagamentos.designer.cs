using System.Drawing;
using SuperGrid;

namespace MoneyBin2 {
    partial class frmPagamentos {
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvPagamentos = new SuperGrid.SuperDGV();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fevDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.marDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.abrDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.junDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.julDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.agoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.setDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.novDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dezDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPagamentos = new System.Windows.Forms.BindingSource(this.components);
            this.chkbtnMeses = new MoneyBin2.CheckableButton();
            this.chkbtnInativo = new MoneyBin2.CheckableButton();
            this.chkbtnAnoInteiro = new MoneyBin2.CheckableButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOut = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxNov = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDez = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxJul = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxAgo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxSet = new System.Windows.Forms.CheckBox();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.checkBoxAbr = new System.Windows.Forms.CheckBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.checkBoxMai = new System.Windows.Forms.CheckBox();
            this.comboBoxSubCategoria = new System.Windows.Forms.ComboBox();
            this.checkBoxJun = new System.Windows.Forms.CheckBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.checkBoxMar = new System.Windows.Forms.CheckBox();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFev = new System.Windows.Forms.CheckBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.checkBoxJan = new System.Windows.Forms.CheckBox();
            this.toolStripPagamentos = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmsPopMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            this.toolStripPagamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1476, 562);
            this.toolStripContainer.Size = new System.Drawing.Size(1476, 562);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvPagamentos);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.chkbtnMeses);
            this.splitContainer.Panel2.Controls.Add(this.chkbtnInativo);
            this.splitContainer.Panel2.Controls.Add(this.chkbtnAnoInteiro);
            this.splitContainer.Panel2.Controls.Add(this.buttonOK);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxOut);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxNov);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxDez);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxJul);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxAgo);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxSet);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxGrupo);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxAbr);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxCategoria);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxMai);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxSubCategoria);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxJun);
            this.splitContainer.Panel2.Controls.Add(this.textBoxDescricao);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxMar);
            this.splitContainer.Panel2.Controls.Add(this.nudDia);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxFev);
            this.splitContainer.Panel2.Controls.Add(this.textBoxValor);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxJan);
            this.splitContainer.Size = new System.Drawing.Size(1476, 562);
            this.splitContainer.SplitterDistance = 874;
            this.splitContainer.TabIndex = 83;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagamentos.AutoGenerateColumns = false;
            this.dgvPagamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPagamentos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPagamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupoDataGridViewTextBoxColumn,
            this.Categoria,
            this.subCategoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.janDataGridViewCheckBoxColumn,
            this.fevDataGridViewCheckBoxColumn,
            this.marDataGridViewCheckBoxColumn,
            this.abrDataGridViewCheckBoxColumn,
            this.maiDataGridViewCheckBoxColumn,
            this.junDataGridViewCheckBoxColumn,
            this.julDataGridViewCheckBoxColumn,
            this.agoDataGridViewCheckBoxColumn,
            this.setDataGridViewCheckBoxColumn,
            this.outDataGridViewCheckBoxColumn,
            this.novDataGridViewCheckBoxColumn,
            this.dezDataGridViewCheckBoxColumn});
            this.dgvPagamentos.DataSource = this.bsPagamentos;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagamentos.EnableHeadersVisualStyles = false;
            this.dgvPagamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPagamentos.Location = new System.Drawing.Point(0, 0);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagamentos.RowHeadersWidth = 20;
            this.dgvPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamentos.Size = new System.Drawing.Size(874, 562);
            this.dgvPagamentos.TabIndex = 0;
            this.dgvPagamentos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellEndEdit);
            this.dgvPagamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPagamentos_CellFormatting);
            this.dgvPagamentos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPagamentos_EditingControlShowing);
            this.dgvPagamentos.DoubleClick += new System.EventHandler(this.dgvPagamentos_DoubleClick);
            this.dgvPagamentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPagamentos_MouseClick);
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
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
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // janDataGridViewCheckBoxColumn
            // 
            this.janDataGridViewCheckBoxColumn.DataPropertyName = "Jan";
            this.janDataGridViewCheckBoxColumn.HeaderText = "Jan";
            this.janDataGridViewCheckBoxColumn.Name = "janDataGridViewCheckBoxColumn";
            // 
            // fevDataGridViewCheckBoxColumn
            // 
            this.fevDataGridViewCheckBoxColumn.DataPropertyName = "Fev";
            this.fevDataGridViewCheckBoxColumn.HeaderText = "Fev";
            this.fevDataGridViewCheckBoxColumn.Name = "fevDataGridViewCheckBoxColumn";
            // 
            // marDataGridViewCheckBoxColumn
            // 
            this.marDataGridViewCheckBoxColumn.DataPropertyName = "Mar";
            this.marDataGridViewCheckBoxColumn.HeaderText = "Mar";
            this.marDataGridViewCheckBoxColumn.Name = "marDataGridViewCheckBoxColumn";
            // 
            // abrDataGridViewCheckBoxColumn
            // 
            this.abrDataGridViewCheckBoxColumn.DataPropertyName = "Abr";
            this.abrDataGridViewCheckBoxColumn.HeaderText = "Abr";
            this.abrDataGridViewCheckBoxColumn.Name = "abrDataGridViewCheckBoxColumn";
            // 
            // maiDataGridViewCheckBoxColumn
            // 
            this.maiDataGridViewCheckBoxColumn.DataPropertyName = "Mai";
            this.maiDataGridViewCheckBoxColumn.HeaderText = "Mai";
            this.maiDataGridViewCheckBoxColumn.Name = "maiDataGridViewCheckBoxColumn";
            // 
            // junDataGridViewCheckBoxColumn
            // 
            this.junDataGridViewCheckBoxColumn.DataPropertyName = "Jun";
            this.junDataGridViewCheckBoxColumn.HeaderText = "Jun";
            this.junDataGridViewCheckBoxColumn.Name = "junDataGridViewCheckBoxColumn";
            // 
            // julDataGridViewCheckBoxColumn
            // 
            this.julDataGridViewCheckBoxColumn.DataPropertyName = "Jul";
            this.julDataGridViewCheckBoxColumn.HeaderText = "Jul";
            this.julDataGridViewCheckBoxColumn.Name = "julDataGridViewCheckBoxColumn";
            // 
            // agoDataGridViewCheckBoxColumn
            // 
            this.agoDataGridViewCheckBoxColumn.DataPropertyName = "Ago";
            this.agoDataGridViewCheckBoxColumn.HeaderText = "Ago";
            this.agoDataGridViewCheckBoxColumn.Name = "agoDataGridViewCheckBoxColumn";
            // 
            // setDataGridViewCheckBoxColumn
            // 
            this.setDataGridViewCheckBoxColumn.DataPropertyName = "Set";
            this.setDataGridViewCheckBoxColumn.HeaderText = "Set";
            this.setDataGridViewCheckBoxColumn.Name = "setDataGridViewCheckBoxColumn";
            // 
            // outDataGridViewCheckBoxColumn
            // 
            this.outDataGridViewCheckBoxColumn.DataPropertyName = "Out";
            this.outDataGridViewCheckBoxColumn.HeaderText = "Out";
            this.outDataGridViewCheckBoxColumn.Name = "outDataGridViewCheckBoxColumn";
            // 
            // novDataGridViewCheckBoxColumn
            // 
            this.novDataGridViewCheckBoxColumn.DataPropertyName = "Nov";
            this.novDataGridViewCheckBoxColumn.HeaderText = "Nov";
            this.novDataGridViewCheckBoxColumn.Name = "novDataGridViewCheckBoxColumn";
            // 
            // dezDataGridViewCheckBoxColumn
            // 
            this.dezDataGridViewCheckBoxColumn.DataPropertyName = "Dez";
            this.dezDataGridViewCheckBoxColumn.HeaderText = "Dez";
            this.dezDataGridViewCheckBoxColumn.Name = "dezDataGridViewCheckBoxColumn";
            // 
            // bsPagamentos
            // 
            this.bsPagamentos.DataSource = typeof(DataLayer.Pagamento);
            // 
            // chkbtnMeses
            // 
            this.chkbtnMeses.BackColor = System.Drawing.Color.Silver;
            this.chkbtnMeses.Checked = false;
            this.chkbtnMeses.ForeColor = System.Drawing.Color.Black;
            this.chkbtnMeses.Location = new System.Drawing.Point(167, 322);
            this.chkbtnMeses.Name = "chkbtnMeses";
            this.chkbtnMeses.Size = new System.Drawing.Size(132, 39);
            this.chkbtnMeses.TabIndex = 86;
            this.chkbtnMeses.Text = "Meses";
            this.chkbtnMeses.UseVisualStyleBackColor = true;
            this.chkbtnMeses.Click += new System.EventHandler(this.chkbtnMeses_Click);
            // 
            // chkbtnInativo
            // 
            this.chkbtnInativo.BackColor = System.Drawing.Color.Silver;
            this.chkbtnInativo.Checked = false;
            this.chkbtnInativo.ForeColor = System.Drawing.Color.Black;
            this.chkbtnInativo.Location = new System.Drawing.Point(322, 322);
            this.chkbtnInativo.Name = "chkbtnInativo";
            this.chkbtnInativo.Size = new System.Drawing.Size(132, 39);
            this.chkbtnInativo.TabIndex = 85;
            this.chkbtnInativo.Text = "Inativo";
            this.chkbtnInativo.UseVisualStyleBackColor = true;
            this.chkbtnInativo.Click += new System.EventHandler(this.chkbtnInativo_Click);
            // 
            // chkbtnAnoInteiro
            // 
            this.chkbtnAnoInteiro.BackColor = System.Drawing.Color.Silver;
            this.chkbtnAnoInteiro.Checked = false;
            this.chkbtnAnoInteiro.ForeColor = System.Drawing.Color.Black;
            this.chkbtnAnoInteiro.Location = new System.Drawing.Point(16, 322);
            this.chkbtnAnoInteiro.Name = "chkbtnAnoInteiro";
            this.chkbtnAnoInteiro.Size = new System.Drawing.Size(132, 39);
            this.chkbtnAnoInteiro.TabIndex = 84;
            this.chkbtnAnoInteiro.Text = "Ano Inteiro";
            this.chkbtnAnoInteiro.UseVisualStyleBackColor = true;
            this.chkbtnAnoInteiro.Click += new System.EventHandler(this.chkbtnAnoInteiro_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.Enabled = false;
            this.buttonOK.Font = new System.Drawing.Font("Wingdings", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(401, 35);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(53, 40);
            this.buttonOK.TabIndex = 82;
            this.buttonOK.Text = "ü";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Grupo";
            // 
            // checkBoxOut
            // 
            this.checkBoxOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxOut.BackColor = System.Drawing.Color.Silver;
            this.checkBoxOut.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Out", true));
            this.checkBoxOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxOut.ForeColor = System.Drawing.Color.Black;
            this.checkBoxOut.Location = new System.Drawing.Point(348, 367);
            this.checkBoxOut.Name = "checkBoxOut";
            this.checkBoxOut.Size = new System.Drawing.Size(106, 39);
            this.checkBoxOut.TabIndex = 80;
            this.checkBoxOut.Tag = "Mes";
            this.checkBoxOut.Text = "Outubro";
            this.checkBoxOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxOut.UseVisualStyleBackColor = false;
            this.checkBoxOut.Visible = false;
            this.checkBoxOut.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Categoria";
            // 
            // checkBoxNov
            // 
            this.checkBoxNov.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNov.BackColor = System.Drawing.Color.Silver;
            this.checkBoxNov.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Nov", true));
            this.checkBoxNov.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxNov.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNov.Location = new System.Drawing.Point(348, 410);
            this.checkBoxNov.Name = "checkBoxNov";
            this.checkBoxNov.Size = new System.Drawing.Size(106, 39);
            this.checkBoxNov.TabIndex = 79;
            this.checkBoxNov.Tag = "Mes";
            this.checkBoxNov.Text = "Novembro";
            this.checkBoxNov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxNov.UseVisualStyleBackColor = false;
            this.checkBoxNov.Visible = false;
            this.checkBoxNov.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "SubCategoria";
            // 
            // checkBoxDez
            // 
            this.checkBoxDez.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDez.BackColor = System.Drawing.Color.Silver;
            this.checkBoxDez.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Dez", true));
            this.checkBoxDez.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxDez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDez.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDez.Location = new System.Drawing.Point(348, 453);
            this.checkBoxDez.Name = "checkBoxDez";
            this.checkBoxDez.Size = new System.Drawing.Size(106, 39);
            this.checkBoxDez.TabIndex = 78;
            this.checkBoxDez.Tag = "Mes";
            this.checkBoxDez.Text = "Dezembro";
            this.checkBoxDez.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxDez.UseVisualStyleBackColor = false;
            this.checkBoxDez.Visible = false;
            this.checkBoxDez.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Descrição";
            // 
            // checkBoxJul
            // 
            this.checkBoxJul.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJul.BackColor = System.Drawing.Color.Silver;
            this.checkBoxJul.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Jul", true));
            this.checkBoxJul.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxJul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxJul.ForeColor = System.Drawing.Color.Black;
            this.checkBoxJul.Location = new System.Drawing.Point(236, 367);
            this.checkBoxJul.Name = "checkBoxJul";
            this.checkBoxJul.Size = new System.Drawing.Size(106, 39);
            this.checkBoxJul.TabIndex = 77;
            this.checkBoxJul.Tag = "Mes";
            this.checkBoxJul.Text = "Julho";
            this.checkBoxJul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxJul.UseVisualStyleBackColor = false;
            this.checkBoxJul.Visible = false;
            this.checkBoxJul.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 28);
            this.label5.TabIndex = 60;
            this.label5.Text = "Dia";
            // 
            // checkBoxAgo
            // 
            this.checkBoxAgo.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAgo.BackColor = System.Drawing.Color.Silver;
            this.checkBoxAgo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Ago", true));
            this.checkBoxAgo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxAgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAgo.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAgo.Location = new System.Drawing.Point(236, 410);
            this.checkBoxAgo.Name = "checkBoxAgo";
            this.checkBoxAgo.Size = new System.Drawing.Size(106, 39);
            this.checkBoxAgo.TabIndex = 76;
            this.checkBoxAgo.Tag = "Mes";
            this.checkBoxAgo.Text = "Agosto";
            this.checkBoxAgo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxAgo.UseVisualStyleBackColor = false;
            this.checkBoxAgo.Visible = false;
            this.checkBoxAgo.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 61;
            this.label6.Text = "Valor";
            // 
            // checkBoxSet
            // 
            this.checkBoxSet.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSet.BackColor = System.Drawing.Color.Silver;
            this.checkBoxSet.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Set", true));
            this.checkBoxSet.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSet.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSet.Location = new System.Drawing.Point(236, 453);
            this.checkBoxSet.Name = "checkBoxSet";
            this.checkBoxSet.Size = new System.Drawing.Size(106, 39);
            this.checkBoxSet.TabIndex = 75;
            this.checkBoxSet.Tag = "Mes";
            this.checkBoxSet.Text = "Setembro";
            this.checkBoxSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxSet.UseVisualStyleBackColor = false;
            this.checkBoxSet.Visible = false;
            this.checkBoxSet.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPagamentos, "Grupo", true));
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.Location = new System.Drawing.Point(154, 35);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(216, 36);
            this.comboBoxGrupo.TabIndex = 62;
            this.comboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupo_SelectedIndexChanged);
            this.comboBoxGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // checkBoxAbr
            // 
            this.checkBoxAbr.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAbr.BackColor = System.Drawing.Color.Silver;
            this.checkBoxAbr.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Abr", true));
            this.checkBoxAbr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxAbr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAbr.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAbr.Location = new System.Drawing.Point(126, 367);
            this.checkBoxAbr.Name = "checkBoxAbr";
            this.checkBoxAbr.Size = new System.Drawing.Size(106, 39);
            this.checkBoxAbr.TabIndex = 74;
            this.checkBoxAbr.Tag = "Mes";
            this.checkBoxAbr.Text = "Abril";
            this.checkBoxAbr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxAbr.UseVisualStyleBackColor = false;
            this.checkBoxAbr.Visible = false;
            this.checkBoxAbr.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPagamentos, "Categoria", true));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(154, 78);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(216, 36);
            this.comboBoxCategoria.TabIndex = 63;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            this.comboBoxCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // checkBoxMai
            // 
            this.checkBoxMai.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMai.BackColor = System.Drawing.Color.Silver;
            this.checkBoxMai.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Mai", true));
            this.checkBoxMai.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMai.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMai.Location = new System.Drawing.Point(126, 410);
            this.checkBoxMai.Name = "checkBoxMai";
            this.checkBoxMai.Size = new System.Drawing.Size(106, 39);
            this.checkBoxMai.TabIndex = 73;
            this.checkBoxMai.Tag = "Mes";
            this.checkBoxMai.Text = "Maio";
            this.checkBoxMai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMai.UseVisualStyleBackColor = false;
            this.checkBoxMai.Visible = false;
            this.checkBoxMai.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // comboBoxSubCategoria
            // 
            this.comboBoxSubCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPagamentos, "SubCategoria", true));
            this.comboBoxSubCategoria.FormattingEnabled = true;
            this.comboBoxSubCategoria.Location = new System.Drawing.Point(154, 121);
            this.comboBoxSubCategoria.Name = "comboBoxSubCategoria";
            this.comboBoxSubCategoria.Size = new System.Drawing.Size(216, 36);
            this.comboBoxSubCategoria.TabIndex = 64;
            this.comboBoxSubCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // checkBoxJun
            // 
            this.checkBoxJun.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJun.BackColor = System.Drawing.Color.Silver;
            this.checkBoxJun.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Jun", true));
            this.checkBoxJun.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxJun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxJun.ForeColor = System.Drawing.Color.Black;
            this.checkBoxJun.Location = new System.Drawing.Point(126, 453);
            this.checkBoxJun.Name = "checkBoxJun";
            this.checkBoxJun.Size = new System.Drawing.Size(106, 39);
            this.checkBoxJun.TabIndex = 72;
            this.checkBoxJun.Tag = "Mes";
            this.checkBoxJun.Text = "Junho";
            this.checkBoxJun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxJun.UseVisualStyleBackColor = false;
            this.checkBoxJun.Visible = false;
            this.checkBoxJun.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPagamentos, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(154, 164);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(216, 34);
            this.textBoxDescricao.TabIndex = 65;
            this.textBoxDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescricao_Validating);
            // 
            // checkBoxMar
            // 
            this.checkBoxMar.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMar.BackColor = System.Drawing.Color.Silver;
            this.checkBoxMar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Mar", true));
            this.checkBoxMar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMar.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMar.Location = new System.Drawing.Point(16, 453);
            this.checkBoxMar.Name = "checkBoxMar";
            this.checkBoxMar.Size = new System.Drawing.Size(106, 39);
            this.checkBoxMar.TabIndex = 71;
            this.checkBoxMar.Tag = "Mes";
            this.checkBoxMar.Text = "Março";
            this.checkBoxMar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMar.UseVisualStyleBackColor = false;
            this.checkBoxMar.Visible = false;
            this.checkBoxMar.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // nudDia
            // 
            this.nudDia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPagamentos, "Dia", true));
            this.nudDia.Location = new System.Drawing.Point(154, 205);
            this.nudDia.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(58, 34);
            this.nudDia.TabIndex = 66;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxFev
            // 
            this.checkBoxFev.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFev.BackColor = System.Drawing.Color.Silver;
            this.checkBoxFev.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Fev", true));
            this.checkBoxFev.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxFev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFev.ForeColor = System.Drawing.Color.Black;
            this.checkBoxFev.Location = new System.Drawing.Point(16, 410);
            this.checkBoxFev.Name = "checkBoxFev";
            this.checkBoxFev.Size = new System.Drawing.Size(106, 39);
            this.checkBoxFev.TabIndex = 70;
            this.checkBoxFev.Tag = "Mes";
            this.checkBoxFev.Text = "Fevereiro";
            this.checkBoxFev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxFev.UseVisualStyleBackColor = false;
            this.checkBoxFev.Visible = false;
            this.checkBoxFev.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // textBoxValor
            // 
            this.textBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPagamentos, "Valor", true));
            this.textBoxValor.Location = new System.Drawing.Point(154, 246);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(134, 34);
            this.textBoxValor.TabIndex = 67;
            // 
            // checkBoxJan
            // 
            this.checkBoxJan.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJan.BackColor = System.Drawing.Color.Silver;
            this.checkBoxJan.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPagamentos, "Jan", true));
            this.checkBoxJan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxJan.ForeColor = System.Drawing.Color.Black;
            this.checkBoxJan.Location = new System.Drawing.Point(16, 367);
            this.checkBoxJan.Name = "checkBoxJan";
            this.checkBoxJan.Size = new System.Drawing.Size(106, 39);
            this.checkBoxJan.TabIndex = 69;
            this.checkBoxJan.Tag = "Mes";
            this.checkBoxJan.Text = "Janeiro";
            this.checkBoxJan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxJan.UseVisualStyleBackColor = false;
            this.checkBoxJan.Visible = false;
            this.checkBoxJan.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // toolStripPagamentos
            // 
            this.toolStripPagamentos.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPagamentos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripPagamentos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNovo});
            this.toolStripPagamentos.Location = new System.Drawing.Point(3, 0);
            this.toolStripPagamentos.Name = "toolStripPagamentos";
            this.toolStripPagamentos.Size = new System.Drawing.Size(375, 27);
            this.toolStripPagamentos.TabIndex = 0;
            // 
            // toolStripButtonNovo
            // 
            this.toolStripButtonNovo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.toolStripButtonNovo.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonNovo.Image = global::MoneyBin2.Properties.Resources.Add_24;
            this.toolStripButtonNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNovo.Name = "toolStripButtonNovo";
            this.toolStripButtonNovo.Size = new System.Drawing.Size(148, 24);
            this.toolStripButtonNovo.Text = "Novo Pagamento";
            this.toolStripButtonNovo.Click += new System.EventHandler(this.toolStripButtonNovo_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmsPopMenu
            // 
            this.cmsPopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPopMenu.Name = "cmsPopMenu";
            this.cmsPopMenu.Size = new System.Drawing.Size(61, 4);
            this.cmsPopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPopMenu_ItemClicked);
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1476, 562);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Name = "frmPagamentos";
            this.Text = "Pagamentos";
            this.Controls.SetChildIndex(this.toolStripContainer, 0);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            this.toolStripPagamentos.ResumeLayout(false);
            this.toolStripPagamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripPagamentos;
        //private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        //private System.Windows.Forms.ToolStripButton toolStripButtonDesfazer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        //private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNovo;
        private System.Windows.Forms.BindingSource bsPagamentos;
        private System.Windows.Forms.CheckBox checkBoxOut;
        private System.Windows.Forms.CheckBox checkBoxNov;
        private System.Windows.Forms.CheckBox checkBoxDez;
        private System.Windows.Forms.CheckBox checkBoxJul;
        private System.Windows.Forms.CheckBox checkBoxAgo;
        private System.Windows.Forms.CheckBox checkBoxSet;
        private System.Windows.Forms.CheckBox checkBoxAbr;
        private System.Windows.Forms.CheckBox checkBoxMai;
        private System.Windows.Forms.CheckBox checkBoxJun;
        private System.Windows.Forms.CheckBox checkBoxMar;
        private System.Windows.Forms.CheckBox checkBoxFev;
        private System.Windows.Forms.CheckBox checkBoxJan;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxSubCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ContextMenuStrip cmsPopMenu;
        private CheckableButton chkbtnAnoInteiro;
        private CheckableButton chkbtnInativo;
        private CheckableButton chkbtnMeses;
        //private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private SuperDGV dgvPagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn janDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fevDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn abrDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn junDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn julDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn agoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn setDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn novDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dezDataGridViewCheckBoxColumn;
    }
}