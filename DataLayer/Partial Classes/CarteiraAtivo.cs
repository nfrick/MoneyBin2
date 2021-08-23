using System;

namespace DataLayer {
    public partial class CarteiraAtivo : Cotacao {

        public override string CCodigo => Codigo;

        public override DateTime? CData => Data;

        public override string ToString() => $"Carteira: {Carteira.Nome}  Código: {Codigo}";

    }
}
