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
    
    public partial class OIRR
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public Nullable<int> Series { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string DocStatus { get; set; }
        public string RefNo { get; set; }
        public Nullable<int> RefEntry { get; set; }
        public Nullable<System.DateTime> RefDocDate { get; set; }
        public Nullable<int> TransId { get; set; }
        public string Comments { get; set; }
        public string ObjType { get; set; }
        public Nullable<int> SrcLoc { get; set; }
        public string SrcLocName { get; set; }
        public string SrcGSTIN { get; set; }
        public Nullable<int> TarLoc { get; set; }
        public string TarLocName { get; set; }
        public string TarGSTIN { get; set; }
        public string DataSource { get; set; }
        public Nullable<short> UserSign { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<short> UserSign2 { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string JrnlMemo { get; set; }
        public string Handwrtten { get; set; }
        public string PIndicator { get; set; }
        public Nullable<int> BPLId { get; set; }
        public string BPLName { get; set; }
        public string VATRegNum { get; set; }
    }
}
