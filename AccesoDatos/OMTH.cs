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
    
    public partial class OMTH
    {
        public string MthAcctCod { get; set; }
        public string IsInternal { get; set; }
        public int MatchNum { get; set; }
        public Nullable<decimal> Totals { get; set; }
        public string IsCard { get; set; }
        public string MatchType { get; set; }
        public Nullable<int> TransId { get; set; }
        public Nullable<System.DateTime> MatchDate { get; set; }
        public string CurrType { get; set; }
        public string DataSource { get; set; }
        public Nullable<short> UserSign { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
    }
}