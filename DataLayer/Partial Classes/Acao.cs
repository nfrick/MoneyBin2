using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataLayer {
    [NotMapped]
    public class Acao {
        public override string ToString() => $"{Codigo} - Qtd:{Qtd} - Preço:{UltimoPreco}";

        public static DbSet<AtivoUltimoPreco> Precos = null;

        public string Codigo { get; set; }

        public decimal UltimoPreco => Precos?.Find(Codigo)?.PrecoUltimo ?? 0;

        public ObservableListSource<Operacao> Operacoes { get; set; }

        public int Qtd => Operacoes.Sum(o => o.QtdComSinal);

        public decimal Total => Qtd * UltimoPreco;
    }
}