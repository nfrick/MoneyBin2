namespace DataLayer {
    public partial class Ativo {

        public ObservableListSource<SerieHistorica> Cotacoes { get; set; }

        public void ResetCotacoes() {
            Cotacoes = null;
        }
    }
}
