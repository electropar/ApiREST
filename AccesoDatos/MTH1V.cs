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
    
    public partial class MTH1V
    {
        public string MthAcctCod { get; set; }
        public string IsInternal { get; set; }
        public int MatchNum { get; set; }
        public int TransID { get; set; }
        public int Line_ID { get; set; }
        public Nullable<System.DateTime> RefDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3Line { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> SYSDeb { get; set; }
        public Nullable<decimal> SYSCred { get; set; }
        public Nullable<decimal> FCDebit { get; set; }
        public Nullable<decimal> FCCredit { get; set; }
        public string Currency { get; set; }
        public string LineMemo { get; set; }
    }
}
