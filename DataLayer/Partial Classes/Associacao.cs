using System;

namespace DataLayer {
    public partial class Associacao {
        public override string ToString() {
            return $"{Saida.Codigo} - Saída: {Saida.Data:d} {Saida.Qtd}  Entrada: {Entrada?.Data:d} {Entrada?.Qtd}";
        }

        public DateTime Data => Entrada?.Data ?? DateTime.Today;

        public string Tipo => Entrada?.OperacaoTipo.Tipo ?? string.Empty;

        public int QtdEntrada => Entrada?.Qtd ?? 0;

        public int QtdSaida => Saida?.Qtd ?? 0;

        public int QtdDisponivel => QtdEntrada - QtdAssociada;

        public decimal ValorReal => Entrada?.ValorReal ?? 0;
    }
}