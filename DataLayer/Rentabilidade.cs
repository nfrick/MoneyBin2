//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rentabilidade
    {
        public int ID { get; set; }
        public string Banco { get; set; }
        public string FundoNome { get; set; }
        public int FundoId { get; set; }
        public System.DateTime Mes { get; set; }
        public double RendDia { get; set; }
        public double RendMes { get; set; }
        public double RendAno { get; set; }
        public double Rend12Meses { get; set; }
        public double ValorCota { get; set; }
    
        public virtual Fundo Fundo { get; set; }
    }
}