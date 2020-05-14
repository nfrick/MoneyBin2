namespace DataLayer {
    public partial class Ativo {

        public override string ToString() => $"{Codigo} - {Nome}";

        public ObservableListSource<SerieHistorica> Cotacoes { get; set; }

        public void ResetCotacoes() {
            Cotacoes = null;
        }
    }
}
