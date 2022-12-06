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
    
    public partial class OTPI
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocType { get; set; }
        public string CANCELED { get; set; }
        public string HandWriten { get; set; }
        public string Printed { get; set; }
        public string Transfered { get; set; }
        public string ObjType { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string CardCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DocDueDate { get; set; }
        public int Series { get; set; }
        public Nullable<short> Segment { get; set; }
        public Nullable<int> CntctCode { get; set; }
        public Nullable<System.DateTime> VatDate { get; set; }
        public string Comments { get; set; }
        public Nullable<short> TrnspCode { get; set; }
        public string ShipToCode { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public string CurSource { get; set; }
        public string DocCur { get; set; }
        public Nullable<short> UserSign { get; set; }
        public Nullable<short> UserSign2 { get; set; }
        public string NumAtCard { get; set; }
        public string CardName { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<decimal> DocTotal { get; set; }
        public Nullable<decimal> VatSum { get; set; }
        public string PayRefNo { get; set; }
        public Nullable<System.DateTime> PayRefDate { get; set; }
        public string TaxMethod { get; set; }
        public Nullable<int> AtcEntry { get; set; }
        public string IsDpm { get; set; }
        public int AltRev { get; set; }
        public string PIndicator { get; set; }
        public Nullable<int> TransId { get; set; }
        public string JrnlMemo { get; set; }
        public Nullable<int> BPLId { get; set; }
        public string BPLName { get; set; }
        public string VATRegNum { get; set; }
        public string GovContrID { get; set; }
        public string DPPStatus { get; set; }
        public string EncryptIV { get; set; }
    }
}
