using System;
using System.Linq;
using IEnumerableExtensions;

namespace DataLayer {
    public partial class ContaAtivo {
        public decimal UltimoPreco => Ativo.AtivoUltimoPreco.PrecoUltimo;

        public DateTime UltimoPrecoData => Ativo.AtivoUltimoPreco.Data;

        public int Qtd => Operacoes.Sum(o => o.QtdComSinal);

        public decimal Total => UltimoPreco * Qtd;

        public ObservableListSource<Entrada> EntradasDisponiveis(Saida saida) =>
            Entradas.Where(e => e.Data <= saida.Data && e.Disponivel).ToObservableListSource();
    }
}
