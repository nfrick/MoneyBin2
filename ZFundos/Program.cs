using DataLayer;
using System;
using System.Linq;

namespace ZFundos {
    class Program {
        static void Main(string[] args) {

            using (var ctx = new MoneyBinEntities()) {

                foreach (var mes in ctx.FundosMeses) {
                    var rent = ctx.Rentabilidades
                        .FirstOrDefault(r => r.FundoId == mes.FundoId && r.Mes == mes.Mes);
                    if (rent != null) {
                        Console.WriteLine($"{mes.RendimentoMes} {rent.RendMes}");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
