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
    
    public partial class WH_PRODUCT_MAST_DTL_DELETE
    {
        public int ROWID { get; set; }
        public int HD_ROWID { get; set; }
        public string PRODUCT_NO { get; set; }
        public string UNIT_NAME { get; set; }
        public float PACK_SIZE { get; set; }
        public decimal COST { get; set; }
        public Nullable<int> SELL_TYPE { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string USER_ID { get; set; }
        public Nullable<int> SKU_KEY { get; set; }
        public Nullable<System.DateTime> LAST_ACTION { get; set; }
        public System.DateTime DELETE_DATE { get; set; }
        public int DELETE_USER { get; set; }
    }
}
