//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Virtual_Bank.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOGIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGIN()
        {
            this.CreditCard_Details = new HashSet<CreditCard_Details>();
            this.Payee_details = new HashSet<Payee_details>();
            this.Payee_details1 = new HashSet<Payee_details>();
            this.Trans_details = new HashSet<Trans_details>();
        }
    
        public string UserName { get; set; }
        public string Pasword { get; set; }
        public string Email_id { get; set; }
        public long Phone_no { get; set; }
        public Nullable<System.DateTime> D_O_B { get; set; }
        public string Type_Acc { get; set; }
        public Nullable<long> Amount { get; set; }
        public Nullable<System.DateTime> Opening_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCard_Details> CreditCard_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payee_details> Payee_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payee_details> Payee_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trans_details> Trans_details { get; set; }
    }
}
