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
    
    public partial class OSLD
    {
        public int AbsEntry { get; set; }
        public string ObjType { get; set; }
        public int DocEntry { get; set; }
        public int DocLineNum { get; set; }
        public int SchdLine { get; set; }
        public string ItemCode { get; set; }
        public string WhsCode { get; set; }
        public Nullable<System.DateTime> CfmDate { get; set; }
        public Nullable<decimal> CfmQty { get; set; }
        public string FixedCfm { get; set; }
        public Nullable<decimal> ReqQty { get; set; }
    }
}
