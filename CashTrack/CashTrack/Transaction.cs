//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CashTrack
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int id { get; set; }
        public short isEnabled { get; set; }
        public double value { get; set; }
        public System.DateTime transactionDate { get; set; }
        public string description { get; set; }
        public int transactionCategoryID { get; set; }
        public int transactionTypeID { get; set; }
        public int companyID { get; set; }
        public int clientID { get; set; }
    
        public virtual TransactionCategory TransactionCategory { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual Company Company { get; set; }
        public virtual Client Client { get; set; }
    }
}
