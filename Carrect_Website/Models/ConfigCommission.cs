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
    
    public partial class ConfigCommission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConfigCommission()
        {
            this.Agents = new HashSet<Agent>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string CarAutocareAcaDemy { get; set; }
        public string Duration { get; set; }
        public string Process { get; set; }
        public Nullable<int> MastersBenefit { get; set; }
        public int IsActive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agent> Agents { get; set; }
    }
}
