using DataLayer;
using MoneyBin2.RepServiceNF;
using SuperReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using IEnumerableExtensions;

namespace MoneyBin2 {
    public partial class frmReport : SuperReportViewer {

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private readonly ToolStripComboBox _toolStripComboBoxConta;
        private readonly ToolStripLabel _toolStripLabelConta;
        private readonly ToolStripLabel _toolStripLabelInicio;
        private readonly ToolStripLabel _toolStripLabelTermino;
        private readonly ToolStripDateTimePicker _toolStripDateTimeInicio = new ToolStripDateTimePicker(DateTimePickerFormat.Short);
        private readonly ToolStripDateTimePicker _toolStripDateTimeTermino = new ToolStripDateTimePicker(DateTimePickerFormat.Short);

        public frmReport() {
            InitializeComponent();
            SetServer(@"http://tyger-i7/reportserver");
            PopulateServerReportMenu("/MoneyBin");
            //PopulateLocalReportMenu();

            tsddbLocalReports.Visible = true;

            var _tsbBalance = new ToolStripMenuItem {
                Tag = "Balance",
                Text = "Balance"
            };
            _tsbBalance.Click += ToolStripButtonReport_Click;
            tsddbLocalReports.DropDownItems.Add(_tsbBalance);

            var _tsbByMonth = new ToolStripMenuItem {
                Tag = "ComDescricao",
                Text = "Por Mês"
            };
            _tsbByMonth.Click += ToolStripButtonReport_Click;
            tsddbLocalReports.DropDownItems.Add(_tsbByMonth);

            var _tsbByGroup = new ToolStripMenuItem {
                Tag = "PorGrupo",
                Text = "Por Grupo"
            };
            _tsbByGroup.Click += ToolStripButtonReport_Click;
            tsddbLocalReports.DropDownItems.Add(_tsbByGroup);

            _toolStripLabelConta = new ToolStripLabel("Conta:") {
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripLabelConta",
                Size = new System.Drawing.Size(51, 25)
            };

            _toolStripComboBoxConta = new ToolStripComboBox {
                AutoSize = false,
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripComboBoxConta",
                Size = new System.Drawing.Size(100, 28)
            };
            _toolStripComboBoxConta.SelectedIndexChanged += toolStripComboBoxConta_SelectedIndexChanged;

            _toolStripLabelInicio = new ToolStripLabel("Início:") {
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripLabelInicio",
                Size = new System.Drawing.Size(48, 25)
            };

            _toolStripLabelTermino = new ToolStripLabel("Término:") {
                ForeColor = System.Drawing.Color.Black,
                Name = "_toolStripLabelTermino",
                Size = new System.Drawing.Size(66, 25)
            };

            _toolStripDateTimeInicio.Width = _toolStripDateTimeTermino.Width = 110;
            toolStripMenu.Items.AddRange(new ToolStripItem[] {
                new ToolStripSeparator(),
                _toolStripLabelConta,
                _toolStripComboBoxConta,
                _toolStripLabelInicio,
                _toolStripDateTimeInicio,
                _toolStripLabelTermino,
                _toolStripDateTimeTermino });

            _toolStripComboBoxConta.ComboBox.DataSource = _ctx.Contas.Where(a => a.Balance.Any()).OrderBy(b => b.Apelido).ToList();
            _toolStripComboBoxConta.ComboBox.DisplayMember = "Apelido";
            _toolStripComboBoxConta.ComboBox.ValueMember = "ID";
            _toolStripComboBoxConta.Font = toolStripMenu.Font;
        }

        private void ToolStripButtonReport_Click(object sender, EventArgs e) {
            var report = (string)((ToolStripMenuItem)sender).Tag;
            var conta = (Conta)_toolStripComboBoxConta.SelectedItem;

            var dados = report == "PorGrupo"
                ? _ctx.Balance.Where(b => b.Data >= _toolStripDateTimeInicio.Value && b.Data <= _toolStripDateTimeTermino.Value)
                : conta.BalanceFiltrado(_toolStripDateTimeInicio.Value, _toolStripDateTimeTermino.Value);

            SetLocalReport(report, "Balance", $@"DataSet{report}", dados);
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
    }
}
