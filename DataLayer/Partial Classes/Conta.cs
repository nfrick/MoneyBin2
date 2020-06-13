using CsvHelper;
using IEnumerableExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace DataLayer {
    public partial class Conta : ICloneable {

        public override string ToString() => $"{Banco.Sigla} {AgenciaComDV} {ContaCorrenteComDV}";

        private Conta _backup;
        public List<BalanceItem> Extrato { get; set; }
        public bool Selecionada { get; set; }

        // DADOS BANCÁRIOS
        public string AgenciaComDV => string.IsNullOrWhiteSpace(AgenciaDV) ? Agencia : $"{Agencia}-{AgenciaDV}";
        public string ContaCorrenteComDV => $"{ContaCorrente}-{ContaCorrenteDV}";

        #region BALANCE ------------------
        public bool BalanceHasData => Balance.Any();

        public DateTime DataMin => BalanceHasData ? Balance.Min(b => b.Data) : DateTime.Today;
        public DateTime DataMax => BalanceHasData ? Balance.Max(b => b.Data) : DateTime.Today;

        public decimal Saldo => BalanceHasData ?
            Balance.OrderByDescending(b => b.Data)
                .ThenByDescending(b => b.ID).First().Saldo ?? 0 : 0;

        public decimal SaldoUltimoMes => BalanceHasData ?
            Balance.OrderByDescending(b => b.Data)
                .ThenByDescending(b => b.ID)
                .SkipWhile(b => b.Data > DateTime.Today.AddDays(-DateTime.Today.Day))
                .First().Saldo ?? 0 : 0;

        public IEnumerable<string> Grupos => Balance.Select(b => b.Grupo)
            .Where(g => g != null).Distinct().OrderBy(g => g);

        public IEnumerable<BalanceItem> BalanceFiltrado(
            DateTime inicio,
            DateTime termino,
            bool afetaSaldo = true,
            ListSortDirection sort = ListSortDirection.Ascending) =>
            sort == ListSortDirection.Ascending
                ? Balance
                    .Where(b => (b.AfetaSaldo || afetaSaldo) &&
                        b.Data >= inicio && b.Data <= termino)
                    .OrderBy(b => b.Data).ThenBy(b => b.ID)
                : Balance
                    .Where(b => (b.AfetaSaldo || afetaSaldo) &&
                                b.Data >= inicio && b.Data <= termino)
                    .OrderByDescending(b => b.Data).ThenByDescending(b => b.ID)
            ;

        public IEnumerable<BalanceItem> BalanceFiltrado(DateTime inicio,
            DateTime termino, string grupo, bool afetaSaldo = true,
            ListSortDirection sort = ListSortDirection.Ascending) =>
            grupo == "Todos"
            ? BalanceFiltrado(inicio, termino, afetaSaldo, sort)
            : (sort == ListSortDirection.Ascending
                ? Balance
                    .Where(b => (b.AfetaSaldo || afetaSaldo) &&
                        b.Grupo == grupo && b.Data >= inicio && b.Data <= termino)
                    .OrderBy(b => b.Data).ThenBy(b => b.ID)
                : Balance
                    .Where(b => (b.AfetaSaldo || afetaSaldo) &&
                        b.Grupo == grupo && b.Data >= inicio && b.Data <= termino)
                    .OrderByDescending(b => b.Data).ThenByDescending(b => b.ID))
            ;

        public IEnumerable<BalanceItem> BalanceFiltrado(DateTime inicio,
            DateTime termino, IEnumerable<string> grupos, bool afetaSaldo = true,
            ListSortDirection sort = ListSortDirection.Ascending) =>
            sort == ListSortDirection.Ascending
                ? Balance
                    .Where(b => (b.AfetaSaldo || afetaSaldo) &&
                        (grupos?.Contains(b.Grupo) ?? false) &&
                        b.Data >= inicio &&
                        b.Data <= termino)
                    .OrderBy(b => b.Data).ThenBy(b => b.ID)
                : Balance
                    .Where(b => (b.AfetaSaldo || afetaSaldo) &&
                        (grupos?.Contains(b.Grupo) ?? false) &&
                        b.Data >= inicio &&
                        b.Data <= termino)
                    .OrderByDescending(b => b.Data).ThenByDescending(b => b.ID)
            ;

        public decimal CalculaBalance() {
            return CalculaSaldos(Balance);
        }
        #endregion BALANCE -----------

        #region LEITURA DE EXTRATO --------------
        public bool ExtratoHasData => Extrato != null && Extrato.Any();

        public bool ExtratoHasAddToDB => Extrato != null && Extrato.Any(i => i.AddToDB);

        public int ExtratoAddToDBCount => Extrato.Count(i => i.AddToDB);

        public void LimpaExtrato() {
            Extrato.Clear();
        }

        public void ExtratoParaBalance() {
            foreach (var bal in Extrato.Where(i => i.AddToDB)
                .OrderBy(i => i.Data).ThenBy(i => i.Valor)) {
                Balance.Add(bal);
            }
            Extrato.Clear();
        }

        public decimal CalculaExtrato() {
            return CalculaSaldos(Extrato);
        }

        public void LerExtratos(string[] arquivos, bool getAll, IEnumerable<Regra> regras) {
            var extrato = new List<BalanceItem>();
            if (Extrato != null) {
                extrato.AddRange(Extrato);
            }

            foreach (var arquivo in arquivos) {
                //var extension = Path.GetExtension(arquivo).ToLower();
                //extension.Equals(".xls") ? 
                //ExtratoFromXML(arquivo, getAll) : 
                var entries = ExtratoFromCSV(arquivo, getAll);
                if (entries == null || !entries.Any()) {
                    continue;
                }

                extrato.AddRange(entries.Except(extrato));
                //extrato.AddRange(getAll ? entries : entries.SkipWhile(i => i.Data.CompareTo(DataMax) < 0));
            }
            Extrato = extrato.OrderByDescending(e => e.Data).ToList();
            ClassificaItens(regras);
        }

        private IEnumerable<BalanceItem> ExtratoFromCSV(string filepath, bool getAll) {
            using (TextReader reader = new StreamReader(filepath, Encoding.Default)) {
                var csv = new CsvReader(reader, new CultureInfo("pt-br"));
                if (Banco.Sigla == "BB") {
                    csv.Configuration.RegisterClassMap<ExtratoBBMap>();
                }
                else {
                    csv.Configuration.RegisterClassMap<ExtratoCEFMap>();
                }
                ExtratoMap.Conta = ID;
                ExtratoMap.DefineFormatoData(filepath, Banco.CSVPosicaoData, Banco.CSVSeparador);
                csv.Configuration.Delimiter = Banco.CSVSeparador;
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.HeaderValidated = null;

                try {
                    // O "ToList() é necessário pois o CSVreader é fechado quando a execução do método termina
                    return getAll ? csv.GetRecords<BalanceItem>().ToList() :
                        csv.GetRecords<BalanceItem>()
                        .SkipWhile(i => i.Data.CompareTo(DataMax) < 0).ToList();
                }
                catch (Exception) {
                    return null;
                    throw;
                }
            }
        }

        private IEnumerable<BalanceItem> ExtratoFromXML(string filepath, bool getAll) {
            //_entries = new List<BalanceItem>();

            //var htmlContent = File.ReadAllText(filepath).Replace("Saldo<td>", "Saldo</td>");
            //var xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml("<root />");

            //var rootEle = xmlDoc.DocumentElement;
            //rootEle.InnerXml = htmlContent;

            ////Get the table node
            //var xTableNode = rootEle.SelectSingleNode("html")
            //    .SelectSingleNode("body").SelectSingleNode("table");

            ////Get each row node
            //var rows = xTableNode.SelectNodes("tr");
            //for (var i = 1; i < rows.Count; i++) {
            //    var xTDNode = rows[i].SelectNodes("td")[0];
            //    _entries.Add(new BalanceItem(xTDNode, _conta.ID));
            //}
            return null;
        }
        #endregion LEITURA DE EXTRATO --------------

        private decimal CalculaSaldos(IEnumerable<BalanceItem> items) {
            var sortedItems = items.OrderBy(b => b.Data).ThenBy(b => b.ID).ThenBy(b => b.Valor);
            var saldo = 0.0m;
            foreach (var bal in sortedItems) {
                saldo += bal.ValorParaSaldo;
                bal.Saldo = saldo;
            }
            return saldo;
        }

        #region CLASSIFICACAO ------------------
        private void ClassificaItens(IEnumerable<Regra> regras) {
            if (!Extrato.Any()) {
                return;
            }

            var minData = Extrato.Min(p => p.Data);
            var maxData = Extrato.Max(p => p.Data);

            var existing = Balance
                .Where(bi => bi.Data >= minData && bi.Data <= maxData)
                .ToList();

            foreach (var regra in regras) {
                regra.Initialize();
            }

            foreach (var item in Extrato) {
                foreach (var regra in regras) {
                    if (regra.MatchAndUpdate(item)) {
                        break;
                    }
                }
                item.AfetaSaldo = !item.Historico.Contains("Depósito bloq") && item.AfetaSaldo;
                item.AddToDB = item.AddToDB && !existing.Any(d => d.Similar(item));
            }
        }
        #endregion CLASSIFICACAO ------------------

        #region CLONE -------------
        public object Clone() {
            return this.MemberwiseClone();
        }

        public void SaveCopy() {
            _backup = (Conta)Clone();
        }

        public void Reset() {
            this.Agencia = _backup.Agencia;
            this.AgenciaDV = _backup.AgenciaDV;
            this.Apelido = _backup.Apelido;
            this.Celular = _backup.Celular;
            this.ContaCorrente = _backup.ContaCorrente;
            this.ContaCorrenteDV = _backup.ContaCorrenteDV;
            this.Dono = _backup.Dono;
            this.EMail = _backup.EMail;
            this.Gerente = _backup.Gerente;
            this.Operacao = _backup.Operacao;
            this.Telefone = _backup.Telefone;
        }
        #endregion CLONE -------------

        #region ACOES ------------------
        public ObservableListSource<ContaAtivo> AcoesNaoZerado =>
            Acoes.Where(a=>a.Qtd > 0).ToObservableListSource();

        public ObservableListSource<ContaAtivo> AcoesZerado =>
            Acoes.Where(a => a.Qtd == 0).ToObservableListSource();

        public ObservableListSource<Patrimonio> PatrimonioAcoes => Acoes
            .Select(a => new Patrimonio { Tipo = "Ações", Item = a.Codigo, Valor = a.Total })
            .OrderBy(p => p.Item).ToObservableListSource();

        public ObservableListSource<Patrimonio> PatrimonioAcoesNaoZerado => PatrimonioAcoes
            .Where(p => p.Valor > 0).ToObservableListSource();
        
        public IEnumerable<Patrimonio> PatrimonioAcoesTotal {
            get {
                var total = new List<Patrimonio> {
                    new Patrimonio {
                        Tipo = "Total Ações",
                        Item = null,
                        Valor = AcoesNaoZerado.Sum(a => a.Total)
                    }
                };

                return total;
            }
        }

        #endregion ACOES ------------------

        #region FUNDOS --------------------
        public ObservableListSource<ContaFundo> FundosNaoZerado =>
            Fundos.Where(f => f.Saldo != 0).ToObservableListSource();

        public ObservableListSource<Patrimonio> PatrimonioFundos =>
            new ObservableListSource<Patrimonio>()
                .Concat(new List<Patrimonio> {new Patrimonio {
                        Tipo = "Saldo em Conta",
                        Item = "Saldo em Conta",
                        Valor = SaldoUltimoMes
                    }
                })
                .Concat(
                    Fundos
                        .Select(f => new Patrimonio {
                            Tipo = "Fundos",
                            Item = f.FundoApelido,
                            Valor = f.Saldo
                        }).OrderBy(p => p.Item))
                .ToObservableListSource();

        public ObservableListSource<Patrimonio> PatrimonioFundosNaoZerado =>
            PatrimonioFundos.Where(f => f.Valor > 0).ToObservableListSource();

        public ObservableListSource<Patrimonio> PatrimonioFundosTotal {
            get {
                var total = new ObservableListSource<Patrimonio> {
                    new Patrimonio {
                        Tipo = "Total Fundos",
                        Item = null,
                        Valor = FundosNaoZerado.Sum(f => f.Saldo)
                    }
                };

                return total;
            }
        }
        #endregion FUNDOS --------------------

        #region PATRIMÔNIO --------------------

        public ObservableListSource<Patrimonio> PatrimonioTotal =>
            PatrimonioAcoes
                .Concat(PatrimonioFundos)
                .OrderByDescending(a => a.Tipo).ThenByDescending(a => a.Item)
                .ToObservableListSource();

        public ObservableListSource<Patrimonio> PatrimonioTotalNaoZerado =>
            PatrimonioTotal.Where(p => p.Valor > 0).ToObservableListSource();

        #endregion PATRIMÔNIO -----------------
    }

    public class Patrimonio {
        public string Tipo { get; set; }
        public string Item { get; set; }
        public decimal Valor { get; set; }

        public override string ToString() => $"{Tipo} {Item} {Valor}";
    }
}