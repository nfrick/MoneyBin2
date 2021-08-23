using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Rentabilidades {
    public abstract class Info {
        [DisplayName("Fundo")]
        [DataMember(Order = 0)]
        public string Fundo { get; set; }

        [DisplayName("Valor Cota")]
        [DataMember(Order = 8)]
        public decimal ValorCota { get; set; }

        [DisplayName("Var. Dia")]
        [DataMember(Order = 1)]
        public decimal VariaçãoDia { get; set; }

        [DisplayName("Mês")]
        [DataMember(Order = 2)]
        public decimal AcumuladoMes { get; set; }

        [DisplayName("Ano")]
        [DataMember(Order = 4)]
        public decimal AcumuladoAno { get; set; }

        [DisplayName("12 Meses")]
        [DataMember(Order = 5)]
        public decimal Acumulado12M { get; set; }

        public override string ToString() => $"{Fundo} - Dia: {VariaçãoDia}  Mês: {AcumuladoMes}  Ano: {AcumuladoAno}  12M: {Acumulado12M}";

        public static decimal ParseDecimal(IReadOnlyList<string> values, int pos, int adjust = 100) {
            return pos < values.Count ?
                !decimal.TryParse(values[pos], out var result) ? 0 : result / adjust : -1000;
        }

        public static DateTime ParseDate(IReadOnlyList<string> values, int pos) {
            return pos < values.Count ?
                !DateTime.TryParse(values[pos], out var result) ? DateTime.Today : result : DateTime.Today;
        }

        public static decimal ParsePercentage(IReadOnlyList<string> values, int pos) {
            return pos < values.Count ?
                !decimal.TryParse(values[pos].Replace("%", ""), out var result) ? 0 : result / 100 : 0;
        }

        public static string RemoveComments(string texto) {
            return Regex.Replace(texto, @" \(\d\)", "").Trim();
        }

        public PropertyInfo[] OrderedProperties =>
            (from property in GetType().GetProperties()
             where Attribute.IsDefined(property, typeof(DataMemberAttribute))
             orderby ((DataMemberAttribute)property
                 .GetCustomAttributes(typeof(DataMemberAttribute), false)
                 .Single()).Order
             select property).ToArray();

        public string[] ColumnHeaders => OrderedProperties
            .Select(c => (DisplayNameAttribute[])c.GetCustomAttributes(typeof(DisplayNameAttribute), false)).Select(h => h[0].DisplayName).ToArray();

        public Rentabilidade ToRentabilidade(string mes, string banco) {
            var ano = int.Parse(mes.Substring(0, 4));
            var mmes = int.Parse(mes.Substring(5, 2));
            return new Rentabilidade() {
                FundoNome = this.Fundo,
                Mes = new DateTime(ano, mmes, 1),
                Banco = banco,
                RendDia = (float)VariaçãoDia,
                RendMes = (float)AcumuladoMes,
                RendAno = (float)AcumuladoAno,
                Rend12Meses = (float)Acumulado12M,
                ValorCota = (float)ValorCota
            };
        }
    }
}
