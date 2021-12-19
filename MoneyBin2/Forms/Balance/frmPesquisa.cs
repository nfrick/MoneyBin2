using DataLayer;
using IEnumerableExtensions;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using CheckBox = System.Windows.Forms.CheckBox;
using ComboBox = System.Windows.Forms.ComboBox;

namespace MoneyBin2 {
    public partial class frmPesquisa : DataForm {
        private string _saveAs;
        private readonly string _myDocsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private readonly Query _queryBase;

        private Exportador _exportador => (Exportador)toolStripComboBoxFormato.SelectedItem;

        private readonly ToolStripComboBox toolStripComboBoxFormato = new ToolStripComboBox() {
            Name = "tsbFormato",
            Size = new Size(200, 30),
        };

        public frmPesquisa() {
            InitializeComponent();

            _mainBindingSource = bsPesquisa;

            checkedListBoxContas.Items.AddRange(_ctx.Contas.OrderBy(c => c.Apelido).ToArray());
            checkedListBoxContas.DisplayMember = "Apelido";

            checkedListBoxGrupo.Items.AddRange(_ctx.Balance.Select(b => b.Grupo).Distinct().OrderBy(g => g).ToArray());
            checkedListBoxCategoria.Items.AddRange(_ctx.Balance.Where(b => b.Categoria != null).Select(b => b.Categoria).Distinct().OrderBy(c => c).ToArray());

            dtpInicio.Value = DateTime.Today.AddMonths(-6);

            var campos = Pesquisa.CSVHeader.Replace("\"", "").Split(',');
            comboBoxOrdem1.Items.AddRange(campos);
            comboBoxOrdem2.Items.AddRange(campos);
            comboBoxOrdem3.Items.AddRange(campos);

            comboBoxOrdem1.Tag = checkBoxSentido1;
            comboBoxOrdem2.Tag = checkBoxSentido2;
            comboBoxOrdem3.Tag = checkBoxSentido3;

            toolStripComboBoxFormato.Items.AddRange(new[]
            {
                new Exportador(){ Texto = "CSV", Extensao = "csv", Filtro = @"CSV Files|*.csv", Exporter = ExportToCSV},
                new Exportador(){ Texto = "XML", Extensao = "xml", Filtro = @"XML Files|*.xml", Exporter = ExportToXML},
                new Exportador(){ Texto = "JSON", Extensao = "json", Filtro = @"JSON Files|*.json", Exporter = ExportToJSON},
                new Exportador(){ Texto = "Excel (planilha única)", Extensao = "xlsx", Filtro = @"Excel Files|*.xlsx", Exporter = ExportToExcel},
                new Exportador(){ Texto = "Excel (planilhas separadas)", Extensao = "xlsx", Filtro = @"Excel Files|*.xlsx", Exporter = ExportToExcel2},
            });
            toolStripComboBoxFormato.ComboBox.DisplayMember = "Texto";
            toolStripComboBoxFormato.SelectedIndexChanged += toolStripComboBoxFormato_SelectedIndexChanged;
            toolStripComboBoxFormato.SelectedIndex = 0;
            toolStripComboBoxFormato.Enabled = false;

            toolStripMenu.Items.Insert(2, toolStripComboBoxFormato);
            toolStripMenu.Items.Insert(2, new ToolStripLabel { Text = "Exportar" });

            tsbSave.Text = "Pesquisar";
            tsbSave.Image = Properties.Resources.Binóculos;
            tsbSave.Click -= tsbSave_Click;
            tsbSave.Click += tsbProcurar_Click;

            tsbRevert.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbRevert.Image = Properties.Resources.Exportar;
            tsbRevert.ToolTipText = "Exportar";
            tsbRevert.BackColor = Color.Aquamarine;
            tsbRevert.Enabled = false;
            tsbRevert.Click -= tsbRevert_Click;
            tsbRevert.Click += buttonExport_Click;

            var font = new Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreach (var item in toolStripMenu.Items.Cast<ToolStripItem>()
                .Where(item => item.Font.Name == "Segoe UI")) {
                item.Font = font;
            }

            UpdateStatusBar();

            dgvPesquisa.FormatColumnByHeader("Conta", null, 80);
            dgvPesquisa.FormatColumnByHeader("Data", dgvPesquisa.StyleDateShort, 80);
            dgvPesquisa.FormatColumnByHeader("Histórico", null, 300);
            dgvPesquisa.FormatColumnByHeader("Documento", null, 120);
            dgvPesquisa.FormatColumnByHeader("Valor", dgvPesquisa.StyleCurrency, 100);
            dgvPesquisa.FormatColumnByHeader("Afeta Saldo", null, 40);
            dgvPesquisa.FormatColumnByHeader("Grupo", null, 120);
            dgvPesquisa.FormatColumnByHeader("Categoria", null, 140);
            dgvPesquisa.FormatColumnByHeader("SubCategoria", null, 200);
            dgvPesquisa.FormatColumnByHeader("Descrição", null, 200);
            dgvPesquisa.Columns[3].Visible = false;

            ResizeForm(dgvPesquisa);

            var str = ConfigurationManager.ConnectionStrings["MoneyBinEntities"].ToString();
            var ec = new EntityConnectionStringBuilder(str);

            var connection = new SqlConnection(ec.ProviderConnectionString);
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(connection, compiler);

            _queryBase = db.Query("Extrato.tbBalance")
                .Join("Contas.tbContas", "tbContas.Id", "tbBalance.ContaId")
                .Select("Extrato.tbBalance.*", "Contas.tbContas.Apelido");
        }


