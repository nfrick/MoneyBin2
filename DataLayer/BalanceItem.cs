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
    
    public partial class BalanceItem
    {
        public int ID { get; set; }
        public int ContaID { get; set; }
        public System.DateTime Data { get; set; }
        public string Historico { get; set; }
        public string Documento { get; set; }
        public decimal Valor { get; set; }
        public bool AfetaSaldo { get; set; }
        public string Grupo { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Saldo { get; set; }
    
        public virtual Conta Conta { get; set; }
    }
}
