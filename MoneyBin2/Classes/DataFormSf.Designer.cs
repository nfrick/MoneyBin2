namespace MoneyBin2 {
    partial class DataFormSf {
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
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAdded = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDeleted = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorSave = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRevert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorUndo = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1100, 471);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1100, 523);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.BackColor = System.Drawing.Color.Silver;
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripMenu);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRecords,
            this.toolStripStatusLabelAdded,
            this.toolStripStatusLabelUpdated,
            this.toolStripStatusLabelDeleted});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1100, 25);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripStatusLabelRecords
            // 
            this.toolStripStatusLabelRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabelRecords.Name = "toolStripStatusLabelRecords";
            this.toolStripStatusLabelRecords.Size = new System.Drawing.Size(73, 20);
            this.toolStripStatusLabelRecords.Text = "Registros:";
            // 
            // toolStripStatusLabelAdded
            // 
            this.toolStripStatusLabelAdded.Name = "toolStripStatusLabelAdded";
            this.toolStripStatusLabelAdded.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabelAdded.Text = "Novos:";
            // 
            // toolStripStatusLabelUpdated
            // 
            this.toolStripStatusLabelUpdated.Name = "toolStripStatusLabelUpdated";
            this.toolStripStatusLabelUpdated.Size = new System.Drawing.Size(90, 20);
            this.toolStripStatusLabelUpdated.Text = "Atualizados:";
            // 
            // toolStripStatusLabelDeleted
            // 
            this.toolStripStatusLabelDeleted.Name = "toolStripStatusLabelDeleted";
            this.toolStripStatusLabelDeleted.Size = new System.Drawing.Size(80, 20);
            this.toolStripStatusLabelDeleted.Text = "Deletados:";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparatorSave,
            this.tsbRevert,
            this.toolStripSeparatorUndo});
            this.toolStripMenu.Location = new System.Drawing.Point(3, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(188, 27);
            this.toolStripMenu.TabIndex = 0;
            // 
            // tsbSave
            // 
            this.tsbSave.BackColor = System.Drawing.Color.PaleGreen;
            this.tsbSave.ForeColor = System.Drawing.Color.Black;
            this.tsbSave.Image = global::MoneyBin2.Properties.Resources.Disquete;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(73, 24);
            this.tsbSave.Tag = "Save";
            this.tsbSave.Text = "Salvar";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparatorSave
            // 
            this.toolStripSeparatorSave.Name = "toolStripSeparatorSave";
            this.toolStripSeparatorSave.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparatorSave.Tag = "Save";
            // 
            // tsbRevert
            // 
            this.tsbRevert.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tsbRevert.ForeColor = System.Drawing.Color.Black;
            this.tsbRevert.Image = global::MoneyBin2.Properties.Resources.Revert_24;
            this.tsbRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRevert.Name = "tsbRevert";
            this.tsbRevert.Size = new System.Drawing.Size(91, 24);
            this.tsbRevert.Tag = "Save";
            this.tsbRevert.Text = "Desfazer";
            this.tsbRevert.Click += new System.EventHandler(this.tsbRevert_Click);
            // 
            // toolStripSeparatorUndo
            // 
            this.toolStripSeparatorUndo.Name = "toolStripSeparatorUndo";
            this.toolStripSeparatorUndo.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparatorUndo.Tag = "Save";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1100, 523);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRecords;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAdded;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUpdated;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDeleted;
        protected System.Windows.Forms.ToolStripButton tsbSave;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparatorSave;
        protected System.Windows.Forms.ToolStripButton tsbRevert;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparatorUndo;
        protected System.Windows.Forms.StatusStrip statusStrip;
        protected System.Windows.Forms.ToolStrip toolStripMenu;
        protected System.Windows.Forms.ToolStripContainer toolStripContainer;
    }
}