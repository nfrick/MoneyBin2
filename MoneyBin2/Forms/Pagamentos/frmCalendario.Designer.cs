using SuperGrid;

namespace MoneyBin2 {
    partial class frmCalendario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvCalendario = new SuperGrid.SuperDGV();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agendado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AgendadoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PagamentoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCalendar = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripCalendario = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrevMonth = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxMes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonNextMonth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEncontrarPagamentos = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalendar)).BeginInit();
            this.toolStripCalendario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvCalendario);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(772, 331);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(772, 364);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripCalendario);
            // 
            // dgvCalendario
            // 
            this.dgvCalendario.AllowUserToAddRows = false;
            this.dgvCalendario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCalendario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalendario.AutoGenerateColumns = false;
            this.dgvCalendario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalendario.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Descricao,
            this.Agendado,
            this.AgendadoData,
            this.Valor,
            this.Pago,
            this.PagamentoData});
            this.dgvCalendario.DataSource = this.bsCalendar;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalendario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendario.EnableHeadersVisualStyles = false;
            this.dgvCalendario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCalendario.Location = new System.Drawing.Point(0, 0);
            this.dgvCalendario.Name = "dgvCalendario";
            this.dgvCalendario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCalendario.RowHeadersWidth = 20;
            this.dgvCalendario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalendario.Size = new System.Drawing.Size(772, 331);
            this.dgvCalendario.TabIndex = 0;
            this.dgvCalendario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendario_CellEndEdit);
            this.dgvCalendario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCalendario_CellFormatting);
            this.dgvCalendario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendario_CellValueChanged);
            this.dgvCalendario.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCalendario_CurrentCellDirtyStateChanged);
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Agendado
            // 
            this.Agendado.DataPropertyName = "Agendado";
            this.Agendado.HeaderText = "Agendado?";
            this.Agendado.Name = "Agendado";
            // 
            // AgendadoData
            // 
            this.AgendadoData.DataPropertyName = "AgendadoData";
            this.AgendadoData.HeaderText = "Data";
            this.AgendadoData.Name = "AgendadoData";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            this.Pago.HeaderText = "Pago?";
            this.Pago.Name = "Pago";
            // 
            // PagamentoData
            // 
            this.PagamentoData.DataPropertyName = "PagamentoData";
            this.PagamentoData.HeaderText = "Data";
            this.PagamentoData.Name = "PagamentoData";
            // 
            // bsCalendar
            // 
            this.bsCalendar.AllowNew = false;
            this.bsCalendar.DataSource = typeof(DataLayer.CalendarioItem);
            // 
            // toolStripCalendario
            // 
            this.toolStripCalendario.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripCalendario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCalendario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCalendario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrevMonth,
            this.toolStripComboBoxMes,
            this.toolStripButtonNextMonth,
            this.toolStripButtonSalvar,
            this.toolStripEncontrarPagamentos});
            this.toolStripCalendario.Location = new System.Drawing.Point(3, 0);
            this.toolStripCalendario.Name = "toolStripCalendario";
            this.toolStripCalendario.Size = new System.Drawing.Size(435, 33);
            this.toolStripCalendario.TabIndex = 0;
            // 
            // toolStripButtonPrevMonth
            // 
            this.toolStripButtonPrevMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPrevMonth.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toolStripButtonPrevMonth.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrevMonth.Image")));
            this.toolStripButtonPrevMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevMonth.Name = "toolStripButtonPrevMonth";
            this.toolStripButtonPrevMonth.Size = new System.Drawing.Size(34, 30);
            this.toolStripButtonPrevMonth.Text = "3";
            this.toolStripButtonPrevMonth.ToolTipText = "Mês anterior";
            this.toolStripButtonPrevMonth.Click += new System.EventHandler(this.toolStripButtonMonth_Click);
            // 
            // toolStripComboBoxMes
            // 
            this.toolStripComboBoxMes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxMes.Name = "toolStripComboBoxMes";
            this.toolStripComboBoxMes.Size = new System.Drawing.Size(80, 33);
            this.toolStripComboBoxMes.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxMes_SelectedIndexChanged);
            // 
            // toolStripButtonNextMonth
            // 
            this.toolStripButtonNextMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNextMonth.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toolStripButtonNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNextMonth.Image")));
            this.toolStripButtonNextMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextMonth.Name = "toolStripButtonNextMonth";
            this.toolStripButtonNextMonth.Size = new System.Drawing.Size(34, 30);
            this.toolStripButtonNextMonth.Text = "4";
            this.toolStripButtonNextMonth.ToolTipText = "Próximo mês";
            this.toolStripButtonNextMonth.Click += new System.EventHandler(this.toolStripButtonMonth_Click);
            // 
            // toolStripButtonSalvar
            // 
            this.toolStripButtonSalvar.BackColor = System.Drawing.Color.Green;
            this.toolStripButtonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSalvar.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalvar.Image")));
            this.toolStripButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            this.toolStripButtonSalvar.Size = new System.Drawing.Size(67, 30);
            this.toolStripButtonSalvar.Tag = "Save";
            this.toolStripButtonSalvar.Text = "Salvar";
            this.toolStripButtonSalvar.Click += new System.EventHandler(this.toolStripButtonSalvar_Click);
            // 
            // toolStripEncontrarPagamentos
            // 
            this.toolStripEncontrarPagamentos.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.toolStripEncontrarPagamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripEncontrarPagamentos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEncontrarPagamentos.Image")));
            this.toolStripEncontrarPagamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEncontrarPagamentos.Name = "toolStripEncontrarPagamentos";
            this.toolStripEncontrarPagamentos.Size = new System.Drawing.Size(206, 30);
            this.toolStripEncontrarPagamentos.Text = "Encontrar Pagamentos";
            this.toolStripEncontrarPagamentos.ToolTipText = "Encontrar pagamentos no extrato";
            this.toolStripEncontrarPagamentos.Click += new System.EventHandler(this.toolStripButtonEncontrarPagamentos_Click);
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 364);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalendario_FormClosing);
            this.Load += new System.EventHandler(this.frmCalendario_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalendar)).EndInit();
            this.toolStripCalendario.ResumeLayout(false);
            this.toolStripCalendario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private SuperDGV dgvCalendario;
        private System.Windows.Forms.BindingSource bsCalendar;
        private System.Windows.Forms.ToolStrip toolStripCalendario;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMes;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevMonth;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextMonth;
        private System.Windows.Forms.ToolStripButton toolStripEncontrarPagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agendado;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendadoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagamentoData;
    }
}