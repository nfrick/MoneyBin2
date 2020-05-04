namespace MoneyBin2 {
    partial class frmBanco {
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSigla = new System.Windows.Forms.Label();
            this.labelExtrato = new System.Windows.Forms.Label();
            this.labelFundos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFundos = new System.Windows.Forms.TextBox();
            this.textBoxExtrato = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSigla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(359, 92);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(359, 28);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(26, 35);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(66, 28);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(26, 79);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(55, 28);
            this.labelSigla.TabIndex = 3;
            this.labelSigla.Text = "Sigla";
            // 
            // labelExtrato
            // 
            this.labelExtrato.AutoSize = true;
            this.labelExtrato.Location = new System.Drawing.Point(33, 43);
            this.labelExtrato.Name = "labelExtrato";
            this.labelExtrato.Size = new System.Drawing.Size(74, 28);
            this.labelExtrato.TabIndex = 2;
            this.labelExtrato.Text = "Extrato";
            // 
            // labelFundos
            // 
            this.labelFundos.AutoSize = true;
            this.labelFundos.Location = new System.Drawing.Point(33, 86);
            this.labelFundos.Name = "labelFundos";
            this.labelFundos.Size = new System.Drawing.Size(76, 28);
            this.labelFundos.TabIndex = 3;
            this.labelFundos.Text = "Fundos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFundos);
            this.groupBox1.Controls.Add(this.textBoxExtrato);
            this.groupBox1.Controls.Add(this.labelExtrato);
            this.groupBox1.Controls.Add(this.labelFundos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(30, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extensões";
            // 
            // textBoxFundos
            // 
            this.textBoxFundos.Location = new System.Drawing.Point(124, 83);
            this.textBoxFundos.Name = "textBoxFundos";
            this.textBoxFundos.Size = new System.Drawing.Size(89, 34);
            this.textBoxFundos.TabIndex = 1;
            this.textBoxFundos.Tag = "Extensão de Fundos";
            this.textBoxFundos.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxExtensao_Validating);
            // 
            // textBoxExtrato
            // 
            this.textBoxExtrato.Location = new System.Drawing.Point(124, 40);
            this.textBoxExtrato.Name = "textBoxExtrato";
            this.textBoxExtrato.Size = new System.Drawing.Size(89, 34);
            this.textBoxExtrato.TabIndex = 0;
            this.textBoxExtrato.Tag = "Extensão do Extrato";
            this.textBoxExtrato.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxExtensao_Validating);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(98, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(224, 34);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.Tag = "Nome";
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            // 
            // textBoxSigla
            // 
            this.textBoxSigla.Location = new System.Drawing.Point(98, 76);
            this.textBoxSigla.Name = "textBoxSigla";
            this.textBoxSigla.Size = new System.Drawing.Size(78, 34);
            this.textBoxSigla.TabIndex = 1;
            this.textBoxSigla.Tag = "Sigla";
            this.textBoxSigla.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSigla_Validating);
            // 
            // frmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 297);
            this.Controls.Add(this.textBoxSigla);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.labelNome);
            this.Name = "frmBanco";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.frmBanco_Load);
            this.Controls.SetChildIndex(this.labelNome, 0);
            this.Controls.SetChildIndex(this.labelSigla, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.textBoxNome, 0);
            this.Controls.SetChildIndex(this.textBoxSigla, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSigla;
        private System.Windows.Forms.Label labelExtrato;
        private System.Windows.Forms.Label labelFundos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFundos;
        private System.Windows.Forms.TextBox textBoxExtrato;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSigla;
    }
}