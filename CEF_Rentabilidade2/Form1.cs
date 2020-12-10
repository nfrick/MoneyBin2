using OfficeOpenXml;
using OfficeOpenXml.Style;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Clipboard = System.Windows.Clipboard;


namespace CEF_Rentabilidade2 {
    public partial class Form1 : MetroForm {
        public Form1() {
            InitializeComponent();
            SetTabs();
            MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
        }

        private void SetTabs() {
            rtbText.SelectionTabs = new[] { 400, 500, 600, 700, 800, 900, 1000 };
        }

        private void sfButtonProcess_Click(object sender, EventArgs e) {
            var textAsArray = rtbText.Lines;
            try {
                rtbText.Clear();
                rtbText.SelectionTabs = null;
                rtbText.Text = "Lendo dados... ";
                var dados = textAsArray.Select(r => new Info(r)).OrderBy(i => i.Fundo).ToList();
                rtbText.AppendText($"Lidos {dados.Count} fundos\n"); // Para forçar exception
                CriaPlanilha(dados);

                MessageBoxAdv.Show(this, $"{dados.Count} fundos lidos corretamente.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBoxAdv.Show(this, $"Erro: \n\n{ex.Message}",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetTabs();
                rtbText.Lines = textAsArray;
            }
        }

        private void CriaPlanilha(IEnumerable<Info> dados) {
            const string excelfile = @"D:\Users\Nelson Frick\SkyDrive\Documents\Financeiro\Caixa\Fundos CEF 3.xlsx";

            rtbText.AppendText("Criando planilha\n");
            var pck = new ExcelPackage(new FileInfo(excelfile));
            var ws = pck.Workbook.Worksheets.FirstOrDefault(s => s.Name == "CEF_Rent");
            if (ws == null) {
                ws = pck.Workbook.Worksheets.Add("CEF_Rent");
                ws.SetValue(1, 1, "Fundo");
                ws.SetValue(1, 2, "Var. Dia");
                ws.SetValue(1, 3, "Acum. Mês");
                ws.SetValue(1, 4, "Acum. Ano");
                ws.SetValue(1, 5, "Acum. 12 Meses");
            }
            else {
                var dim = new ExcelAddress(2, 1, ws.Dimension.Rows, ws.Dimension.Columns);
                ws.Cells[dim.Address].Clear();
            }

            ws.View.ShowGridLines = false;

            rtbText.AppendText("Gravando dados...\n");
            var row = 1;
            foreach (var info in dados) {
                rtbText.AppendText($"\t{info.Fundo}\n");
                ws.SetValue(++row, 1, info.Fundo);
                ws.SetValue(row, 2, info.VariaçãoDia);
                ws.SetValue(row, 3, info.AcumuladoMes);
                ws.SetValue(row, 4, info.AcumuladoAno);
                ws.SetValue(row, 5, info.Acumulado12M);
            }

            Console.WriteLine("Formatando planilha");
            ws.Cells[$"A2:A{row}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Cells[$"B2:E{row}"].Style.Numberformat.Format = "0.000%";
            ws.Cells.AutoFitColumns(0);

            ws.View.FreezePanes(2, 1);

            rtbText.AppendText("Salvando planilha...\n");
            pck.Save();
        }

        private void sfButtonColar_Click(object sender, EventArgs e) {
            if (rtbText.TextLength > 0) {
                rtbText.AppendText("\n");
            }
            rtbText.AppendText(Clipboard.GetText());
            rtbText.Lines = rtbText.Lines.Where(l => !string.IsNullOrEmpty(l)).ToArray();
        }
    }

    public class Info {
        public string Fundo { get; set; }
        public string Dados { get; set; }
        public decimal VariaçãoDia { get; set; }
        public decimal AcumuladoMes { get; set; }
        public decimal AcumuladoAno { get; set; }
        public decimal Acumulado12M { get; set; }

        private readonly Regex _regexData = new Regex(@"\d{2}\/\d{2}\/\d{4}");

        private static readonly char[] Seps = new[] { ' ', '\t' };

        public Info(string linha) {
            var match = _regexData.Match(linha);
            if (!match.Success) {
                return;
            }

            Fundo = linha.Substring(0, match.Index).Trim();
            Fundo = Regex.Replace(Fundo, @"\(\d\)", "").Trim();
            var dados = linha.Substring(match.Index + 11).Trim().Split(Seps);
            VariaçãoDia = Parse(dados, 2);
            AcumuladoMes = Parse(dados, 3);
            AcumuladoAno = Parse(dados, 4);
            Acumulado12M = Parse(dados, 5);
        }

        private static decimal Parse(IReadOnlyList<string> values, int pos) {
            return pos < values.Count ?
                !decimal.TryParse(values[pos], out var result) ? 0 : result / 100 :
                -1000;
        }

        public override string ToString() => $"{Fundo} - Dia: {VariaçãoDia}  Mês: {AcumuladoMes}  Ano: {AcumuladoAno}  12M: {Acumulado12M}";
    }
}