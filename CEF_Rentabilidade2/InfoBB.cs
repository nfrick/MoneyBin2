using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rentabilidades {
    public class InfoBB : Info {
        [DisplayName("Mês Anterior")]
        [DataMember(Order = 3)]
        public decimal MesAnterior { get; set; }

        [DisplayName("Taxa Adm.")]
        [DataMember(Order = 6)]
        public decimal TaxaAdm { get; set; }

        [DisplayName("Data Cotação")]
        [DataMember(Order = 7)]
        public DateTime DataCotacao { get; set; }

        private static readonly char[] Seps = { '\t' };

        public InfoBB(string linha) {
            var dados = linha.Trim().Split(Seps);
            //Fundo	Dia	Acum. Mês	Dezembro	2021	12 Meses	24 Meses	36 Meses	PL Médio 12 meses	Taxa de Adm.(aa)	Data Cotação	Cota R$	Data Início R$
            Fundo = dados[0]; //RemoveComments(dados[0]);
            VariaçãoDia = ParseDecimal(dados, 1);
            AcumuladoMes = ParseDecimal(dados, 2);
            MesAnterior = ParseDecimal(dados, 3);
            AcumuladoAno = ParseDecimal(dados, 4);
            Acumulado12M = ParseDecimal(dados, 5);
            TaxaAdm = ParsePercentage(dados, 9);
            DataCotacao = ParseDate(dados, 10);
            ValorCota = ParseDecimal(dados, 11, 1);
        }
    }
}
