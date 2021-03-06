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
    
    public partial class Conta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conta()
        {
            this.Balance = new ObservableListSource<BalanceItem>();
            this.Fundos = new ObservableListSource<ContaFundo>();
            this.LCAs = new ObservableListSource<LCA>();
            this.Acoes = new ObservableListSource<ContaAtivo>();
        }
    
        public int ID { get; set; }
        public string Dono { get; set; }
        public int BancoID { get; set; }
        public string Apelido { get; set; }
        public string Agencia { get; set; }
        public string AgenciaDV { get; set; }
        public string ContaCorrente { get; set; }
        public string ContaCorrenteDV { get; set; }
        public string Operacao { get; set; }
        public string Gerente { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string EMail { get; set; }
        public bool Ativa { get; set; }
    
        public virtual Banco Banco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<BalanceItem> Balance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ContaFundo> Fundos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<LCA> LCAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ContaAtivo> Acoes { get; set; }
    }
}
