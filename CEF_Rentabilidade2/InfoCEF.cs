using System.Text.RegularExpressions;

namespace Rentabilidades {
    public class InfoCEF : Info {
        private readonly Regex _regexData = new Regex(@"\d{2}\/\d{2}\/\d{4}");

        private static readonly char[] Seps = { ' ', '\t' };

        public InfoCEF(string linha) {
            var match = _regexData.Match(linha);
            if (!match.Success) {
                return;
            }

            Fundo = RemoveComments(linha.Substring(0, match.Index).Trim());
            var dados = linha.Substring(match.Index + 11).Trim().Split(Seps);
            ValorCota = ParseDecimal(dados, 1, 1);
            VariaçãoDia = ParseDecimal(dados, 2);
            AcumuladoMes = ParseDecimal(dados, 3);
            AcumuladoAno = ParseDecimal(dados, 4);
            Acumulado12M = ParseDecimal(dados, 5);
        }
    }
}
