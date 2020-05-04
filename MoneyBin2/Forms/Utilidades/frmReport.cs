using DataLayer;
using MoneyBin2;
using SuperReport;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmReport : SuperReportViewer {

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private readonly ToolStripButton _toolStripButtonBalance = new ToolStripButton();
        private readonly ToolStripButton _toolStripButtonByMonth = new ToolStripButton();
        private readonly ToolStripButton _toolStripButtonByGroup = new ToolStripButton();
        private readonly ToolStripSeparator _toolStripSeparator1 = new ToolStripSeparator();
        private readonly ToolStripComboBox _toolStripComboBoxConta = new ToolStripComboBox();
        private readonly ToolStripLabel _toolStripLabelConta = new ToolStripLabel();
        private readonly ToolStripLabel _toolStripLabelInicio = new ToolStripLabel();
        private readonly ToolStripLabel _toolStripLabelTermino = new ToolStripLabel();
        private readonly ToolStripDateTimePicker _toolStripDateTimeInicio = new ToolStripDateTimePicker(DateTimePickerFormat.Short);
        private readonly ToolStripDateTimePicker _toolStripDateTimeTermino = new ToolStripDateTimePicker(DateTimePickerFormat.Short);

        public frmReport() {
            InitializeComponent();
            RptPath = AppDomain.CurrentDomain.BaseDirectory + @"Reports\{0}.rdlc";
            // 
            // toolStripButtonBalance
            // 
            this._toolStripButtonBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._toolStripButtonBalance.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this._toolStripButtonBalance.ForeColor = System.Drawing.Color.Black;
            this._toolStripButtonBalance.Name = "_toolStripButtonBalance";
            this._toolStripButtonBalance.Size = new System.Drawing.Size(80, 25);
            this._toolStripButtonBalance.Tag = "Balance";
            this._toolStripButtonBalance.Text = "Balance";
            this._toolStripButtonBalance.Click += new System.EventHandler(this.ToolStripButtonReport_Click);
            // 
            // toolStripButtonByMonth
            // 
            this._toolStripButtonByMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._toolStripButtonByMonth.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this._toolStripButtonByMonth.ForeColor = System.Drawing.Color.Black;
            this._toolStripButtonByMonth.Name = "_toolStripButtonByMonth";
            this._toolStripButtonByMonth.Size = new System.Drawing.Size(80, 25);
            this._toolStripButtonByMonth.Tag = "ComDescricao";
            this._toolStripButtonByMonth.Text = "Por Mês";
            this._toolStripButtonByMonth.Click += new System.EventHandler(this.ToolStripButtonReport_Click);
            // 
            // toolStripButtonByGroup
            // 
            this._toolStripButtonByGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._toolStripButtonByGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripButtonByGroup.ForeColor = System.Drawing.Color.Black;
            this._toolStripButtonByGroup.Name = "_toolStripButtonByGroup";
            this._toolStripButtonByGroup.Size = new System.Drawing.Size(80, 25);
            this._toolStripButtonByGroup.Tag = "PorGrupo";
            this._toolStripButtonByGroup.Text = "Por Grupo";
            this._toolStripButtonByGroup.Click += new System.EventHandler(this.ToolStripButtonReport_Click);
            // 
            // toolStripLabelBanco
            // 
            this._toolStripLabelConta.ForeColor = System.Drawing.Color.Black;
            this._toolStripLabelConta.Name = "_toolStripLabelConta";
            this._toolStripLabelConta.Size = new System.Drawing.Size(51, 25);
            this._toolStripLabelConta.Text = "Conta:";
            // 
            // toolStripComboBoxConta
            // 
            this._toolStripComboBoxConta.AutoSize = false;
            this._toolStripComboBoxConta.ForeColor = System.Drawing.Color.Black;
            this._toolStripComboBoxConta.Name = "_toolStripComboBoxConta";
            this._toolStripComboBoxConta.Size = new System.Drawing.Size(100, 28);
            this._toolStripComboBoxConta.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxConta_SelectedIndexChanged);
            // 
            // toolStripLabelInicio
            // 
            this._toolStripLabelInicio.ForeColor = System.Drawing.Color.Black;
            this._toolStripLabelInicio.Name = "_toolStripLabelInicio";
            this._toolStripLabelInicio.Size = new System.Drawing.Size(48, 25);
            this._toolStripLabelInicio.Text = "Início:";
            // 
            // toolStripLabelTermino
            // 
            this._toolStripLabelTermino.ForeColor = System.Drawing.Color.Black;
            this._toolStripLabelTermino.Name = "_toolStripLabelTermino";
            this._toolStripLabelTermino.Size = new System.Drawing.Size(66, 25);
            this._toolStripLabelTermino.Text = "Término:";

            _toolStripDateTimeInicio.Width = _toolStripDateTimeTermino.Width = 110;
            toolStripMenu.Items.AddRange(new ToolStripItem[] {
                _toolStripButtonBalance,
                _toolStripButtonByMonth,
                _toolStripButtonByGroup,
                _toolStripSeparator1,
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

            SetReport(report, "Balance", $@"DataSet{report}", dados);
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
