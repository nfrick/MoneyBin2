using DataLayer;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using Ookii.Dialogs.WinForms;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Clipboard = System.Windows.Clipboard;


namespace Rentabilidades {
    public partial class Form1 : MetroForm {
        private readonly string _excelFile = Properties.Settings.Default.ExcelFilePath;
        //private readonly string _excelFile = @"D:\Users\Nelson Frick\SkyDrive\Documents\Financeiro\Caixa\Fundos BB e CEF2.xlsm";

        #region FORM

        public Form1() {
            InitializeComponent();
            SetTabs();
            MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
        }

        private void toolStripButtonColar_Click(object sender, EventArgs e) {
            var linhas = Info.RemoveComments(Clipboard.GetText()).Split(new [] { "\r\n" }, StringSplitOptions.None).Where(l => !string.IsNullOrEmpty(l) && l.Length > 20).ToArray();
            rtbText.Lines = rtbText.Lines.Concat(linhas).ToArray();
        }

        private void toolStripButtonProcessCEF_Click(object sender, EventArgs e) {
            //private async void toolStripButtonProcessCEF_Click(object sender, EventArgs e) {
            var dados = ProcessarCEF();
            //await CriaPlanilhaCEF(dados);
            CriaPlanilhaCEF(dados);
            ShowSuccess(dados.Select(d => d.Fundo));
        }

        private void toolStripButtonCEFMoneyBin_Click(object sender, EventArgs e) {
            var dados = ProcessarCEF();
            if (dados == null) {
                return;
            }
            AddToDatabase(dados, "CEF");
            ShowSuccess(dados.Select(d => d.Fundo));
        }

        private void toolStripButtonProcessBB_Click(object sender, EventArgs e) {
            //private async void toolStripButtonProcessarBB_Click(object sender, EventArgs e) {
            var dados = ProcessarBB();
            if (dados == null) {
                return;
            }
            //await CriaPlanilhaBB(dados);
            CriaPlanilhaBB(dados);
            ShowSuccess(dados.Select(d => d.Fundo));
        }

        private void toolStripButtonBBMoneyBin_Click(object sender, EventArgs e) {
            var dados = ProcessarBB();
            if (dados == null) {
                return;
            }
            AddToDatabase(dados, "BB");
            ShowSuccess(dados.Select(d => d.Fundo));
        }

        #endregion

        private List<InfoCEF> ProcessarCEF() {
            var textAsArray = rtbText.Lines;
            try {
                rtbText.Clear();
                rtbText.SelectionTabs = null;
                rtbText.Text = "Lendo dados... ";
                var dados = textAsArray.Where(r => !string.IsNullOrEmpty(r.Trim()))
                    .Select(r => new InfoCEF(r)).OrderBy(i => i.Fundo)
                    .Where(d => !string.IsNullOrEmpty(d.Fundo))
                    .ToList();
                rtbText.AppendText($"Lidos {dados.Count} fundos\n"); // Para forçar exception
                return dados;
            }
            catch (Exception ex) {
                ShowError(ex);
                rtbText.Lines = textAsArray;
                return null;
            }
        }

