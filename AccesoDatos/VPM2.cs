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
    
    public partial class VPM2
    {
        public int DocNum { get; set; }
        public int InvoiceId { get; set; }
        public Nullable<int> DocEntry { get; set; }
        public Nullable<decimal> SumApplied { get; set; }
        public Nullable<decimal> AppliedFC { get; set; }
        public Nullable<decimal> AppliedSys { get; set; }
        public string InvType { get; set; }
        public Nullable<decimal> DocRate { get; set; }
        public Nullable<int> Flags { get; set; }
        public string IntrsStat { get; set; }
        public Nullable<int> DocLine { get; set; }
        public Nullable<decimal> vatApplied { get; set; }
        public Nullable<decimal> vatAppldFC { get; set; }
        public Nullable<decimal> vatAppldSy { get; set; }
        public string selfInv { get; set; }
        public string ObjType { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public Nullable<decimal> Dcount { get; set; }
        public Nullable<decimal> DcntSum { get; set; }
        public Nullable<decimal> DcntSumFC { get; set; }
        public Nullable<decimal> DcntSumSy { get; set; }
        public Nullable<decimal> BfDcntSum { get; set; }
        public Nullable<decimal> BfDcntSumF { get; set; }
        public Nullable<decimal> BfDcntSumS { get; set; }
        public Nullable<decimal> BfNetDcnt { get; set; }
        public Nullable<decimal> BfNetDcntF { get; set; }
        public Nullable<decimal> BfNetDcntS { get; set; }
        public Nullable<decimal> PaidSum { get; set; }
        public Nullable<decimal> ExpAppld { get; set; }
        public Nullable<decimal> ExpAppldFC { get; set; }
        public Nullable<decimal> ExpAppldSC { get; set; }
        public Nullable<decimal> Rounddiff { get; set; }
        public Nullable<decimal> RounddifFc { get; set; }
        public Nullable<decimal> RounddifSc { get; set; }
        public Nullable<short> InstId { get; set; }
        public Nullable<decimal> WtAppld { get; set; }
        public Nullable<decimal> WtAppldFC { get; set; }
        public Nullable<decimal> WtAppldSC { get; set; }
        public Nullable<System.DateTime> LinkDate { get; set; }
        public Nullable<System.DateTime> AmtDifPst { get; set; }
        public string PaidDpm { get; set; }
        public string DpmPosted { get; set; }
        public Nullable<decimal> ExpVatSum { get; set; }
        public Nullable<decimal> ExpVatSumF { get; set; }
        public Nullable<decimal> ExpVatSumS { get; set; }
        public string IsRateDiff { get; set; }
        public Nullable<decimal> WtInvCatS { get; set; }
        public Nullable<decimal> WtInvCatSF { get; set; }
        public Nullable<decimal> WtInvCatSS { get; set; }
        public string OcrCode { get; set; }
        public Nullable<int> DocTransId { get; set; }
        public Nullable<int> MIEntry { get; set; }
        public string OcrCode2 { get; set; }
        public string OcrCode3 { get; set; }
        public string OcrCode4 { get; set; }
        public string OcrCode5 { get; set; }
        public string IsSelected { get; set; }
        public Nullable<decimal> WTOnHold { get; set; }
        public Nullable<decimal> WTOnhldPst { get; set; }
        public Nullable<int> baseAbs { get; set; }
        public string MIType { get; set; }
        public string DocSubType { get; set; }
        public string SpltPmtVAT { get; set; }
        public string EncryptIV { get; set; }
        public Nullable<decimal> U_RETENCION { get; set; }
        public string U_NroRet { get; set; }
        public Nullable<decimal> U_RetValorIva { get; set; }
        public string U_nrofactura { get; set; }
        public Nullable<decimal> U_porcretencion { get; set; }
        public Nullable<short> U_generado_ret { get; set; }
        public string U_aplica_cuota { get; set; }
        public Nullable<short> U_anulado { get; set; }
    }
}