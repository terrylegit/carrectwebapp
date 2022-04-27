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
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.BankMembers = new HashSet<BankMember>();
            this.BankMembers1 = new HashSet<BankMember>();
            this.BankMembers2 = new HashSet<BankMember>();
            this.DeviceHistoryLogins = new HashSet<DeviceHistoryLogin>();
            this.MembersTransactionHistories = new HashSet<MembersTransactionHistory>();
            this.Notifications = new HashSet<Notification>();
            this.Wallets = new HashSet<Wallet>();
            this.RequestForAdmins = new HashSet<RequestForAdmin>();
        }
    
        public int ID { get; set; }
        public Nullable<int> AgentID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DeviceID { get; set; }
        public string Token { get; set; }
        public string ConfirmCode { get; set; }
        public int IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> IsLogin { get; set; }
        public Nullable<System.DateTime> ExpriceDateOTP { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> QtyOTP { get; set; }
        public Nullable<System.DateTime> OTPDateTime { get; set; }
        public string Lang { get; set; }
    
        public virtual Agent Agent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankMember> BankMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankMember> BankMembers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankMember> BankMembers2 { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceHistoryLogin> DeviceHistoryLogins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembersTransactionHistory> MembersTransactionHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wallet> Wallets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForAdmin> RequestForAdmins { get; set; }
    }
}
