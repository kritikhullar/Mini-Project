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
    
    public partial class CreditCard_Details
    {
        public int Userid { get; set; }
        public Nullable<long> User_ph_no { get; set; }
        public string CC_No { get; set; }
        public Nullable<long> Limit { get; set; }
        public Nullable<int> CVV { get; set; }
        public Nullable<int> EXP_dateyear { get; set; }
    
        public virtual LOGIN LOGIN { get; set; }
    }
}
