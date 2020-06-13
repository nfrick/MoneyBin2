using System.Windows.Forms;
using SuperGrid;

namespace MoneyBin2 {
    partial class frmAssociarCompraComVenda {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nudQtdAssociada = new System.Windows.Forms.NumericUpDown();
            this.buttonAssociarOK = new System.Windows.Forms.Button();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQtdComprada = new System.Windows.Forms.Label();
            this.labelQtdVendida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelVenda = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelAtivo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAssociacoes = new System.Windows.Forms.Label();
            this.labelPendente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDisponiveis = new SuperGrid.SuperDGV();
            this.dgvAssociadas = new SuperGrid.SuperDGV();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEditar = new System.Windows.Forms.TableLayoutPanel();
            this.qtdAssociadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAssociadas = new System.Windows.Forms.BindingSource(this.components);
            this.bsDisponiveis = new System.Windows.Forms.BindingSource(this.components);
            this.btnAssociarDireto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAssociar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacaoTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdAssociadaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDisponivelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRealDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdAssociada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociadas)).BeginInit();
            this.panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDisponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQtdAssociada
            // 
            this.nudQtdAssociada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudQtdAssociada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdAssociada.Location = new System.Drawing.Point(199, 72);
            this.nudQtdAssociada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdAssociada.Name = "nudQtdAssociada";
            this.nudQtdAssociada.Size = new System.Drawing.Size(62, 34);
            this.nudQtdAssociada.TabIndex = 21;
            this.nudQtdAssociada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQtdAssociada.ThousandsSeparator = true;
            this.nudQtdAssociada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdAssociada.ValueChanged += new System.EventHandler(this.numericUpDownQtdAAssociar_ValueChanged);
            // 
            // buttonAssociarOK
            // 
            this.buttonAssociarOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAssociarOK.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonAssociarOK.ForeColor = System.Drawing.Color.Green;
            this.buttonAssociarOK.Location = new System.Drawing.Point(267, 72);
            this.buttonAssociarOK.Name = "buttonAssociarOK";
            this.buttonAssociarOK.Size = new System.Drawing.Size(33, 32);
            this.buttonAssociarOK.TabIndex = 19;
            this.buttonAssociarOK.Text = "ü";
            this.buttonAssociarOK.UseVisualStyleBackColor = true;
            this.buttonAssociarOK.Click += new System.EventHandler(this.buttonAssociarOK_Click);
            // 
            // labelSaldo
            // 
            this.labelSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSaldo.Location = new System.Drawing.Point(199, 107);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSaldo.Size = new System.Drawing.Size(62, 28);
            this.labelSaldo.TabIndex = 15;
            this.labelSaldo.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pendente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Esta associação:";
            // 
            // labelQtdComprada
            // 
            this.labelQtdComprada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQtdComprada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdComprada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQtdComprada.Location = new System.Drawing.Point(199, 39);
            this.labelQtdComprada.Name = "labelQtdComprada";
            this.labelQtdComprada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelQtdComprada.Size = new System.Drawing.Size(62, 30);
            this.labelQtdComprada.TabIndex = 12;
            this.labelQtdComprada.Text = "200";
            // 
            // labelQtdVendida
            // 
            this.labelQtdVendida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQtdVendida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdVendida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQtdVendida.Location = new System.Drawing.Point(199, 10);
            this.labelQtdVendida.Name = "labelQtdVendida";
            this.labelQtdVendida.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelQtdVendida.Size = new System.Drawing.Size(62, 29);
            this.labelQtdVendida.TabIndex = 11;
            this.labelQtdVendida.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Outras associações:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vendidas:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.Control;
            this.labelData.Location = new System.Drawing.Point(24, 51);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(68, 32);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "Data";
            // 
            // labelVenda
            // 
            this.labelVenda.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenda.ForeColor = System.Drawing.Color.Red;
            this.labelVenda.Location = new System.Drawing.Point(408, 19);
            this.labelVenda.Name = "labelVenda";
            this.labelVenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelVenda.Size = new System.Drawing.Size(88, 32);
            this.labelVenda.TabIndex = 19;
            this.labelVenda.Text = "Qtd:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValor.Location = new System.Drawing.Point(24, 83);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(74, 32);
            this.labelValor.TabIndex = 20;
            this.labelValor.Text = "Valor";
            // 
            // labelAtivo
            // 
            this.labelAtivo.AutoSize = true;
            this.labelAtivo.BackColor = System.Drawing.Color.Transparent;
            this.labelAtivo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtivo.ForeColor = System.Drawing.Color.Yellow;
            this.labelAtivo.Location = new System.Drawing.Point(23, 11);
            this.labelAtivo.Name = "labelAtivo";
            this.labelAtivo.Size = new System.Drawing.Size(93, 41);
            this.labelAtivo.TabIndex = 21;
            this.labelAtivo.Text = "Ativo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Entradas já associadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(624, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Entradas disponíveis";
            // 
            // labelAssociacoes
            // 
            this.labelAssociacoes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssociacoes.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelAssociacoes.Location = new System.Drawing.Point(408, 48);
            this.labelAssociacoes.Name = "labelAssociacoes";
            this.labelAssociacoes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAssociacoes.Size = new System.Drawing.Size(88, 34);
            this.labelAssociacoes.TabIndex = 24;
            this.labelAssociacoes.Text = "Qtd:";
            // 
            // labelPendente
            // 
            this.labelPendente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendente.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelPendente.Location = new System.Drawing.Point(408, 80);
            this.labelPendente.Name = "labelPendente";
            this.labelPendente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPendente.Size = new System.Drawing.Size(88, 32);
            this.labelPendente.TabIndex = 25;
            this.labelPendente.Text = "Qtd:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(250, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pendente:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(250, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 34);
            this.label9.TabIndex = 27;
            this.label9.Text = "Associações:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(250, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 32);
            this.label10.TabIndex = 26;
            this.label10.Text = "Venda:";
            // 
            // dgvDisponiveis
            // 
            this.dgvDisponiveis.AllowUserToAddRows = false;
            this.dgvDisponiveis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDisponiveis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDisponiveis.AutoGenerateColumns = false;
            this.dgvDisponiveis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisponiveis.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisponiveis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisponiveis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAssociarDireto,
            this.btnAssociar,
            this.dataDataGridViewTextBoxColumn,
            this.operacaoTipoDataGridViewTextBoxColumn,
            this.QtdReal,
            this.qtdAssociadaDataGridViewTextBoxColumn2,
            this.qtdDisponivelDataGridViewTextBoxColumn1,
            this.valorRealDataGridViewTextBoxColumn1});
            this.dgvDisponiveis.DataSource = this.bsDisponiveis;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisponiveis.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvDisponiveis.EnableHeadersVisualStyles = false;
            this.dgvDisponiveis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDisponiveis.Location = new System.Drawing.Point(621, 161);
            this.dgvDisponiveis.MultiSelect = false;
            this.dgvDisponiveis.Name = "dgvDisponiveis";
            this.dgvDisponiveis.ReadOnly = true;
            this.dgvDisponiveis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisponiveis.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvDisponiveis.RowHeadersWidth = 25;
            this.dgvDisponiveis.RowTemplate.Height = 24;
            this.dgvDisponiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponiveis.Size = new System.Drawing.Size(574, 150);
            this.dgvDisponiveis.TabIndex = 0;
            this.dgvDisponiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisponiveis_CellContentClick);
            // 
            // dgvAssociadas
            // 
            this.dgvAssociadas.AllowUserToAddRows = false;
            this.dgvAssociadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAssociadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvAssociadas.AutoGenerateColumns = false;
            this.dgvAssociadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssociadas.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAssociadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssociadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvAssociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnDeletar,
            this.Data,
            this.Tipo,
            this.QtdEntrada,
            this.qtdAssociadaDataGridViewTextBoxColumn,
            this.QtdDisponivel,
            this.ValorReal,
            this.EntradaId});
            this.dgvAssociadas.DataSource = this.bsAssociadas;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociadas.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvAssociadas.EnableHeadersVisualStyles = false;
            this.dgvAssociadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAssociadas.Location = new System.Drawing.Point(30, 161);
            this.dgvAssociadas.Name = "dgvAssociadas";
            this.dgvAssociadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvAssociadas.RowHeadersWidth = 25;
            this.dgvAssociadas.RowTemplate.Height = 25;
            this.dgvAssociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAssociadas.Size = new System.Drawing.Size(565, 150);
            this.dgvAssociadas.TabIndex = 10;
            this.dgvAssociadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociadas_CellContentClick);
            this.dgvAssociadas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociadas_CellEndEdit);
            this.dgvAssociadas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAssociadas_CellPainting);
            this.dgvAssociadas.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociadas_CellValidated);
            this.dgvAssociadas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAssociadas_CellValidating);
            this.dgvAssociadas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAssociadas_DataError);
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "…";
            this.btnEditar.ToolTipText = "Alterar Qtd Associada";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 25;
            // 
            // btnDeletar
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Red;
            this.btnDeletar.DefaultCellStyle = dataGridViewCellStyle31;
            this.btnDeletar.HeaderText = "";
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ReadOnly = true;
            this.btnDeletar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDeletar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDeletar.Text = "û";
            this.btnDeletar.ToolTipText = "Remover";
            this.btnDeletar.UseColumnTextForButtonValue = true;
            this.btnDeletar.Width = 25;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // QtdEntrada
            // 
            this.QtdEntrada.DataPropertyName = "QtdEntrada";
            this.QtdEntrada.HeaderText = "Qtd";
            this.QtdEntrada.Name = "QtdEntrada";
            this.QtdEntrada.ReadOnly = true;
            // 
            // QtdDisponivel
            // 
            this.QtdDisponivel.DataPropertyName = "QtdDisponivel";
            this.QtdDisponivel.HeaderText = "Disponível";
            this.QtdDisponivel.Name = "QtdDisponivel";
            this.QtdDisponivel.ReadOnly = true;
            // 
            // ValorReal
            // 
            this.ValorReal.DataPropertyName = "ValorReal";
            this.ValorReal.HeaderText = "Valor";
            this.ValorReal.Name = "ValorReal";
            this.ValorReal.ReadOnly = true;
            // 
            // EntradaId
            // 
            this.EntradaId.DataPropertyName = "EntradaId";
            this.EntradaId.HeaderText = "CompraId";
            this.EntradaId.Name = "EntradaId";
            this.EntradaId.Visible = false;
            // 
            // panelEditar
            // 
            this.panelEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEditar.ColumnCount = 5;
            this.panelEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.panelEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.panelEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.panelEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.panelEditar.Controls.Add(this.buttonAssociarOK, 3, 3);
            this.panelEditar.Controls.Add(this.nudQtdAssociada, 2, 3);
            this.panelEditar.Controls.Add(this.labelSaldo, 2, 4);
            this.panelEditar.Controls.Add(this.label1, 1, 1);
            this.panelEditar.Controls.Add(this.label2, 1, 2);
            this.panelEditar.Controls.Add(this.label3, 1, 3);
            this.panelEditar.Controls.Add(this.labelQtdComprada, 2, 2);
            this.panelEditar.Controls.Add(this.label4, 1, 4);
            this.panelEditar.Controls.Add(this.labelQtdVendida, 2, 1);
            this.panelEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEditar.Location = new System.Drawing.Point(466, 329);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.RowCount = 6;
            this.panelEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.panelEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.panelEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.panelEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.panelEditar.Size = new System.Drawing.Size(314, 151);
            this.panelEditar.TabIndex = 29;
            this.panelEditar.Visible = false;
            // 
            // qtdAssociadaDataGridViewTextBoxColumn
            // 
            this.qtdAssociadaDataGridViewTextBoxColumn.DataPropertyName = "QtdAssociada";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N0";
            this.qtdAssociadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle32;
            this.qtdAssociadaDataGridViewTextBoxColumn.HeaderText = "Associado";
            this.qtdAssociadaDataGridViewTextBoxColumn.Name = "qtdAssociadaDataGridViewTextBoxColumn";
            this.qtdAssociadaDataGridViewTextBoxColumn.Width = 75;
            // 
            // bsAssociadas
            // 
            this.bsAssociadas.DataSource = typeof(DataLayer.Associacao);
            // 
            // bsDisponiveis
            // 
            this.bsDisponiveis.DataSource = typeof(DataLayer.Entrada);
            // 
            // btnAssociarDireto
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAssociarDireto.DefaultCellStyle = dataGridViewCellStyle20;
            this.btnAssociarDireto.HeaderText = "";
            this.btnAssociarDireto.Name = "btnAssociarDireto";
            this.btnAssociarDireto.ReadOnly = true;
            this.btnAssociarDireto.Text = "ç";
            this.btnAssociarDireto.ToolTipText = "Associar direto";
            this.btnAssociarDireto.UseColumnTextForButtonValue = true;
            this.btnAssociarDireto.Width = 25;
            // 
            // btnAssociar
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociar.DefaultCellStyle = dataGridViewCellStyle21;
            this.btnAssociar.HeaderText = "";
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.ReadOnly = true;
            this.btnAssociar.Text = "…";
            this.btnAssociar.ToolTipText = "Adicionar";
            this.btnAssociar.UseColumnTextForButtonValue = true;
            this.btnAssociar.Width = 25;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataGridViewCellStyle22.Format = "dd/MM/yy";
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 70;
            // 
            // operacaoTipoDataGridViewTextBoxColumn
            // 
            this.operacaoTipoDataGridViewTextBoxColumn.DataPropertyName = "OperacaoTipo";
            this.operacaoTipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.operacaoTipoDataGridViewTextBoxColumn.Name = "operacaoTipoDataGridViewTextBoxColumn";
            this.operacaoTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QtdReal
            // 
            this.QtdReal.DataPropertyName = "Qtd";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N0";
            this.QtdReal.DefaultCellStyle = dataGridViewCellStyle23;
            this.QtdReal.HeaderText = "Qtd";
            this.QtdReal.Name = "QtdReal";
            this.QtdReal.ReadOnly = true;
            this.QtdReal.Width = 75;
            // 
            // qtdAssociadaDataGridViewTextBoxColumn2
            // 
            this.qtdAssociadaDataGridViewTextBoxColumn2.DataPropertyName = "QtdAssociada";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N0";
            this.qtdAssociadaDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle24;
            this.qtdAssociadaDataGridViewTextBoxColumn2.HeaderText = "Associado";
            this.qtdAssociadaDataGridViewTextBoxColumn2.Name = "qtdAssociadaDataGridViewTextBoxColumn2";
            this.qtdAssociadaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.qtdAssociadaDataGridViewTextBoxColumn2.Width = 75;
            // 
            // qtdDisponivelDataGridViewTextBoxColumn1
            // 
            this.qtdDisponivelDataGridViewTextBoxColumn1.DataPropertyName = "QtdDisponivel";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N0";
            this.qtdDisponivelDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle25;
            this.qtdDisponivelDataGridViewTextBoxColumn1.HeaderText = "Disponivel";
            this.qtdDisponivelDataGridViewTextBoxColumn1.Name = "qtdDisponivelDataGridViewTextBoxColumn1";
            this.qtdDisponivelDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qtdDisponivelDataGridViewTextBoxColumn1.Width = 75;
            // 
            // valorRealDataGridViewTextBoxColumn1
            // 
            this.valorRealDataGridViewTextBoxColumn1.DataPropertyName = "ValorReal";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.valorRealDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle26;
            this.valorRealDataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.valorRealDataGridViewTextBoxColumn1.Name = "valorRealDataGridViewTextBoxColumn1";
            this.valorRealDataGridViewTextBoxColumn1.ReadOnly = true;
            this.valorRealDataGridViewTextBoxColumn1.Width = 60;
            // 
            // frmAssociarCompraComVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1226, 498);
            this.Controls.Add(this.panelEditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelPendente);
            this.Controls.Add(this.labelAssociacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAtivo);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelVenda);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dgvAssociadas);
            this.Controls.Add(this.dgvDisponiveis);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssociarCompraComVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Compra Com Venda";
            this.Load += new System.EventHandler(this.AssociarCompraComVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdAssociada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociadas)).EndInit();
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDisponiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDisponiveis;
        private System.Windows.Forms.BindingSource bsAssociadas;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQtdComprada;
        private System.Windows.Forms.Label labelQtdVendida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SuperDGV dgvDisponiveis;
        private System.Windows.Forms.NumericUpDown nudQtdAssociada;
        private System.Windows.Forms.Button buttonAssociarOK;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelVenda;
        //private System.Windows.Forms.DataGridViewTextBoxColumn qtdCompradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAssociacoes;
        private System.Windows.Forms.Label labelPendente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDisponivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRealDataGridViewTextBoxColumn;
        private SuperDGV dgvAssociadas;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnDeletar;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn QtdEntrada;
        private DataGridViewTextBoxColumn qtdAssociadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn QtdDisponivel;
        private DataGridViewTextBoxColumn ValorReal;
        private DataGridViewTextBoxColumn EntradaId;
        private TableLayoutPanel panelEditar;
        private DataGridViewButtonColumn btnAssociarDireto;
        private DataGridViewButtonColumn btnAssociar;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operacaoTipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn QtdReal;
        private DataGridViewTextBoxColumn qtdAssociadaDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn qtdDisponivelDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn valorRealDataGridViewTextBoxColumn1;
    }
}