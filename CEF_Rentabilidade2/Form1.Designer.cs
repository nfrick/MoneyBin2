using Ookii.Dialogs.WinForms;

namespace Rentabilidades {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskDialog = new Ookii.Dialogs.WinForms.TaskDialog(this.components);
            this._okTaskDialogButton = new Ookii.Dialogs.WinForms.TaskDialogButton(this.components);
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProcessarBB = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelSpace1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSpace2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonProcessarCEF = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBBMoneyBin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonCEFMoneyBin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskDialog
            // 
            this.taskDialog.Buttons.Add(this._okTaskDialogButton);
            this.taskDialog.EnableHyperlinks = true;
            this.taskDialog.FooterIcon = Ookii.Dialogs.WinForms.TaskDialogIcon.Information;
            this.taskDialog.WindowTitle = "Rentabilidades";
            // 
            // _okTaskDialogButton
            // 
            this._okTaskDialogButton.ButtonType = Ookii.Dialogs.WinForms.ButtonType.Ok;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.ControlText;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbText.Location = new System.Drawing.Point(0, 0);
            this.rtbText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(1193, 592);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1193, 592);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1193, 624);
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
            this.toolStripButtonProcessarBB,
            this.toolStripLabelSpace1,
            this.toolStripLabelSpace2,
            this.toolStripButtonProcessarCEF,
            this.toolStripButtonBBMoneyBin,
            this.toolStripLabel1,
            this.toolStripButtonCEFMoneyBin,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(949, 32);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonColar
            // 
            this.toolStripButtonColar.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonColar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonColar.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonColar.Image = global::Rentabilidades.Properties.Resources.Paste_icon;
            this.toolStripButtonColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColar.Name = "toolStripButtonColar";
            this.toolStripButtonColar.Size = new System.Drawing.Size(81, 29);
            this.toolStripButtonColar.Text = "Colar";
            this.toolStripButtonColar.Click += new System.EventHandler(this.toolStripButtonColar_Click);
            // 
            // toolStripButtonProcessarBB
            // 
            this.toolStripButtonProcessarBB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonProcessarBB.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonProcessarBB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonProcessarBB.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonProcessarBB.Image = global::Rentabilidades.Properties.Resources.BB;
            this.toolStripButtonProcessarBB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProcessarBB.Name = "toolStripButtonProcessarBB";
            this.toolStripButtonProcessarBB.Size = new System.Drawing.Size(119, 29);
            this.toolStripButtonProcessarBB.Text = "Gravar BB";
            this.toolStripButtonProcessarBB.Click += new System.EventHandler(this.toolStripButtonProcessBB_Click);
            // 
            // toolStripLabelSpace1
            // 
            this.toolStripLabelSpace1.AutoSize = false;
            this.toolStripLabelSpace1.Name = "toolStripLabelSpace1";
            this.toolStripLabelSpace1.Size = new System.Drawing.Size(50, 29);
            // 
            // toolStripLabelSpace2
            // 
            this.toolStripLabelSpace2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelSpace2.AutoSize = false;
            this.toolStripLabelSpace2.Name = "toolStripLabelSpace2";
            this.toolStripLabelSpace2.Size = new System.Drawing.Size(50, 29);
            // 
            // toolStripButtonProcessarCEF
            // 
            this.toolStripButtonProcessarCEF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonProcessarCEF.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonProcessarCEF.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonProcessarCEF.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonProcessarCEF.Image = global::Rentabilidades.Properties.Resources.CEF;
            this.toolStripButtonProcessarCEF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProcessarCEF.Name = "toolStripButtonProcessarCEF";
            this.toolStripButtonProcessarCEF.Size = new System.Drawing.Size(128, 29);
            this.toolStripButtonProcessarCEF.Text = "Gravar CEF";
            this.toolStripButtonProcessarCEF.Click += new System.EventHandler(this.toolStripButtonProcessCEF_Click);
            // 
            // toolStripButtonBBMoneyBin
            // 
            this.toolStripButtonBBMoneyBin.BackColor = System.Drawing.Color.Yellow;
            this.toolStripButtonBBMoneyBin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonBBMoneyBin.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButtonBBMoneyBin.Image = global::Rentabilidades.Properties.Resources.BB;
            this.toolStripButtonBBMoneyBin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBBMoneyBin.Name = "toolStripButtonBBMoneyBin";
            this.toolStripButtonBBMoneyBin.Size = new System.Drawing.Size(156, 29);
            this.toolStripButtonBBMoneyBin.Text = "BB MoneyBin";
            this.toolStripButtonBBMoneyBin.Click += new System.EventHandler(this.toolStripButtonBBMoneyBin_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 29);
            // 
            // toolStripButtonCEFMoneyBin
            // 
            this.toolStripButtonCEFMoneyBin.BackColor = System.Drawing.Color.Blue;
            this.toolStripButtonCEFMoneyBin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonCEFMoneyBin.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButtonCEFMoneyBin.Image = global::Rentabilidades.Properties.Resources.CEF;
            this.toolStripButtonCEFMoneyBin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCEFMoneyBin.Name = "toolStripButtonCEFMoneyBin";
            this.toolStripButtonCEFMoneyBin.Size = new System.Drawing.Size(164, 29);
            this.toolStripButtonCEFMoneyBin.Text = "CEF MoneyBin";
            this.toolStripButtonCEFMoneyBin.Click += new System.EventHandler(this.toolStripButtonCEFMoneyBin_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 29);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.CaptionBarColor = System.Drawing.Color.CornflowerBlue;
            this.CaptionButtonColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 624);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonProcessarCEF;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSpace1;
        private System.Windows.Forms.ToolStripButton toolStripButtonProcessarBB;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSpace2;
        private TaskDialog taskDialog;
        private TaskDialogButton _okTaskDialogButton;
        private System.Windows.Forms.ToolStripButton toolStripButtonBBMoneyBin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCEFMoneyBin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

