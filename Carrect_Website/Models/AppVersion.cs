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
    
    public partial class AppVersion
    {
        public int ID { get; set; }
        public string VersionApp { get; set; }
        public Nullable<int> TypeOS { get; set; }
        public string CodePushVersion { get; set; }
        public Nullable<int> Is_Force_Update { get; set; }
        public string Note { get; set; }
    }
}
