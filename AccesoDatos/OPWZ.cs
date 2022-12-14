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
    
    public partial class OPWZ
    {
        public int IdNumber { get; set; }
        public Nullable<System.DateTime> PmntDate { get; set; }
        public Nullable<System.DateTime> NextDate { get; set; }
        public string OutgoType { get; set; }
        public string IncomType { get; set; }
        public string CheckPmntM { get; set; }
        public string BnkTrnsPmM { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> PostDtFrom { get; set; }
        public Nullable<System.DateTime> PostDtTo { get; set; }
        public Nullable<System.DateTime> ValDteFrom { get; set; }
        public Nullable<System.DateTime> ValDateTo { get; set; }
        public Nullable<decimal> ApInvAmntF { get; set; }
        public Nullable<decimal> ApInvAmntT { get; set; }
        public Nullable<int> PchNoFrom { get; set; }
        public Nullable<int> PchNoTo { get; set; }
        public Nullable<int> InvNoFrom { get; set; }
        public Nullable<int> InvNoTo { get; set; }
        public Nullable<int> SelPriorit { get; set; }
        public string Status { get; set; }
        public string WizardName { get; set; }
        public string StatusDisc { get; set; }
        public string Canceled { get; set; }
        public string BoePmnMn { get; set; }
        public Nullable<int> SeriesOut { get; set; }
        public Nullable<int> SeriesIn { get; set; }
        public Nullable<decimal> TotalOut { get; set; }
        public Nullable<decimal> TotalIn { get; set; }
        public string ViewIntBal { get; set; }
        public string SelMthd { get; set; }
        public Nullable<int> MINumFrom { get; set; }
        public Nullable<int> MINumTo { get; set; }
        public Nullable<System.DateTime> MIDateFrom { get; set; }
        public Nullable<System.DateTime> MIDateTo { get; set; }
        public Nullable<int> MIVNumFrom { get; set; }
        public Nullable<int> MIVNumTo { get; set; }
        public Nullable<System.DateTime> MIVDateFro { get; set; }
        public Nullable<System.DateTime> MIVDateTo { get; set; }
        public Nullable<System.DateTime> APDocDtFrm { get; set; }
        public Nullable<System.DateTime> APDocDtTo { get; set; }
        public Nullable<System.DateTime> APDueDtFrm { get; set; }
        public Nullable<System.DateTime> NxtPmntDat { get; set; }
        public Nullable<decimal> MinPayAR { get; set; }
        public Nullable<decimal> MinPayAP { get; set; }
        public string ShowAtCard { get; set; }
        public Nullable<short> TolerDays { get; set; }
        public Nullable<decimal> MinCashDis { get; set; }
        public string NegBalBP { get; set; }
        public string ManualJE { get; set; }
        public string NegTrans { get; set; }
        public string CDTransApp { get; set; }
        public Nullable<short> UserSign { get; set; }
        public Nullable<int> CigTo { get; set; }
        public Nullable<int> CupFrom { get; set; }
        public Nullable<int> CupTo { get; set; }
        public Nullable<int> CigFrom { get; set; }
        public Nullable<int> BPLId { get; set; }
        public Nullable<System.DateTime> BoeDDFrom { get; set; }
        public Nullable<System.DateTime> BoeDDTo { get; set; }
        public Nullable<int> BoeNumFrom { get; set; }
        public Nullable<int> BoeNumTo { get; set; }
        public string BoeStatus { get; set; }
        public string HaExistBoe { get; set; }
        public Nullable<int> SeriesPOO { get; set; }
        public Nullable<int> SeriesPOI { get; set; }
        public string SeqType { get; set; }
        public string PayDueDate { get; set; }
        public string CentrPay { get; set; }
        public Nullable<int> BA_AP_From { get; set; }
        public Nullable<int> BA_AP_To { get; set; }
        public Nullable<int> BA_AR_From { get; set; }
        public Nullable<int> BA_AR_To { get; set; }
        public Nullable<int> JobId { get; set; }
        public string ZeroBalBP { get; set; }
        public string ZeroBalDoc { get; set; }
    }
}
