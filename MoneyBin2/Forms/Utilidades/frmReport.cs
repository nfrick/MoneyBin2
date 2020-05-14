using DataLayer;
using MoneyBin2.RepServiceNF;
using SuperReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmReport : SuperReportViewer {

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private readonly ToolStripButton _toolStripButtonBalance;
        private readonly ToolStripButton _toolStripButtonByMonth;
        private readonly ToolStripButton _toolStripButtonByGroup;
        private readonly ToolStripComboBox _toolStripComboBoxConta;
        private readonly ToolStripLabel _toolStripLabelConta;
        private readonly ToolStripLabel _toolStripLabelInicio;
        private readonly ToolStripLabel _toolStripLabelTermino;
        private readonly ToolStripDateTimePicker _toolStripDateTimeInicio = new ToolStripDateTimePicker(DateTimePickerFormat.Short);
        private readonly ToolStripDateTimePicker _toolStripDateTimeTermino = new ToolStripDateTimePicker(DateTimePickerFormat.Short);

        public frmReport() {
            InitializeComponent();
            RptPath = AppDomain.CurrentDomain.BaseDirectory + @"Reports\{0}.rdlc";
            // 
            // toolStripButtonBalance
            // 
            _toolStripButtonBalance = new ToolStripButton() {
                BackColor = System.Drawing.Color.FromArgb(255, 255, 192),
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripButtonBalance",
                Size = new System.Drawing.Size(80, 25),
                Tag = "Balance",
                Text = "Balance"
            };
            _toolStripButtonBalance.Click += new System.EventHandler(this.ToolStripButtonReport_Click);

            // 
            // toolStripButtonByMonth
            // 
            _toolStripButtonByMonth = new ToolStripButton() {
                BackColor = System.Drawing.Color.FromArgb(255, 224, 192),
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripButtonByMonth",
                Size = new System.Drawing.Size(80, 25),
                Tag = "ComDescricao",
                Text = "Por Mês"
            };
            _toolStripButtonByMonth.Click += new System.EventHandler(this.ToolStripButtonReport_Click);

            // 
            // toolStripButtonByGroup
            // 
            _toolStripButtonByGroup = new ToolStripButton() {
                BackColor = System.Drawing.Color.FromArgb(192, 255, 192),
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripButtonByGroup",
                Size = new System.Drawing.Size(80, 25),
                Tag = "PorGrupo",
                Text = "Por Grupo"
            };
            _toolStripButtonByGroup.Click += new System.EventHandler(this.ToolStripButtonReport_Click);

            // 
            // toolStripLabelConta
            // 
            _toolStripLabelConta = new ToolStripLabel("Conta:") {
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripLabelConta",
                Size = new System.Drawing.Size(51, 25)
            };

            // 
            // toolStripComboBoxConta
            // 
            _toolStripComboBoxConta = new ToolStripComboBox {
                AutoSize = false,
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripComboBoxConta",
                Size = new System.Drawing.Size(100, 28)
            };
            _toolStripComboBoxConta.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxConta_SelectedIndexChanged);

            // 
            // toolStripLabelInicio
            // 
            _toolStripLabelInicio = new ToolStripLabel("Início:") {
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripLabelInicio",
                Size = new System.Drawing.Size(48, 25)
            };

            // 
            // toolStripLabelTermino
            // 
            _toolStripLabelTermino = new ToolStripLabel("Término:") {
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripLabelTermino",
                Size = new System.Drawing.Size(66, 25)
            };

            _toolStripDateTimeInicio.Width = _toolStripDateTimeTermino.Width = 110;
            toolStripMenu.Items.AddRange(new ToolStripItem[] {
                _toolStripButtonBalance,
                _toolStripButtonByMonth,
                _toolStripButtonByGroup,
                new ToolStripSeparator(),
                _toolStripLabelConta,
                _toolStripComboBoxConta,
                _toolStripLabelInicio,
                _toolStripDateTimeInicio,
                _toolStripLabelTermino,
                _toolStripDateTimeTermino });

            _toolStripComboBoxConta.ComboBox.DataSource = _ctx.Contas.Where(a => a.Balance.Any()).OrderBy(b => b.Apelido).ToList();
            _toolStripComboBoxConta.ComboBox.DisplayMember = "Apelido";
            _toolStripComboBoxConta.ComboBox.ValueMember = "Apelido";
            _toolStripComboBoxConta.Font = toolStripMenu.Font;
        }

        private void ToolStripButtonReport_Click(object sender, EventArgs e) {
            var report = (string)((ToolStripButton)sender).Tag;
            var conta = (Conta)_toolStripComboBoxConta.SelectedItem;

            var dados = report == "PorGrupo"
                ? _ctx.Balance.Where(b => b.Data >= _toolStripDateTimeInicio.Value && b.Data <= _toolStripDateTimeTermino.Value)
                : conta.BalanceFiltrado(_toolStripDateTimeInicio.Value, _toolStripDateTimeTermino.Value);

            SetLocalReport(report, "Balance", $@"DataSet{report}", dados);

            //SetServerReport("http://tyger-i7/reportserver", "/Investimentos/Tudo XTab");

        }

        private void toolStripComboBoxConta_SelectedIndexChanged(object sender, EventArgs e) {
            var conta = (Conta)_toolStripComboBoxConta.SelectedItem;
            if (conta.DataMax.Year == 1900) {
                _toolStripDateTimeInicio.Value = _toolStripDateTimeTermino.Value = DateTime.Today;
                _toolStripDateTimeInicio.Enabled = _toolStripDateTimeTermino.Enabled = false;
            }
            else {
                var menosSeis = conta.DataMax.AddMonths(-6);
                _toolStripDateTimeInicio.MinDate = conta.DataMin;
                _toolStripDateTimeInicio.MaxDate = conta.DataMax;
                _toolStripDateTimeInicio.Value = (menosSeis.CompareTo(conta.DataMin) < 0) ? conta.DataMin : menosSeis;

                _toolStripDateTimeTermino.MinDate = conta.DataMin;
                _toolStripDateTimeTermino.MaxDate = conta.DataMax;
                _toolStripDateTimeTermino.Value = conta.DataMax;
            }
        }

        private IEnumerable<string> GetServerReports() {
            // http://ssrstutorials.blogspot.com/2012/10/lesson-12-using-ssrs-web-services.html
            var rs = new ReportingService2005 { Credentials = System.Net.CredentialCache.DefaultCredentials };

            // Retrieve a list of all items from the report server database.   
            try {
                return rs.ListChildren("/", true).Where(i => i.Type == ItemTypeEnum.Report)
                    .Select(i => i.Path);
            }

            catch (SoapException ex) {
                Console.WriteLine(ex.Detail.OuterXml);
                return null;
            }
        }
    }
}
