using System.Text.RegularExpressions;

namespace DataLayer {
    public partial class Fundo
    {
        public override string ToString() => Apelido ?? Nome;

        public string CNPJFormatado => Regex.Replace(CNPJ,
            "(.{2})(.{3})(.{3})(.{4})(.{2})", "$1.$2.$3/$4-$5");
    }
}
