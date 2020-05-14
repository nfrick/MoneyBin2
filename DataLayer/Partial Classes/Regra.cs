using System.Text.RegularExpressions;

namespace DataLayer {
    public partial class Regra {
        private string[] _categoria;
        private int _subCatLength;
        private int _descricaoLength;
        private bool _regraNumerica;
        private Regex _regex;
        private decimal _valor;

        public override string ToString() => Texto;

        public void Initialize() {
            _categoria = Categoria?.Split('/');
            int.TryParse(SubCategoria, out _subCatLength);
            int.TryParse(Descricao, out _descricaoLength);
            _regraNumerica = decimal.TryParse(Texto, out _valor);
            _regex = new Regex(Texto);
        }

        public bool Matches(BalanceItem bal) {
            return _regraNumerica ? bal.Valor == _valor : _regex.IsMatch(bal.Historico);
        }

        public bool MatchAndUpdate(BalanceItem bal) {
            if (!Matches(bal)) {
                return false;
            }

            bal.Grupo = Grupo;
            bal.Categoria = _categoria == null
                ? null
                : (_categoria.Length == 1 ? _categoria[0] : (bal.Valor > 0 ? _categoria[0] : _categoria[1]));
            bal.SubCategoria = SubCategoria == "[All]"
                ? bal.Historico
                : (_subCatLength == 0
                    ? SubCategoria
                    : bal.Historico.Substring(Texto.Length, _subCatLength).Trim());
            bal.Descricao = _descricaoLength == 0
                ? Descricao
                : bal.Historico.Substring(Texto.Length + _subCatLength, _descricaoLength).Trim();
            bal.AddToDB = AddToDatabase;
            bal.AfetaSaldo = AfetaSaldo;
            return true;
        }
    }
}
