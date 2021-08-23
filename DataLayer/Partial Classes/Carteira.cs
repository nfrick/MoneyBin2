using System;
using System.Linq;

namespace DataLayer {
    public partial class Carteira {
        private DateTime? _inicio;
        private DateTime? _termino;
        private bool _useData;

        public void ObterCotacoes() {
            foreach (var acao in Ativos.Where(a => a.Status == Cotacao.LoadStatus.NotLoaded)) {
                acao.ObterCotacoes();
            }
        }

        public void Filtrar(DateTime inicio, DateTime termino, bool useData) {
            var datas = new[] { inicio, termino };
            var minData = datas.Min();
            var maxData = datas.Max();
            if (useData != _useData || _inicio != minData || _termino != maxData) {
                foreach (var acao in Ativos) {
                    acao.FiltrarCotacoes(minData, maxData, useData);
                }
                _inicio = minData;
                _termino = maxData;
                _useData = useData;
            }
        }
    }
}
