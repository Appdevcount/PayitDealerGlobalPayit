//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayitDealerGlobalPayit.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions_Log
    {
        public int Id { get; set; }
        public System.DateTime TransactionTime { get; set; }
        public int TransactionId { get; set; }
        public int TransactionStatus { get; set; }
        public string RequestMessage { get; set; }
        public string ResponseMessage { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
