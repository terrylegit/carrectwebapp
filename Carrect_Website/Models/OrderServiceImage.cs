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
    
    public partial class OrderServiceImage
    {
        public int ID { get; set; }
        public int OrderServiceID { get; set; }
        public Nullable<int> ServiceRequiteImageID { get; set; }
        public int TypeImage { get; set; }
        public string Content { get; set; }
        public int OrderDisplay { get; set; }
        public string Path { get; set; }
        public int IsActive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual OrderService OrderService { get; set; }
        public virtual ServiceRequiteImage ServiceRequiteImage { get; set; }
    }
}
