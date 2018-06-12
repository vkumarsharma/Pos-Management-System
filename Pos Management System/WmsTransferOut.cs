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
    
    public partial class WmsTransferOut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WmsTransferOut()
        {
            this.WmsTransferOutDetails = new HashSet<WmsTransferOutDetails>();
        }
    
        public string Code { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int FK2Branch { get; set; }
        public decimal TotalQty { get; set; }
        public decimal TotalQtyUnit { get; set; }
        public decimal TotalUnVat { get; set; }
        public decimal TotalBeforeVat { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotalBalance { get; set; }
        public int FKEmployee { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WmsTransferOutDetails> WmsTransferOutDetails { get; set; }
    }
}