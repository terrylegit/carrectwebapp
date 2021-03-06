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
    
    public partial class CarModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarModel()
        {
            this.CarCustomers = new HashSet<CarCustomer>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> CarBrandID { get; set; }
        public Nullable<int> CarSegmentID { get; set; }
        public Nullable<int> Year { get; set; }
        public string Parth { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual CarBrand CarBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarCustomer> CarCustomers { get; set; }
        public virtual CarSegment CarSegment { get; set; }
    }
}
