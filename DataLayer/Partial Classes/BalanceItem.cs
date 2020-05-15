using System;
using System.Globalization;
using System.Xml.Linq;

namespace DataLayer {
    public partial class BalanceItem : IEquatable<BalanceItem> {
        public override string ToString() {
            return $"{Data:d}  {Historico}  {Valor:C2}";
        }

        private static readonly CultureInfo CultureUS = CultureInfo.CreateSpecificCulture("en-US");
        //private static readonly CultureInfo CultureBR = CultureInfo.CreateSpecificCulture("pt-BR");

        public bool AddToDB { get; set; }

        public string Banco => Conta.Banco.Sigla;
        public string BancoApelido => $"{Conta.Banco.Sigla} {Conta.Apelido}";
        public string ContaCorrente => Conta.ContaCorrente;
        public string ContaCorrenteDV => Conta.ContaCorrenteComDV;
        public string ContaCompleta => $"{Banco} {Conta.AgenciaComDV} {Conta.ContaCorrenteComDV}";
        public string ContaCompletaDV => $"{Banco} {Conta.AgenciaComDV} {Conta.ContaCorrenteComDV}";
        public decimal ValorParaSaldo => AfetaSaldo ? Valor : 0.0m;
        public int Sinal => Valor == 0 ? 0 : (int)(Valor / Math.Abs(Valor));

        #region IEquitable_implementation
        /// <summary>
        /// Compares two BalanceItems
        /// </summary>
        /// <param name="bi"></param>
        /// <returns></returns>
        public override bool Equals(object obj) {
            if (!(obj is BalanceItem)) {
                throw new ArgumentException("Object is not a BalanceItem");
            }
            var other = (BalanceItem)obj;
            return this.Equals(other);
        }

        public bool Equals(BalanceItem other) {
            if (other == null) {
                return false;
            }

            return //this.ContaID.Equals(other.ContaID) &&
                this.Data.Equals(other.Data) &&
                this.Valor.Equals(other.Valor) &&
                this.Historico.Equals(other.Historico) &&
                   (other.Documento == null ? 
                        (this.Documento == null || this.Documento.Equals("")) : 
                        this.Documento.Equals(other.Documento));
        }

        public override int GetHashCode() {
            return $"{Data}{Valor}{Historico}{Documento}".GetHashCode();
        }

        //public static bool operator ==(BalanceItem bi1, BalanceItem bi2) {
        //    if (object.ReferenceEquals(bi1, bi2)) {
        //        return true;
        //    }

        //    if (object.ReferenceEquals(bi1, null)) {
        //        return false;
        //    }

        //    return !object.ReferenceEquals(bi2, null) && bi1.Equals(bi2);
        //}

        //public static bool operator !=(BalanceItem bi1, BalanceItem bi2) {
        //    if (object.ReferenceEquals(bi1, bi2)) {
        //        return false;
        //    }

        //    if (object.ReferenceEquals(bi1, null)) {
        //        return true;
        //    }

        //    if (object.ReferenceEquals(bi2, null)) {
        //        return true;
        //    }

        //    return !bi1.Equals(bi2);
        //}

        public bool Similar(BalanceItem other) {
            if (other == null) {
                return false;
            }

            return this.Data.Equals(other.Data) &&
                   this.Valor.Equals(other.Valor) &&
                   (other.Documento == null ?
                       string.IsNullOrEmpty(this.Documento) :
                       this.Documento.Equals(other.Documento));
        }
        #endregion

        #region Exporters -----------------
        public static string CSVHeader =>
            "\"ID\",\"Conta\",,\"ContaID\"\"Data\",\"Historico\",\"Documento\",\"Valor\",\"AfetaSaldo\",\"Grupo\",\"Categoria\",\"SubCategoria\",\"Descricao\"";

        public string ToCSV =>
            $"\"{ID}\",,\"{Conta.Apelido}\"\"{ContaID}\",\"{Data:MM/dd/yyyy}\",\"{Historico}\",\"{Documento}\",\"{Valor.ToString("0.00", CultureUS)}\",\"{AfetaSaldo}\",\"{Grupo}\",\"{Categoria}\",\"{SubCategoria}\",\"{Descricao}\"";

        public XElement toXML() {
            return new XElement("BalanceItem",
                new XAttribute("ID", ID),
                new XElement("Conta", Conta.Apelido),
                new XElement("ContaID", ContaID),
                new XElement("Data", Data.ToString("MM/dd/yyyy")),
                new XElement("Historico", Historico),
                new XElement("Documento", Documento),
                new XElement("Valor", Valor.ToString("0.00", CultureUS)),
                new XElement("AfetaSaldo", AfetaSaldo),
                new XElement("Grupo", Grupo),
                new XElement("Categoria", Categoria),
                new XElement("SubCategoria", SubCategoria),
                new XElement("Descricao", Descricao)
            );
        }
        #endregion Exporters -----------------

    }
}
