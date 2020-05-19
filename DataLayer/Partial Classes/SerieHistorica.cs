using System;
using System.Globalization;

namespace DataLayer {
    public partial class SerieHistorica : IEquatable<SerieHistorica> {

        public override string ToString() => $"{Codigo} {Data}";

        public SerieHistorica() {
        }

        public SerieHistorica(string linha) {
            Data = DateTime.ParseExact(linha.Substring(2, 8), "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None);
            Codigo = linha.Substring(12, 12).Trim();
            PrecoAbertura = Convert.ToDecimal(linha.Substring(56, 13)) / 100;
            PrecoMaximo = Convert.ToDecimal(linha.Substring(69, 13)) / 100;
            PrecoMinimo = Convert.ToDecimal(linha.Substring(82, 13)) / 100;
            PrecoMedio = Convert.ToDecimal(linha.Substring(95, 13)) / 100;
            PrecoUltimo = Convert.ToDecimal(linha.Substring(108, 13)) / 100;
            PrecoMelhorOfertaCompra = Convert.ToDecimal(linha.Substring(121, 13)) / 100;
            PrecoMelhorOfertaVenda = Convert.ToDecimal(linha.Substring(134, 13)) / 100;
        }

        public bool Equals(SerieHistorica other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }

            if (ReferenceEquals(this, other)) {
                return true;
            }

            return string.Equals(Codigo, other.Codigo) && Data.Equals(other.Data);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }

            if (ReferenceEquals(this, obj)) {
                return true;
            }

            return obj.GetType() == this.GetType() && Equals((SerieHistorica)obj);
        }

        public override int GetHashCode() {
            unchecked {
                return ((Codigo != null ? Codigo.GetHashCode() : 0) * 397) ^ Data.GetHashCode();
            }
        }
    }
}
