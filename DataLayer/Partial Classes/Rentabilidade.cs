using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer {
    public partial class Rentabilidade {
        public override string ToString() => $"Fundo: {this.FundoId}  Mês: {Mes:MMM/yyyy}";
    }
}
