namespace MoneyBin2 {
    partial class frmBalanceOld {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalanceOld));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvBalance = new SuperGrid.SuperDGV();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afetaSaldoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBalance = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripBalance = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelConta = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxConta = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelGrupo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxGrupo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelInicio = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSelecionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorSalvar = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDesfazer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorDesfazer = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelProcurar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxProcurar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPopMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            this.toolStripBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvBalance);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1374, 372);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1374, 405);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripBalance);
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBalance.AutoGenerateColumns = false;
            this.dgvBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBalance.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.afetaSaldoDataGridViewCheckBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subCategoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvBalance.DataSource = this.bsBalance;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalance.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBalance.EnableHeadersVisualStyles = false;
            this.dgvBalance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBalance.Location = new System.Drawing.Point(0, 0);
            this.dgvBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBalance.RowHeadersWidth = 20;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(716, 337);
            this.dgvBalance.TabIndex = 0;
            this.dgvBalance.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalance_CellEndEdit);
            this.dgvBalance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBalance_CellFormatting);
            this.dgvBalance.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalance_CellValueChanged);
            this.dgvBalance.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBalance_ColumnHeaderMouseClick);
            this.dgvBalance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBalance_EditingControlShowing);
            this.dgvBalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBalance_MouseClick);
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsBalance
            // 
            this.bsBalance.DataSource = typeof(DataLayer.BalanceItem);
            // 
            // toolStripBalance
            // 
            this.toolStripBalance.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBalance.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBalance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelConta,
            this.toolStripComboBoxConta,
            this.toolStripLabelGrupo,
            this.toolStripComboBoxGrupo,
            this.toolStripLabelInicio,
            this.toolStripButtonSelecionar,
            this.toolStripSeparator1,
            this.toolStripButtonSalvar,
            this.toolStripSeparatorSalvar,
            this.toolStripButtonDesfazer,
            this.toolStripSeparatorDesfazer,
            this.toolStripLabelProcurar,
            this.toolStripTextBoxProcurar,
            this.toolStripButtonProcurar,
            this.toolStripSeparator4});
            this.toolStripBalance.Location = new System.Drawing.Point(3, 0);
            this.toolStripBalance.Name = "toolStripBalance";
            this.toolStripBalance.Size = new System.Drawing.Size(591, 33);
            this.toolStripBalance.TabIndex = 0;
            this.toolStripBalance.Tag = "Save";
            // 
            // toolStripLabelConta
            // 
            this.toolStripLabelConta.Name = "toolStripLabelConta";
            this.toolStripLabelConta.Size = new System.Drawing.Size(51, 30);
            this.toolStripLabelConta.Text = "Conta:";
            // 
            // toolStripComboBoxConta
            // 
            this.toolStripComboBoxConta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxConta.Name = "toolStripComboBoxConta";
            this.toolStripComboBoxConta.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBoxConta.SelectedIndexChanged += new System.EventHandler(this.FilterItemChanged);
            // 
            // toolStripLabelGrupo
            // 
            this.toolStripLabelGrupo.Name = "toolStripLabelGrupo";
            this.toolStripLabelGrupo.Size = new System.Drawing.Size(53, 30);
            this.toolStripLabelGrupo.Text = "Grupo:";
            // 
            // toolStripComboBoxGrupo
            // 
            this.toolStripComboBoxGrupo.Name = "toolStripComboBoxGrupo";
            this.toolStripComboBoxGrupo.Size = new System.Drawing.Size(121, 33);
            // 
            // toolStripLabelInicio
            // 
            this.toolStripLabelInicio.Name = "toolStripLabelInicio";
            this.toolStripLabelInicio.Size = new System.Drawing.Size(48, 30);
            this.toolStripLabelInicio.Text = "Início:";
            // 
            // toolStripButtonSelecionar
            // 
            this.toolStripButtonSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripButtonSelecionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionar.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toolStripButtonSelecionar.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionar.Image")));
            this.toolStripButtonSelecionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionar.Name = "toolStripButtonSelecionar";
            this.toolStripButtonSelecionar.Size = new System.Drawing.Size(35, 30);
            this.toolStripButtonSelecionar.Text = "è";
            this.toolStripButtonSelecionar.ToolTipText = "è";
            this.toolStripButtonSelecionar.Visible = false;
            this.toolStripButtonSelecionar.Click += new System.EventHandler(this.FilterItemChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonSalvar
            // 
            this.toolStripButtonSalvar.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButtonSalvar.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonSalvar.Image = global::MoneyBin2.Properties.Resources.OK;
            this.toolStripButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            this.toolStripButtonSalvar.Size = new System.Drawing.Size(73, 30);
            this.toolStripButtonSalvar.Tag = "Save";
            this.toolStripButtonSalvar.Text = "Salvar";
            this.toolStripButtonSalvar.Visible = false;
            this.toolStripButtonSalvar.Click += new System.EventHandler(this.toolStripButtonSalvar_Click);
            this.toolStripButtonSalvar.VisibleChanged += new System.EventHandler(this.toolStripButtonSalvar_VisibleChanged);
            // 
            // toolStripSeparatorSalvar
            // 
            this.toolStripSeparatorSalvar.Name = "toolStripSeparatorSalvar";
            this.toolStripSeparatorSalvar.Size = new System.Drawing.Size(6, 33);
            this.toolStripSeparatorSalvar.Tag = "Save";
            this.toolStripSeparatorSalvar.Visible = false;
            // 
            // toolStripButtonDesfazer
            // 
            this.toolStripButtonDesfazer.BackColor = System.Drawing.Color.Khaki;
            this.toolStripButtonDesfazer.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonDesfazer.Image = global::MoneyBin2.Properties.Resources.Revert;
            this.toolStripButtonDesfazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDesfazer.Name = "toolStripButtonDesfazer";
            this.toolStripButtonDesfazer.Size = new System.Drawing.Size(91, 30);
            this.toolStripButtonDesfazer.Tag = "Save";
            this.toolStripButtonDesfazer.Text = "Desfazer";
            this.toolStripButtonDesfazer.Visible = false;
            this.toolStripButtonDesfazer.Click += new System.EventHandler(this.toolStripButtonDesfazer_Click);
            // 
            // toolStripSeparatorDesfazer
            // 
            this.toolStripSeparatorDesfazer.Name = "toolStripSeparatorDesfazer";
            this.toolStripSeparatorDesfazer.Size = new System.Drawing.Size(6, 33);
            this.toolStripSeparatorDesfazer.Tag = "Save";
            this.toolStripSeparatorDesfazer.Visible = false;
            // 
            // toolStripLabelProcurar
            // 
            this.toolStripLabelProcurar.Name = "toolStripLabelProcurar";
            this.toolStripLabelProcurar.Size = new System.Drawing.Size(67, 30);
            this.toolStripLabelProcurar.Text = "Procurar:";
            // 
            // toolStripTextBoxProcurar
            // 
            this.toolStripTextBoxProcurar.Name = "toolStripTextBoxProcurar";
            this.toolStripTextBoxProcurar.Size = new System.Drawing.Size(100, 33);
            this.toolStripTextBoxProcurar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxProcurar_KeyDown);
            this.toolStripTextBoxProcurar.Validated += new System.EventHandler(this.toolStripTextBoxProcurar_Validated);
            this.toolStripTextBoxProcurar.TextChanged += new System.EventHandler(this.toolStripTextBoxProcurar_TextChanged);
            // 
            // toolStripButtonProcurar
            // 
            this.toolStripButtonProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripButtonProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonProcurar.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toolStripButtonProcurar.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonProcurar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProcurar.Image")));
            this.toolStripButtonProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProcurar.Name = "toolStripButtonProcurar";
            this.toolStripButtonProcurar.Size = new System.Drawing.Size(35, 30);
            this.toolStripButtonProcurar.Text = "L";
            this.toolStripButtonProcurar.ToolTipText = "è";
            this.toolStripButtonProcurar.Visible = false;
            this.toolStripButtonProcurar.Click += new System.EventHandler(this.toolStripButtonProcurar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // cmsPopMenu
            // 
            this.cmsPopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPopMenu.Name = "cmsPopMenu";
            this.cmsPopMenu.ShowImageMargin = false;
            this.cmsPopMenu.Size = new System.Drawing.Size(36, 4);
            this.cmsPopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPopMenu_ItemClicked);
            // 
            // frmBalanceOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 405);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBalanceOld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBalance_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            this.toolStripBalance.ResumeLayout(false);
            this.toolStripBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGrid.SuperDGV dgvBalance;
        private System.Windows.Forms.BindingSource bsBalance;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripBalance;
        private System.Windows.Forms.ToolStripLabel toolStripLabelConta;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxConta;
        private System.Windows.Forms.ToolStripLabel toolStripLabelInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButtonDesfazer;
        private System.Windows.Forms.ToolStripLabel toolStripLabelGrupo;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxGrupo;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionar;
        private System.Windows.Forms.ToolStripLabel toolStripLabelProcurar;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorDesfazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip cmsPopMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afetaSaldoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}