using System.Linq;
using IEnumerableExtensions;

namespace DataLayer {
    public partial class Ativo {

        public override string ToString() => $"{Codigo} - {Nome}";

        public ObservableListSource<SerieHistorica> Cotacoes { get; set; }

        public void ResetCotacoes() {
            Cotacoes = null;
        }

        public bool TemCotacoes => Cotacoes != null && Cotacoes.Any();

        public decimal Min => TemCotacoes ? Cotacoes.Min(c => c.PrecoUltimo) : 0;

        public decimal Max => TemCotacoes ? Cotacoes.Max(c => c.PrecoUltimo) : 0;

        // A ordem das cotações é DECRESCENTE por data
        public decimal Primeiro => TemCotacoes ? Cotacoes.Last().PrecoUltimo : 0;

        public decimal Ultimo => TemCotacoes ? Cotacoes.First().PrecoUltimo : 0;

        public decimal Variacao => TemCotacoes ? (Ultimo - Primeiro) / Primeiro : 0;
    }
}
