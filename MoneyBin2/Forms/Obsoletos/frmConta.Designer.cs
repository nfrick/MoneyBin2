namespace MoneyBin2 {
    partial class frmConta {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApelido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDono = new System.Windows.Forms.TextBox();
            this.textBoxContaCorrenteDV = new System.Windows.Forms.TextBox();
            this.textBoxGerente = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.maskedTextBoxAgencia = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAgenciaDV = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxContaCorrente = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxOperacao = new System.Windows.Forms.MaskedTextBox();
            this.labelBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(501, 71);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(501, 12);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apelido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Agência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Conta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Operação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gerente";
            // 
            // textBoxApelido
            // 
            this.textBoxApelido.Location = new System.Drawing.Point(126, 71);
            this.textBoxApelido.Name = "textBoxApelido";
            this.textBoxApelido.Size = new System.Drawing.Size(100, 34);
            this.textBoxApelido.TabIndex = 0;
            this.textBoxApelido.Tag = "Apelido";
            this.textBoxApelido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApelido_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "E-Mail";
            // 
            // textBoxDono
            // 
            this.textBoxDono.Location = new System.Drawing.Point(126, 114);
            this.textBoxDono.Name = "textBoxDono";
            this.textBoxDono.Size = new System.Drawing.Size(100, 34);
            this.textBoxDono.TabIndex = 1;
            this.textBoxDono.Tag = "Dono";
            this.textBoxDono.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDono_Validating);
            // 
            // textBoxContaCorrenteDV
            // 
            this.textBoxContaCorrenteDV.Location = new System.Drawing.Point(232, 200);
            this.textBoxContaCorrenteDV.Name = "textBoxContaCorrenteDV";
            this.textBoxContaCorrenteDV.Size = new System.Drawing.Size(42, 34);
            this.textBoxContaCorrenteDV.TabIndex = 5;
            this.textBoxContaCorrenteDV.Tag = "Conta Corrente DV";
            this.textBoxContaCorrenteDV.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContaCorrenteDV_Validating);
            // 
            // textBoxGerente
            // 
            this.textBoxGerente.Location = new System.Drawing.Point(126, 243);
            this.textBoxGerente.Name = "textBoxGerente";
            this.textBoxGerente.Size = new System.Drawing.Size(323, 34);
            this.textBoxGerente.TabIndex = 7;
            this.textBoxGerente.Tag = "Gerente";
            this.textBoxGerente.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxGerente_Validating);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(126, 286);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(127, 34);
            this.textBoxTelefone.TabIndex = 8;
            this.textBoxTelefone.Tag = "Telefone";
            this.textBoxTelefone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefone_Validating);
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(126, 372);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(323, 34);
            this.textBoxEMail.TabIndex = 10;
            this.textBoxEMail.Tag = "E-Mail";
            this.textBoxEMail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEMail_Validating);
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(126, 329);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(127, 34);
            this.textBoxCelular.TabIndex = 9;
            this.textBoxCelular.Tag = "Celular";
            this.textBoxCelular.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCelular_Validating);
            // 
            // maskedTextBoxAgencia
            // 
            this.maskedTextBoxAgencia.Location = new System.Drawing.Point(126, 157);
            this.maskedTextBoxAgencia.Mask = "0000000000";
            this.maskedTextBoxAgencia.Name = "maskedTextBoxAgencia";
            this.maskedTextBoxAgencia.Size = new System.Drawing.Size(100, 34);
            this.maskedTextBoxAgencia.TabIndex = 2;
            this.maskedTextBoxAgencia.Tag = "Agência";
            this.maskedTextBoxAgencia.ValidatingType = typeof(int);
            this.maskedTextBoxAgencia.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxAgencia_Validating);
            // 
            // maskedTextBoxAgenciaDV
            // 
            this.maskedTextBoxAgenciaDV.Location = new System.Drawing.Point(232, 157);
            this.maskedTextBoxAgenciaDV.Mask = "0";
            this.maskedTextBoxAgenciaDV.Name = "maskedTextBoxAgenciaDV";
            this.maskedTextBoxAgenciaDV.Size = new System.Drawing.Size(42, 34);
            this.maskedTextBoxAgenciaDV.TabIndex = 3;
            this.maskedTextBoxAgenciaDV.Tag = "Agência DV";
            this.maskedTextBoxAgenciaDV.ValidatingType = typeof(int);
            this.maskedTextBoxAgenciaDV.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxAgenciaDV_Validating);
            // 
            // maskedTextBoxContaCorrente
            // 
            this.maskedTextBoxContaCorrente.Location = new System.Drawing.Point(126, 200);
            this.maskedTextBoxContaCorrente.Mask = "0000000000";
            this.maskedTextBoxContaCorrente.Name = "maskedTextBoxContaCorrente";
            this.maskedTextBoxContaCorrente.Size = new System.Drawing.Size(100, 34);
            this.maskedTextBoxContaCorrente.TabIndex = 4;
            this.maskedTextBoxContaCorrente.Tag = "Conta Corrente";
            this.maskedTextBoxContaCorrente.ValidatingType = typeof(int);
            this.maskedTextBoxContaCorrente.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxContaCorrente_Validating);
            // 
            // maskedTextBoxOperacao
            // 
            this.maskedTextBoxOperacao.Location = new System.Drawing.Point(393, 200);
            this.maskedTextBoxOperacao.Mask = "000";
            this.maskedTextBoxOperacao.Name = "maskedTextBoxOperacao";
            this.maskedTextBoxOperacao.Size = new System.Drawing.Size(56, 34);
            this.maskedTextBoxOperacao.TabIndex = 6;
            this.maskedTextBoxOperacao.Tag = "Operação";
            this.maskedTextBoxOperacao.ValidatingType = typeof(int);
            this.maskedTextBoxOperacao.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxOperacao_Validating);
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanco.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelBanco.Location = new System.Drawing.Point(24, 30);
            this.labelBanco.Name = "labelBanco";
            this.labelBanco.Size = new System.Drawing.Size(70, 28);
            this.labelBanco.TabIndex = 22;
            this.labelBanco.Text = "Banco";
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.ClientSize = new System.Drawing.Size(642, 429);
            this.Controls.Add(this.labelBanco);
            this.Controls.Add(this.maskedTextBoxOperacao);
            this.Controls.Add(this.maskedTextBoxContaCorrente);
            this.Controls.Add(this.maskedTextBoxAgenciaDV);
            this.Controls.Add(this.maskedTextBoxAgencia);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxCelular);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxGerente);
            this.Controls.Add(this.textBoxContaCorrenteDV);
            this.Controls.Add(this.textBoxDono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxApelido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConta";
            this.Text = "Conta Corrente";
            this.Load += new System.EventHandler(this.frmConta_Load);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBoxApelido, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.textBoxDono, 0);
            this.Controls.SetChildIndex(this.textBoxContaCorrenteDV, 0);
            this.Controls.SetChildIndex(this.textBoxGerente, 0);
            this.Controls.SetChildIndex(this.textBoxTelefone, 0);
            this.Controls.SetChildIndex(this.textBoxCelular, 0);
            this.Controls.SetChildIndex(this.textBoxEMail, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxAgencia, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxAgenciaDV, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxContaCorrente, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxOperacao, 0);
            this.Controls.SetChildIndex(this.labelBanco, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApelido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDono;
        private System.Windows.Forms.TextBox textBoxContaCorrenteDV;
        private System.Windows.Forms.TextBox textBoxGerente;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAgencia;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAgenciaDV;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContaCorrente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOperacao;
        private System.Windows.Forms.Label labelBanco;
    }
}
