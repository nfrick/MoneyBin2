using DataLayer;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MoneyBin2 {
    public partial class frmExport : Form {
        private readonly MoneyBinEntities _ctx = new MoneyBinEntities();
        private List<string> _gruposChecked;
        private Func<bool> _exporter;
        private string _saveAs;
        private readonly string _myDocsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private readonly string _oneDriveFolder = Environment.GetEnvironmentVariable("ONEDRIVE");
        private readonly DateTime _lastExportDate = Properties.Settings.Default.ExportacaoUltimaData;

        //private IEnumerable<Conta> ContasSelecionadas => edsExport.DbContext.Set<Conta>().Local.Where(c => c.Selecionada);
        private IEnumerable<Conta> ContasSelecionadas =>
            dgvContas.Rows.Cast<DataGridViewRow>()
            .Select(r => (Conta) r.DataBoundItem).Where(c => c.Selecionada);

        private IEnumerable<BalanceItem> ItensSelecionados =>
            checkBoxGruposTodos.Checked ?
                ContasSelecionadas.SelectMany(c => c.BalanceFiltrado(dtpInicio.Value, dtpTermino.Value, checkBoxAfetaSaldo.Checked)) :
                ContasSelecionadas.SelectMany(c => c.BalanceFiltrado(dtpInicio.Value,
                    dtpTermino.Value, _gruposChecked, checkBoxAfetaSaldo.Checked));

        #region FORM ---------------------------
        public frmExport() {
            InitializeComponent();
        }

        private void frmExport_Load(object sender, EventArgs e) {
            _ctx.Contas.Load();
            bsContas.DataSource = _ctx.Contas.Local.ToBindingList();

            _saveAs = $@"{_myDocsFolder}\Money Bin Export.csv";
            radioButtonCSV.Checked = true;
            dgvContas.Sort(dgvContas.Columns[1], ListSortDirection.Ascending);
            SelecionaParaExportar();
        }

        private void frmExport_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.ExportacaoUltimaData = dtpTermino.Value;
            Properties.Settings.Default.Save();
        }

        private void buttonSair_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion FORM ---------------------------

        #region SELECTING ---------------------------

        #region EVENT HANDLERS ---------------------------
        private void dgvContas_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            dtpInicio.Enabled = dtpTermino.Enabled =
                buttonExport.Enabled = ContasSelecionadas.Any();
            checkedListBoxGrupos.Enabled = !checkBoxGruposTodos.Checked && buttonExport.Enabled;
            if (buttonExport.Enabled) {
                dtpInicio.MinDate = dtpTermino.MinDate = ContasSelecionadas.Min(b => b.DataMin);
                dtpInicio.MaxDate = dtpTermino.MaxDate = ContasSelecionadas.Max(b => b.DataMax);
                dtpInicio.Value = dtpInicio.MinDate;
                dtpTermino.Value = dtpTermino.MaxDate;
            }
            SelecionaParaExportar();
        }

        private void dtpickers_ValueChanged(object sender, EventArgs e) {
            AtualizaGrupos();
            SelecionaParaExportar();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e) {
            var chk = sender as RadioButton;
            if (!chk.Checked) {
                return;
            }
            if (radioButtonCSV.Checked) {
                SetSaveDialog("Money Bin Export", "csv", @"CSV Files|*.csv");
                _exporter = ExportToCSV;
            }
            else if (radioButtonXML.Checked) {
                SetSaveDialog("Money Bin Export", "xml", @"XML Files|*.xml");
                _exporter = ExportToXML;
            }

            else if (radioButtonExcel.Checked || radioButtonExcel2.Checked) {
                SetSaveDialog("Money Bin Export", "xlsx", @"Excel Files|*.xlsx");
                _exporter = ExportToExcel;
            }

            else if (radioButtonExtrato.Checked) {
                SetSaveDialog("Extratos", "accdb", @"Access Files|*.accdb");
                _exporter = ExportToExtrato;
            }
        }

        private void checkedListBoxGrupos_ItemCheck(object sender, ItemCheckEventArgs e) {
            _gruposChecked = checkedListBoxGrupos.CheckedItems.Cast<string>()
                .Select(g => g.Substring(0, g.IndexOf(" ("))).ToList();

            var curItem = checkedListBoxGrupos.Items[e.Index].ToString();
            curItem = curItem.Substring(0, curItem.IndexOf(" ("));
            if (e.NewValue == CheckState.Checked) {
                _gruposChecked.Add(curItem);
            }
            else {
                _gruposChecked.Remove(curItem);
            }

            SelecionaParaExportar();
        }

        private void labelDataInicio_Click(object sender, EventArgs e) {
            if (_lastExportDate.Year == 1) {
                return;
            }

            dtpInicio.Value = (dtpInicio.Value == dtpInicio.MinDate) ?
                _lastExportDate : dtpInicio.MinDate;
        }

        private void checkBoxAfetaSaldo_CheckedChanged(object sender, EventArgs e) {
            SelecionaParaExportar();
        }

        private void checkBoxGruposTodos_CheckedChanged(object sender, EventArgs e) {
            checkedListBoxGrupos.Enabled = !checkBoxGruposTodos.Checked;
        }
        #endregion EVENT HANDLERS ---------------------------

        private void AtualizaGrupos() {
            checkedListBoxGrupos.Items.Clear();
            checkedListBoxGrupos.Items.AddRange(
                ItensSelecionados
                    .GroupBy(b => b.Grupo)
                    .Select(g => $"{g.Key} ({g.Count()})")
                    .OrderBy(b => b).ToArray());

            for (var i = 0; i < checkedListBoxGrupos.Items.Count; i++) {
                checkedListBoxGrupos.SetItemChecked(i, true);
            }
        }

        private void SelecionaParaExportar() {
            var CountSelecionados = ItensSelecionados.Count();
            labelCount.Text = $"Registros a serem exportados: {CountSelecionados}";
            buttonExport.Enabled = CountSelecionados > 0;
        }

        private void SetSaveDialog(string filename, string extension, string filter) {
            SFD.DefaultExt = extension;
            SFD.Filter = filter;
            _saveAs = extension == "accdb" ?
                $@"{_oneDriveFolder}\Documents\Financeiro\Extratos\{filename}.{extension}" :
                $@"{_myDocsFolder}\{filename}.{extension}";
        }

        #endregion SELECTING ---------------------------

        #region EXPORTING ---------------------------
        private void buttonExport_Click(object sender, EventArgs e) {
            var fInfo = new FileInfo(_saveAs);
            SFD.InitialDirectory = fInfo.DirectoryName;
            SFD.FileName = fInfo.Name;
            SFD.CheckFileExists = SFD.DefaultExt == "accdb";
            SFD.OverwritePrompt = SFD.DefaultExt != "accdb";

            if (fInfo.Extension == "accdb") {
                do {
                    if (SFD.ShowDialog() != DialogResult.OK) {
                        return;
                    }

                    _saveAs = SFD.FileName;
                } while (!File.Exists(_saveAs));
            }
            else {
                if (SFD.ShowDialog() != DialogResult.OK) {
                    return;
                }
            }

            _saveAs = SFD.FileName;
            Cursor.Current = Cursors.WaitCursor;

            if (_exporter()) {
                MessageBox.Show($@"{ItensSelecionados.Count()} registros exportados.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor.Current = Cursors.Default;
        }

        private bool ExportToCSV() {
            var itens = ItensSelecionados;
            var progressDialog = new frmProgressBar();
            var backgroundThread = new Thread(
                () =>
                {
                    progressDialog.Maximum = itens.Count();
                    progressDialog.UpdateProgress("Exportando \u2026");
                    var sw = new StreamWriter(_saveAs, false, Encoding.Default);
                    sw.WriteLine(BalanceItem.CSVHeader);

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
                var xEle = new XElement("Balance", ItensSelecionados.Select(b => b.toXML()));
                xEle.Save(_saveAs);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, @"Export", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool ExportToExcel() {
            var pck = new ExcelPackage(new FileInfo(_saveAs));
            if (radioButtonExcel.Checked) {
                CriaPlanilha(pck, "Balance", ItensSelecionados);
            }
            else {
                foreach (var conta in ContasSelecionadas) {
                    var itens = checkBoxGruposTodos.Checked
                        ? conta.BalanceFiltrado(dtpInicio.Value, dtpTermino.Value, checkBoxAfetaSaldo.Checked)
                        : conta.BalanceFiltrado(dtpInicio.Value, dtpTermino.Value, _gruposChecked,
                            checkBoxAfetaSaldo.Checked);
                    CriaPlanilha(pck, conta.Apelido, itens);
                }
            }
            return true;
        }

        private static void CriaPlanilha(ExcelPackage pck, string tabLabel, IEnumerable<BalanceItem> items) {
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
                ws.Cells[row, col++].Value = item.Conta.Apelido;
                ws.Cells[row, col++].Value = item.ContaID;
                ws.Cells[row, col++].Value = item.Data;
                ws.Cells[row, col++].Value = item.Historico;
                ws.Cells[row, col++].Value = item.Documento;
                ws.Cells[row, col++].Value = item.Valor;
                ws.Cells[row, col++].Value = item.AfetaSaldo;
                ws.Cells[row, col++].Value = item.Saldo;
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

        private bool ExportToExtrato() {
            // https://www.aspsnippets.com/Articles/The-OLE-DB-provider-Microsoft.Ace.OLEDB.12.0-for-linked-server-null.aspx
            var retorno = true;
            using (var ctx = new MoneyBinEntities()) {
                ctx.spExportToAccessExtrato(_saveAs);
            }

            MoneyBinDB.ExportToExtrato(_saveAs);

            var tempFile = Path.Combine(Path.GetDirectoryName(_saveAs),
                Path.GetRandomFileName() + Path.GetExtension(_saveAs));
            var app = new Microsoft.Office.Interop.Access.Application { Visible = false };
            try {
                app.CompactRepair(_saveAs, tempFile, false);
                var temp = new FileInfo(tempFile);
                temp.CopyTo(_saveAs, true);
                temp.Delete();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                retorno = false;
                //throw;
            }
            finally {
                app.Quit();
            }
            return retorno;
        }

        #endregion EXPORTING ---------------------------

    }
}