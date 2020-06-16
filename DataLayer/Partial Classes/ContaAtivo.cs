using IEnumerableExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DataLayer {
    public partial class ContaAtivo {
        #region CONTAATIVO

        public override string ToString() => $"ContaID: {ContaId}  Código: {Codigo}";
        
        public decimal UltimoPreco => Ativo.AtivoUltimoPreco.PrecoUltimo;

        public DateTime UltimoPrecoData => Ativo.AtivoUltimoPreco.Data;

        public int Qtd => Operacoes.Sum(o => o.QtdComSinal);

        public decimal Total => UltimoPreco * Qtd;

        public ObservableListSource<Entrada> EntradasDisponiveis(Saida saida) =>
            Entradas.Where(e => e.Data <= saida.Data && e.Disponivel).ToObservableListSource();

        #endregion CONTAATIVO -----------------------------------


        #region COTACAO -----------------------------------------
        public SortedDictionary<DateTime, StockInfo> Cotacoes = new SortedDictionary<DateTime, StockInfo>();

        public const string TrendUp = "é";
        public const string TrendDown = "ê";
        public const string TrendNeutral = "l";
        public const string TrendNone = "¡";

        public void AtualizarCotacao(bool reset = false) {
            var offTime = DateTime.Now.Hour < 10 || DateTime.Now.Hour >= 17;
            if (reset || offTime) {
                Cotacoes.Clear();
            }

            if (offTime) {
                var cotacao5 = ObterCotacao(5);
                if (cotacao5 == null) {
                    return;
                }

                var serie = cotacao5.TimeSeries;
                var data = serie.ElementAt(0).Key.Date;
                foreach (var cot in serie.Where(c => c.Key.Date == data)) {
                    Cotacoes.Add(cot.Key, cot.Value);
                }
            }
            else {
                var cotacao1 = ObterCotacao(1);
                if (cotacao1 == null) {
                    return;
                }

                var serie = cotacao1.TimeSeries.Take(60);
                if (!Cotacoes.Any()) {
                    var horaInicio = DateTime.Today + new TimeSpan(10, 0, 0);
                    var maisAntigo = serie.Last().Key;
                    if (maisAntigo.CompareTo(horaInicio) < 0) {
                        var fechamento = serie
                            .First(c => c.Key.CompareTo(horaInicio) <= 0);
                        Cotacoes.Add(horaInicio, fechamento.Value);
                    }
                    else {
                        var cotacao5 = ObterCotacao(5);
                        if (cotacao5 != null) {
                            var fechamento = cotacao5.TimeSeries
                                .First(c => c.Key.CompareTo(horaInicio) <= 0);
                            if (!Cotacoes.ContainsKey(horaInicio)) {
                                Cotacoes.Add(horaInicio, fechamento.Value);
                            }

                            foreach (var cot in cotacao5.TimeSeries
                                .SkipWhile(c => c.Key.CompareTo(maisAntigo) > 0)
                                .TakeWhile(c => c.Key.CompareTo(horaInicio) > 0)) {
                                if (!Cotacoes.ContainsKey(cot.Key)) {
                                    Cotacoes.Add(cot.Key, cot.Value);
                                }
                            }
                        }
                    }
                }
                var maisRecente = Cotacoes.Last().Key;
                foreach (var cot in serie.TakeWhile(c => c.Key.CompareTo(maisRecente) > 0)) {
                    Cotacoes.Add(cot.Key, cot.Value);
                }
            }
        }

        public AlphaVantage ObterCotacao(int interval) {
            var request = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={Codigo}.SA&interval={interval}min&apikey=5M72TGSVJXVYAO5W";

            using (var web = new WebClient()) {
                try {
                    AlphaVantage cotacao;
                    do {
                        var json = web.DownloadString(request);
                        cotacao = JsonConvert.DeserializeObject<AlphaVantage>(json);
                    } while (cotacao.MetaData == null);
                    return cotacao;
                }
                catch (System.Net.WebException ex) {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool JaNegociado => Operacoes.Any();

        public bool Corrente => Qtd > 0;

        private IEnumerable<Entrada> Vendaveis => Entradas.Where(o => o.QtdDisponivel > 0 && o.ValorReal < LastTrade);

        public int QtdVendavel => Corrente ? Vendaveis.Sum(o => o.QtdDisponivel) : 0;

        public decimal VMVendavel => QtdVendavel == 0 ? 0 : Vendaveis.Sum(o => o.QtdDisponivel * o.ValorReal) / QtdVendavel;

        public decimal? LucroImediato => QtdVendavel * (LastTrade - VMVendavel);

        public decimal ValorMedioCompra => JaNegociado ? _valorMedioCompra(false) : 0;

        public decimal ValorMedioCompraReal => JaNegociado ? _valorMedioCompra(true) : 0;

        public decimal? AlertaVenda => LastTrade == 0 || ValorMedioCompraReal == 0 ? 10m : LastTrade / ValorMedioCompraReal;

        private decimal _valorMedioCompra(bool real) =>
           Operacoes
                .OrderByDescending(o => o.Data)
                .TakeWhile(o => o.QtdAcumulada > 0)
                .Where(o => o.IsEntrada).Reverse()
                .Aggregate(0.0m,
                    (current, operacao) => (current * operacao.QtdAntes +
                                (real ? operacao.ValorOperacaoComTaxasReal : operacao.ValorOperacaoComTaxas)) / operacao.QtdAcumulada);

        public decimal Patrimonio => LastTrade * Qtd;

        public decimal Lucro => (LastTrade - ValorMedioCompra) * Qtd;

        public decimal LucroReal => (LastTrade - ValorMedioCompraReal) * Qtd;

        public bool HasTrades => Cotacoes.Any();

        public decimal? Open => HasTrades ? Cotacoes.First().Value.open : 0;

        public decimal? PreviousClose => HasTrades ? Cotacoes.ElementAt(0).Value.close : 0;

        public decimal LastTrade => HasTrades ? Cotacoes.Last().Value.close : 0;

        public DateTime? LastTradeDate => HasTrades ? (DateTime?)Cotacoes.Last().Key : null;

        public decimal? PreviousTrade => Cotacoes.Count > 1 ? Cotacoes.ElementAt(Cotacoes.Count - 2).Value.close : 0;

        public string Trend {
            get {
                if (LastTrade == 0 || PreviousTrade == 0) {
                    return TrendNone;
                }

                return LastTrade > PreviousTrade ? TrendUp :
                (LastTrade < PreviousTrade ? TrendDown :
                    TrendNeutral);
            }
        }

        public double DayLow => (double)(HasTrades ? Cotacoes.Min(c => c.Value.low) : 0);

        public double DayHigh => (double)(HasTrades ? Cotacoes.Max(c => c.Value.high) : 0);

        public decimal? Change => LastTrade - Open;

        public decimal? ChangePercent => HasTrades ? Change / Open : 0;
    }
    #endregion COTACAO
}