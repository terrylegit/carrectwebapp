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
    
    public partial class ServiceRequiteImage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceRequiteImage()
        {
            this.OrderServiceImages = new HashSet<OrderServiceImage>();
        }
    
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public string Content { get; set; }
        public Nullable<int> OrderDisplay { get; set; }
        public Nullable<int> TypeImage { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderServiceImage> OrderServiceImages { get; set; }
        public virtual Service Service { get; set; }
    }
}