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
    
    public partial class Complaint
    {
        public int ID { get; set; }
        public string TicketID { get; set; }
        public string ComplaintType { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public int CTypeID { get; set; }
        public string Username { get; set; }
        public string UEmail { get; set; }
        public string UMobNo { get; set; }
        public string StatusDesc { get; set; }
        public string Reason { get; set; }
        public string UserType { get; set; }
    
        public virtual ComplaintType ComplaintType1 { get; set; }
    }
}
