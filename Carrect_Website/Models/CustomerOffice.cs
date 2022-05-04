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
    
    public partial class CustomerOffice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerOffice()
        {
            this.OrderServices = new HashSet<OrderService>();
        }
    
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string VAT { get; set; }
        public string Address { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string BankName { get; set; }
        public string Account { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderService> OrderServices { get; set; }
    }
}