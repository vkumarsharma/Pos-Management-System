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
    
    public partial class PosUsedPromotion
    {
        public int Id { get; set; }
        public bool Enable { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int FKPos { get; set; }
        public int FKPriceSchedule { get; set; }
        public int Qty { get; set; }
    
        public virtual PosHeader PosHeader { get; set; }
        public virtual PriceSchedule PriceSchedule { get; set; }
    }
}
