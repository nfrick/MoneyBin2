using System;

namespace DataLayer {
    public partial class CalendarioMes {
        public short Mes12 => (short) (1 + (short)Math.Log(Mes, 2));
        public string MesAno => $"{Mes12:00}-{Ano}";
        public string AnoMes => $"{Ano:0000}-{Mes12:00}";

        public CalendarioMes() {
            Mes = (short)Math.Pow(2, DateTime.Today.Month - 1);
            Ano = (short)DateTime.Today.Year;
        }

        public CalendarioMes ProximoMes =>
            Mes12 == 12 ? new CalendarioMes { Mes = 1, Ano = (short) (Ano + 1) } :
                new CalendarioMes { Mes = (short) (Mes * 2), Ano = Ano };
    }
}
