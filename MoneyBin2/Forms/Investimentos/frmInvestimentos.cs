﻿using ChartLibrary;
using DataLayer;
using IEnumerableExtensions;
using MoneyBin2.Properties;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using SuperPrompt;
using Syncfusion.Data.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyBin2 {

    //public enum posicao {
    //    Papel,
    //    Nada,
    //    Cotação,
    //    VarPercent,
    //    QtdComprada,
    //    Compra,
    //    Venda,
    //    QtdVendida,
    //    Max,
    //    Min,
    //    Fech
    //}

    public partial class frmInvestimentos : Form {
        private const string DialogTitle = "Ler extrato de fundo";
        private string _balancePath;

        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();

        private Conta ContaAtual => (Conta)toolStripComboBoxConta.SelectedItem;

        private readonly ToolStripCheckbox _chkShowAll = new ToolStripCheckbox("chkAcoesMostrarZeradas", "Mostrar zeradas", false) {
            Tag = "Ações, Fundos, LCA, Resumo",
            ForeColor = SystemColors.ControlText,
            BackColor = SystemColors.Control
        };

        public frmInvestimentos() {
            InitializeComponent();

            _chkShowAll.CheckedChanged += (sender, args) => {
                var showAll = ((ToolStripCheckbox)sender).Checked;
                var sufixo = showAll ? "" : "NaoZerado";
                bsAcoes.DataMember = "Acoes" + sufixo;
                bsFundos.DataMember = "Fundos" + sufixo;

                UpdateResumo();
            };
            toolStripMenu.Items.Insert(3, _chkShowAll);

            SFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";
            SFD.CheckFileExists = false;
            SFD.OverwritePrompt = true;
        }

        #region FORM --------------------------------------------
        private void frmInvestimentos_Load(object sender, EventArgs e) {

            // AÇÕES
            dgvAcoes.FormatColumnByHeader("Código", dgvAcoes.StyleBase, 60);
            dgvAcoes.FormatColumnByHeader("Qtd", dgvAcoes.StyleInteger, 60);
            dgvAcoes.FormatColumnByHeader("Último Preço", dgvAcoes.StyleCurrency, 70);
            dgvAcoes.FormatColumnByHeader("Total", dgvAcoes.StyleCurrency, 95);

            dgvOperacoes.FormatColumnByHeader("Data", dgvOperacoes.StyleDateTimeShort, 120);
            dgvOperacoes.FormatColumnByHeader("Operação", dgvOperacoes.StyleBase, 100);
            dgvOperacoes.FormatColumnByHeader("Qtd", dgvOperacoes.StyleInteger, 65);
            dgvOperacoes.FormatColumnByHeader("Acum.", dgvOperacoes.StyleInteger, 65);
            dgvOperacoes.FormatColumnByHeader("Valor Nominal", dgvOperacoes.StyleCurrency, 68);
            dgvOperacoes.FormatColumnByHeader("Valor Real", dgvOperacoes.StyleCurrency, 68);
            dgvOperacoes.FormatColumnByHeader("Valor Operação", dgvOperacoes.StyleCurrency, 95);
            dgvOperacoes.FormatColumnByHeader("Custos", dgvOperacoes.StyleCurrency, 68);

            dgvVendas.FormatColumnByHeader("Data", dgvVendas.StyleDateTimeShort, 120);
            dgvVendas.FormatColumnByHeader("Antes", dgvVendas.StyleInteger, 75);
            dgvVendas.FormatColumnByHeader("Venda", dgvVendas.StyleInteger, 75);
            dgvVendas.FormatColumnByHeader("Depois", dgvVendas.StyleInteger, 75);
            dgvVendas.FormatColumnByHeader("Valor", dgvVendas.StyleCurrency, 75);
            dgvVendas.FormatColumnByHeader("Valor Real", dgvVendas.StyleCurrency, 75);
            dgvVendas.FormatColumnByHeader("Compras", dgvVendas.StyleInteger, 75);
            dgvVendas.FormatColumnByHeader("Pendente", dgvVendas.StyleInteger, 75);
            dgvVendas.FormatColumnByHeader("VM Compra", dgvVendas.StyleCurrency, 75);
            dgvVendas.FormatColumnByHeader("VM Compra Real", dgvVendas.StyleCurrency, 75);
            dgvVendas.FormatColumnByHeader("Lucro", dgvVendas.StyleCurrency, 75);
            dgvVendas.FormatColumnByHeader("Lucro Real", dgvVendas.StyleCurrency, 75);

            // FUNDOS
            dgvFundos.FormatColumnByHeader("Fundo", dgvFundos.StyleBase, -1);
            dgvFundos.FormatColumnByHeader("Saldo", dgvFundos.StyleCurrency, 100);
            dgvFundos.FormatColumnByHeader("Rend. Líquido", dgvFundos.StyleCurrency, 95);

            //0 mes, 1 saldo, 2 qtd cotas, 3 valor cota, 4 rend bruto, 5 ir, 6 iof, 7 rendliquido, 8 rend mes, rend ano, rend12 meses
            dgvContasMeses.FormatColumnByHeader("Mês", dgvContasMeses.StyleMMMAndYear, 80);
            dgvContasMeses.FormatColumnByHeader("Saldo Mês", dgvContasMeses.StyleCurrency, 100);
            dgvContasMeses.FormatColumnByHeader("Qtd Cotas", dgvContasMeses.StyleNumber(6), 120);
            dgvContasMeses.FormatColumnByHeader("Valor Cota", dgvContasMeses.StyleNumber(6), 95);
            dgvContasMeses.FormatColumnByHeader("Rend. Bruto", dgvContasMeses.StyleCurrency, 95);
            dgvContasMeses.FormatColumnByHeader("I.R.", dgvContasMeses.StyleCurrency, 60);
            dgvContasMeses.FormatColumnByHeader("IOF", dgvContasMeses.StyleCurrency, 60);
            dgvContasMeses.FormatColumnByHeader("Rend. Líquido", dgvContasMeses.StyleCurrency, 85);
            dgvContasMeses.FormatColumnByHeader("Rend. Mês", dgvContasMeses.StyleNumber(4), 95);
            dgvContasMeses.FormatColumnByHeader("Rend. Ano", dgvContasMeses.StyleNumber(4), 95);
            dgvContasMeses.FormatColumnByHeader("Rend. 12 Meses", dgvContasMeses.StyleNumber(4), 95);

            // data, historico, valor, IR, IOF, Qtd Cotas, Valor Cota
            dgvMovimentos.FormatColumnByHeader("Data", dgvMovimentos.StyleDateShort, 75);
            dgvMovimentos.FormatColumnByHeader("Histórico", dgvMovimentos.StyleBase, -1);
            dgvMovimentos.FormatColumnByHeader("Valor", dgvMovimentos.StyleCurrency, 90);
            dgvMovimentos.FormatColumnByHeader("I.R.", dgvMovimentos.StyleCurrency, 70);
            dgvMovimentos.FormatColumnByHeader("IOF", dgvMovimentos.StyleCurrency, 70);
            dgvMovimentos.FormatColumnByHeader("Qtd Cotas", dgvMovimentos.StyleNumber(4), 95);
            dgvMovimentos.FormatColumnByHeader("Valor Cota", dgvMovimentos.StyleNumber(6), 95);

            // LCA
            dgvLCAs.Columns[0].Width = 70;
            dgvLCAs.FormatColumnByHeader("Número", null, 70);
            dgvLCAs.FormatColumnByHeader("Aplic.", dgvLCAs.StyleDateShort, 69);
            dgvLCAs.FormatColumnByHeader("Venc.", dgvLCAs.StyleDateShort, 69);
            dgvLCAs.FormatColumnByHeader("Taxa", dgvLCAs.StyleCurrency, 50);
            dgvLCAs.FormatColumnByHeader("Valor Emissão", dgvLCAs.StyleCurrency, 80);
            dgvLCAs.FormatColumnByHeader("Saldo", dgvLCAs.StyleCurrency, 70);
            dgvLCAs.FormatColumnByHeader("Rend. Líq.", dgvLCAs.StyleCurrency, 80);
            dgvLCAs.FormatColumnByHeader("Rend. %", dgvLCAs.StylePercent, 60);
            dgvLCAs.FormatColumnByHeader("Rend. Mensal", dgvLCAs.StylePercent, 55);


            dgvLCAMeses.FormatColumnByHeader("Mês", dgvLCAMeses.StyleMMMAndYear, 80);
            dgvLCAMeses.FormatColumnByHeader("Aplicações", dgvLCAMeses.StyleCurrency, 90);
            dgvLCAMeses.FormatColumnByHeader("Resgates", dgvLCAMeses.StyleCurrency, 90);
            dgvLCAMeses.FormatColumnByHeader("Rend. Bruto", dgvLCAMeses.StyleCurrency, 90);
            //dgvLCAMeses.FormatColumnByHeader("I.R.", dgvLCAMeses.StyleCurrency, 60);
            //dgvLCAMeses.FormatColumnByHeader("I.O.F.", dgvLCAMeses.StyleCurrency, 60);
            dgvLCAMeses.FormatColumnByHeader("Rend. Líquido", dgvLCAMeses.StyleCurrency, 80);
            dgvLCAMeses.FormatColumnByHeader("Saldo", dgvLCAMeses.StyleCurrency, 90);
            dgvLCAMeses.FormatColumnByHeader("Rend. Mês", dgvLCAMeses.StylePercent, 70);

            dgvLCAMovimentos.FormatColumnByHeader("Data", dgvLCAMeses.StyleDateShort, 70);
            dgvLCAMovimentos.FormatColumnByHeader("Histórico", dgvLCAMeses.StyleBase, -1);
            //dgvLCAMovimentos.FormatColumnByHeader("I.R.", dgvLCAMeses.StyleCurrency, 60);
            //dgvLCAMovimentos.FormatColumnByHeader("I.O.F.", dgvLCAMeses.StyleCurrency, 60);
            dgvLCAMovimentos.FormatColumnByHeader("Rend.", dgvLCAMeses.StyleCurrency, 90);
            dgvLCAMovimentos.FormatColumnByHeader("Valor Atual", dgvLCAMeses.StyleCurrency, 90);

            // RESUMO
            dgvResumoAcoes.FormatColumnByHeader("Item", dgvResumoAcoes.StyleBase, -1);
            dgvResumoAcoes.FormatColumnByHeader("Valor", dgvResumoAcoes.StyleCurrency, 100);
            dgvResumoAcoes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvResumoFundos.CopyFormatFrom(dgvResumoAcoes);

            // 60 = vertical scroll bar width
            var w0 = 60 + dgvAcoes.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            var w1 = 60 + dgvOperacoes.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            var w2 = 60 + dgvVendas.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            tlpAcoes.ColumnStyles[0].Width = w0;
            tlpAcoes.ColumnStyles[1].Width = w1;
            Width = 40 + Math.Max(w0 + w1, w2);

            //tlpAcoes.RowStyles[0].Height =
            //    8 + dgvAtivos.ColumnHeadersHeight + 11 * dgvAtivos.RowTemplate.Height;

            //----------------
            //Acao.Precos = _ctx.AtivosUltimosPrecos;
            _ctx.Contas.Load();
            bsContas.DataSource = _ctx.Contas.Local.ToBindingList();

            toolStripComboBoxConta.ComboBox.DataSource = _ctx.Contas.ToList(); //bsContas;
            toolStripComboBoxConta.ComboBox.DisplayMember = "Apelido";
            toolStripComboBoxConta.ComboBox.ValueMember = "ID";

            toolStripComboBoxConta.ComboBox.SelectedValue =
                Settings.Default.InvestimentosUsarContaPadrao
                    ? Settings.Default.InvestimentosContaPadrao
                    : Settings.Default.InvestimentosUltimaConta;

            GetBalancePath();

            _ctx.Operacoes.Local.CollectionChanged += LocalOnCollectionChanged;
            _ctx.FundosMeses.Local.CollectionChanged += LocalOnCollectionChanged;
            _ctx.LCAMeses.Local.CollectionChanged += LocalOnCollectionChanged;
        }

        private void LocalOnCollectionChanged(object o, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs) {
            RefreshSalvar();
        }

        private void frmInvestimentos_FormClosing(object sender, FormClosingEventArgs e) {
            Settings.Default.InvestimentosUltimaConta = (int)toolStripComboBoxConta.ComboBox.SelectedValue;
            Settings.Default.Save();

            if (!_ctx.ChangeTracker.HasChanges()) {
                return;
            }

            switch (MessageBox.Show($"{_ctx.TextoSalvar()}?", @"Investimentos",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    _ctx.SaveChanges();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    break; // do nothing
            }
        }
        #endregion FORM -----------------------------------------

        #region DATAGRID GENÉRICAS ----------------------------
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var dgv = (DataGridView)sender;
            var col = Convert.ToInt32(dgv.Tag); // coluna com valor que controla a cor
            //var color = col > 0 ? Color.Orange : Color.DarkGray;
            col = Math.Abs(col);
            var row = dgv.Rows[e.RowIndex];
            var value = Convert.ToDecimal(row.Cells[col].Value);
            if (value > 0) {
                return;
            }

            e.CellStyle.ForeColor = value < 0 ? Color.Orange : Color.DarkGray;
        }

        #endregion DATAGRID GENÉRICAS -------------------------

        #region TABS ==========================================
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            var tabLabel = tabControlInvestimentos.SelectedTab.Text;
            foreach (var item in toolStripMenu.Items
                .Cast<ToolStripItem>().Where(i => i.Tag != null)) {
                var tag = item.Tag.ToString();
                item.Visible = tag == "all" || tag.Contains(tabLabel);
            }
            if (tabLabel != "Resumo") {
                return;
            }

            UpdateResumo();
        }

        #region TAB AÇÕES --------------------------------------------
        private void dgvOperacoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            var op = (Operacao)bsOperacoes.Current;
            var frm = GetFrmEditarOperacao(op);
            if (frm.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            RefreshDataAcoes();
        }

        private void dgvVendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            var frm = new frmAssociarCompraComVenda {
                Saida = (Saida)bsVendas.Current,
                AcaoAtual = (ContaAtivo)bsAcoes.Current
            };
            frm.ShowDialog();
            RefreshDataAcoes();
        }

        private frmEditarOperacao GetFrmEditarOperacao(Operacao op) {
            var frm = new frmEditarOperacao {
                Acoes = ContaAtual.Acoes,
                Operacao = op,
                Ctx = _ctx
            };
            return frm;
        }

        private void RefreshDataAcoes() {
            dgvAcoes.Refresh();
            dgvOperacoes.Refresh();
            dgvVendas.Refresh();
            RefreshSalvar();
        }
        #endregion TAB AÇÕES -----------------------------------------

        #region TAB FUNDOS --------------------------------------------
        private void RefreshDataFundos() {
            //dgvFundos.SaveCurrentRow();
            //EDS.Refresh();
            //dgvFundosMeses.Refresh();
            //dgvMovimentos.Refresh();
            //dgvFundos.RestoreCurrentRow(0);
            //RefreshSalvar();
        }
        #endregion TAB FUNDOS -----------------------------------------

        #region TAB LCA --------------------------------------------
        private void dgvLCAs_SelectionChanged(object sender, EventArgs e) {
            //OrderByDate(dgvLCAMeses);
            //OrderByDate(dgvLCAMovimentos);
        }

        private void RefreshDataLCA() {
            //dgvLCAs.SaveCurrentRow();
            //EDS.Refresh();
            //dgvLCAMeses.Refresh();
            //dgvLCAMovimentos.Refresh();
            //dgvLCAs.RestoreCurrentRow(0);
            //RefreshSalvar();
        }

        #endregion TAB LCA -----------------------------------------

        #region TAB RESUMO --------------------------------------------

        private void BindDataSourceAndPopulatePieChart(IEnumerable<Patrimonio> data,
            string fonte) {
            var dgv = fonte == "Ações" ? dgvResumoAcoes : dgvResumoFundos;
            var chart = fonte == "Ações" ? chartResumoAcoes : chartResumoFundos;
            var label = fonte == "Ações" ? labelResumoAcoes : labelResumoFundos;

            var data1 = data.ToArray();

            dgv.Visible = chart.Visible = label.Visible = false;
            chart.Series.Clear();

            if (!data1.Any()) {
                return;
            }

            var total = data1.Sum(d => d.Valor);
            if (total == 0 && !_chkShowAll.Checked) {
                return;
            }

            dgv.Visible = label.Visible = true;
            if (total == 0) {
                return;
            }
            chart.Visible = true;
            chart.Titles[0].Text = $"{fonte}: {total:N2}";
            var serie = chart.Series.Add("AAA");
            serie.ChartType = SeriesChartType.Pie;
            serie.Font = new Font("Segoe UI", 7);
            foreach (var d in data1.Where(d => d.Valor > 0)) {
                var dp = serie.Points.Add((double)d.Valor);
                dp.LegendText = d.Item;
                dp.AxisLabel = $"{d.Valor / total:P0}";
                dp.LabelForeColor = ColorFunctions.ContrastColor(dp.Color);
            }
            chart.ApplyPaletteColors();
        }

        private static void PopulateBarChart(IEnumerable<Patrimonio> data, Chart chart) {
            chart.Visible = false;
            chart.Series.Clear();

            var data1 = data.ToArray();
            if (!data1.Any()) {
                return;
            }

            var total = data1.Sum(d => d.Valor);
            if (total == 0) {
                return;
            }

            chart.Visible = true;
            chart.Titles[0].Text = $"Total: {total:N2}";
            foreach (var d in data1.Where(d => d.Valor > 0)) {
                var serie = chart.Series.Add(d.Item);
                serie.ChartType = SeriesChartType.StackedColumn100;
                serie.Font = new Font("Segoe UI", 7);
                serie.Label = $"{d.Valor / total:P0}";
                serie.Points.AddY((double)d.Valor);
                //chart.ApplyPaletteColors();
                serie.LabelForeColor = ColorFunctions.ContrastColor(serie.Color);
            }
            chart.ApplyPaletteColors();
        }

        private void UpdateResumo() {
            bsResumoAcoes.DataSource =
                _chkShowAll.Checked ? ContaAtual.PatrimonioAcoes : ContaAtual.PatrimonioAcoesNaoZerado;
            bsResumoFundos.DataSource =
                _chkShowAll.Checked ? ContaAtual.PatrimonioFundos : ContaAtual.PatrimonioFundosNaoZerado;

            BindDataSourceAndPopulatePieChart(ContaAtual.PatrimonioAcoes, "Ações");
            BindDataSourceAndPopulatePieChart(ContaAtual.PatrimonioFundos, "Fundos");
            PopulateBarChart(ContaAtual.PatrimonioTudo, chartResumoTotal);
        }
        #endregion TAB RESUMO -----------------------------------------

        #region TAB IMPOSTO RENDA --------------------------------------------
        private void nupAno_ValueChanged(object sender, EventArgs e) {
            GetAcoesImpostoRenda();
        }

        private void GetAcoesImpostoRenda() {
            var IR = _ctx.spSituacaoImpostoRenda(ContaAtual.ID, (int)nupIR_Ano.Value)
                    .ToObservableListSource();
            dgvImpostoRenda.DataSource = IR;
            dgvImpostoRenda.Columns[0].Width = 70;
            dgvImpostoRenda.FormatColumnByHeader("Qtd", dgvImpostoRenda.StyleInteger, 60);
            dgvImpostoRenda.FormatColumnByHeader("Preço", dgvImpostoRenda.StyleCurrency, 60);
            dgvImpostoRenda.FormatColumnByHeader("Total", dgvImpostoRenda.StyleCurrency, 90);
            labelIRTotal.Text = @"Total: " + (IR.Any() ? $"{IR.Sum(t => t.Total):N2}" : "0.00");
        }
        #endregion TAB IMPOSTO RENDA -----------------------------------------

        #endregion TABS ========================================

        #region TOOLSTRIP --------------------------------------
        private void toolStripComboBoxConta_SelectedIndexChanged(object sender, EventArgs e) {
            if (ContaAtual == null) {
                return;
            }

            bsContas.Position = bsContas.List.IndexOf(ContaAtual);

            UpdateResumo();

            var ops = _ctx.Operacoes.Where(o => o.ContaId == ContaAtual.ID);
            nupIR_Ano.Value = nupIR_Ano.Maximum = nupIR_Ano.Minimum = DateTime.Now.Year;
            nupIR_Ano.Minimum = ops.Any() ? ops.Min(o => o.Data.Year) + 1 : DateTime.Now.Year;

            GetAcoesImpostoRenda();
        }

        #region TOOLSTRIP AÇÕES --------------------------------------
        private void tsbNovaOperacao_Click(object sender, EventArgs e) {
            var acaoAtual = (ContaAtivo)bsAcoes.Current;

            var op = new Operacao { ContaId = ContaAtual.ID, Codigo = acaoAtual.Codigo };
            var frm = GetFrmEditarOperacao(op);
            if (frm.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            acaoAtual = ContaAtual.Acoes.FirstOrDefault(ca => ca.Codigo == op.Codigo);

            if (acaoAtual == null) {
                acaoAtual = new ContaAtivo { Conta = ContaAtual, Codigo = op.Codigo };
                ContaAtual.Acoes.Add(acaoAtual);
            }

            bsAcoes.Position = bsAcoes.ToList<ContaAtivo>().TakeWhile(a => a.Codigo != acaoAtual.Codigo).Count();

            if (op.IsEntrada) {
                acaoAtual.Operacoes.Add(op.ToEntrada);
            }
            else {
                acaoAtual.Operacoes.Add(op.ToSaida);
            }

            dgvAcoes.Refresh();
            RefreshDataAcoes();
        }

        private void tsbResumoVendas_Click(object sender, EventArgs e) {
            //var frm = new frmBalanco() { Conta = ContaAtual.ID };
            //frm.ShowDialog();
        }
        #endregion TOOLSTRIP AÇÕES --------------------------------------

        #region TOOLSTRIP SALVAR --------------------------------------
        private void tsbSalvar_Click(object sender, EventArgs e) {
            if (!_ctx.SaveChanges(out var message)) {
                MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            RefreshSalvar();
        }

        private void tsbDesfazer_Click(object sender, EventArgs e) {
            _ctx.RevertChanges();
            RefreshDataAcoes();
        }

        private void RefreshSalvar() {
            tsbSalvar.Visible = tsbDesfazer.Visible =
            toolStripSeparatorSalvar.Visible = _ctx.ChangeTracker.HasChanges();

            var alts = _ctx.ChangesCount;

            tsbSalvar.Text = $" Salvar {alts} alteraç" + (alts == 1 ? "ão" : "ões");
        }
        #endregion TOOLSTRIP SALVAR --------------------------------------

        #region TOOLSTRIP LEITURA ----------------------------
        private void tsbLerExtrato_Click(object sender, EventArgs e) {
            string[] files;

            var tabLabel = tabControlInvestimentos.SelectedTab.Text;

            Action<string> leitor;
            Action refresher = null;
            switch (tabLabel) {
                case "Ações":
                    leitor = LerExtratoAcoes;
                    files = GetExtratoAcoes();
                    break;

                case "Fundos":
                    leitor = LerExtratoFundos;
                    refresher = RefreshDataFundos;
                    files = GetExtratosFundos();
                    break;

                case "LCA":
                    leitor = LerExtratoLCA;
                    refresher = RefreshDataLCA;
                    OFD.DefaultExt = "txt";
                    OFD.Filter = @"TXT files|*.txt";
                    OFD.Multiselect = true;
                    files = (OFD.ShowDialog() == DialogResult.Cancel) ? null : OFD.FileNames;
                    break;

                default:
                    return;
            }
            if (files == null) {
                return;
            }

            LerExtratos(files, leitor, refresher);
        }

        private string[] GetExtratoAcoes() {
            OFD.DefaultExt = "csv";
            OFD.Filter = @"CSV files|*.csv";
            OFD.Multiselect = false;
            return (OFD.ShowDialog() == DialogResult.Cancel) ? null : OFD.FileNames;
        }

        private string[] GetExtratosFundos() {
            var conta = ContaAtual;
            var path = $@"{_balancePath}\{conta.Banco.Sigla}\{conta.ContaCorrente}\Fundos {conta.Banco.ExtensaoFundos}";

            MessageBoxManager.Yes = "Mês inteiro";
            MessageBoxManager.No = "Selecionados";
            MessageBoxManager.Register();
            var resp = MessageBox.Show($"Ler extrato(s) da conta {conta.ContaCorrenteComDV}?", DialogTitle,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            MessageBoxManager.Unregister();
            switch (resp) {
                case DialogResult.Cancel:
                    return null;

                case DialogResult.Yes:
                    var allFiles = Directory.GetFiles(path, $"*.{conta.Banco.ExtensaoFundos}");
                    if (!allFiles.Any()) {
                        return null;
                    }
                    var regex = new Regex(@"([12]\d{3}-(0[1-9]|1[0-2]))");
                    var meses = allFiles.Select(f => regex.Match(f).Value).Distinct().OrderByDescending(m => m)
                        .ToArray();
                    if (!meses.Any()) {
                        MessageBox.Show($"Não foi possível selecionar os meses nos arquivos em\n\n{path}",
                            DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return null;
                    }

                    var mes = meses.First();
                    return PromptDialog.InputCombo(DialogTitle, "Selecione o mês:", meses, ref mes) ==
                           DialogResult.Cancel
                        ? null
                        : allFiles.Where(f => f.Contains(mes)).ToArray();

                case DialogResult.No:
                    OFD.InitialDirectory = path;
                    OFD.DefaultExt = conta.Banco.ExtensaoFundos.ToLower();
                    OFD.Filter = $@"Arquivos {OFD.DefaultExt.ToUpper()}|*.{OFD.DefaultExt}";
                    OFD.Multiselect = true;
                    return (OFD.ShowDialog() == DialogResult.Cancel) ? null : OFD.FileNames;

                default:
                    return null;
            }
        }

        private void tsbPath_Click(object sender, EventArgs e) {
            SetBalancePath();
        }

        private void GetBalancePath() {
            _balancePath = Settings.Default.InvestimentosBalancePath;
            while (_balancePath == null || !Directory.Exists(_balancePath)) {
                SetBalancePath();
            }
            tsbPath.Text = $@"Path: {_balancePath}";
        }

        private void SetBalancePath() {
            var fbd = new FolderBrowserDialog { ShowNewFolderButton = false };
            if (fbd.ShowDialog() == DialogResult.Cancel) {
                return;
            }
            _balancePath = fbd.SelectedPath;
            if (_balancePath.EndsWith("\\")) {
                _balancePath = _balancePath.Substring(0, _balancePath.Length - 1);
            }
            Settings.Default.InvestimentosBalancePath = _balancePath;
            Settings.Default.Save();
            tsbPath.Text = $@"Path: {_balancePath}";
        }

        private void ToggleLeitura() {
            tsbLerExtrato.Visible = !tsbLerExtrato.Visible;
            toolStripLabelLendoExtrato.Visible = !toolStripLabelLendoExtrato.Visible;
            toolStripProgressBar1.Visible = !toolStripProgressBar1.Visible;
            toolStripMenu.Refresh();
        }

        private void tsbLerExtratosMes_Click(object sender, EventArgs e) {
            var mes = DateTime.Today.AddMonths(-1).ToString("yyyy-MM");
            if (PromptDialog.InputString(DialogTitle, "Selecione o mês:", ref mes) ==
                DialogResult.Cancel) {
                return;
            }

            var allFiles = new List<string>();
            foreach (var conta in toolStripComboBoxConta.Items.Cast<Conta>().Where(c => c.Ativa)) {
                //var conta = (Conta)item;
                var path = $@"{_balancePath}\{conta.Banco.Sigla}\{conta.ContaCorrente}\Fundos {conta.Banco.ExtensaoFundos}";
                if (Directory.Exists(path)) {
                    var files = Directory.GetFiles(path, $"*.{conta.Banco.ExtensaoFundos}").Where(f => f.Contains(mes));
                    if (files.Any()) {
                        allFiles.AddRange(files);
                    }
                    else {
                        MessageBox.Show($"Conta {conta.ContaCorrenteComDV} não possui extratos para o mês {mes} em:\n\n{path}",
                            DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else {
                    MessageBox.Show($"Conta {conta.ContaCorrenteComDV} - diretório não encontrado:\n\n{path}",
                        DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            LerExtratos(allFiles, LerExtratoFundos, RefreshDataFundos);
        }
        #endregion TOOLSTRIP LEITURA --------------------------

        private void toolStripCopyToClipboard_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();
            var source = (IEnumerable)dgvImpostoRenda.DataSource;
            foreach (SituacaoImpostoRenda item in source) {
                sb.AppendFormat("{0}\t{1}\t{2:#,###.00}\t{3:#,###.00}\n",
                    item.Codigo, item.Qtd, item.Preco, item.Total);
            }
            sb.AppendFormat("TOTAL\t\t{0}", labelIRTotal.Text);
            Clipboard.SetText(sb.ToString());
        }

        private void tsbExportar_Click(object sender, EventArgs e) {
            SFD.FileName = $"Fundos conta {ContaAtual.Apelido}";
            if (SFD.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            var pck = new ExcelPackage(new FileInfo(SFD.FileName));

            var source = _chkShowAll.Checked ? ContaAtual.Fundos : ContaAtual.FundosNaoZerado;

            CriaPlanilhaResumo(pck, source);

            foreach (var fundo in source) {
                CriaPlanilhaFundo(pck, fundo);
            }

            pck.Save();
            if (MessageBox.Show("Dados exportados. Deseja abrir planilha?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                System.Diagnostics.Process.Start(SFD.FileName);
            }
        }

        private void CriaPlanilhaResumo(ExcelPackage pck, IEnumerable<ContaFundo> fundos) {
            var ws = InicializaPlanilha(pck, "Resumo");
            var col = 1;
            foreach (var column in dgvFundos.Columns.Cast<DataGridViewColumn>()) {
                ws.Cells[1, col++].Value = column.HeaderText;
            }

            var row = 2;
            foreach (var fundo in fundos) {
                col = 1;
                ws.Cells[row, col++].Value = fundo.FundoApelido;
                ws.Cells[row, col++].Value = fundo.Saldo;
                ws.Cells[row++, col++].Value = fundo.RendimentoLiquido;
            }
            row--;
            col--;
            ws.Cells[$"A2:A{row}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Cells[$"B2:C{row + 1}"].Style.Numberformat.Format = "#,##0.00";

            var range = ws.Cells[1, 1, row, col];
            var table = ws.Tables.Add(range, $"Resumo");
            table.Columns[1].TotalsRowFunction = RowFunctions.Sum;
            table.Columns[2].TotalsRowFunction = RowFunctions.Sum;
            table.ShowTotal = true;
            table.TableStyle = TableStyles.Medium8;
            ws.Cells.AutoFitColumns(0);

            ws.View.FreezePanes(2, 1);
        }

        private static ExcelWorksheet InicializaPlanilha(ExcelPackage pck, string nome) {
            var ws = pck.Workbook.Worksheets.FirstOrDefault(s => s.Name == nome);
            if (ws != null) {
                pck.Workbook.Worksheets.Delete(nome);
            }

            ws = pck.Workbook.Worksheets.Add(nome);
            ws.View.ShowGridLines = false;
            return ws;
        }

        private void CriaPlanilhaFundo(ExcelPackage pck, ContaFundo fundo) {
            var ws = InicializaPlanilha(pck, fundo.FundoApelido);

            var col = 1;
            foreach (var column in dgvContasMeses.Columns.Cast<DataGridViewColumn>()) {
                ws.Cells[1, col++].Value = column.HeaderText;
            }

            var row = 2;
            foreach (var contaMes in fundo.ContasMeses) {
                col = 1;
                ws.Cells[row, col++].Value = contaMes.Mes;
                ws.Cells[row, col++].Value = contaMes.Saldo;
                ws.Cells[row, col++].Value = contaMes.CotaQtd;
                ws.Cells[row, col++].Value = contaMes.CotaValor;
                ws.Cells[row, col++].Value = contaMes.RendimentoBruto;
                ws.Cells[row, col++].Value = contaMes.ImpostoRenda;
                ws.Cells[row, col++].Value = contaMes.IOF;
                ws.Cells[row, col++].Value = contaMes.RendimentoLiquido;
                ws.Cells[row, col++].Value = contaMes.RendimentoMes / 100;
                ws.Cells[row, col++].Value = contaMes.RendimentoAno / 100;
                ws.Cells[row++, col++].Value = contaMes.Rendimento12Meses / 100;
            }

            row--;
            col--;
            ws.Cells[$"A2:A{row}"].Style.Numberformat.Format = "MMM-yyyy";
            ws.Cells[$"A2:A{row}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Cells[$"B2:B{row}"].Style.Numberformat.Format = "#,##0.00";
            ws.Cells[$"C2:D{row}"].Style.Numberformat.Format = "#,##0.0000";
            ws.Cells[$"E2:H{row}"].Style.Numberformat.Format = "#,##0.00";
            ws.Cells[$"I2:K{row}"].Style.Numberformat.Format = "0.000%";

            var range = ws.Cells[1, 1, row, col];
            var table = ws.Tables.Add(range, $"table{fundo.FundoApelido.Replace(' ', '_')}");
            table.ShowTotal = true;
            table.TableStyle = TableStyles.Light1;

            ws.Cells.AutoFitColumns(0);
            ws.Column(6).Hidden = fundo.ContasMeses.All(c => c.ImpostoRenda == 0);
            ws.Column(7).Hidden = fundo.ContasMeses.All(c => c.IOF == 0);
            ws.View.FreezePanes(2, 1);
        }

        #endregion TOOLSTRIP -----------------------------------------------

        #region LEITURA DE EXTRATO --------------------------------------------
        private void LerExtratos(IEnumerable<string> files, Action<string> leitor, Action refresher) {
            ToggleLeitura();
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = files.Count();

            foreach (var file in files.OrderBy(f => f)) {
                toolStripProgressBar1.Value += 1;
                toolStripLabelLendoExtrato.Text = $"Lendo extrato: {Path.GetFileName(file)}";
                leitor(file);
            }
            ToggleLeitura();

            refresher?.Invoke();
        }

        private void LerExtratoAcoes(string filename) {
            //var seps = new[] { "\r\n" };
            //var readText = File.ReadAllText(filename);
            //var lines = readText.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            //var conta = (Conta)toolStripComboBoxConta.SelectedItem;
            //var ativos = conta.AtivosDaConta;

            //foreach (var line in lines) {
            //    var cotacao = line.Split(';');
            //    var papel = cotacao[(int)posicao.Papel];
            //    var ativo = ativos.FirstOrDefault(a => a.Ativo.Codigo == papel);
            //    if (ativo != null) {
            //        ativo.CotacaoAtual = decimal.Parse(cotacao[(int)posicao.Cotação]);
            //    }
            //}
            //dgvAtivos.Refresh();
        }

        private void LerExtratoFundos(string filename) {
            if (filename.EndsWith("txt")) {
                LerExtratoFundosBB(filename);
            }
            else {
                LerExtratoFundosCEF(filename);
            }
        }

        private bool SelecionaConta(ExtratoReader extrato, out Conta conta) {
            var contacorrente = extrato.ContaCorrente;
            conta = toolStripComboBoxConta.Items
                .Cast<Conta>().FirstOrDefault(c => contacorrente.Contains(c.ContaCorrente));
            if (conta == null) {
                MessageBox.Show($"Conta {contacorrente} não encontrada.", "Extrato Fundos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            toolStripComboBoxConta.SelectedItem = conta;
            return true;
        }

        private void LerExtratoFundosBB(string filename) {
            var extrato = new ExtratoBBeader(filename);
            if (!SelecionaConta(extrato, out Conta conta)) {
                return;
            }

            var fundosNoDatabase = _ctx.Fundos.Local;

            foreach (var fundoNoExtrato in extrato.FundosNoExtrato) {
                var fundo = fundosNoDatabase.FirstOrDefault(f => f.CNPJ == fundoNoExtrato.CNPJ);
                if (fundo == null) {
                    fundo = fundoNoExtrato.CreateFundo();
                    fundosNoDatabase.Add(fundo);
                }

                else if (fundo.Nome != fundoNoExtrato.Nome) {
                    fundo.Nome = fundoNoExtrato.Nome;
                }

                fundoNoExtrato.UpdateFundoMes(fundo);

                // Localiza a ContaFundo, criando se necessário
                var contaFundo = conta.Fundos.FirstOrDefault(f => f.FundoCNPJ == fundoNoExtrato.CNPJ);
                if (contaFundo == null) {
                    contaFundo = new ContaFundo { Fundo = fundo };
                    conta.Fundos.Add(contaFundo);
                }

                fundoNoExtrato.UpdateContaMes(contaFundo);
            }
        }

        private void LerExtratoFundosCEF(string filename) {
            var extrato = new ExtratoCEFReader(filename);
            if (!SelecionaConta(extrato, out var conta)) {
                return;
            }

            var fundosNoDatabase = _ctx.Fundos.ToList(); //.Local;

            var fundo = fundosNoDatabase.FirstOrDefault(f => f.CNPJ == extrato.CNPJ);
            if (fundo == null) {
                fundo = extrato.CreateFundo();
                fundosNoDatabase.Add(fundo);
            }
            else if (fundo.Nome != extrato.Nome) {
                fundo.Nome = extrato.Nome;
            }

            extrato.UpdateFundoMes(fundo);

            // Localiza a ContaFundo, criando se necessário
            var contaFundo = conta.Fundos.FirstOrDefault(f => f.FundoCNPJ == extrato.CNPJ);
            if (contaFundo == null) {
                contaFundo = new ContaFundo() { Fundo = fundo };
                conta.Fundos.Add(contaFundo);
            }

            var contaMes = extrato.UpdateContaMes(contaFundo.ContasMeses
                .FirstOrDefault(c => c.Mes == extrato.Mes));
            if (contaMes.ContaMesId == 0) {
                contaFundo.ContasMeses.Add(contaMes);
            }
        }

        private void LerExtratoLCA(string filename) {
            ExtratoLCAReader.LerExtratoLCA(filename, (Conta)toolStripComboBoxConta.SelectedItem);
        }
        #endregion LEITURA DE EXTRATO -------------------------------

        private void chart_DoubleClick(object sender, EventArgs e) {
            var chart = (Chart)sender;
            chart.ChartAreas[0].Area3DStyle.Enable3D = !chart.ChartAreas[0].Area3DStyle.Enable3D;
        }
    }
}