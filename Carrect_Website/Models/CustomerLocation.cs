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
    
    public partial class CustomerLocation
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Longi { get; set; }
        public double Lati { get; set; }
        public string PlaceID { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}