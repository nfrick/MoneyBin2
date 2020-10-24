using Newtonsoft.Json;
using System.Globalization;
using System.Xml.Linq;

namespace DataLayer {
    public partial class Pesquisa {
        #region Exporters -----------------
        private static readonly CultureInfo CultureUS = CultureInfo.CreateSpecificCulture("en-US");

        public static string CSVHeader =>
            "\"ContaID\",\"Apelido\",\"ID\",\"Data\",\"Historico\",\"Documento\",\"Valor\",\"AfetaSaldo\",\"Grupo\",\"Categoria\",\"SubCategoria\",\"Descricao\"";

        [JsonIgnore]
        public string ToCSV =>
            $"\"{ContaID}\",\"{Apelido}\",\"{ID}\",\"{Data:MM/dd/yyyy}\",\"{Historico}\",\"{Documento}\",\"{Valor.ToString("0.00", CultureUS)}\",\"{AfetaSaldo}\",\"{Grupo}\",\"{Categoria}\",\"{SubCategoria}\",\"{Descricao}\"";

        public XElement toXML() {
            return new XElement("BalanceItem",
                new XElement("ContaID", ContaID),
                new XElement("Conta", Apelido),
                new XAttribute("ID", ID),
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
