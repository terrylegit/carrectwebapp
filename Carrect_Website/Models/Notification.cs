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
    
    public partial class Notification
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> NewsID { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public int IsRead { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> OrderServiceID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string code { get; set; }
        public string Description { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual News News { get; set; }
        public virtual OrderService OrderService { get; set; }
        public virtual ProductOrder ProductOrder { get; set; }
    }
}
