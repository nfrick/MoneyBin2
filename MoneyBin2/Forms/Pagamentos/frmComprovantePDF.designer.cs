﻿namespace MoneyBin2 {
    partial class frmComprovantePDF {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelValorNumero = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPagamentoData = new System.Windows.Forms.Label();
            this.labelPagamento = new System.Windows.Forms.Label();
            this.panelAgendamento = new System.Windows.Forms.Panel();
            this.labelAgendamentoData = new System.Windows.Forms.Label();
            this.labelAgendamento = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPDF = new System.Windows.Forms.TextBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAgendamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPDF, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHeader, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 607);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelAgendamento);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 271);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::MoneyBin2.Properties.Resources.Pula_24;
            this.button1.Location = new System.Drawing.Point(186, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pula";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.labelValorNumero);
            this.panel3.Controls.Add(this.labelValor);
            this.panel3.Location = new System.Drawing.Point(17, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 55);
            this.panel3.TabIndex = 18;
            // 
            // labelValorNumero
            // 
            this.labelValorNumero.AutoSize = true;
            this.labelValorNumero.BackColor = System.Drawing.Color.Transparent;
            this.labelValorNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorNumero.ForeColor = System.Drawing.Color.White;
            this.labelValorNumero.Location = new System.Drawing.Point(215, 9);
            this.labelValorNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorNumero.Name = "labelValorNumero";
            this.labelValorNumero.Size = new System.Drawing.Size(79, 37);
            this.labelValorNumero.TabIndex = 11;
            this.labelValorNumero.Text = "Valor";
            this.labelValorNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelValorNumero.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.BackColor = System.Drawing.Color.Transparent;
            this.labelValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.White;
            this.labelValor.Location = new System.Drawing.Point(9, 9);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(78, 37);
            this.labelValor.TabIndex = 10;
            this.labelValor.Text = "Valor";
            this.labelValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelPagamentoData);
            this.panel2.Controls.Add(this.labelPagamento);
            this.panel2.Location = new System.Drawing.Point(17, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 55);
            this.panel2.TabIndex = 17;
            // 
            // labelPagamentoData
            // 
            this.labelPagamentoData.AutoSize = true;
            this.labelPagamentoData.BackColor = System.Drawing.Color.Transparent;
            this.labelPagamentoData.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagamentoData.ForeColor = System.Drawing.Color.White;
            this.labelPagamentoData.Location = new System.Drawing.Point(215, 9);
            this.labelPagamentoData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPagamentoData.Name = "labelPagamentoData";
            this.labelPagamentoData.Size = new System.Drawing.Size(156, 37);
            this.labelPagamentoData.TabIndex = 11;
            this.labelPagamentoData.Text = "Pagamento";
            this.labelPagamentoData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPagamentoData.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // labelPagamento
            // 
            this.labelPagamento.AutoSize = true;
            this.labelPagamento.BackColor = System.Drawing.Color.Transparent;
            this.labelPagamento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagamento.ForeColor = System.Drawing.Color.White;
            this.labelPagamento.Location = new System.Drawing.Point(9, 9);
            this.labelPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPagamento.Name = "labelPagamento";
            this.labelPagamento.Size = new System.Drawing.Size(152, 37);
            this.labelPagamento.TabIndex = 10;
            this.labelPagamento.Text = "Pagamento";
            this.labelPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAgendamento
            // 
            this.panelAgendamento.BackColor = System.Drawing.Color.DarkGreen;
            this.panelAgendamento.Controls.Add(this.labelAgendamentoData);
            this.panelAgendamento.Controls.Add(this.labelAgendamento);
            this.panelAgendamento.Location = new System.Drawing.Point(17, 16);
            this.panelAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.panelAgendamento.Name = "panelAgendamento";
            this.panelAgendamento.Size = new System.Drawing.Size(497, 55);
            this.panelAgendamento.TabIndex = 16;
            // 
            // labelAgendamentoData
            // 
            this.labelAgendamentoData.AutoSize = true;
            this.labelAgendamentoData.BackColor = System.Drawing.Color.Transparent;
            this.labelAgendamentoData.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgendamentoData.ForeColor = System.Drawing.Color.White;
            this.labelAgendamentoData.Location = new System.Drawing.Point(215, 9);
            this.labelAgendamentoData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgendamentoData.Name = "labelAgendamentoData";
            this.labelAgendamentoData.Size = new System.Drawing.Size(265, 37);
            this.labelAgendamentoData.TabIndex = 11;
            this.labelAgendamentoData.Text = "NÃO ENCONTRADO";
            this.labelAgendamentoData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAgendamentoData.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // labelAgendamento
            // 
            this.labelAgendamento.AutoSize = true;
            this.labelAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.labelAgendamento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgendamento.ForeColor = System.Drawing.Color.White;
            this.labelAgendamento.Location = new System.Drawing.Point(9, 9);
            this.labelAgendamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgendamento.Name = "labelAgendamento";
            this.labelAgendamento.Size = new System.Drawing.Size(186, 37);
            this.labelAgendamento.TabIndex = 10;
            this.labelAgendamento.Text = "Agendamento";
            this.labelAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Image = global::MoneyBin2.Properties.Resources.Yes_24;
            this.buttonOK.Location = new System.Drawing.Point(17, 215);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(161, 47);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Confirma";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = global::MoneyBin2.Properties.Resources.No_24;
            this.buttonCancel.Location = new System.Drawing.Point(355, 215);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 47);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancela";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxPDF
            // 
            this.textBoxPDF.BackColor = System.Drawing.Color.Black;
            this.textBoxPDF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPDF.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPDF.ForeColor = System.Drawing.Color.White;
            this.textBoxPDF.Location = new System.Drawing.Point(544, 53);
            this.textBoxPDF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPDF.Multiline = true;
            this.textBoxPDF.Name = "textBoxPDF";
            this.tableLayoutPanel1.SetRowSpan(this.textBoxPDF, 2);
            this.textBoxPDF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPDF.Size = new System.Drawing.Size(755, 550);
            this.textBoxPDF.TabIndex = 0;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BackColor = System.Drawing.Color.Black;
            this.listBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiles.ForeColor = System.Drawing.Color.White;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 28;
            this.listBoxFiles.Location = new System.Drawing.Point(4, 53);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(532, 271);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHeader, 2);
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(4, 0);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1295, 49);
            this.labelHeader.TabIndex = 12;
            this.labelHeader.Text = "label2";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComprovantePDF
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1303, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmComprovantePDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pagamento em PDF";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAgendamento.ResumeLayout(false);
            this.panelAgendamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPDF;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAgendamento;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelAgendamento;
        private System.Windows.Forms.Label labelAgendamentoData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelValorNumero;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPagamentoData;
        private System.Windows.Forms.Label labelPagamento;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button button1;
    }
}