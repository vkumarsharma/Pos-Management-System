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
    
    public partial class V_Stkmas
    {
        public int FKRowID { get; set; }
        public int FKProduct { get; set; }
        public int FKProductdetail { get; set; }
        public string Barcode { get; set; }
        public string ThaiName { get; set; }
        public string FKProductGroup { get; set; }
        public string Description { get; set; }
        public string FKUnit { get; set; }
        public decimal PackSize { get; set; }
        public decimal CostOnly { get; set; }
        public decimal SellPrice { get; set; }
        public decimal CostVat { get; set; }
    }
}
