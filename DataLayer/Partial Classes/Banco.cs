using System;

namespace DataLayer {
    public partial class Banco : ICloneable {

        public override string ToString() {
            return $"{Sigla} {Nome}";
        }

        private Banco _backup;
        public object Clone() {
            return this.MemberwiseClone();
        }

        public void SaveCopy() {
            _backup = (Banco)Clone();
        }
        
        public void Reset() {
            this.Nome = _backup.Nome;
            this.Sigla = _backup.Sigla;
            this.ExtensaoExtrato = _backup.ExtensaoExtrato;
            this.ExtensaoFundos = _backup.ExtensaoFundos;
        }
    }
}
