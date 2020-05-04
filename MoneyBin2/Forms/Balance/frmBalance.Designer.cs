namespace MoneyBin2 {
    partial class frmBalance {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsBalance = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBalance = new SuperGrid.SuperDGV();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AfetaSaldo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsPopMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.dgvBalance);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1100, 446);
            this.toolStripContainer.TopToolStripPanelVisible = true;
            // 
            // bsBalance
            // 
            this.bsBalance.DataSource = typeof(DataLayer.BalanceItem);
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBalance.AutoGenerateColumns = false;
            this.dgvBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBalance.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Historico,
            this.Documento,
            this.Valor,
            this.AfetaSaldo,
            this.Saldo,
            this.Grupo,
            this.Categoria,
            this.SubCategoria,
            this.Descricao});
            this.dgvBalance.DataSource = this.bsBalance;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalance.EnableHeadersVisualStyles = false;
            this.dgvBalance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBalance.Location = new System.Drawing.Point(0, 0);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBalance.RowHeadersWidth = 20;
            this.dgvBalance.RowTemplate.Height = 24;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(1100, 446);
            this.dgvBalance.TabIndex = 0;
            this.dgvBalance.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalance_CellEndEdit);
            this.dgvBalance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBalance_CellFormatting);
            this.dgvBalance.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalance_CellValueChanged);
            this.dgvBalance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBalance_EditingControlShowing);
            this.dgvBalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBalance_MouseClick);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Historico
            // 
            this.Historico.DataPropertyName = "Historico";
            this.Historico.HeaderText = "Histórico";
            this.Historico.Name = "Historico";
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.Visible = false;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // AfetaSaldo
            // 
            this.AfetaSaldo.DataPropertyName = "AfetaSaldo";
            this.AfetaSaldo.HeaderText = "Afeta Saldo";
            this.AfetaSaldo.Name = "AfetaSaldo";
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "Grupo";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // SubCategoria
            // 
            this.SubCategoria.DataPropertyName = "SubCategoria";
            this.SubCategoria.HeaderText = "SubCategoria";
            this.SubCategoria.Name = "SubCategoria";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // cmsPopMenu
            // 
            this.cmsPopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPopMenu.Name = "cmsPopMenu";
            this.cmsPopMenu.Size = new System.Drawing.Size(61, 4);
            this.cmsPopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPopMenu_ItemClicked);
            // 
            // frmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.ClientSize = new System.Drawing.Size(1100, 523);
            this.Name = "frmBalance";
            this.Text = "Balance";
            this.Controls.SetChildIndex(this.toolStripContainer, 0);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGrid.SuperDGV dgvBalance;
        private System.Windows.Forms.BindingSource bsBalance;
        private System.Windows.Forms.ContextMenuStrip cmsPopMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AfetaSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}
