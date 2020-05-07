using System;

namespace DataLayer {
    public partial class CalendarioItem {
        public override string ToString() => $"{Data:dd/MM/yy} {Descricao}";

        public int Dia => Pagamento?.Dia ?? 1;

        public int Month12 => 1 + (int)Math.Log(Mes, 2);

        public DateTime Data => new DateTime(Ano, Month12, Dia);

        //public string Descricao => $"{ToString().ToUpper()} - {Data:dd/MM/yyyy}";

        public string Descricao => $"{Pagamento}";
    }
}
