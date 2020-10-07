using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CEF_Rent {
    class Program {
        static void Main(string[] args) {
            const string textfile = @"D:\Users\Nelson Frick\Desktop\Fundos CEF.txt";
            try {
                Console.Write("Lendo dados... ");
                var textAsArray = File.ReadAllLines(textfile);
                var dados = textAsArray.Select(r => new Info(r)).OrderBy(i => i.Fundo);
                Console.WriteLine($"Lidos {dados.Count()} fundos"); // Para forçar exception
                //CriaPlanilha2();
                CriaPlanilha(dados);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Dados lidos corretamente.");
            }
            catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally {
                Console.ReadLine();
            }
        }

        private static void CriaPlanilha2() {
            const string textfile = @"D:\Users\Nelson Frick\Desktop\Fundos CEF.txt";
            const string excelfile = @"D:\Users\Nelson Frick\SkyDrive\Documents\Financeiro\Caixa\AAA.xlsx";
            var pck = new ExcelPackage(new FileInfo(excelfile));


            //Create the Worksheet
            var sheet = pck.Workbook.Worksheets.FirstOrDefault(s => s.Name == "CEF_Rent");
            ExcelTable tbl;
            if (sheet == null) {
                sheet = pck.Workbook.Worksheets.Add("CEF_Rent");
            }
            else {
                tbl = sheet.Tables.FirstOrDefault(t => t.Name == "CEF_Rent");
                if (tbl != null) {
                    sheet.Tables.Delete(tbl, true);
                }
            }

            //Create the format object to describe the text file
            var format = new ExcelTextFormat
            {
                TextQualifier = '"',
                Culture = new CultureInfo("pt-BR") { NumberFormat = { NumberDecimalSeparator = "," } },
                Encoding = Encoding.UTF8,
                Delimiter = '\t'
            };

            if (pck.Workbook.Styles.NamedStyles.All(s => s.Name != "Header")) {
                var headerStyle = pck.Workbook.Styles.CreateNamedStyle("Header");
                headerStyle.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                headerStyle.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                headerStyle.Style.WrapText = true;
            }

            //Now read the file into the sheet. Start from cell A1. Create a table with style 27. First row contains the header.
            Console.WriteLine("Loading the text file...");
            sheet.Cells["A1"].LoadFromText(new FileInfo(textfile), format, TableStyles.Medium27, true);
            sheet.DeleteColumn(10);
            sheet.DeleteColumn(9);
            sheet.DeleteColumn(2);
            sheet.Cells["A1:H1"].StyleName = "Header";
            tbl = sheet.Tables.FirstOrDefault(t => t.Name == "Table1");
            if (tbl != null) {
                tbl.Name = "CEF_Rent";
            }

            tbl.Range.Sort(0);

            pck.Save();
        }

        private static void CriaPlanilha(IEnumerable<Info> dados) {
            const string excelfile = @"D:\Users\Nelson Frick\SkyDrive\Documents\Financeiro\Caixa\Fundos CEF 3.xlsx";

            Console.WriteLine("Criando planilha");
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

            Console.WriteLine("Gravando dados");
            var row = 1;
            foreach (var info in dados) {
                Console.WriteLine($"\t{info.Fundo}");
                ws.SetValue(++row, 1, info.Fundo);
                ws.SetValue(row, 2, info.VariaçãoDia);
                ws.SetValue(row, 3, info.AcumuladoMes);
                ws.SetValue(row, 4, info.AcumuladoAno);
                ws.SetValue(row, 5, info.Acumulado12M);
            }

            //var table = ws.Tables.FirstOrDefault(t => t.Name == "tblCEF_Rent");
            //if (table != null) {
            //    ws.Tables.Delete(table);
            //}
            //table = ws.Tables.Add(new ExcelAddress(ws.Dimension.Address), "tblCEF_Rent");
            //table.TableStyle = TableStyles.Medium2;

            Console.WriteLine("Formatando planilha");
            ws.Cells[$"A2:A{row}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Cells[$"B2:E{row}"].Style.Numberformat.Format = "0.000%";
            ws.Cells.AutoFitColumns(0);

            ws.View.FreezePanes(2, 1);

            Console.WriteLine("Salvando planilha");
            pck.Save();
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
