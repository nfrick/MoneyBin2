using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DataLayer {
    public abstract class Cotacao {
        public virtual string CCodigo => null;
        public virtual DateTime? CData => null;
        public LoadStatus Status { get; private set; }

        public SortedDictionary<DateTime, StockInfo> Cotacoes; //= new SortedDictionary<DateTime, StockInfo>();
        public SortedDictionary<DateTime, StockInfo> CotacoesFiltradas; //= new SortedDictionary<DateTime, StockInfo>();

        public const string TrendUp = "é";
        public const string TrendDown = "ê";
        public const string TrendNeutral = "l";
        public const string TrendNone = "¡";

        public enum LoadStatus {
            NotLoaded,
            NoData,
            Loaded,
            Error
        }

        protected Cotacao() {
            Status = LoadStatus.NotLoaded;
        }

        public void ObterCotacoes() {
            if (HasTrades) {
                return;
            }

            var request = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={CCodigo}.SA&apikey=5M72TGSVJXVYAO5W";
            using (var web = new WebClient()) {
                try {

                    AlphaVantage cotacao;
                    var i = 0;
                    do {
                        var json = web.DownloadString(request);
                        cotacao = JsonConvert.DeserializeObject<AlphaVantage>(json);
                    } while (cotacao.NoData && ++i < 10);
                    Status = cotacao.NoData ? LoadStatus.NoData : LoadStatus.Loaded;
                    Cotacoes = cotacao.NoData ? null : new SortedDictionary<DateTime, StockInfo>(cotacao.DailySeries);
                }
                catch (WebException ex) {
                    Console.WriteLine(ex.Message);
                    Status = LoadStatus.Error;
                    Cotacoes = null;
                }
            }
        }

        public void ObterCotacoes(DateTime inicio, DateTime termino, bool useData) {
            ObterCotacoes();
            FiltrarCotacoes(inicio, termino, useData);
        }

        public void FiltrarCotacoes() {
            CotacoesFiltradas = Cotacoes == null ? null :
                new SortedDictionary<DateTime, StockInfo>(Cotacoes);
        }

        public void FiltrarCotacoes(DateTime inicio, DateTime termino, bool useData) {
            var inicioreal = !useData || CData == null ? 
                inicio : 
                (new[] { (DateTime)CData, inicio }.Max());
            CotacoesFiltradas = Cotacoes == null ? null :
                new SortedDictionary<DateTime, StockInfo>(Cotacoes
                    .Where(c => c.Key >= inicioreal && c.Key <= termino)
                    .ToDictionary(p => p.Key, p => p.Value));
        }

        public bool HasTrades => CotacoesFiltradas?.Any() ?? false;

        public KeyValuePair<DateTime, StockInfo> PrimeiraCotacao => CotacoesFiltradas.First();

        public KeyValuePair<DateTime, StockInfo> UltimaCotacao => CotacoesFiltradas.Last();

        public KeyValuePair<DateTime, StockInfo> PenultimaCotacao => CotacoesFiltradas.ElementAt(CotacoesFiltradas.Count - 2);

        public decimal? FirstOpen => HasTrades ? PrimeiraCotacao.Value.open : 0;

        public decimal? LastOpen => HasTrades ? UltimaCotacao.Value.open : 0;

        public decimal LastClose => HasTrades ? UltimaCotacao.Value.close : 0;

        public decimal? PreviousClose => HasTrades ? PenultimaCotacao.Value.close : 0;

        public DateTime? FirstTradeDate => HasTrades ? (DateTime?)PrimeiraCotacao.Key : null;

        public DateTime? LastTradeDate => HasTrades ? (DateTime?)UltimaCotacao.Key : null;

        public string Trend {
            get {
                if (LastClose == 0 || PreviousClose == 0) {
                    return TrendNone;
                }

                return LastClose > PreviousClose ? TrendUp :
                    (LastClose < PreviousClose ? TrendDown :
                        TrendNeutral);
            }
        }

        public double RangeLow => (double)(HasTrades ? CotacoesFiltradas.Min(c => c.Value.low) : 0);

        public double RangeHigh => (double)(HasTrades ? CotacoesFiltradas.Max(c => c.Value.high) : 0);

        public double DayLow => (double)(HasTrades ? UltimaCotacao.Value.low : 0);

        public double DayHigh => (double)(HasTrades ? UltimaCotacao.Value.high : 0);

        public decimal? LastDayChange => LastClose - LastOpen;

        public decimal? DayChangePercent => HasTrades ? LastDayChange / LastOpen : 0;

        public decimal? IntraNightChange => PreviousClose - LastOpen;

        public decimal? RangeChangePercent => HasTrades ? (LastClose - FirstOpen) / FirstOpen : 0;
    }
}