        #region TOOLSTRIP ---------------------------
        private void tsbProcurar_Click(object sender, EventArgs e) {

            bsPesquisa.DataSource = null;
            dgvPesquisa.Refresh();

            var query = _queryBase.Clone().WhereBetween("Data", dtpInicio.Value, dtpTermino.Value);

            var contas = checkedListBoxContas.CheckedItems.Cast<Conta>().Select(c => c.ID).ToArray();
            if (contas.Any() && contas.Length != checkedListBoxContas.Items.Count) {
                query = query.WhereIn("ContaID", contas);
            }

            var grupos = checkedListBoxGrupo.CheckedItems.Cast<string>().ToArray();
            if (grupos.Any() && grupos.Length != checkedListBoxGrupo.Items.Count) {
                query = query.WhereIn("Grupo", grupos);
            }

            var categorias = checkedListBoxCategoria.CheckedItems.Cast<string>().ToArray();
            if (categorias.Any() && grupos.Length != checkedListBoxCategoria.Items.Count) {
                query = query.WhereIn("Categoria", categorias);
            }

            if (!radioButtonAll.Checked) {
                var valor1 = currencyTextBoxValor1.DecimalValue;
                if (radioButtonBetween.Checked) {
                    var valor2 = currencyTextBoxValor2.DecimalValue;
                    query = query.WhereBetween("Valor", valor1, valor2);
                }
                else if (radioButtonEqual.Checked) {
                    query = query.Where("Valor", valor1);
                }
                else if (radioButtonGreater.Checked) {
                    query = query.Where("Valor", ">=", valor1);
                }
                else {
                    query = query.Where("Valor", "<=", valor1);
                }
            }

            switch (checkBoxAfetaSaldo.CheckState) {
                case CheckState.Checked:
                    query = query.WhereTrue("AfetaSaldo");
                    break;
                case CheckState.Unchecked:
                    query = query.WhereFalse("AfetaSaldo");
                    break;
                default:
                    break;
            }

            var descricao = textBoxDescricao.Text.Trim();
            if (!string.IsNullOrEmpty(descricao)) {
                query = query.WhereContains("Descricao", descricao);
            }

            var historico = textBoxHistorico.Text.Trim();
            if (!string.IsNullOrEmpty(historico)) {
                query = query.WhereContains("Historico", historico);
            }

            AddSort(query, comboBoxOrdem1, checkBoxSentido1);
            AddSort(query, comboBoxOrdem2, checkBoxSentido2);
            AddSort(query, comboBoxOrdem3, checkBoxSentido3);

            bsPesquisa.DataSource = query.Get<Pesquisa>().ToObservableListSource();

            dgvPesquisa.Refresh();
            UpdateStatusBar();
        }

