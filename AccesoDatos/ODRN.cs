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
    
    public partial class ODRN
    {
        public int DocEntry { get; set; }
        public Nullable<int> DocNum { get; set; }
        public Nullable<int> Series { get; set; }
        public string DprArea { get; set; }
        public string Status { get; set; }
        public string Canceled { get; set; }
        public Nullable<System.DateTime> RefDate { get; set; }
        public string PeriodCat { get; set; }
        public Nullable<int> PostPeriod { get; set; }
        public Nullable<System.DateTime> KeyDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> NumOfJEs { get; set; }
        public Nullable<decimal> SumOfDpr { get; set; }
        public string SumByPro { get; set; }
        public string SumByDistr { get; set; }
        public string TransType { get; set; }
        public Nullable<int> TransAbs { get; set; }
    }
}
