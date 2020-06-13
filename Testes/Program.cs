using DataLayer;
using System;
using System.Linq;

namespace Testes {
    class Program {
        static void Main(string[] args) {

            using (var ctx = new MoneyBinEntities()) {
                var conta = ctx.Contas.Find(1);
                var inicio = conta.Operacoes.Min(o => o.Data);

                var serie = ctx.SeriesHistoricas.ToList();

                var monthList = serie
                    .GroupBy(i => new { i.Data.Year, i.Data.Month })
                    .Select(g => new {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        LastDate = new DateTime(g.Key.Year, g.Key.Month, 1).AddMonths(1).AddDays(-1)
                    }).ToList();
            }

        }
    }
}
