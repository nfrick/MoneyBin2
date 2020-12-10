namespace MoneyBin2 {
    partial class frmBalanceSF {
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
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            this.dgvBalance = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.cmsPopMenu = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.dgvBalance);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1924, 450);
            this.toolStripContainer.Size = new System.Drawing.Size(1924, 502);
            this.toolStripContainer.TopToolStripPanelVisible = true;
            // 
            // dgvBalance
            // 
            this.dgvBalance.AccessibleName = "Table";
            this.dgvBalance.AllowFiltering = true;
            this.dgvBalance.AllowGrouping = false;
            this.dgvBalance.AllowResizingColumns = true;
            this.dgvBalance.AllowTriStateSorting = true;
            this.dgvBalance.BackColor = System.Drawing.Color.Black;
            this.dgvBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvBalance.Location = new System.Drawing.Point(0, 0);
            this.dgvBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.PreviewRowHeight = 35;
            this.dgvBalance.ShowGroupDropArea = true;
            this.dgvBalance.Size = new System.Drawing.Size(1924, 450);
            this.dgvBalance.Style.CaptionSummaryRowStyle.BackColor = System.Drawing.Color.Black;
            this.dgvBalance.Style.CaptionSummaryRowStyle.ExpanderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvBalance.Style.CaptionSummaryRowStyle.Font.Bold = false;
            this.dgvBalance.Style.CaptionSummaryRowStyle.Font.Facename = "Segoe UI";
            this.dgvBalance.Style.CaptionSummaryRowStyle.Font.Size = 12F;
            this.dgvBalance.Style.CaptionSummaryRowStyle.TextColor = System.Drawing.Color.Yellow;
            this.dgvBalance.Style.CaptionSummaryRowStyle.TextMargins = new System.Windows.Forms.Padding(0);
            this.dgvBalance.Style.CellStyle.BackColor = System.Drawing.Color.Black;
            gridBordersInfo1.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            gridBordersInfo1.Left = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            gridBordersInfo1.Right = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            gridBordersInfo1.Top = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            this.dgvBalance.Style.CellStyle.Borders = gridBordersInfo1;
            this.dgvBalance.Style.CellStyle.Font.Facename = "Segoe UI";
            this.dgvBalance.Style.CellStyle.Font.Size = 12F;
            this.dgvBalance.Style.CellStyle.TextColor = System.Drawing.Color.White;
            this.dgvBalance.Style.GroupSummaryRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBalance.Style.GroupSummaryRowStyle.Font.Bold = true;
            this.dgvBalance.Style.GroupSummaryRowStyle.Font.Facename = "Segoe UI";
            this.dgvBalance.Style.GroupSummaryRowStyle.Font.Size = 12F;
            this.dgvBalance.Style.GroupSummaryRowStyle.TextColor = System.Drawing.Color.Yellow;
            this.dgvBalance.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvBalance.TabIndex = 0;
            this.dgvBalance.Text = "Balance";
            this.dgvBalance.QueryCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventHandler(this.dgvBalance_QueryCellStyle);
            this.dgvBalance.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvBalance_CellClick);
            this.dgvBalance.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.dgvBalance_CurrentCellEndEdit);
            // 
            // cmsPopMenu
            // 
            this.cmsPopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPopMenu.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.cmsPopMenu.Name = "cmsPopMenu";
            this.cmsPopMenu.Size = new System.Drawing.Size(61, 4);
            this.cmsPopMenu.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.cmsPopMenu.ThemeName = "Default";
            this.cmsPopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPopMenu_ItemClicked);
            // 
            // frmBalanceSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 502);
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "frmBalanceSF";
            this.Text = "frmBalanceSF";
            this.Controls.SetChildIndex(this.toolStripContainer, 0);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvBalance;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx cmsPopMenu;
    }
}