//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pos_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class DebtorPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DebtorPayment()
        {
            this.DebtorPaymentDetails = new HashSet<DebtorPaymentDetails>();
        }
    
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public decimal TotalBalancePay { get; set; }
        public string DocNo { get; set; }
        public System.DateTime DocDate { get; set; }
        public string PaymenType { get; set; }
        public bool Enable { get; set; }
        public int Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebtorPaymentDetails> DebtorPaymentDetails { get; set; }
    }
}
