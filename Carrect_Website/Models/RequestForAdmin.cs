//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carrect_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestForAdmin
    {
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public string Note { get; set; }
        public int status { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual OrderService OrderService { get; set; }
    }
}
