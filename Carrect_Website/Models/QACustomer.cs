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
    
    public partial class QACustomer
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Nullable<int> OrderDisplay { get; set; }
        public Nullable<int> Type { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
