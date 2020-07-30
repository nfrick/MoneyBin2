namespace MoneyBin2 {
    partial class frmExport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExport));
            this.buttonExport = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonExcel2 = new System.Windows.Forms.RadioButton();
            this.radioButtonExtrato = new System.Windows.Forms.RadioButton();
            this.radioButtonExcel = new System.Windows.Forms.RadioButton();
            this.radioButtonXML = new System.Windows.Forms.RadioButton();
            this.radioButtonCSV = new System.Windows.Forms.RadioButton();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBoxCriteria = new System.Windows.Forms.GroupBox();
            this.checkBoxGruposTodos = new System.Windows.Forms.CheckBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.checkBoxAfetaSaldo = new System.Windows.Forms.CheckBox();
            this.labelContas = new System.Windows.Forms.Label();
            this.checkedListBoxGrupos = new System.Windows.Forms.CheckedListBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDataTermino = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.bsContas = new System.Windows.Forms.BindingSource(this.components);
            this.selecionadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExport.Location = new System.Drawing.Point(451, 161);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(94, 41);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Exportar";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonExcel2);
            this.groupBox1.Controls.Add(this.radioButtonExtrato);
            this.groupBox1.Controls.Add(this.radioButtonExcel);
            this.groupBox1.Controls.Add(this.radioButtonXML);
            this.groupBox1.Controls.Add(this.radioButtonCSV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(526, 101);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato";
            // 
            // radioButtonExcel2
            // 
            this.radioButtonExcel2.AutoSize = true;
            this.radioButtonExcel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonExcel2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonExcel2.Location = new System.Drawing.Point(126, 58);
            this.radioButtonExcel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButtonExcel2.Name = "radioButtonExcel2";
            this.radioButtonExcel2.Size = new System.Drawing.Size(222, 27);
            this.radioButtonExcel2.TabIndex = 19;
            this.radioButtonExcel2.TabStop = true;
            this.radioButtonExcel2.Text = "Excel planilhas separadas";
            this.radioButtonExcel2.UseVisualStyleBackColor = true;
            this.radioButtonExcel2.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonExtrato
            // 
            this.radioButtonExtrato.AutoSize = true;
            this.radioButtonExtrato.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonExtrato.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonExtrato.Location = new System.Drawing.Point(356, 27);
            this.radioButtonExtrato.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButtonExtrato.Name = "radioButtonExtrato";
            this.radioButtonExtrato.Size = new System.Drawing.Size(150, 27);
            this.radioButtonExtrato.TabIndex = 18;
            this.radioButtonExtrato.TabStop = true;
            this.radioButtonExtrato.Text = "Extrato (Access)";
            this.radioButtonExtrato.UseVisualStyleBackColor = true;
            this.radioButtonExtrato.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonExcel
            // 
            this.radioButtonExcel.AutoSize = true;
            this.radioButtonExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonExcel.Location = new System.Drawing.Point(127, 27);
            this.radioButtonExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButtonExcel.Name = "radioButtonExcel";
            this.radioButtonExcel.Size = new System.Drawing.Size(180, 27);
            this.radioButtonExcel.TabIndex = 16;
            this.radioButtonExcel.TabStop = true;
            this.radioButtonExcel.Text = "Excel planilha única";
            this.radioButtonExcel.UseVisualStyleBackColor = true;
            this.radioButtonExcel.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonXML
            // 
            this.radioButtonXML.AutoSize = true;
            this.radioButtonXML.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXML.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonXML.Location = new System.Drawing.Point(24, 58);
            this.radioButtonXML.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButtonXML.Name = "radioButtonXML";
            this.radioButtonXML.Size = new System.Drawing.Size(64, 27);
            this.radioButtonXML.TabIndex = 15;
            this.radioButtonXML.TabStop = true;
            this.radioButtonXML.Text = "XML";
            this.radioButtonXML.UseVisualStyleBackColor = true;
            this.radioButtonXML.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonCSV
            // 
            this.radioButtonCSV.AutoSize = true;
            this.radioButtonCSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCSV.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonCSV.Location = new System.Drawing.Point(24, 27);
            this.radioButtonCSV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButtonCSV.Name = "radioButtonCSV";
            this.radioButtonCSV.Size = new System.Drawing.Size(62, 27);
            this.radioButtonCSV.TabIndex = 14;
            this.radioButtonCSV.TabStop = true;
            this.radioButtonCSV.Text = "CSV";
            this.radioButtonCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButtonCSV.UseVisualStyleBackColor = true;
            this.radioButtonCSV.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSair.Location = new System.Drawing.Point(451, 204);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(94, 41);
            this.buttonSair.TabIndex = 15;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // groupBoxCriteria
            // 
            this.groupBoxCriteria.Controls.Add(this.checkBoxGruposTodos);
            this.groupBoxCriteria.Controls.Add(this.dgvContas);
            this.groupBoxCriteria.Controls.Add(this.checkBoxAfetaSaldo);
            this.groupBoxCriteria.Controls.Add(this.labelContas);
            this.groupBoxCriteria.Controls.Add(this.checkedListBoxGrupos);
            this.groupBoxCriteria.Controls.Add(this.labelCount);
            this.groupBoxCriteria.Controls.Add(this.labelDataTermino);
            this.groupBoxCriteria.Controls.Add(this.labelDataInicio);
            this.groupBoxCriteria.Controls.Add(this.dtpTermino);
            this.groupBoxCriteria.Controls.Add(this.dtpInicio);
            this.groupBoxCriteria.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxCriteria.Location = new System.Drawing.Point(19, 135);
            this.groupBoxCriteria.Name = "groupBoxCriteria";
            this.groupBoxCriteria.Size = new System.Drawing.Size(409, 374);
            this.groupBoxCriteria.TabIndex = 16;
            this.groupBoxCriteria.TabStop = false;
            this.groupBoxCriteria.Text = "Critério";
            // 
            // checkBoxGruposTodos
            // 
            this.checkBoxGruposTodos.AutoSize = true;
            this.checkBoxGruposTodos.Checked = true;
            this.checkBoxGruposTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGruposTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGruposTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxGruposTodos.Location = new System.Drawing.Point(212, 25);
            this.checkBoxGruposTodos.Name = "checkBoxGruposTodos";
            this.checkBoxGruposTodos.Size = new System.Drawing.Size(156, 27);
            this.checkBoxGruposTodos.TabIndex = 18;
            this.checkBoxGruposTodos.Text = "Todos os grupos";
            this.checkBoxGruposTodos.UseVisualStyleBackColor = true;
            this.checkBoxGruposTodos.CheckedChanged += new System.EventHandler(this.checkBoxGruposTodos_CheckedChanged);
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvContas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContas.AutoGenerateColumns = false;
            this.dgvContas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.ColumnHeadersVisible = false;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionadaDataGridViewCheckBoxColumn,
            this.apelidoDataGridViewTextBoxColumn});
            this.dgvContas.DataSource = this.bsContas;
            this.dgvContas.Location = new System.Drawing.Point(24, 55);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.RowHeadersVisible = false;
            this.dgvContas.RowHeadersWidth = 25;
            this.dgvContas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvContas.RowTemplate.Height = 24;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(172, 149);
            this.dgvContas.TabIndex = 17;
            this.dgvContas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellEndEdit);
            // 
            // checkBoxAfetaSaldo
            // 
            this.checkBoxAfetaSaldo.AutoSize = true;
            this.checkBoxAfetaSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAfetaSaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxAfetaSaldo.Location = new System.Drawing.Point(22, 289);
            this.checkBoxAfetaSaldo.Name = "checkBoxAfetaSaldo";
            this.checkBoxAfetaSaldo.Size = new System.Drawing.Size(331, 27);
            this.checkBoxAfetaSaldo.TabIndex = 8;
            this.checkBoxAfetaSaldo.Text = "Incluir apenas itens que afetam o saldo";
            this.checkBoxAfetaSaldo.UseVisualStyleBackColor = true;
            this.checkBoxAfetaSaldo.CheckedChanged += new System.EventHandler(this.checkBoxAfetaSaldo_CheckedChanged);
            // 
            // labelContas
            // 
            this.labelContas.AutoSize = true;
            this.labelContas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContas.Location = new System.Drawing.Point(25, 26);
            this.labelContas.Name = "labelContas";
            this.labelContas.Size = new System.Drawing.Size(63, 23);
            this.labelContas.TabIndex = 7;
            this.labelContas.Text = "Contas";
            // 
            // checkedListBoxGrupos
            // 
            this.checkedListBoxGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkedListBoxGrupos.Enabled = false;
            this.checkedListBoxGrupos.ForeColor = System.Drawing.Color.Black;
            this.checkedListBoxGrupos.FormattingEnabled = true;
            this.checkedListBoxGrupos.Location = new System.Drawing.Point(212, 54);
            this.checkedListBoxGrupos.Name = "checkedListBoxGrupos";
            this.checkedListBoxGrupos.Size = new System.Drawing.Size(171, 229);
            this.checkedListBoxGrupos.TabIndex = 6;
            this.checkedListBoxGrupos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxGrupos_ItemCheck);
            // 
            // labelCount
            // 
            this.labelCount.BackColor = System.Drawing.Color.SteelBlue;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCount.Location = new System.Drawing.Point(22, 321);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(356, 42);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "count";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDataTermino
            // 
            this.labelDataTermino.AutoSize = true;
            this.labelDataTermino.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDataTermino.Location = new System.Drawing.Point(20, 259);
            this.labelDataTermino.Name = "labelDataTermino";
            this.labelDataTermino.Size = new System.Drawing.Size(36, 23);
            this.labelDataTermino.TabIndex = 4;
            this.labelDataTermino.Text = "Até";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDataInicio.Location = new System.Drawing.Point(20, 227);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(31, 23);
            this.labelDataInicio.TabIndex = 3;
            this.labelDataInicio.Text = "De";
            this.labelDataInicio.Click += new System.EventHandler(this.labelDataInicio_Click);
            // 
            // dtpTermino
            // 
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(58, 253);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(118, 30);
            this.dtpTermino.TabIndex = 1;
            this.dtpTermino.ValueChanged += new System.EventHandler(this.dtpickers_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(58, 221);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(118, 30);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpickers_ValueChanged);
            // 
            // bsContas
            // 
            this.bsContas.DataSource = typeof(DataLayer.Conta);
            // 
            // selecionadaDataGridViewCheckBoxColumn
            // 
            this.selecionadaDataGridViewCheckBoxColumn.DataPropertyName = "Selecionada";
            this.selecionadaDataGridViewCheckBoxColumn.HeaderText = "Selecionada";
            this.selecionadaDataGridViewCheckBoxColumn.Name = "selecionadaDataGridViewCheckBoxColumn";
            this.selecionadaDataGridViewCheckBoxColumn.Width = 30;
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            this.apelidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apelidoDataGridViewTextBoxColumn.DataPropertyName = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 528);
            this.Controls.Add(this.groupBoxCriteria);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExport);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExport_FormClosing);
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCriteria.ResumeLayout(false);
            this.groupBoxCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonExcel;
        private System.Windows.Forms.RadioButton radioButtonXML;
        private System.Windows.Forms.RadioButton radioButtonCSV;
        private System.Windows.Forms.RadioButton radioButtonExtrato;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.GroupBox groupBoxCriteria;
        private System.Windows.Forms.Label labelDataTermino;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.CheckedListBox checkedListBoxGrupos;
        private System.Windows.Forms.Label labelContas;
        private System.Windows.Forms.CheckBox checkBoxAfetaSaldo;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.CheckBox checkBoxGruposTodos;
        private System.Windows.Forms.RadioButton radioButtonExcel2;
        private System.Windows.Forms.BindingSource bsContas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
    }
}