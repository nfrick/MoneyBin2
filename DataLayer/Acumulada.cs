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
    
    public partial class Acumulada
    {
        public int OperacaoId { get; set; }
        public Nullable<int> Qtd { get; set; }
    
        public virtual Operacao Operacao { get; set; }
    }
}
