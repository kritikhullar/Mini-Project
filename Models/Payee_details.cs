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
    
    public partial class Payee_details
    {
        public int Payee_Id { get; set; }
        public Nullable<long> User_no { get; set; }
        public Nullable<long> Payee_no { get; set; }
        public string Payee_NickName { get; set; }
    
        public virtual LOGIN LOGIN { get; set; }
        public virtual LOGIN LOGIN1 { get; set; }
    }
}
