﻿namespace MoneyBin2 {
    partial class frmEditarOperacao {
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
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAtivo = new System.Windows.Forms.ComboBox();
            this.comboBoxOperacao = new System.Windows.Forms.ComboBox();
            this.labelAtivo = new System.Windows.Forms.Label();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelImpostos = new System.Windows.Forms.Label();
            this.nudCustoOperacao = new System.Windows.Forms.NumericUpDown();
            this.labelReal = new System.Windows.Forms.Label();
            this.labelQtdReal = new System.Windows.Forms.Label();
            this.nudValorReal = new System.Windows.Forms.NumericUpDown();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.labelValorNominal = new System.Windows.Forms.Label();
            this.nudValorNominal = new System.Windows.Forms.NumericUpDown();
            this.labelTotalNominal = new System.Windows.Forms.Label();
            this.labelTotalReal = new System.Windows.Forms.Label();
            this.buttonNovoCodigo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustoOperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorNominal)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerData.Location = new System.Drawing.Point(144, 93);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.ShowUpDown = true;
            this.dateTimePickerData.Size = new System.Drawing.Size(139, 30);
            this.dateTimePickerData.TabIndex = 2;
            // 
            // comboBoxAtivo
            // 
            this.comboBoxAtivo.FormattingEnabled = true;
            this.comboBoxAtivo.Location = new System.Drawing.Point(144, 19);
            this.comboBoxAtivo.Name = "comboBoxAtivo";
            this.comboBoxAtivo.Size = new System.Drawing.Size(139, 31);
            this.comboBoxAtivo.TabIndex = 0;
            this.comboBoxAtivo.SelectedValueChanged += new System.EventHandler(this.combos_ValueChanged);
            this.comboBoxAtivo.TextChanged += new System.EventHandler(this.combos_ValueChanged);
            // 
            // comboBoxOperacao
            // 
            this.comboBoxOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperacao.FormattingEnabled = true;
            this.comboBoxOperacao.Location = new System.Drawing.Point(143, 56);
            this.comboBoxOperacao.Name = "comboBoxOperacao";
            this.comboBoxOperacao.Size = new System.Drawing.Size(139, 31);
            this.comboBoxOperacao.TabIndex = 1;
            this.comboBoxOperacao.SelectedValueChanged += new System.EventHandler(this.combos_ValueChanged);
            this.comboBoxOperacao.TextChanged += new System.EventHandler(this.combos_ValueChanged);
            // 
            // labelAtivo
            // 
            this.labelAtivo.AutoSize = true;
            this.labelAtivo.BackColor = System.Drawing.Color.Transparent;
            this.labelAtivo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAtivo.Location = new System.Drawing.Point(17, 22);
            this.labelAtivo.Name = "labelAtivo";
            this.labelAtivo.Size = new System.Drawing.Size(49, 23);
            this.labelAtivo.TabIndex = 9;
            this.labelAtivo.Text = "Ativo";
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.BackColor = System.Drawing.Color.Transparent;
            this.labelOperacao.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOperacao.Location = new System.Drawing.Point(17, 59);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(84, 23);
            this.labelOperacao.TabIndex = 10;
            this.labelOperacao.Text = "Operação";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.ForeColor = System.Drawing.SystemColors.Control;
            this.labelData.Location = new System.Drawing.Point(17, 99);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(46, 23);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Data";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOK.Location = new System.Drawing.Point(366, 22);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(55, 42);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "ü";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Location = new System.Drawing.Point(366, 70);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(55, 42);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "û";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelImpostos
            // 
            this.labelImpostos.AutoSize = true;
            this.labelImpostos.BackColor = System.Drawing.Color.Transparent;
            this.labelImpostos.ForeColor = System.Drawing.SystemColors.Control;
            this.labelImpostos.Location = new System.Drawing.Point(17, 241);
            this.labelImpostos.Name = "labelImpostos";
            this.labelImpostos.Size = new System.Drawing.Size(133, 23);
            this.labelImpostos.TabIndex = 15;
            this.labelImpostos.Text = "Custo Operação";
            // 
            // nudCustoOperacao
            // 
            this.nudCustoOperacao.DecimalPlaces = 2;
            this.nudCustoOperacao.Enabled = false;
            this.nudCustoOperacao.Location = new System.Drawing.Point(144, 237);
            this.nudCustoOperacao.Name = "nudCustoOperacao";
            this.nudCustoOperacao.Size = new System.Drawing.Size(139, 30);
            this.nudCustoOperacao.TabIndex = 6;
            this.nudCustoOperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCustoOperacao.ThousandsSeparator = true;
            this.nudCustoOperacao.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.BackColor = System.Drawing.Color.Transparent;
            this.labelReal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelReal.Location = new System.Drawing.Point(17, 203);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(86, 23);
            this.labelReal.TabIndex = 14;
            this.labelReal.Text = "Valor Real";
            // 
            // labelQtdReal
            // 
            this.labelQtdReal.AutoSize = true;
            this.labelQtdReal.BackColor = System.Drawing.Color.Transparent;
            this.labelQtdReal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelQtdReal.Location = new System.Drawing.Point(17, 136);
            this.labelQtdReal.Name = "labelQtdReal";
            this.labelQtdReal.Size = new System.Drawing.Size(39, 23);
            this.labelQtdReal.TabIndex = 12;
            this.labelQtdReal.Text = "Qtd";
            // 
            // nudValorReal
            // 
            this.nudValorReal.DecimalPlaces = 2;
            this.nudValorReal.Location = new System.Drawing.Point(144, 201);
            this.nudValorReal.Name = "nudValorReal";
            this.nudValorReal.Size = new System.Drawing.Size(139, 30);
            this.nudValorReal.TabIndex = 5;
            this.nudValorReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudValorReal.ThousandsSeparator = true;
            this.nudValorReal.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.nudValorReal.Validated += new System.EventHandler(this.nudValor_Validated);
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(143, 129);
            this.nudQtd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(139, 30);
            this.nudQtd.TabIndex = 3;
            this.nudQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQtd.ThousandsSeparator = true;
            this.nudQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtd.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelValorNominal
            // 
            this.labelValorNominal.AutoSize = true;
            this.labelValorNominal.BackColor = System.Drawing.Color.Transparent;
            this.labelValorNominal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorNominal.Location = new System.Drawing.Point(17, 167);
            this.labelValorNominal.Name = "labelValorNominal";
            this.labelValorNominal.Size = new System.Drawing.Size(119, 23);
            this.labelValorNominal.TabIndex = 13;
            this.labelValorNominal.Text = "Valor Nominal";
            // 
            // nudValorNominal
            // 
            this.nudValorNominal.DecimalPlaces = 2;
            this.nudValorNominal.Location = new System.Drawing.Point(144, 165);
            this.nudValorNominal.Name = "nudValorNominal";
            this.nudValorNominal.Size = new System.Drawing.Size(139, 30);
            this.nudValorNominal.TabIndex = 4;
            this.nudValorNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudValorNominal.ThousandsSeparator = true;
            this.nudValorNominal.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.nudValorNominal.Validated += new System.EventHandler(this.nudValor_Validated);
            // 
            // labelTotalNominal
            // 
            this.labelTotalNominal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTotalNominal.Location = new System.Drawing.Point(289, 167);
            this.labelTotalNominal.Name = "labelTotalNominal";
            this.labelTotalNominal.Size = new System.Drawing.Size(132, 59);
            this.labelTotalNominal.TabIndex = 18;
            this.labelTotalNominal.Text = "labelValorNominal";
            // 
            // labelTotalReal
            // 
            this.labelTotalReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTotalReal.Location = new System.Drawing.Point(289, 207);
            this.labelTotalReal.Name = "labelTotalReal";
            this.labelTotalReal.Size = new System.Drawing.Size(132, 59);
            this.labelTotalReal.TabIndex = 19;
            this.labelTotalReal.Text = "labelValorReal";
            // 
            // buttonNovoCodigo
            // 
            this.buttonNovoCodigo.BackColor = System.Drawing.Color.Ivory;
            this.buttonNovoCodigo.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoCodigo.Image = global::MoneyBin2.Properties.Resources.Add_24;
            this.buttonNovoCodigo.Location = new System.Drawing.Point(289, 19);
            this.buttonNovoCodigo.Name = "buttonNovoCodigo";
            this.buttonNovoCodigo.Size = new System.Drawing.Size(39, 33);
            this.buttonNovoCodigo.TabIndex = 20;
            this.buttonNovoCodigo.UseVisualStyleBackColor = false;
            this.buttonNovoCodigo.Click += new System.EventHandler(this.buttonNovoCodigo_Click);
            // 
            // frmEditarOperacao
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(434, 288);
            this.Controls.Add(this.buttonNovoCodigo);
            this.Controls.Add(this.labelTotalReal);
            this.Controls.Add(this.labelTotalNominal);
            this.Controls.Add(this.labelValorNominal);
            this.Controls.Add(this.nudValorNominal);
            this.Controls.Add(this.labelReal);
            this.Controls.Add(this.labelQtdReal);
            this.Controls.Add(this.nudValorReal);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.labelImpostos);
            this.Controls.Add(this.nudCustoOperacao);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.labelAtivo);
            this.Controls.Add(this.comboBoxOperacao);
            this.Controls.Add(this.comboBoxAtivo);
            this.Controls.Add(this.dateTimePickerData);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar/Editar Operação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditarOperacao_FormClosing);
            this.Load += new System.EventHandler(this.EditarOperacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCustoOperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorNominal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ComboBox comboBoxAtivo;
        private System.Windows.Forms.Label labelAtivo;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.ComboBox comboBoxOperacao;
        private System.Windows.Forms.Label labelImpostos;
        private System.Windows.Forms.NumericUpDown nudCustoOperacao;
        private System.Windows.Forms.Label labelReal;
        private System.Windows.Forms.Label labelQtdReal;
        private System.Windows.Forms.NumericUpDown nudValorReal;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label labelValorNominal;
        private System.Windows.Forms.NumericUpDown nudValorNominal;
        private System.Windows.Forms.Label labelTotalNominal;
        private System.Windows.Forms.Label labelTotalReal;
        private System.Windows.Forms.Button buttonNovoCodigo;
    }
}