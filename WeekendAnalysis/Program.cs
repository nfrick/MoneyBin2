using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WeekendAnalysis {
    class Program {
        static void Main(string[] args) {

            using (var ctx = new MoneyBinEntities()) {
                var conta = ctx.Contas.First();
                var ativos = conta.AcoesNaoZerado;

                var termino = new DateTime(2020, 05, 25);

                foreach (var ativo in ativos) {
                    var sh = ativo.Ativo.SerieHistorica;
                    Console.WriteLine($"\n{ativo.Codigo}");
                    var data = new DateTime(2019, 01, 05);
                    while (data < termino) {
                        var antes = sh.TakeWhile(c => c.Data < data)
                            .TakeLast(2).ToArray();

                        var variacao = (antes[0].PrecoMedio - antes[1].PrecoMedio) / antes[0].PrecoMedio;

                        var depois = sh.First(c => c.Data > data);

                        Console.ForegroundColor = variacao > 0 ? ConsoleColor.White : ConsoleColor.Red;
                        Console.WriteLine($"\t{data:d}\t{antes[0].PrecoMedio:N2}\t{antes[1].PrecoMedio:N2}\t{variacao:P1}\t{depois.PrecoMedio:N2}");

                        data = data.AddDays(7);
                    }
                }
                Console.ReadLine();
            }
        }
    }

    public static class MiscExtensions {
        // Ex: collection.TakeLast(5);
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int N) {
            return source.Skip(Math.Max(0, source.Count() - N));
        }
    }
}