        private void CriaPlanilhaCEF(IEnumerable<InfoCEF> dados) {
            //private async Task CriaPlanilhaCEF(IEnumerable<InfoCEF> dados) {
            using (var pck = new ExcelPackage(new FileInfo(_excelFile))) {
                var table = AbrePlanilha(pck, "CEF");
                var ws = table.WorkSheet;

                try {
                    //var range = ws.Cells["A1"].LoadFromCollection(dados, true, //    OfficeOpenXml.Table.TableStyles.Medium8,
                    //    BindingFlags.Instance | BindingFlags.Public,
                    //    dados.First().OrderedProperties);

                    rtbText.AppendText("Gravando dados...\n");
                    int row = 2;
                    table.InsertRow(1, dados.Count() - 1);
                    // Fundo	Var. Dia	Mês	Ano	12 Meses	Valor Cota
                    foreach (var dado in dados) {
                        ws.Cells[row, 1].Value = dado.Fundo;
                        ws.Cells[row, 2].Value = dado.VariaçãoDia;
                        ws.Cells[row, 3].Value = dado.AcumuladoMes;
                        ws.Cells[row, 4].Value = dado.AcumuladoAno;
                        ws.Cells[row, 5].Value = dado.Acumulado12M;
                        ws.Cells[row, 6].Value = dado.ValorCota;
                        row++;
                    }
                    row--;

                    rtbText.AppendText("Formatando planilha...\n");
                    ws.Cells[$"A2:A{row}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    ws.Cells[$"B2:E{row}"].Style.Numberformat.Format = "0.000%";
                    ws.Cells[$"F2:F{row}"].Style.Numberformat.Format = "#,##0.0000";

                    ws.Cells[$"A1:F1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    ws.Cells[$"A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells[$"A1:F1"].Style.WrapText = true;

                    table.Range.AutoFitColumns(0);
                    ws.View.FreezePanes(2, 1);
                    ws.View.ZoomScale = 130;

                    rtbText.AppendText("Salvando planilha...\n");
                    //await pck.SaveAsync();
                    pck.Save();
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        private List<InfoBB> ProcessarBB() {
            var textAsArray = rtbText.Lines;
            try {
                rtbText.Clear();
                rtbText.SelectionTabs = null;
                rtbText.Text = "Lendo dados... ";
                var dados = textAsArray.Where(r => !string.IsNullOrEmpty(r.Trim()))
                    .Select(r => new InfoBB(r)).OrderBy(i => i.Fundo)
                    .Where(d => !string.IsNullOrEmpty(d.Fundo))
                    .ToList();
                rtbText.AppendText($"Lidos {dados.Count} fundos\n"); // Para forçar exception
                return dados;
            }
            catch (Exception ex) {
                ShowError(ex);
                rtbText.Lines = textAsArray;
                return null;
            }
        }

        private void CriaPlanilhaBB(IEnumerable<InfoBB> dados) {
            //private async Task CriaPlanilhaBB(IEnumerable<InfoBB> dados) {
            using (var pck = new ExcelPackage(new FileInfo(_excelFile))) {
                var table = AbrePlanilha(pck, "BB");
                var ws = table.WorkSheet;

                rtbText.AppendText("Gravando dados...\n");
                //var range = ws.Cells["A1"].LoadFromCollection(dados, true, OfficeOpenXml.Table.TableStyles.Medium8,
                //    BindingFlags.Instance | BindingFlags.Public, dados.First().OrderedProperties);

                int row = 2;
                table.InsertRow(1, dados.Count() - 1);
                // Fundo	Var. Dia	Mês	    Mês Anterior	Ano	12 Meses	Taxa Adm.	Data Cotação	Valor Cota

                foreach (var dado in dados) {
                    ws.Cells[row, 1].Value = dado.Fundo;
                    ws.Cells[row, 2].Value = dado.VariaçãoDia;
                    ws.Cells[row, 3].Value = dado.AcumuladoMes;
                    ws.Cells[row, 4].Value = dado.MesAnterior;
                    ws.Cells[row, 5].Value = dado.AcumuladoAno;
                    ws.Cells[row, 6].Value = dado.Acumulado12M;
                    ws.Cells[row, 7].Value = dado.TaxaAdm;
                    ws.Cells[row, 8].Value = dado.DataCotacao;
                    ws.Cells[row, 9].Value = dado.ValorCota;
                    row++;
                }
                row--;

                rtbText.AppendText("Formatando planilha...\n");
                ws.Cells[$"A2:A{row}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                ws.Cells[$"B2:F{row}"].Style.Numberformat.Format = "0.000%";
                ws.Cells[$"G2:G{row}"].Style.Numberformat.Format = "0.00%";
                ws.Cells[$"H2:H{row}"].Style.Numberformat.Format = "dd-MM-yyyy";
                ws.Cells[$"I2:I{row}"].Style.Numberformat.Format = "#,##0.00000";

                ws.Cells[$"A1:I1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells[$"A1:I1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Cells[$"A1:I1"].Style.WrapText = true;

                table.Range.AutoFitColumns();
                ws.View.FreezePanes(2, 1);
                ws.View.ZoomScale = 130;

                rtbText.AppendText("Salvando planilha...\n");
                //await pck.SaveAsync();
                pck.Save();
            }
        }

        private ExcelTable AbrePlanilha(ExcelPackage pck, string bank) {
            var sheet = $"{bank}_Rent";
            var tableName = $"tbl{sheet}";

            rtbText.AppendText($"Criando planilha {sheet}\n");
            var ws = pck.Workbook.Worksheets.FirstOrDefault(s => s.Name == sheet) ??
                pck.Workbook.Worksheets.Add(sheet);

            pck.Workbook.Worksheets.MoveAfter(sheet, bank);

            ws.View.ShowGridLines = false;
            if (ws.Cells["A1"].Value == null) {
                var headers = bank == "BB" ? new InfoBB("").ColumnHeaders : new InfoCEF("").ColumnHeaders;
                for (var i = 0; i < headers.Count(); i++) {
                    ws.Cells[1, i + 1].Value = headers[i];
                }
                ws.Tables.Add(ws.Cells[1, 1, ws.Dimension.End.Row + 1, ws.Dimension.End.Column], tableName);
            }

            var table = ws.Tables[tableName];
            if (table.Range.Rows > 2)
                table.DeleteRow(1, table.Range.Rows - 2);
            table.TableStyle = TableStyles.Medium8;
            return table;
        }

        private void ShowSuccess(IEnumerable<string> fundos) {
            taskDialog.MainIcon = TaskDialogIcon.Information;
            taskDialog.MainInstruction = $"{fundos.Count()} fundos lidos corretamente.";
            taskDialog.ExpandedInformation = string.Join("\n", fundos);
            taskDialog.ShowDialog();
            SetTabs();
        }

        private void ShowError(Exception ex) {
            ShowError("Erro ao ler arquivo.", ex.Message);
        }

        private void ShowError(string mainMessage, string expandedInfo) {
            taskDialog.MainIcon = TaskDialogIcon.Warning;
            taskDialog.MainInstruction = mainMessage;
            taskDialog.ExpandedInformation = expandedInfo;
            taskDialog.ShowDialog();
            SetTabs();
        }

        private void AddToDatabase(IEnumerable<Info> dados, string banco) {
            using (var ctx = new MoneyBinEntities()) {
                var novoMes = "2019-01";
                var rentsAtuais = ctx.Rentabilidades.Where(r => r.Banco == banco);
                if (rentsAtuais.Any()) {
                    var ultimoMes = ctx.Rentabilidades.Where(r => r.Banco == banco)
                        .Select(r => r.Mes).Max();

                    novoMes = ultimoMes.AddMonths(1).ToString("yyyy-MM");
                }
                if (SuperPrompt.PromptDialog
                    .InputString($"Rentabilidade {banco}", "Entre o mês", ref novoMes) ==
                    DialogResult.Cancel) {
                    return;
                }

                var rents = dados.Select(d => d.ToRentabilidade(novoMes, banco)).OrderBy(r => r.FundoNome);
                foreach (var rent in rents) {
                    rent.FundoId = ctx.Fundos.First(f => f.NomeTabRent == rent.FundoNome).ID;
                }
                ctx.Rentabilidades.AddRange(rents);
                if (ctx.SaveChanges(out var errorMessage)) {
                    return;
                }
                ShowError("Erro ao adicionar ao database.", errorMessage);
            }
        }

        private void SetTabs() {
            rtbText.Clear();
            rtbText.SelectionTabs = new[] { 400, 500, 600, 700, 800, 900, 1000 };
        }
    }
}