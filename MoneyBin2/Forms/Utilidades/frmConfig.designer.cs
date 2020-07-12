namespace MoneyBin2 {
    partial class frmConfig {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.tlpDatabaseMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.buttonSaveDatabase = new System.Windows.Forms.Button();
            this.propertyGridConn = new System.Windows.Forms.PropertyGrid();
            this.tlpDatabaseLeftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.comboBoxStrings = new System.Windows.Forms.ComboBox();
            this.labelConexoes = new System.Windows.Forms.Label();
            this.labelSQLServers = new System.Windows.Forms.Label();
            this.listBoxSQLServers = new System.Windows.Forms.ListBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBoxBarraFerramentas = new System.Windows.Forms.GroupBox();
            this.checkBoxBarraFerramentasImagemeTexto = new System.Windows.Forms.CheckBox();
            this.checkBoxBarraFerramentasVisivel = new System.Windows.Forms.CheckBox();
            this.groupBoxBackground = new System.Windows.Forms.GroupBox();
            this.checkBoxBackgroundRodizio = new System.Windows.Forms.CheckBox();
            this.checkBoxBackgroundVisivel = new System.Windows.Forms.CheckBox();
            this.groupBoxCalendario = new System.Windows.Forms.GroupBox();
            this.labelCalendarioPastaPagamentos = new System.Windows.Forms.Label();
            this.labelPastaDocumentos = new System.Windows.Forms.Label();
            this.groupBoxBalance = new System.Windows.Forms.GroupBox();
            this.labelAbrirCom = new System.Windows.Forms.Label();
            this.radioButtonBalanceUltimaConta = new System.Windows.Forms.RadioButton();
            this.radioButtonBalanceContaPadrao = new System.Windows.Forms.RadioButton();
            this.comboBoxBalanceContaPadrao = new System.Windows.Forms.ComboBox();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonInvestimentosUltimaConta = new System.Windows.Forms.RadioButton();
            this.radioButtonInvestimentosContaPadrao = new System.Windows.Forms.RadioButton();
            this.comboBoxInvestimentosContaPadrao = new System.Windows.Forms.ComboBox();
            this.groupBoxInvestimentos = new System.Windows.Forms.GroupBox();
            this.tlpDatabaseMain.SuspendLayout();
            this.tlpDatabaseLeftPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBoxBarraFerramentas.SuspendLayout();
            this.groupBoxBackground.SuspendLayout();
            this.groupBoxCalendario.SuspendLayout();
            this.groupBoxBalance.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            this.groupBoxInvestimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatabaseMain
            // 
            this.tlpDatabaseMain.ColumnCount = 2;
            this.tlpDatabaseMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlpDatabaseMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatabaseMain.Controls.Add(this.textBoxString, 1, 2);
            this.tlpDatabaseMain.Controls.Add(this.buttonSaveDatabase, 0, 2);
            this.tlpDatabaseMain.Controls.Add(this.propertyGridConn, 1, 1);
            this.tlpDatabaseMain.Controls.Add(this.tlpDatabaseLeftPanel, 0, 1);
            this.tlpDatabaseMain.Controls.Add(this.labelTitulo, 0, 0);
            this.tlpDatabaseMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatabaseMain.Location = new System.Drawing.Point(3, 3);
            this.tlpDatabaseMain.Name = "tlpDatabaseMain";
            this.tlpDatabaseMain.RowCount = 3;
            this.tlpDatabaseMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDatabaseMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatabaseMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpDatabaseMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatabaseMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatabaseMain.Size = new System.Drawing.Size(861, 497);
            this.tlpDatabaseMain.TabIndex = 7;
            // 
            // textBoxString
            // 
            this.textBoxString.BackColor = System.Drawing.Color.Black;
            this.textBoxString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxString.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxString.Location = new System.Drawing.Point(176, 440);
            this.textBoxString.Multiline = true;
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.ReadOnly = true;
            this.textBoxString.Size = new System.Drawing.Size(682, 54);
            this.textBoxString.TabIndex = 11;
            // 
            // buttonSaveDatabase
            // 
            this.buttonSaveDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveDatabase.Enabled = false;
            this.buttonSaveDatabase.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveDatabase.Image = global::MoneyBin2.Properties.Resources.Disquete;
            this.buttonSaveDatabase.Location = new System.Drawing.Point(3, 440);
            this.buttonSaveDatabase.Name = "buttonSaveDatabase";
            this.buttonSaveDatabase.Size = new System.Drawing.Size(167, 54);
            this.buttonSaveDatabase.TabIndex = 3;
            this.buttonSaveDatabase.Text = "Salvar";
            this.buttonSaveDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveDatabase.UseVisualStyleBackColor = true;
            this.buttonSaveDatabase.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // propertyGridConn
            // 
            this.propertyGridConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridConn.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGridConn.Location = new System.Drawing.Point(176, 43);
            this.propertyGridConn.Name = "propertyGridConn";
            this.propertyGridConn.Size = new System.Drawing.Size(682, 391);
            this.propertyGridConn.TabIndex = 10;
            this.propertyGridConn.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridConn_PropertyValueChanged);
            // 
            // tlpDatabaseLeftPanel
            // 
            this.tlpDatabaseLeftPanel.ColumnCount = 1;
            this.tlpDatabaseLeftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatabaseLeftPanel.Controls.Add(this.buttonTestConnection, 0, 2);
            this.tlpDatabaseLeftPanel.Controls.Add(this.comboBoxStrings, 0, 1);
            this.tlpDatabaseLeftPanel.Controls.Add(this.labelConexoes, 0, 0);
            this.tlpDatabaseLeftPanel.Controls.Add(this.labelSQLServers, 0, 4);
            this.tlpDatabaseLeftPanel.Controls.Add(this.listBoxSQLServers, 0, 5);
            this.tlpDatabaseLeftPanel.Location = new System.Drawing.Point(3, 43);
            this.tlpDatabaseLeftPanel.Name = "tlpDatabaseLeftPanel";
            this.tlpDatabaseLeftPanel.RowCount = 6;
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpDatabaseLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatabaseLeftPanel.Size = new System.Drawing.Size(167, 391);
            this.tlpDatabaseLeftPanel.TabIndex = 9;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTestConnection.Enabled = false;
            this.buttonTestConnection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestConnection.ForeColor = System.Drawing.Color.Black;
            this.buttonTestConnection.Image = global::MoneyBin2.Properties.Resources.TestConnection_24;
            this.buttonTestConnection.Location = new System.Drawing.Point(3, 58);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(161, 29);
            this.buttonTestConnection.TabIndex = 7;
            this.buttonTestConnection.Text = "Testar Conexão";
            this.buttonTestConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // comboBoxStrings
            // 
            this.comboBoxStrings.FormattingEnabled = true;
            this.comboBoxStrings.Location = new System.Drawing.Point(3, 23);
            this.comboBoxStrings.Name = "comboBoxStrings";
            this.comboBoxStrings.Size = new System.Drawing.Size(161, 36);
            this.comboBoxStrings.TabIndex = 4;
            this.comboBoxStrings.SelectedIndexChanged += new System.EventHandler(this.comboBoxStrings_SelectedIndexChanged);
            // 
            // labelConexoes
            // 
            this.labelConexoes.AutoSize = true;
            this.labelConexoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConexoes.ForeColor = System.Drawing.Color.White;
            this.labelConexoes.Location = new System.Drawing.Point(3, 0);
            this.labelConexoes.Name = "labelConexoes";
            this.labelConexoes.Size = new System.Drawing.Size(161, 20);
            this.labelConexoes.TabIndex = 8;
            this.labelConexoes.Text = "Conexões";
            // 
            // labelSQLServers
            // 
            this.labelSQLServers.AutoSize = true;
            this.labelSQLServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSQLServers.ForeColor = System.Drawing.Color.White;
            this.labelSQLServers.Location = new System.Drawing.Point(3, 110);
            this.labelSQLServers.Name = "labelSQLServers";
            this.labelSQLServers.Size = new System.Drawing.Size(161, 20);
            this.labelSQLServers.TabIndex = 9;
            this.labelSQLServers.Text = "SQL Servers";
            // 
            // listBoxSQLServers
            // 
            this.listBoxSQLServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.listBoxSQLServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSQLServers.ForeColor = System.Drawing.Color.White;
            this.listBoxSQLServers.FormattingEnabled = true;
            this.listBoxSQLServers.ItemHeight = 28;
            this.listBoxSQLServers.Location = new System.Drawing.Point(3, 133);
            this.listBoxSQLServers.Name = "listBoxSQLServers";
            this.listBoxSQLServers.Size = new System.Drawing.Size(161, 255);
            this.listBoxSQLServers.TabIndex = 10;
            this.listBoxSQLServers.SelectedIndexChanged += new System.EventHandler(this.listBoxSQLServers_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlpDatabaseMain.SetColumnSpan(this.labelTitulo, 2);
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(855, 40);
            this.labelTitulo.TabIndex = 19;
            this.labelTitulo.Text = "CONEXÕES COM BANCO DE DADOS";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageDatabase);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 544);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.Black;
            this.tabPageSettings.Controls.Add(this.groupBoxInvestimentos);
            this.tabPageSettings.Controls.Add(this.buttonSaveSettings);
            this.tabPageSettings.Controls.Add(this.groupBoxBarraFerramentas);
            this.tabPageSettings.Controls.Add(this.groupBoxBackground);
            this.tabPageSettings.Controls.Add(this.groupBoxCalendario);
            this.tabPageSettings.Controls.Add(this.groupBoxBalance);
            this.tabPageSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 37);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(867, 503);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveSettings.Image = global::MoneyBin2.Properties.Resources.Disquete;
            this.buttonSaveSettings.Location = new System.Drawing.Point(706, 26);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(137, 54);
            this.buttonSaveSettings.TabIndex = 15;
            this.buttonSaveSettings.Text = "Salvar";
            this.buttonSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // groupBoxBarraFerramentas
            // 
            this.groupBoxBarraFerramentas.Controls.Add(this.checkBoxBarraFerramentasImagemeTexto);
            this.groupBoxBarraFerramentas.Controls.Add(this.checkBoxBarraFerramentasVisivel);
            this.groupBoxBarraFerramentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxBarraFerramentas.Location = new System.Drawing.Point(265, 328);
            this.groupBoxBarraFerramentas.Name = "groupBoxBarraFerramentas";
            this.groupBoxBarraFerramentas.Size = new System.Drawing.Size(229, 147);
            this.groupBoxBarraFerramentas.TabIndex = 14;
            this.groupBoxBarraFerramentas.TabStop = false;
            this.groupBoxBarraFerramentas.Text = "Barra de Ferramentas";
            // 
            // checkBoxBarraFerramentasImagemeTexto
            // 
            this.checkBoxBarraFerramentasImagemeTexto.AutoSize = true;
            this.checkBoxBarraFerramentasImagemeTexto.ForeColor = System.Drawing.Color.White;
            this.checkBoxBarraFerramentasImagemeTexto.Location = new System.Drawing.Point(32, 94);
            this.checkBoxBarraFerramentasImagemeTexto.Name = "checkBoxBarraFerramentasImagemeTexto";
            this.checkBoxBarraFerramentasImagemeTexto.Size = new System.Drawing.Size(174, 32);
            this.checkBoxBarraFerramentasImagemeTexto.TabIndex = 10;
            this.checkBoxBarraFerramentasImagemeTexto.Text = "Apenas imagem";
            this.checkBoxBarraFerramentasImagemeTexto.UseVisualStyleBackColor = true;
            // 
            // checkBoxBarraFerramentasVisivel
            // 
            this.checkBoxBarraFerramentasVisivel.AutoSize = true;
            this.checkBoxBarraFerramentasVisivel.ForeColor = System.Drawing.Color.White;
            this.checkBoxBarraFerramentasVisivel.Location = new System.Drawing.Point(32, 46);
            this.checkBoxBarraFerramentasVisivel.Name = "checkBoxBarraFerramentasVisivel";
            this.checkBoxBarraFerramentasVisivel.Size = new System.Drawing.Size(89, 32);
            this.checkBoxBarraFerramentasVisivel.TabIndex = 9;
            this.checkBoxBarraFerramentasVisivel.Text = "Visível";
            this.checkBoxBarraFerramentasVisivel.UseVisualStyleBackColor = true;
            // 
            // groupBoxBackground
            // 
            this.groupBoxBackground.Controls.Add(this.checkBoxBackgroundRodizio);
            this.groupBoxBackground.Controls.Add(this.checkBoxBackgroundVisivel);
            this.groupBoxBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxBackground.Location = new System.Drawing.Point(23, 328);
            this.groupBoxBackground.Name = "groupBoxBackground";
            this.groupBoxBackground.Size = new System.Drawing.Size(229, 147);
            this.groupBoxBackground.TabIndex = 13;
            this.groupBoxBackground.TabStop = false;
            this.groupBoxBackground.Text = "Background";
            // 
            // checkBoxBackgroundRodizio
            // 
            this.checkBoxBackgroundRodizio.AutoSize = true;
            this.checkBoxBackgroundRodizio.ForeColor = System.Drawing.Color.White;
            this.checkBoxBackgroundRodizio.Location = new System.Drawing.Point(32, 94);
            this.checkBoxBackgroundRodizio.Name = "checkBoxBackgroundRodizio";
            this.checkBoxBackgroundRodizio.Size = new System.Drawing.Size(100, 32);
            this.checkBoxBackgroundRodizio.TabIndex = 8;
            this.checkBoxBackgroundRodizio.Text = "Rodízio";
            this.checkBoxBackgroundRodizio.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackgroundVisivel
            // 
            this.checkBoxBackgroundVisivel.AutoSize = true;
            this.checkBoxBackgroundVisivel.ForeColor = System.Drawing.Color.White;
            this.checkBoxBackgroundVisivel.Location = new System.Drawing.Point(32, 46);
            this.checkBoxBackgroundVisivel.Name = "checkBoxBackgroundVisivel";
            this.checkBoxBackgroundVisivel.Size = new System.Drawing.Size(89, 32);
            this.checkBoxBackgroundVisivel.TabIndex = 7;
            this.checkBoxBackgroundVisivel.Text = "Visível";
            this.checkBoxBackgroundVisivel.UseVisualStyleBackColor = true;
            // 
            // groupBoxCalendario
            // 
            this.groupBoxCalendario.Controls.Add(this.labelCalendarioPastaPagamentos);
            this.groupBoxCalendario.Controls.Add(this.labelPastaDocumentos);
            this.groupBoxCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxCalendario.Location = new System.Drawing.Point(23, 222);
            this.groupBoxCalendario.Name = "groupBoxCalendario";
            this.groupBoxCalendario.Size = new System.Drawing.Size(820, 100);
            this.groupBoxCalendario.TabIndex = 11;
            this.groupBoxCalendario.TabStop = false;
            this.groupBoxCalendario.Text = "Calendário";
            // 
            // labelCalendarioPastaPagamentos
            // 
            this.labelCalendarioPastaPagamentos.AutoSize = true;
            this.labelCalendarioPastaPagamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCalendarioPastaPagamentos.Location = new System.Drawing.Point(212, 43);
            this.labelCalendarioPastaPagamentos.Name = "labelCalendarioPastaPagamentos";
            this.labelCalendarioPastaPagamentos.Size = new System.Drawing.Size(169, 28);
            this.labelCalendarioPastaPagamentos.TabIndex = 4;
            this.labelCalendarioPastaPagamentos.Text = "Pasta Pagamentos";
            this.labelCalendarioPastaPagamentos.DoubleClick += new System.EventHandler(this.labelCalendarioPastaPagamentos_DoubleClick);
            // 
            // labelPastaDocumentos
            // 
            this.labelPastaDocumentos.AutoSize = true;
            this.labelPastaDocumentos.ForeColor = System.Drawing.Color.White;
            this.labelPastaDocumentos.Location = new System.Drawing.Point(27, 43);
            this.labelPastaDocumentos.Name = "labelPastaDocumentos";
            this.labelPastaDocumentos.Size = new System.Drawing.Size(169, 28);
            this.labelPastaDocumentos.TabIndex = 3;
            this.labelPastaDocumentos.Text = "Pasta Pagamentos";
            // 
            // groupBoxBalance
            // 
            this.groupBoxBalance.Controls.Add(this.labelAbrirCom);
            this.groupBoxBalance.Controls.Add(this.radioButtonBalanceUltimaConta);
            this.groupBoxBalance.Controls.Add(this.radioButtonBalanceContaPadrao);
            this.groupBoxBalance.Controls.Add(this.comboBoxBalanceContaPadrao);
            this.groupBoxBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxBalance.Location = new System.Drawing.Point(23, 26);
            this.groupBoxBalance.Name = "groupBoxBalance";
            this.groupBoxBalance.Size = new System.Drawing.Size(229, 190);
            this.groupBoxBalance.TabIndex = 10;
            this.groupBoxBalance.TabStop = false;
            this.groupBoxBalance.Text = "Balance";
            // 
            // labelAbrirCom
            // 
            this.labelAbrirCom.AutoSize = true;
            this.labelAbrirCom.ForeColor = System.Drawing.Color.White;
            this.labelAbrirCom.Location = new System.Drawing.Point(23, 47);
            this.labelAbrirCom.Name = "labelAbrirCom";
            this.labelAbrirCom.Size = new System.Drawing.Size(99, 28);
            this.labelAbrirCom.TabIndex = 12;
            this.labelAbrirCom.Text = "Abrir com";
            // 
            // radioButtonBalanceUltimaConta
            // 
            this.radioButtonBalanceUltimaConta.AutoSize = true;
            this.radioButtonBalanceUltimaConta.ForeColor = System.Drawing.Color.White;
            this.radioButtonBalanceUltimaConta.Location = new System.Drawing.Point(35, 130);
            this.radioButtonBalanceUltimaConta.Name = "radioButtonBalanceUltimaConta";
            this.radioButtonBalanceUltimaConta.Size = new System.Drawing.Size(145, 32);
            this.radioButtonBalanceUltimaConta.TabIndex = 11;
            this.radioButtonBalanceUltimaConta.TabStop = true;
            this.radioButtonBalanceUltimaConta.Text = "Última conta";
            this.radioButtonBalanceUltimaConta.UseVisualStyleBackColor = true;
            // 
            // radioButtonBalanceContaPadrao
            // 
            this.radioButtonBalanceContaPadrao.AutoSize = true;
            this.radioButtonBalanceContaPadrao.ForeColor = System.Drawing.Color.White;
            this.radioButtonBalanceContaPadrao.Location = new System.Drawing.Point(35, 97);
            this.radioButtonBalanceContaPadrao.Name = "radioButtonBalanceContaPadrao";
            this.radioButtonBalanceContaPadrao.Size = new System.Drawing.Size(17, 16);
            this.radioButtonBalanceContaPadrao.TabIndex = 10;
            this.radioButtonBalanceContaPadrao.TabStop = true;
            this.radioButtonBalanceContaPadrao.UseVisualStyleBackColor = true;
            // 
            // comboBoxBalanceContaPadrao
            // 
            this.comboBoxBalanceContaPadrao.FormattingEnabled = true;
            this.comboBoxBalanceContaPadrao.Location = new System.Drawing.Point(58, 88);
            this.comboBoxBalanceContaPadrao.Name = "comboBoxBalanceContaPadrao";
            this.comboBoxBalanceContaPadrao.Size = new System.Drawing.Size(144, 36);
            this.comboBoxBalanceContaPadrao.TabIndex = 9;
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.BackColor = System.Drawing.Color.Black;
            this.tabPageDatabase.Controls.Add(this.tlpDatabaseMain);
            this.tabPageDatabase.ForeColor = System.Drawing.Color.White;
            this.tabPageDatabase.Location = new System.Drawing.Point(4, 37);
            this.tabPageDatabase.Name = "tabPageDatabase";
            this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabase.Size = new System.Drawing.Size(867, 503);
            this.tabPageDatabase.TabIndex = 0;
            this.tabPageDatabase.Text = "Banco de Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Abrir com";
            // 
            // radioButtonInvestimentosUltimaConta
            // 
            this.radioButtonInvestimentosUltimaConta.AutoSize = true;
            this.radioButtonInvestimentosUltimaConta.ForeColor = System.Drawing.Color.White;
            this.radioButtonInvestimentosUltimaConta.Location = new System.Drawing.Point(32, 130);
            this.radioButtonInvestimentosUltimaConta.Name = "radioButtonInvestimentosUltimaConta";
            this.radioButtonInvestimentosUltimaConta.Size = new System.Drawing.Size(145, 32);
            this.radioButtonInvestimentosUltimaConta.TabIndex = 15;
            this.radioButtonInvestimentosUltimaConta.TabStop = true;
            this.radioButtonInvestimentosUltimaConta.Text = "Última conta";
            this.radioButtonInvestimentosUltimaConta.UseVisualStyleBackColor = true;
            // 
            // radioButtonInvestimentosContaPadrao
            // 
            this.radioButtonInvestimentosContaPadrao.AutoSize = true;
            this.radioButtonInvestimentosContaPadrao.ForeColor = System.Drawing.Color.White;
            this.radioButtonInvestimentosContaPadrao.Location = new System.Drawing.Point(32, 97);
            this.radioButtonInvestimentosContaPadrao.Name = "radioButtonInvestimentosContaPadrao";
            this.radioButtonInvestimentosContaPadrao.Size = new System.Drawing.Size(17, 16);
            this.radioButtonInvestimentosContaPadrao.TabIndex = 14;
            this.radioButtonInvestimentosContaPadrao.TabStop = true;
            this.radioButtonInvestimentosContaPadrao.UseVisualStyleBackColor = true;
            // 
            // comboBoxInvestimentosContaPadrao
            // 
            this.comboBoxInvestimentosContaPadrao.FormattingEnabled = true;
            this.comboBoxInvestimentosContaPadrao.Location = new System.Drawing.Point(55, 88);
            this.comboBoxInvestimentosContaPadrao.Name = "comboBoxInvestimentosContaPadrao";
            this.comboBoxInvestimentosContaPadrao.Size = new System.Drawing.Size(144, 36);
            this.comboBoxInvestimentosContaPadrao.TabIndex = 13;
            // 
            // groupBoxInvestimentos
            // 
            this.groupBoxInvestimentos.Controls.Add(this.label1);
            this.groupBoxInvestimentos.Controls.Add(this.radioButtonInvestimentosUltimaConta);
            this.groupBoxInvestimentos.Controls.Add(this.comboBoxInvestimentosContaPadrao);
            this.groupBoxInvestimentos.Controls.Add(this.radioButtonInvestimentosContaPadrao);
            this.groupBoxInvestimentos.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxInvestimentos.Location = new System.Drawing.Point(268, 26);
            this.groupBoxInvestimentos.Name = "groupBoxInvestimentos";
            this.groupBoxInvestimentos.Size = new System.Drawing.Size(229, 190);
            this.groupBoxInvestimentos.TabIndex = 16;
            this.groupBoxInvestimentos.TabStop = false;
            this.groupBoxInvestimentos.Text = "Investimentos";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(875, 544);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfig_FormClosing);
            this.tlpDatabaseMain.ResumeLayout(false);
            this.tlpDatabaseMain.PerformLayout();
            this.tlpDatabaseLeftPanel.ResumeLayout(false);
            this.tlpDatabaseLeftPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.groupBoxBarraFerramentas.ResumeLayout(false);
            this.groupBoxBarraFerramentas.PerformLayout();
            this.groupBoxBackground.ResumeLayout(false);
            this.groupBoxBackground.PerformLayout();
            this.groupBoxCalendario.ResumeLayout(false);
            this.groupBoxCalendario.PerformLayout();
            this.groupBoxBalance.ResumeLayout(false);
            this.groupBoxBalance.PerformLayout();
            this.tabPageDatabase.ResumeLayout(false);
            this.groupBoxInvestimentos.ResumeLayout(false);
            this.groupBoxInvestimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveDatabase;
        private System.Windows.Forms.TableLayoutPanel tlpDatabaseMain;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.PropertyGrid propertyGridConn;
        private System.Windows.Forms.TableLayoutPanel tlpDatabaseLeftPanel;
        private System.Windows.Forms.ComboBox comboBoxStrings;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.Label labelConexoes;
        private System.Windows.Forms.Label labelSQLServers;
        private System.Windows.Forms.ListBox listBoxSQLServers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Label labelPastaDocumentos;
        private System.Windows.Forms.GroupBox groupBoxBarraFerramentas;
        private System.Windows.Forms.GroupBox groupBoxBackground;
        private System.Windows.Forms.GroupBox groupBoxCalendario;
        private System.Windows.Forms.GroupBox groupBoxBalance;
        private System.Windows.Forms.RadioButton radioButtonBalanceUltimaConta;
        private System.Windows.Forms.RadioButton radioButtonBalanceContaPadrao;
        private System.Windows.Forms.ComboBox comboBoxBalanceContaPadrao;
        private System.Windows.Forms.CheckBox checkBoxBarraFerramentasImagemeTexto;
        private System.Windows.Forms.CheckBox checkBoxBarraFerramentasVisivel;
        private System.Windows.Forms.CheckBox checkBoxBackgroundRodizio;
        private System.Windows.Forms.CheckBox checkBoxBackgroundVisivel;
        private System.Windows.Forms.Label labelCalendarioPastaPagamentos;
        private System.Windows.Forms.Label labelAbrirCom;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonInvestimentosUltimaConta;
        private System.Windows.Forms.RadioButton radioButtonInvestimentosContaPadrao;
        private System.Windows.Forms.ComboBox comboBoxInvestimentosContaPadrao;
        private System.Windows.Forms.GroupBox groupBoxInvestimentos;
    }
}