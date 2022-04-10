﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace CashTrack
{
    public class Transaction
    {
        private int isEnabled;
        private double value;
        private DateTime transactionDate;
        private string description;
        private int transactionCategoryID;
        private int transactionTypeID;
        private int companyID;
        private int clientID;

        public Transaction(double value, string description, int transactionCategoryID, int transactionTypeID, int companyID, int clientID)
        {
            isEnabled = 1;
            this.value = value;
            transactionDate = DateTime.Now;
            this.description = description;
            this.transactionCategoryID = transactionCategoryID;
            this.transactionTypeID = transactionTypeID;
            this.companyID = companyID;
            this.clientID = clientID;
        }
    }
}