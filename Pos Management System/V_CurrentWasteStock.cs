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
    
    public partial class V_CurrentWasteStock
    {
        public int FKProductDetails { get; set; }
        public Nullable<decimal> SumPiece { get; set; }
        public Nullable<decimal> SumPlus { get; set; }
        public decimal SumMinus { get; set; }
        public Nullable<decimal> Result { get; set; }
        public string Code { get; set; }
        public string ThaiName { get; set; }
        public string VendorCode { get; set; }
        public string Name { get; set; }
    }
}
