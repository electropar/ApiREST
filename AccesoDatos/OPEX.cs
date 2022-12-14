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
    
    public partial class OPEX
    {
        public int AbsEntry { get; set; }
        public Nullable<System.DateTime> PayRunDate { get; set; }
        public string VendorNum { get; set; }
        public string CustNum { get; set; }
        public string PaymMethod { get; set; }
        public Nullable<int> PaymDocNum { get; set; }
        public Nullable<System.DateTime> FiscalYear { get; set; }
        public string Country { get; set; }
        public string CompTaxNum { get; set; }
        public string PayeeName { get; set; }
        public string PayeeZip { get; set; }
        public string PayeeCity { get; set; }
        public string PayeeStree { get; set; }
        public string PayCountry { get; set; }
        public string PayeeState { get; set; }
        public string PayBnkName { get; set; }
        public string PayBankZip { get; set; }
        public string PayBnkCity { get; set; }
        public string PayBnkStr { get; set; }
        public string PayBnkCntr { get; set; }
        public string PayBankAct { get; set; }
        public string PayBnkCode { get; set; }
        public string PayBnkCtrl { get; set; }
        public string PayBnkSwif { get; set; }
        public string PayBnkIBAN { get; set; }
        public Nullable<System.DateTime> PymPostDat { get; set; }
        public string PymBnkAcct { get; set; }
        public string PymBnkCntr { get; set; }
        public string PymBnkCode { get; set; }
        public string PymBnkIBAN { get; set; }
        public string PymGLAcct { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> PymDocAmnt { get; set; }
        public string PymDocCurr { get; set; }
        public Nullable<decimal> PymDcAmtFC { get; set; }
        public Nullable<decimal> PymCshDsct { get; set; }
        public Nullable<decimal> PyCshDscFC { get; set; }
        public Nullable<int> PymNumOfPa { get; set; }
        public Nullable<decimal> PymDocRate { get; set; }
        public string Status { get; set; }
        public Nullable<int> PaymWizCod { get; set; }
        public string InstrucKey { get; set; }
        public string CllctAutho { get; set; }
        public string PayBnkPost { get; set; }
        public Nullable<int> PayBnkChNo { get; set; }
        public string PayBnkHsBk { get; set; }
        public string PayBnkBlck { get; set; }
        public string PayBnkCnty { get; set; }
        public string PayBnkStat { get; set; }
        public string PayBnkBISR { get; set; }
        public string PayBnkUsr1 { get; set; }
        public string PayBnkUsr2 { get; set; }
        public string PayBnkUsr3 { get; set; }
        public string PayBnkUsr4 { get; set; }
        public string PaymFormat { get; set; }
        public string CompName { get; set; }
        public string CompAddres { get; set; }
        public string CompISRBil { get; set; }
        public string VendISRBil { get; set; }
        public string AddIdNum { get; set; }
        public string CompOrgNum { get; set; }
        public string PayBnkBrnc { get; set; }
        public string PymBnkBrnc { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPortNo { get; set; }
        public string UserFax { get; set; }
        public Nullable<short> Department { get; set; }
        public string DebitMemo { get; set; }
        public string EuInTrnsfr { get; set; }
        public string FilePath { get; set; }
        public string OrderParty { get; set; }
        public string PymCtrlKey { get; set; }
        public string PayeeTaxNo { get; set; }
        public string PymKeyCode { get; set; }
        public string PayRefDtls { get; set; }
        public string FormatName { get; set; }
        public string CheckPmnt { get; set; }
        public string PymBnkUsr1 { get; set; }
        public string PymBnkUsr2 { get; set; }
        public string PymBnkUsr3 { get; set; }
        public string PymBnkUsr4 { get; set; }
        public string CompStreet { get; set; }
        public string CompBlock { get; set; }
        public string CompCity { get; set; }
        public string CompZip { get; set; }
        public string CompCounty { get; set; }
        public string CompState { get; set; }
        public string PymBCACode { get; set; }
        public string PaymDocTyp { get; set; }
        public Nullable<int> PayOrderNo { get; set; }
        public string FreeText1 { get; set; }
        public string FreeText2 { get; set; }
        public string FreeText3 { get; set; }
        public string PymBnkSwif { get; set; }
        public string PayBnkUIC { get; set; }
        public string LineType { get; set; }
        public Nullable<int> BoeKey { get; set; }
        public string BoeCurrSta { get; set; }
        public Nullable<System.DateTime> BoeDate { get; set; }
        public Nullable<System.DateTime> BoeDueDate { get; set; }
        public string Instruct1 { get; set; }
        public string Instruct2 { get; set; }
        public string BoeCancIns { get; set; }
        public string BoeOccCode { get; set; }
        public string BoePtfID { get; set; }
        public Nullable<int> BoeOurNum { get; set; }
        public Nullable<decimal> BoeIntrAm { get; set; }
        public Nullable<System.DateTime> BoeDiscD { get; set; }
        public Nullable<decimal> BoeDisAmnt { get; set; }
        public Nullable<System.DateTime> BoeFineD { get; set; }
        public Nullable<decimal> BoeFineAmt { get; set; }
        public Nullable<System.DateTime> BoeIntrstD { get; set; }
        public Nullable<decimal> BoeIOFAmt { get; set; }
        public string BoeMovCode { get; set; }
        public string BarcodeRep { get; set; }
        public Nullable<int> PONumber { get; set; }
        public Nullable<int> POSeries { get; set; }
        public string PaPriority { get; set; }
        public string PaymType { get; set; }
        public string RecipStatu { get; set; }
        public string BudegetId { get; set; }
        public string OKATO { get; set; }
        public string PymReason { get; set; }
        public string PostPeriod { get; set; }
        public string BaseDocTyp { get; set; }
        public Nullable<System.DateTime> BaseDocDat { get; set; }
        public string TaxPymType { get; set; }
        public string OKTMO { get; set; }
        public string SeqType { get; set; }
        public Nullable<System.DateTime> PymDate { get; set; }
        public string PymBnkName { get; set; }
        public string UIPCode { get; set; }
        public Nullable<short> UserId { get; set; }
        public string SpltPmtVAT { get; set; }
        public string EnBnkAct { get; set; }
        public string EnBnkIBan { get; set; }
        public string EncryptIV { get; set; }
        public string DPPStatus { get; set; }
    }
}
