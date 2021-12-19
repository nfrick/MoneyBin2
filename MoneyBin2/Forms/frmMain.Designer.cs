namespace MoneyBin2 {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbContas = new System.Windows.Forms.ToolStripButton();
            this.tsbBalance = new System.Windows.Forms.ToolStripButton();
            this.tsbLeitor = new System.Windows.Forms.ToolStripButton();
            this.tsbRegras = new System.Windows.Forms.ToolStripButton();
            this.tsbClassificacao = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisa = new System.Windows.Forms.ToolStripButton();
            this.tsbExportar = new System.Windows.Forms.ToolStripButton();
            this.tsbRelatorios = new System.Windows.Forms.ToolStripButton();
            this.tsbPagamentos = new System.Windows.Forms.ToolStripButton();
            this.tsbCalendario = new System.Windows.Forms.ToolStripButton();
            this.tsbSerieHistorica = new System.Windows.Forms.ToolStripButton();
            this.tsbInvestimentos = new System.Windows.Forms.ToolStripButton();
            this.tsbConfiguracao = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmiExtrato = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBalanceSF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBancos_Contas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClassificacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPagamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPagamentos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInvestimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInvestimentos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAcoesSerieHistorica = new System.Windows.Forms.ToolStripMenuItem();
            this.AcoesCotaçoesTempoReal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFundos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConexoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBarraDeFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolbarVisivel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolbarImagemApenas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundRodizio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundVisivel = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBackground = new System.Windows.Forms.Timer(this.components);
            this.toolStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbContas,
            this.tsbBalance,
            this.tsbLeitor,
            this.tsbRegras,
            this.tsbClassificacao,
            this.tsbPesquisa,
            this.tsbExportar,
            this.tsbRelatorios,
            this.tsbPagamentos,
            this.tsbCalendario,
            this.tsbSerieHistorica,
            this.tsbInvestimentos,
            this.tsbConfiguracao});
            this.toolStripMain.Location = new System.Drawing.Point(0, 28);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1214, 59);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbContas
            // 
            this.tsbContas.BackColor = System.Drawing.Color.LemonChiffon;
            this.tsbContas.Image = global::MoneyBin2.Properties.Resources.Banco;
            this.tsbContas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbContas.Name = "tsbContas";
            this.tsbContas.Size = new System.Drawing.Size(121, 56);
            this.tsbContas.Text = "Bancos e Contas";
            this.tsbContas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbContas.Click += new System.EventHandler(this.tsbContas_Click);
            // 
            // tsbBalance
            // 
            this.tsbBalance.BackColor = System.Drawing.Color.PeachPuff;
            this.tsbBalance.Image = global::MoneyBin2.Properties.Resources.Balance;
            this.tsbBalance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBalance.Name = "tsbBalance";
            this.tsbBalance.Size = new System.Drawing.Size(65, 56);
            this.tsbBalance.Text = "Balance";
            this.tsbBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBalance.Click += new System.EventHandler(this.tsbBalance_Click);
            // 
            // tsbLeitor
            // 
            this.tsbLeitor.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tsbLeitor.Image = global::MoneyBin2.Properties.Resources.Oculos;
            this.tsbLeitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeitor.Name = "tsbLeitor";
            this.tsbLeitor.Size = new System.Drawing.Size(51, 56);
            this.tsbLeitor.Text = "Leitor";
            this.tsbLeitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLeitor.Click += new System.EventHandler(this.tsbLeitor_Click);
            // 
            // tsbRegras
            // 
            this.tsbRegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsbRegras.Image = global::MoneyBin2.Properties.Resources.Regras;
            this.tsbRegras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegras.Name = "tsbRegras";
            this.tsbRegras.Size = new System.Drawing.Size(58, 56);
            this.tsbRegras.Text = "Regras";
            this.tsbRegras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRegras.Click += new System.EventHandler(this.tsbRegras_Click);
            // 
            // tsbClassificacao
            // 
            this.tsbClassificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsbClassificacao.Image = global::MoneyBin2.Properties.Resources.Classificar;
            this.tsbClassificacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClassificacao.Name = "tsbClassificacao";
            this.tsbClassificacao.Size = new System.Drawing.Size(98, 56);
            this.tsbClassificacao.Text = "Classificação";
            this.tsbClassificacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClassificacao.Click += new System.EventHandler(this.tsbClassificacao_Click);
            // 
            // tsbPesquisa
            // 
            this.tsbPesquisa.Image = global::MoneyBin2.Properties.Resources.Binóculos;
            this.tsbPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisa.Name = "tsbPesquisa";
            this.tsbPesquisa.Size = new System.Drawing.Size(69, 56);
            this.tsbPesquisa.Text = "Pesquisa";
            this.tsbPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPesquisa.Click += new System.EventHandler(this.tsbPesquisa_Click);
            // 
            // tsbExportar
            // 
            this.tsbExportar.BackColor = System.Drawing.Color.Khaki;
            this.tsbExportar.Image = global::MoneyBin2.Properties.Resources.Exportar;
            this.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportar.Name = "tsbExportar";
            this.tsbExportar.Size = new System.Drawing.Size(69, 56);
            this.tsbExportar.Text = "Exportar";
            this.tsbExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExportar.Visible = false;
            this.tsbExportar.Click += new System.EventHandler(this.tsbExportar_Click);
            // 
            // tsbRelatorios
            // 
            this.tsbRelatorios.BackColor = System.Drawing.Color.PowderBlue;
            this.tsbRelatorios.Image = global::MoneyBin2.Properties.Resources.Relatorios;
            this.tsbRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRelatorios.Name = "tsbRelatorios";
            this.tsbRelatorios.Size = new System.Drawing.Size(80, 56);
            this.tsbRelatorios.Text = "Relatórios";
            this.tsbRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRelatorios.Click += new System.EventHandler(this.tsbRelatorios_Click);
            // 
            // tsbPagamentos
            // 
            this.tsbPagamentos.BackColor = System.Drawing.Color.Moccasin;
            this.tsbPagamentos.Image = global::MoneyBin2.Properties.Resources.Dinheiro;
            this.tsbPagamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPagamentos.Name = "tsbPagamentos";
            this.tsbPagamentos.Size = new System.Drawing.Size(94, 56);
            this.tsbPagamentos.Text = "Pagamentos";
            this.tsbPagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPagamentos.Click += new System.EventHandler(this.tsbPagamentos_Click);
            // 
            // tsbCalendario
            // 
            this.tsbCalendario.Image = global::MoneyBin2.Properties.Resources.Calendario;
            this.tsbCalendario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalendario.Name = "tsbCalendario";
            this.tsbCalendario.Size = new System.Drawing.Size(85, 56);
            this.tsbCalendario.Text = "Calendário";
            this.tsbCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCalendario.Click += new System.EventHandler(this.tsbCalendario_Click);
            // 
            // tsbSerieHistorica
            // 
            this.tsbSerieHistorica.Image = global::MoneyBin2.Properties.Resources.SerieHistorica48;
            this.tsbSerieHistorica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSerieHistorica.Name = "tsbSerieHistorica";
            this.tsbSerieHistorica.Size = new System.Drawing.Size(109, 56);
            this.tsbSerieHistorica.Text = "Série Histórica";
            this.tsbSerieHistorica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSerieHistorica.Click += new System.EventHandler(this.tsbSerieHistorica_Click);
            // 
            // tsbInvestimentos
            // 
            this.tsbInvestimentos.Image = global::MoneyBin2.Properties.Resources.dollar48;
            this.tsbInvestimentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvestimentos.Name = "tsbInvestimentos";
            this.tsbInvestimentos.Size = new System.Drawing.Size(104, 56);
            this.tsbInvestimentos.Text = "Investimentos";
            this.tsbInvestimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInvestimentos.Click += new System.EventHandler(this.tsbInvestimentos_Click);
            // 
            // tsbConfiguracao
            // 
            this.tsbConfiguracao.BackColor = System.Drawing.Color.AliceBlue;
            this.tsbConfiguracao.Image = global::MoneyBin2.Properties.Resources.Config;
            this.tsbConfiguracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfiguracao.Name = "tsbConfiguracao";
            this.tsbConfiguracao.Size = new System.Drawing.Size(102, 56);
            this.tsbConfiguracao.Text = "Configuração";
            this.tsbConfiguracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConfiguracao.Click += new System.EventHandler(this.tsbConfig_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExtrato,
            this.tsmiPagamentos,
            this.tsmiInvestimentos,
            this.tsmiConfiguracao});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1214, 28);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsmiExtrato
            // 
            this.tsmiExtrato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBalanceSF,
            this.tsmiBancos_Contas,
            this.tsmiRegras,
            this.tsmiClassificacao,
            this.tsmiPesquisa,
            this.tsmiExportar,
            this.tsmiRelatorios,
            this.tsmiBalance});
            this.tsmiExtrato.Image = global::MoneyBin2.Properties.Resources.Binóculos;
            this.tsmiExtrato.Name = "tsmiExtrato";
            this.tsmiExtrato.Size = new System.Drawing.Size(90, 24);
            this.tsmiExtrato.Text = "Extrato";
            // 
            // tsmiBalanceSF
            // 
            this.tsmiBalanceSF.Name = "tsmiBalanceSF";
            this.tsmiBalanceSF.Size = new System.Drawing.Size(201, 26);
            this.tsmiBalanceSF.Text = "Balance";
            this.tsmiBalanceSF.Click += new System.EventHandler(this.tsbBalance_Click);
            // 
            // tsmiBancos_Contas
            // 
            this.tsmiBancos_Contas.Image = global::MoneyBin2.Properties.Resources.Banco;
            this.tsmiBancos_Contas.Name = "tsmiBancos_Contas";
            this.tsmiBancos_Contas.Size = new System.Drawing.Size(201, 26);
            this.tsmiBancos_Contas.Text = "Bancos e Contas";
            this.tsmiBancos_Contas.Click += new System.EventHandler(this.tsbContas_Click);
            // 
            // tsmiRegras
            // 
            this.tsmiRegras.Image = global::MoneyBin2.Properties.Resources.Regras;
            this.tsmiRegras.Name = "tsmiRegras";
            this.tsmiRegras.Size = new System.Drawing.Size(201, 26);
            this.tsmiRegras.Text = "Regras";
            this.tsmiRegras.Click += new System.EventHandler(this.tsbRegras_Click);
            // 
            // tsmiClassificacao
            // 
            this.tsmiClassificacao.Image = global::MoneyBin2.Properties.Resources.Classificar;
            this.tsmiClassificacao.Name = "tsmiClassificacao";
            this.tsmiClassificacao.Size = new System.Drawing.Size(201, 26);
            this.tsmiClassificacao.Text = "Classificação";
            this.tsmiClassificacao.Click += new System.EventHandler(this.tsbClassificacao_Click);
            // 
            // tsmiPesquisa
            // 
            this.tsmiPesquisa.Image = global::MoneyBin2.Properties.Resources.Binóculos;
            this.tsmiPesquisa.Name = "tsmiPesquisa";
            this.tsmiPesquisa.Size = new System.Drawing.Size(201, 26);
            this.tsmiPesquisa.Text = "Pesquisa";
            this.tsmiPesquisa.Click += new System.EventHandler(this.tsbPesquisa_Click);
            // 
            // tsmiExportar
            // 
            this.tsmiExportar.Image = global::MoneyBin2.Properties.Resources.Exportar;
            this.tsmiExportar.Name = "tsmiExportar";
            this.tsmiExportar.Size = new System.Drawing.Size(201, 26);
            this.tsmiExportar.Text = "Exportar";
            this.tsmiExportar.Click += new System.EventHandler(this.tsbExportar_Click);
            // 
            // tsmiRelatorios
            // 
            this.tsmiRelatorios.Image = global::MoneyBin2.Properties.Resources.Relatorios;
            this.tsmiRelatorios.Name = "tsmiRelatorios";
            this.tsmiRelatorios.Size = new System.Drawing.Size(201, 26);
            this.tsmiRelatorios.Text = "Relatórios";
            this.tsmiRelatorios.Click += new System.EventHandler(this.tsbRelatorios_Click);
            // 
            // tsmiBalance
            // 
            this.tsmiBalance.Image = global::MoneyBin2.Properties.Resources.Dinheiro;
            this.tsmiBalance.Name = "tsmiBalance";
            this.tsmiBalance.Size = new System.Drawing.Size(201, 26);
            this.tsmiBalance.Text = "Balance (antigo)";
            this.tsmiBalance.Click += new System.EventHandler(this.tsbBalanceAntigo_Click);
            // 
            // tsmiPagamentos
            // 
            this.tsmiPagamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalendario,
            this.tsmiPagamentos1});
            this.tsmiPagamentos.Name = "tsmiPagamentos";
            this.tsmiPagamentos.Size = new System.Drawing.Size(104, 24);
            this.tsmiPagamentos.Text = "Pagamentos";
            // 
            // tsmiCalendario
            // 
            this.tsmiCalendario.Image = global::MoneyBin2.Properties.Resources.Calendario;
            this.tsmiCalendario.Name = "tsmiCalendario";
            this.tsmiCalendario.Size = new System.Drawing.Size(173, 26);
            this.tsmiCalendario.Text = "Calendário";
            this.tsmiCalendario.Click += new System.EventHandler(this.tsbCalendario_Click);
            // 
            // tsmiPagamentos1
            // 
            this.tsmiPagamentos1.Image = global::MoneyBin2.Properties.Resources.Dinheiro;
            this.tsmiPagamentos1.Name = "tsmiPagamentos1";
            this.tsmiPagamentos1.Size = new System.Drawing.Size(173, 26);
            this.tsmiPagamentos1.Text = "Pagamentos";
            this.tsmiPagamentos1.Click += new System.EventHandler(this.tsbPagamentos_Click);
            // 
            // tsmiInvestimentos
            // 
            this.tsmiInvestimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInvestimentos1,
            this.tsmiAcoesSerieHistorica,
            this.AcoesCotaçoesTempoReal,
            this.tsmiFundos});
            this.tsmiInvestimentos.Name = "tsmiInvestimentos";
            this.tsmiInvestimentos.Size = new System.Drawing.Size(114, 24);
            this.tsmiInvestimentos.Text = "Investimentos";
            // 
            // tsmiInvestimentos1
            // 
            this.tsmiInvestimentos1.Image = global::MoneyBin2.Properties.Resources.dollar48;
            this.tsmiInvestimentos1.Name = "tsmiInvestimentos1";
            this.tsmiInvestimentos1.Size = new System.Drawing.Size(290, 26);
            this.tsmiInvestimentos1.Text = "Investimentos";
            this.tsmiInvestimentos1.Click += new System.EventHandler(this.tsbInvestimentos_Click);
            // 
            // tsmiAcoesSerieHistorica
            // 
            this.tsmiAcoesSerieHistorica.Image = global::MoneyBin2.Properties.Resources.SerieHistorica48;
            this.tsmiAcoesSerieHistorica.Name = "tsmiAcoesSerieHistorica";
            this.tsmiAcoesSerieHistorica.Size = new System.Drawing.Size(290, 26);
            this.tsmiAcoesSerieHistorica.Text = "Ações Série Histórica";
            this.tsmiAcoesSerieHistorica.Click += new System.EventHandler(this.tsbSerieHistorica_Click);
            // 
            // AcoesCotaçoesTempoReal
            // 
            this.AcoesCotaçoesTempoReal.Name = "AcoesCotaçoesTempoReal";
            this.AcoesCotaçoesTempoReal.Size = new System.Drawing.Size(290, 26);
            this.AcoesCotaçoesTempoReal.Text = "Ações - Cotações Tempo Real";
            // 
            // tsmiFundos
            // 
            this.tsmiFundos.Name = "tsmiFundos";
            this.tsmiFundos.Size = new System.Drawing.Size(290, 26);
            this.tsmiFundos.Text = "Fundos";
            this.tsmiFundos.Click += new System.EventHandler(this.tsmiFundos_Click);
            // 
            // tsmiConfiguracao
            // 
            this.tsmiConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConexoes,
            this.tsmiBarraDeFerramentas,
            this.tsmiBackground});
            this.tsmiConfiguracao.Name = "tsmiConfiguracao";
            this.tsmiConfiguracao.Size = new System.Drawing.Size(112, 24);
            this.tsmiConfiguracao.Text = "Configuração";
            // 
            // tsmiConexoes
            // 
            this.tsmiConexoes.Image = global::MoneyBin2.Properties.Resources.Configuracao;
            this.tsmiConexoes.Name = "tsmiConexoes";
            this.tsmiConexoes.Size = new System.Drawing.Size(299, 26);
            this.tsmiConexoes.Text = "Conexões com banos de dados";
            this.tsmiConexoes.Click += new System.EventHandler(this.tsbConfig_Click);
            // 
            // tsmiBarraDeFerramentas
            // 
            this.tsmiBarraDeFerramentas.Checked = true;
            this.tsmiBarraDeFerramentas.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.tsmiBarraDeFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolbarVisivel,
            this.tsmiToolbarImagemApenas});
            this.tsmiBarraDeFerramentas.Name = "tsmiBarraDeFerramentas";
            this.tsmiBarraDeFerramentas.Size = new System.Drawing.Size(299, 26);
            this.tsmiBarraDeFerramentas.Text = "Barra de ferramentas";
            // 
            // tsmiToolbarVisivel
            // 
            this.tsmiToolbarVisivel.CheckOnClick = true;
            this.tsmiToolbarVisivel.Name = "tsmiToolbarVisivel";
            this.tsmiToolbarVisivel.Size = new System.Drawing.Size(224, 26);
            this.tsmiToolbarVisivel.Text = "Visivel";
            this.tsmiToolbarVisivel.CheckedChanged += new System.EventHandler(this.tsmiToolbarVisivel_CheckedChanged);
            // 
            // tsmiToolbarImagemApenas
            // 
            this.tsmiToolbarImagemApenas.CheckOnClick = true;
            this.tsmiToolbarImagemApenas.Name = "tsmiToolbarImagemApenas";
            this.tsmiToolbarImagemApenas.Size = new System.Drawing.Size(224, 26);
            this.tsmiToolbarImagemApenas.Text = "Imagem apenas";
            this.tsmiToolbarImagemApenas.CheckedChanged += new System.EventHandler(this.tsmiToolbarImagemApenas_CheckedChanged);
            // 
            // tsmiBackground
            // 
            this.tsmiBackground.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackgroundRodizio,
            this.tsmiBackgroundVisivel});
            this.tsmiBackground.Image = global::MoneyBin2.Properties.Resources.Uncle_Scrooge_McDuck;
            this.tsmiBackground.Name = "tsmiBackground";
            this.tsmiBackground.Size = new System.Drawing.Size(299, 26);
            this.tsmiBackground.Text = "Background";
            // 
            // tsmiBackgroundRodizio
            // 
            this.tsmiBackgroundRodizio.CheckOnClick = true;
            this.tsmiBackgroundRodizio.Name = "tsmiBackgroundRodizio";
            this.tsmiBackgroundRodizio.Size = new System.Drawing.Size(224, 26);
            this.tsmiBackgroundRodizio.Text = "Rodízio";
            this.tsmiBackgroundRodizio.CheckedChanged += new System.EventHandler(this.tsmiBackgroundRodízio_CheckedChanged);
            // 
            // tsmiBackgroundVisivel
            // 
            this.tsmiBackgroundVisivel.CheckOnClick = true;
            this.tsmiBackgroundVisivel.Name = "tsmiBackgroundVisivel";
            this.tsmiBackgroundVisivel.Size = new System.Drawing.Size(224, 26);
            this.tsmiBackgroundVisivel.Text = "Visível";
            this.tsmiBackgroundVisivel.CheckedChanged += new System.EventHandler(this.tsmiBackgroundVisível_CheckedChanged);
            // 
            // timerBackground
            // 
            this.timerBackground.Interval = 60000;
            this.timerBackground.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "Money Bin 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbContas;
        private System.Windows.Forms.ToolStripButton tsbRegras;
        private System.Windows.Forms.ToolStripButton tsbLeitor;
        private System.Windows.Forms.ToolStripButton tsbBalance;
        private System.Windows.Forms.ToolStripButton tsbClassificacao;
        private System.Windows.Forms.ToolStripMenuItem tsmiExtrato;
        private System.Windows.Forms.ToolStripMenuItem tsmiBalance;
        private System.Windows.Forms.ToolStripMenuItem tsmiBancos_Contas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegras;
        private System.Windows.Forms.ToolStripMenuItem tsmiClassificacao;
        private System.Windows.Forms.ToolStripButton tsbExportar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportar;
        private System.Windows.Forms.Timer timerBackground;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem tsmiConexoes;
        private System.Windows.Forms.ToolStripMenuItem tsmiBarraDeFerramentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackground;
        private System.Windows.Forms.ToolStripButton tsbRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelatorios;
        private System.Windows.Forms.ToolStripButton tsbPagamentos;
        private System.Windows.Forms.ToolStripButton tsbCalendario;
        private System.Windows.Forms.ToolStripButton tsbConfiguracao;
        private System.Windows.Forms.ToolStripButton tsbSerieHistorica;
        private System.Windows.Forms.ToolStripButton tsbInvestimentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiPagamentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalendario;
        private System.Windows.Forms.ToolStripMenuItem tsmiPagamentos1;
        private System.Windows.Forms.ToolStripMenuItem tsmiInvestimentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiInvestimentos1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAcoesSerieHistorica;
        private System.Windows.Forms.ToolStripMenuItem AcoesCotaçoesTempoReal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFundos;
        private System.Windows.Forms.ToolStripButton tsbPesquisa;
        private System.Windows.Forms.ToolStripMenuItem tsmiPesquisa;
        private System.Windows.Forms.ToolStripMenuItem tsmiBalanceSF;
        public System.Windows.Forms.ToolStripMenuItem tsmiToolbarVisivel;
        public System.Windows.Forms.ToolStripMenuItem tsmiToolbarImagemApenas;
        public System.Windows.Forms.ToolStripMenuItem tsmiBackgroundRodizio;
        public System.Windows.Forms.ToolStripMenuItem tsmiBackgroundVisivel;
        public System.Windows.Forms.MenuStrip menuStripMain;
    }
}

