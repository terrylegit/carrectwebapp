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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Carts = new HashSet<Cart>();
            this.ProductImages = new HashSet<ProductImage>();
            this.ProductOrderDetails = new HashSet<ProductOrderDetail>();
        }
    
        public int ID { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }
        public int Point { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string ProductCode { get; set; }
        public int Status { get; set; }
        public int BasePrice { get; set; }
        public string Description { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOrderDetail> ProductOrderDetails { get; set; }
    }
}
