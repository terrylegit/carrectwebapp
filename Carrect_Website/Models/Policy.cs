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
    
    public partial class Policy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Role { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public Nullable<int> Lang { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}