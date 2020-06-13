using System.Linq;

namespace DataLayer {

    public partial class Entrada {
        public int QtdAssociada => Associacoes?.Sum(e => e.QtdAssociada) ?? 0;

        public int QtdDisponivel => Qtd - QtdAssociada;

        public bool Disponivel => QtdDisponivel > 0;
    }
}