namespace CEF_Rentabilidade2 {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelSpace = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProcessar = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.ControlText;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbText.Location = new System.Drawing.Point(0, 0);
            this.rtbText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(1706, 592);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            this.rtbText.WordWrap = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbText);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1706, 592);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1706, 624);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.DimGray;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonColar,
            this.toolStripButtonProcessar,
            this.toolStripLabelSpace});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(274, 32);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabelSpace
            // 
            this.toolStripLabelSpace.AutoSize = false;
            this.toolStripLabelSpace.Name = "toolStripLabelSpace";
            this.toolStripLabelSpace.Size = new System.Drawing.Size(50, 29);
            // 
            // toolStripButtonColar
            // 
            this.toolStripButtonColar.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonColar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonColar.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonColar.Image = global::CEF_Rentabilidade2.Properties.Resources.Paste_icon;
            this.toolStripButtonColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColar.Name = "toolStripButtonColar";
            this.toolStripButtonColar.Size = new System.Drawing.Size(81, 29);
            this.toolStripButtonColar.Text = "Colar";
            this.toolStripButtonColar.Click += new System.EventHandler(this.sfButtonColar_Click);
            // 
            // toolStripButtonProcessar
            // 
            this.toolStripButtonProcessar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonProcessar.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonProcessar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonProcessar.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonProcessar.Image = global::CEF_Rentabilidade2.Properties.Resources.Excel_icon;
            this.toolStripButtonProcessar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProcessar.Name = "toolStripButtonProcessar";
            this.toolStripButtonProcessar.Size = new System.Drawing.Size(92, 29);
            this.toolStripButtonProcessar.Text = "Gravar";
            this.toolStripButtonProcessar.Click += new System.EventHandler(this.sfButtonProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CaptionBarColor = System.Drawing.Color.CornflowerBlue;
            this.CaptionButtonColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1706, 624);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEF Rentabilidade";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonColar;
        private System.Windows.Forms.ToolStripButton toolStripButtonProcessar;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSpace;
    }
}

