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
    
    public partial class ClassShift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassShift()
        {
            this.Days = new HashSet<Day>();
            this.Shifts = new HashSet<Shift>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Day> Days { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}