//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class MRV3
    {
        public int DocEntry { get; set; }
        public int BaseLine { get; set; }
        public int LineNum { get; set; }
        public string SNBNum { get; set; }
        public Nullable<System.DateTime> AdmisDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<decimal> CurrCost { get; set; }
        public Nullable<decimal> NewCost { get; set; }
        public Nullable<decimal> DebCred { get; set; }
        public Nullable<decimal> SNBOpenQty { get; set; }
        public Nullable<decimal> RToStock { get; set; }
        public Nullable<int> SnbSysNum { get; set; }
        public Nullable<int> SnbAbsEnt { get; set; }
        public Nullable<decimal> SnbQty { get; set; }
        public Nullable<decimal> SnbCostT { get; set; }
        public string SnbLotNum { get; set; }
        public string SnbMfn { get; set; }
    }
}