        private static void AddSort(Query query, ComboBox column, CheckBox direction) {
            var coluna = (string)column.SelectedItem;
            if (string.IsNullOrEmpty(coluna)) {
                return;
            }
            query = direction.Checked ?
                query.OrderByDesc(coluna) : query.OrderBy((string)column.SelectedItem);
        }

        private void toolStripComboBoxFormato_SelectedIndexChanged(object sender, EventArgs e) {
            SFD.DefaultExt = _exportador.Extensao;
            SFD.Filter = _exportador.Filtro;
            _saveAs = $@"{_myDocsFolder}\Money Bin Export.{_exportador.Extensao}";
        }

        #endregion TOOLSTRIP ---------------------------

        #region EXPORTING ---------------------------
        private void buttonExport_Click(object sender, EventArgs e) {
            var fInfo = new FileInfo(_saveAs);
            SFD.InitialDirectory = fInfo.DirectoryName;
            SFD.FileName = fInfo.Name;
            SFD.CheckFileExists = false;
            SFD.OverwritePrompt = true;

            if (SFD.ShowDialog() != DialogResult.OK) {
                return;
            }

            _saveAs = SFD.FileName;
            Cursor.Current = Cursors.WaitCursor;

            if (_exportador.Exporter()) {
                MessageBox.Show($@"{bsPesquisa.CurrencyManager.Count} registros exportados.",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor.Current = Cursors.Default;
        }

        private bool ExportToCSV() {
            var itens = (IEnumerable<Pesquisa>)bsPesquisa.DataSource;
            var progressDialog = new frmProgressBar();
            var backgroundThread = new Thread(
                () => {
                    progressDialog.Maximum = itens.Count();
                    progressDialog.UpdateProgress("Exportando \u2026");
                    var sw = new StreamWriter(_saveAs, false, Encoding.Default);
                    sw.WriteLine(Pesquisa.CSVHeader);

                    foreach (var item in itens) {
                        progressDialog.UpdateProgress();
                        sw.WriteLine(item.ToCSV);
                    }
                    sw.Flush();
                    sw.Close();

                    progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                }
            );
            backgroundThread.Start();
            progressDialog.ShowDialog();
            return true;
        }

        private bool ExportToXML() {
            try {
                var itens = (IEnumerable<Pesquisa>)bsPesquisa.DataSource;
                var xEle = new XElement("Balance", itens.Select(b => b.toXML()));
                xEle.Save(_saveAs);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, @"Export", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool ExportToJSON() {
            var itens = (IEnumerable<Pesquisa>)bsPesquisa.DataSource;
            var json = JsonConvert.SerializeObject(itens, Formatting.Indented);
            var sw = new StreamWriter(_saveAs, false, Encoding.Default);
            sw.WriteLine(json);

            sw.Flush();
            sw.Close();
            return true;
        }

        private bool ExportToExcel() {
            var itens = (IEnumerable<Pesquisa>)bsPesquisa.DataSource;
            var pck = new ExcelPackage(new FileInfo(_saveAs));
            CriaPlanilha(pck, "Balance", itens);
            return true;
        }

        private bool ExportToExcel2() {
            var itens = (IEnumerable<Pesquisa>)bsPesquisa.DataSource;
            var pck = new ExcelPackage(new FileInfo(_saveAs));
            var contas = itens.GroupBy(i => i.Apelido);
            foreach (var conta in contas) {
                CriaPlanilha(pck, conta.Key, conta.ToList());
            }
            return true;
        }

        private static void CriaPlanilha(ExcelPackage pck, string tabLabel, IEnumerable<Pesquisa> items) {
            var ws = pck.Workbook.Worksheets.FirstOrDefault(s => s.Name == tabLabel);
            if (ws != null) {
                pck.Workbook.Worksheets.Delete(tabLabel);
            }

            ws = pck.Workbook.Worksheets.Add(tabLabel);
            ws.View.ShowGridLines = false;

            var col = 1;
            ws.Cells[1, col++].Value = "Conta";
            ws.Cells[1, col++].Value = "Conta ID";
            ws.Cells[1, col++].Value = "Data";
            ws.Cells[1, col++].Value = "Histórico";
            ws.Cells[1, col++].Value = "Documento";
            ws.Cells[1, col++].Value = "Valor";
            ws.Cells[1, col++].Value = "Afeta Saldo";
            ws.Cells[1, col++].Value = "Saldo";
            ws.Cells[1, col++].Value = "Grupo";
            ws.Cells[1, col++].Value = "Categoria";
            ws.Cells[1, col++].Value = "SubCategoria";
            ws.Cells[1, col++].Value = "Descrição";

            var row = 2;
            foreach (var item in items) {
                col = 1;
                ws.Cells[row, col++].Value = item.Apelido;
                ws.Cells[row, col++].Value = item.ContaID;
                ws.Cells[row, col++].Value = item.Data;
                ws.Cells[row, col++].Value = item.Historico;
                ws.Cells[row, col++].Value = item.Documento;
                ws.Cells[row, col++].Value = item.Valor;
                ws.Cells[row, col++].Value = item.AfetaSaldo;
                //                ws.Cells[row, col++].Value = item.Saldo;
                ws.Cells[row, col++].Value = item.Grupo;
                ws.Cells[row, col++].Value = item.Categoria;
                ws.Cells[row, col++].Value = item.SubCategoria;
                ws.Cells[row++, col++].Value = item.Descricao;
            }

            row--;
            col--;
            ws.Cells[$"C2:C{row}"].Style.Numberformat.Format = "dd-MM-yyyy";
            ws.Cells[$"E2:E{row}"].Style.Numberformat.Format = "@";
            ws.Cells[$"F2:F{row}"].Style.Numberformat.Format = "#,##0.00";
            ws.Cells[$"H2:H{row}"].Style.Numberformat.Format = "#,##0.00";
            ws.Cells.AutoFitColumns(0);

            var range = ws.Cells[1, 1, row, col];
            var table = ws.Tables.Add(range, $"table{tabLabel}");
            table.ShowTotal = true;
            table.TableStyle = TableStyles.Light1;

            ws.View.FreezePanes(2, 1);

            pck.Save();
        }

        #endregion EXPORTING ---------------------------

        #region DATAGRIDVIEW ---------------------------
        private void dgvPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            try {
                var item = (Pesquisa)dgvPesquisa.Rows[e.RowIndex].DataBoundItem;
                if (!item.AfetaSaldo) {
                    e.CellStyle.ForeColor = Color.DarkGray;
                    return;
                }

                if (e.ColumnIndex == 4 && (decimal)e.Value < 0) {
                    e.CellStyle.ForeColor = Color.LightCoral;
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                //throw;
            }
        }

        #endregion DATAGRIDVIEW ------------------------

        private void bsPesquisa_DataSourceChanged(object sender, EventArgs e) {
            toolStripComboBoxFormato.Enabled = tsbRevert.Enabled =
                bsPesquisa.CurrencyManager.Count > 0;
        }

        private void checkBoxSentido_CheckedChanged(object sender, EventArgs e) {
            var chk = (CheckBox)sender;
            chk.Image = chk.Checked ?
                Properties.Resources.Arrow_down_24 : Properties.Resources.Arrow_up_24;
        }

        private void comboBoxOrdem1_SelectionChangeCommitted(object sender, EventArgs e) {
            var cmbox = (ComboBox)sender;
            var chkbox = (CheckBox)cmbox.Tag;
            chkbox.Visible = !string.IsNullOrEmpty(cmbox.Text);
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e) {
            var rad = (RadioButton)sender;
            if (!rad.Checked) {
                return;
            }

            currencyTextBoxValor2.Visible = false;
            labelValor_e.Visible = false;
            if (radioButtonAll.Checked) {
                currencyTextBoxValor1.Visible = false;
                return;
            }
            currencyTextBoxValor1.Visible = true;
            if (radioButtonBetween.Checked) {
                currencyTextBoxValor1.Location = new Point(6, currencyTextBoxValor2.Location.Y);
                currencyTextBoxValor2.Visible = true;
                labelValor_e.Visible = true;
                return;

            }
            currencyTextBoxValor1.Location = new Point(50, rad.Location.Y);
        }
    }

    public class Exportador {
        public string Texto { get; set; }
        public Func<bool> Exporter { get; set; }
        public string Extensao { get; set; }
        public string Filtro { get; set; }
    }
}
