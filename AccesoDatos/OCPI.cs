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
    
    public partial class OCPI
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocType { get; set; }
        public string CANCELED { get; set; }
        public string Handwrtten { get; set; }
        public string Printed { get; set; }
        public string DocStatus { get; set; }
        public string InvntSttus { get; set; }
        public string Transfered { get; set; }
        public string ObjType { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<System.DateTime> DocDueDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Address { get; set; }
        public string NumAtCard { get; set; }
        public Nullable<decimal> VatPercent { get; set; }
        public Nullable<decimal> VatSum { get; set; }
        public Nullable<decimal> VatSumFC { get; set; }
        public Nullable<decimal> DiscPrcnt { get; set; }
        public Nullable<decimal> DiscSum { get; set; }
        public Nullable<decimal> DiscSumFC { get; set; }
        public string DocCur { get; set; }
        public Nullable<decimal> DocRate { get; set; }
        public Nullable<decimal> DocTotal { get; set; }
        public Nullable<decimal> DocTotalFC { get; set; }
        public Nullable<decimal> PaidToDate { get; set; }
        public Nullable<decimal> PaidFC { get; set; }
        public Nullable<decimal> GrosProfit { get; set; }
        public Nullable<decimal> GrosProfFC { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Comments { get; set; }
        public string JrnlMemo { get; set; }
        public Nullable<int> TransId { get; set; }
        public Nullable<int> ReceiptNum { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public Nullable<short> DocTime { get; set; }
        public Nullable<int> SlpCode { get; set; }
        public Nullable<short> TrnspCode { get; set; }
        public string PartSupply { get; set; }
        public string Confirmed { get; set; }
        public Nullable<short> GrossBase { get; set; }
        public Nullable<int> ImportEnt { get; set; }
        public string CreateTran { get; set; }
        public string SummryType { get; set; }
        public string UpdInvnt { get; set; }
        public string UpdCardBal { get; set; }
        public short Instance { get; set; }
        public Nullable<int> Flags { get; set; }
        public string InvntDirec { get; set; }
        public Nullable<int> CntctCode { get; set; }
        public string ShowSCN { get; set; }
        public string FatherCard { get; set; }
        public Nullable<decimal> SysRate { get; set; }
        public string CurSource { get; set; }
        public Nullable<decimal> VatSumSy { get; set; }
        public Nullable<decimal> DiscSumSy { get; set; }
        public Nullable<decimal> DocTotalSy { get; set; }
        public Nullable<decimal> PaidSys { get; set; }
        public string FatherType { get; set; }
        public Nullable<decimal> GrosProfSy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string IsICT { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<short> VolUnit { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<short> WeightUnit { get; set; }
        public Nullable<int> Series { get; set; }
        public Nullable<System.DateTime> TaxDate { get; set; }
        public string Filler { get; set; }
        public string DataSource { get; set; }
        public string StampNum { get; set; }
        public string isCrin { get; set; }
        public Nullable<int> FinncPriod { get; set; }
        public Nullable<short> UserSign { get; set; }
        public string selfInv { get; set; }
        public Nullable<decimal> VatPaid { get; set; }
        public Nullable<decimal> VatPaidFC { get; set; }
        public Nullable<decimal> VatPaidSys { get; set; }
        public Nullable<short> UserSign2 { get; set; }
        public string WddStatus { get; set; }
        public Nullable<int> draftKey { get; set; }
        public Nullable<decimal> TotalExpns { get; set; }
        public Nullable<decimal> TotalExpFC { get; set; }
        public Nullable<decimal> TotalExpSC { get; set; }
        public Nullable<int> DunnLevel { get; set; }
        public string Address2 { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public string Exported { get; set; }
        public Nullable<int> StationID { get; set; }
        public string Indicator { get; set; }
        public string NetProc { get; set; }
        public Nullable<decimal> AqcsTax { get; set; }
        public Nullable<decimal> AqcsTaxFC { get; set; }
        public Nullable<decimal> AqcsTaxSC { get; set; }
        public Nullable<decimal> CashDiscPr { get; set; }
        public Nullable<decimal> CashDiscnt { get; set; }
        public Nullable<decimal> CashDiscFC { get; set; }
        public Nullable<decimal> CashDiscSC { get; set; }
        public string ShipToCode { get; set; }
        public string LicTradNum { get; set; }
        public string PaymentRef { get; set; }
        public Nullable<decimal> WTSum { get; set; }
        public Nullable<decimal> WTSumFC { get; set; }
        public Nullable<decimal> WTSumSC { get; set; }
        public Nullable<decimal> RoundDif { get; set; }
        public Nullable<decimal> RoundDifFC { get; set; }
        public Nullable<decimal> RoundDifSy { get; set; }
        public string CheckDigit { get; set; }
        public Nullable<int> Form1099 { get; set; }
        public string Box1099 { get; set; }
        public string submitted { get; set; }
        public string PoPrss { get; set; }
        public string Rounding { get; set; }
        public string RevisionPo { get; set; }
        public short Segment { get; set; }
        public Nullable<System.DateTime> ReqDate { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string PickStatus { get; set; }
        public string Pick { get; set; }
        public string BlockDunn { get; set; }
        public string PeyMethod { get; set; }
        public string PayBlock { get; set; }
        public Nullable<int> PayBlckRef { get; set; }
        public string MaxDscn { get; set; }
        public string Reserve { get; set; }
        public Nullable<decimal> Max1099 { get; set; }
        public string CntrlBnk { get; set; }
        public string PickRmrk { get; set; }
        public string ISRCodLine { get; set; }
        public Nullable<decimal> ExpAppl { get; set; }
        public Nullable<decimal> ExpApplFC { get; set; }
        public Nullable<decimal> ExpApplSC { get; set; }
        public string Project { get; set; }
        public string DeferrTax { get; set; }
        public string LetterNum { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<decimal> WTApplied { get; set; }
        public Nullable<decimal> WTAppliedF { get; set; }
        public string BoeReserev { get; set; }
        public string AgentCode { get; set; }
        public Nullable<decimal> WTAppliedS { get; set; }
        public Nullable<decimal> EquVatSum { get; set; }
        public Nullable<decimal> EquVatSumF { get; set; }
        public Nullable<decimal> EquVatSumS { get; set; }
        public Nullable<short> Installmnt { get; set; }
        public string VATFirst { get; set; }
        public Nullable<decimal> NnSbAmnt { get; set; }
        public Nullable<decimal> NnSbAmntSC { get; set; }
        public Nullable<decimal> NbSbAmntFC { get; set; }
        public Nullable<decimal> ExepAmnt { get; set; }
        public Nullable<decimal> ExepAmntSC { get; set; }
        public Nullable<decimal> ExepAmntFC { get; set; }
        public Nullable<System.DateTime> VatDate { get; set; }
        public string CorrExt { get; set; }
        public Nullable<int> CorrInv { get; set; }
        public Nullable<int> NCorrInv { get; set; }
        public string CEECFlag { get; set; }
        public Nullable<decimal> BaseAmnt { get; set; }
        public Nullable<decimal> BaseAmntSC { get; set; }
        public Nullable<decimal> BaseAmntFC { get; set; }
        public string CtlAccount { get; set; }
        public Nullable<int> BPLId { get; set; }
        public string BPLName { get; set; }
        public string VATRegNum { get; set; }
        public string TxInvRptNo { get; set; }
        public Nullable<System.DateTime> TxInvRptDt { get; set; }
        public string KVVATCode { get; set; }
        public string WTDetails { get; set; }
        public Nullable<int> SumAbsId { get; set; }
        public Nullable<System.DateTime> SumRptDate { get; set; }
        public string PIndicator { get; set; }
        public string ManualNum { get; set; }
        public string UseShpdGd { get; set; }
        public Nullable<decimal> BaseVtAt { get; set; }
        public Nullable<decimal> BaseVtAtSC { get; set; }
        public Nullable<decimal> BaseVtAtFC { get; set; }
        public Nullable<decimal> NnSbVAt { get; set; }
        public Nullable<decimal> NnSbVAtSC { get; set; }
        public Nullable<decimal> NbSbVAtFC { get; set; }
        public Nullable<decimal> ExptVAt { get; set; }
        public Nullable<decimal> ExptVAtSC { get; set; }
        public Nullable<decimal> ExptVAtFC { get; set; }
        public Nullable<decimal> LYPmtAt { get; set; }
        public Nullable<decimal> LYPmtAtSC { get; set; }
        public Nullable<decimal> LYPmtAtFC { get; set; }
        public Nullable<decimal> ExpAnSum { get; set; }
        public Nullable<decimal> ExpAnSys { get; set; }
        public Nullable<decimal> ExpAnFrgn { get; set; }
        public string DocSubType { get; set; }
        public string DpmStatus { get; set; }
        public Nullable<decimal> DpmAmnt { get; set; }
        public Nullable<decimal> DpmAmntSC { get; set; }
        public Nullable<decimal> DpmAmntFC { get; set; }
        public string DpmDrawn { get; set; }
        public Nullable<decimal> DpmPrcnt { get; set; }
        public Nullable<decimal> PaidSum { get; set; }
        public Nullable<decimal> PaidSumFc { get; set; }
        public Nullable<decimal> PaidSumSc { get; set; }
        public string FolioPref { get; set; }
        public Nullable<int> FolioNum { get; set; }
        public Nullable<decimal> DpmAppl { get; set; }
        public Nullable<decimal> DpmApplFc { get; set; }
        public Nullable<decimal> DpmApplSc { get; set; }
        public Nullable<int> LPgFolioN { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Posted { get; set; }
        public Nullable<int> OwnerCode { get; set; }
        public string BPChCode { get; set; }
        public Nullable<int> BPChCntc { get; set; }
        public string PayToCode { get; set; }
        public string IsPaytoBnk { get; set; }
        public string BnkCntry { get; set; }
        public string BankCode { get; set; }
        public string BnkAccount { get; set; }
        public string BnkBranch { get; set; }
        public string isIns { get; set; }
        public string TrackNo { get; set; }
        public string VersionNum { get; set; }
        public Nullable<int> LangCode { get; set; }
        public string BPNameOW { get; set; }
        public string BillToOW { get; set; }
        public string ShipToOW { get; set; }
        public string RetInvoice { get; set; }
        public Nullable<System.DateTime> ClsDate { get; set; }
        public Nullable<int> MInvNum { get; set; }
        public Nullable<System.DateTime> MInvDate { get; set; }
        public Nullable<short> SeqCode { get; set; }
        public Nullable<int> Serial { get; set; }
        public string SeriesStr { get; set; }
        public string SubStr { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> TaxOnExp { get; set; }
        public Nullable<decimal> TaxOnExpFc { get; set; }
        public Nullable<decimal> TaxOnExpSc { get; set; }
        public Nullable<decimal> TaxOnExAp { get; set; }
        public Nullable<decimal> TaxOnExApF { get; set; }
        public Nullable<decimal> TaxOnExApS { get; set; }
        public string LastPmnTyp { get; set; }
        public Nullable<int> LndCstNum { get; set; }
        public string UseCorrVat { get; set; }
        public string BlkCredMmo { get; set; }
        public string OpenForLaC { get; set; }
        public string Excised { get; set; }
        public Nullable<System.DateTime> ExcRefDate { get; set; }
        public string ExcRmvTime { get; set; }
        public Nullable<decimal> SrvGpPrcnt { get; set; }
        public Nullable<int> DepositNum { get; set; }
        public string CertNum { get; set; }
        public string DutyStatus { get; set; }
        public string AutoCrtFlw { get; set; }
        public Nullable<System.DateTime> FlwRefDate { get; set; }
        public string FlwRefNum { get; set; }
        public Nullable<int> VatJENum { get; set; }
        public Nullable<decimal> DpmVat { get; set; }
        public Nullable<decimal> DpmVatFc { get; set; }
        public Nullable<decimal> DpmVatSc { get; set; }
        public Nullable<decimal> DpmAppVat { get; set; }
        public Nullable<decimal> DpmAppVatF { get; set; }
        public Nullable<decimal> DpmAppVatS { get; set; }
        public string InsurOp347 { get; set; }
        public string IgnRelDoc { get; set; }
        public string BuildDesc { get; set; }
        public string ResidenNum { get; set; }
        public Nullable<int> Checker { get; set; }
        public Nullable<int> Payee { get; set; }
        public Nullable<int> CopyNumber { get; set; }
        public string SSIExmpt { get; set; }
        public Nullable<int> PQTGrpSer { get; set; }
        public Nullable<int> PQTGrpNum { get; set; }
        public string PQTGrpHW { get; set; }
        public string ReopOriDoc { get; set; }
        public string ReopManCls { get; set; }
        public string DocManClsd { get; set; }
        public Nullable<short> ClosingOpt { get; set; }
        public Nullable<System.DateTime> SpecDate { get; set; }
        public string Ordered { get; set; }
        public string NTSApprov { get; set; }
        public Nullable<short> NTSWebSite { get; set; }
        public string NTSeTaxNo { get; set; }
        public string NTSApprNo { get; set; }
        public string PayDuMonth { get; set; }
        public Nullable<short> ExtraMonth { get; set; }
        public Nullable<short> ExtraDays { get; set; }
        public Nullable<short> CdcOffset { get; set; }
        public string SignMsg { get; set; }
        public string SignDigest { get; set; }
        public string CertifNum { get; set; }
        public Nullable<int> KeyVersion { get; set; }
        public string EDocGenTyp { get; set; }
        public Nullable<short> ESeries { get; set; }
        public string EDocNum { get; set; }
        public Nullable<int> EDocExpFrm { get; set; }
        public string OnlineQuo { get; set; }
        public string POSEqNum { get; set; }
        public string POSManufSN { get; set; }
        public Nullable<int> POSCashN { get; set; }
        public string EDocStatus { get; set; }
        public string EDocCntnt { get; set; }
        public string EDocProces { get; set; }
        public string EDocErrCod { get; set; }
        public string EDocErrMsg { get; set; }
        public string EDocCancel { get; set; }
        public string EDocTest { get; set; }
        public string EDocPrefix { get; set; }
        public Nullable<int> CUP { get; set; }
        public Nullable<int> CIG { get; set; }
        public string DpmAsDscnt { get; set; }
        public string Attachment { get; set; }
        public Nullable<int> AtcEntry { get; set; }
        public string SupplCode { get; set; }
        public string GTSRlvnt { get; set; }
        public Nullable<decimal> BaseDisc { get; set; }
        public Nullable<decimal> BaseDiscSc { get; set; }
        public Nullable<decimal> BaseDiscFc { get; set; }
        public Nullable<decimal> BaseDiscPr { get; set; }
        public Nullable<int> CreateTS { get; set; }
        public Nullable<int> UpdateTS { get; set; }
        public string SrvTaxRule { get; set; }
        public Nullable<int> AnnInvDecR { get; set; }
        public string Supplier { get; set; }
        public Nullable<int> Releaser { get; set; }
        public Nullable<int> Receiver { get; set; }
        public string ToWhsCode { get; set; }
        public Nullable<System.DateTime> AssetDate { get; set; }
        public string Requester { get; set; }
        public string ReqName { get; set; }
        public Nullable<short> Branch { get; set; }
        public Nullable<short> Department { get; set; }
        public string Email { get; set; }
        public string Notify { get; set; }
        public Nullable<int> ReqType { get; set; }
        public string OriginType { get; set; }
        public string IsReuseNum { get; set; }
        public string IsReuseNFN { get; set; }
        public string DocDlvry { get; set; }
        public Nullable<decimal> PaidDpm { get; set; }
        public Nullable<decimal> PaidDpmF { get; set; }
        public Nullable<decimal> PaidDpmS { get; set; }
        public Nullable<int> EnvTypeNFe { get; set; }
        public Nullable<int> AgrNo { get; set; }
        public string IsAlt { get; set; }
        public Nullable<int> AltBaseTyp { get; set; }
        public Nullable<int> AltBaseEnt { get; set; }
        public string AuthCode { get; set; }
        public Nullable<System.DateTime> StDlvDate { get; set; }
        public Nullable<int> StDlvTime { get; set; }
        public Nullable<System.DateTime> EndDlvDate { get; set; }
        public Nullable<int> EndDlvTime { get; set; }
        public string VclPlate { get; set; }
        public string ElCoStatus { get; set; }
        public string AtDocType { get; set; }
        public string ElCoMsg { get; set; }
        public string PrintSEPA { get; set; }
        public Nullable<decimal> FreeChrg { get; set; }
        public Nullable<decimal> FreeChrgFC { get; set; }
        public Nullable<decimal> FreeChrgSC { get; set; }
        public Nullable<decimal> NfeValue { get; set; }
        public string FiscDocNum { get; set; }
        public Nullable<int> RelatedTyp { get; set; }
        public Nullable<int> RelatedEnt { get; set; }
        public Nullable<int> CCDEntry { get; set; }
        public Nullable<int> NfePrntFo { get; set; }
        public Nullable<int> ZrdAbs { get; set; }
        public Nullable<int> POSRcptNo { get; set; }
        public Nullable<decimal> FoCTax { get; set; }
        public Nullable<decimal> FoCTaxFC { get; set; }
        public Nullable<decimal> FoCTaxSC { get; set; }
        public Nullable<int> TpCusPres { get; set; }
        public Nullable<System.DateTime> ExcDocDate { get; set; }
        public Nullable<decimal> FoCFrght { get; set; }
        public Nullable<decimal> FoCFrghtFC { get; set; }
        public Nullable<decimal> FoCFrghtSC { get; set; }
        public Nullable<short> InterimTyp { get; set; }
        public string PTICode { get; set; }
        public string Letter { get; set; }
        public Nullable<int> FolNumFrom { get; set; }
        public Nullable<int> FolNumTo { get; set; }
        public Nullable<int> FolSeries { get; set; }
        public Nullable<decimal> SplitTax { get; set; }
        public Nullable<decimal> SplitTaxFC { get; set; }
        public Nullable<decimal> SplitTaxSC { get; set; }
        public string ToBinCode { get; set; }
        public string PriceMode { get; set; }
        public string PoDropPrss { get; set; }
        public string PermitNo { get; set; }
        public string MYFtype { get; set; }
        public string DocTaxID { get; set; }
        public Nullable<System.DateTime> DateReport { get; set; }
        public string RepSection { get; set; }
        public string ExclTaxRep { get; set; }
        public Nullable<int> PosCashReg { get; set; }
        public string DmpTransID { get; set; }
        public string ECommerBP { get; set; }
        public string EComerGSTN { get; set; }
        public string Revision { get; set; }
        public string RevRefNo { get; set; }
        public Nullable<System.DateTime> RevRefDate { get; set; }
        public string RevCreRefN { get; set; }
        public Nullable<System.DateTime> RevCreRefD { get; set; }
        public string TaxInvNo { get; set; }
        public Nullable<System.DateTime> FrmBpDate { get; set; }
        public string GSTTranTyp { get; set; }
        public Nullable<int> BaseType { get; set; }
        public Nullable<int> BaseEntry { get; set; }
        public string ComTrade { get; set; }
        public string UseBilAddr { get; set; }
        public Nullable<short> IssReason { get; set; }
        public string ComTradeRt { get; set; }
        public string SplitPmnt { get; set; }
        public Nullable<int> SOIWizId { get; set; }
        public string SelfPosted { get; set; }
        public string EnBnkAcct { get; set; }
        public string EncryptIV { get; set; }
        public string DPPStatus { get; set; }
        public string EWBGenType { get; set; }
        public string SAPPassprt { get; set; }
        public Nullable<decimal> CtActTax { get; set; }
        public Nullable<decimal> CtActTaxFC { get; set; }
        public Nullable<decimal> CtActTaxSC { get; set; }
        public string U_ESTA { get; set; }
        public string U_PEMI { get; set; }
        public string U_TIMB { get; set; }
        public string U_LIIV { get; set; }
        public string U_AUTOFACTURA { get; set; }
        public string U_Estado_OC { get; set; }
        public Nullable<short> U_OC_hora_ent { get; set; }
        public string U_tipo_fac_imp { get; set; }
        public Nullable<decimal> U_ValorImp { get; set; }
        public string U_ind_p_facturacion { get; set; }
        public string U_tras_concepto { get; set; }
        public string U_transporte { get; set; }
        public string U_nom_chofer { get; set; }
        public string U_ci_conductor { get; set; }
        public string U_ruc_trans { get; set; }
        public string U_dir_transportista { get; set; }
        public string U_razon_soc_trans { get; set; }
        public string U_Obras { get; set; }
        public string U_Remision { get; set; }
        public string U_COND_ENTREGA { get; set; }
        public string U_temp_nombre_cli { get; set; }
        public string U_Lista_Precio { get; set; }
        public Nullable<int> U_Precio_Lista_nro { get; set; }
        public string U_SUCURSAL { get; set; }
        public string U_POSICION { get; set; }
        public string U_DPTO { get; set; }
        public string U_EQUIPO { get; set; }
        public string U_OC_NRO { get; set; }
        public string U_OBS_INT { get; set; }
        public string U_PLAZO_ENT { get; set; }
        public Nullable<decimal> U_SALDO_CUENTA { get; set; }
        public string U_PROC_AUTO { get; set; }
        public string U_OBS_AUTO { get; set; }
        public Nullable<decimal> U_CREDIT_LIMIT { get; set; }
        public Nullable<decimal> U_SOBREGIRO { get; set; }
        public string U_COMENT_AUT { get; set; }
        public Nullable<System.DateTime> U_FECHA_COMP { get; set; }
        public string U_ESTADO_AUT { get; set; }
        public string U_SOL_CLIENTE { get; set; }
        public Nullable<int> U_NRO_ORDEN { get; set; }
        public string U_ESTADO_AUT_S { get; set; }
        public string U_ESTADO_AUT_DESC { get; set; }
        public Nullable<short> U_BAND_AUT { get; set; }
        public string U_PREPAR_POR { get; set; }
        public string U_VERIFICADO { get; set; }
        public string U_TIPO_FR { get; set; }
        public string U_ESTADO_AUT_DESC_OV { get; set; }
        public Nullable<System.DateTime> U_fecha_alta { get; set; }
        public string U_hora_alta { get; set; }
        public Nullable<short> U_porc_dif { get; set; }
        public string U_clasif_presup { get; set; }
        public Nullable<System.DateTime> U_fecRecMercaderia { get; set; }
        public Nullable<System.DateTime> U_fecRecCIM { get; set; }
        public Nullable<System.DateTime> U_fecIniControl { get; set; }
        public Nullable<System.DateTime> U_fecFinControl { get; set; }
        public Nullable<decimal> U_recibido { get; set; }
        public Nullable<decimal> U_averiado { get; set; }
        public string U_motivo_transf { get; set; }
        public string U_mot_ajuste { get; set; }
        public string U_mot_nc { get; set; }
        public Nullable<int> U_sol_dev { get; set; }
        public string U_TIPOOPERACION { get; set; }
        public string U_TipoFactCompra { get; set; }
        public string U_tipo_pago { get; set; }
        public string U_Anulado { get; set; }
        public Nullable<System.DateTime> U_fecha_facturacion { get; set; }
        public int U_cast { get; set; }
        public Nullable<int> U_aut_cre { get; set; }
        public Nullable<System.DateTime> U_aut_cre_fec { get; set; }
        public Nullable<int> U_aut_des { get; set; }
        public Nullable<System.DateTime> U_aut_des_fec { get; set; }
        public Nullable<int> U_aut_stock { get; set; }
        public Nullable<System.DateTime> U_aut_stock_fec { get; set; }
        public string U_transportadora { get; set; }
        public string U_trans_tipo_pago { get; set; }
        public Nullable<decimal> U_promo_cupones { get; set; }
        public string U_promo_marcas { get; set; }
        public string U_com_SN { get; set; }
        public string U_parcelado { get; set; }
        public Nullable<System.DateTime> U_fecha_anticipo { get; set; }
        public Nullable<System.DateTime> U_fecha_embarque { get; set; }
        public Nullable<System.DateTime> U_fecha_recepcion { get; set; }
        public Nullable<System.DateTime> U_fecha_pago { get; set; }
        public int U_fr_cast { get; set; }
        public string U_mot_canc { get; set; }
        public string U_com_canc { get; set; }
        public Nullable<System.DateTime> U_fecha_cierre { get; set; }
        public Nullable<short> U_teamid { get; set; }
        public Nullable<int> U_proyecto_expertia { get; set; }
        public Nullable<short> U_refacturar { get; set; }
        public Nullable<int> U_refacturado { get; set; }
        public string U_mkt_categoria { get; set; }
        public string U_mkt_iniciativa { get; set; }
        public string U_mkt_une { get; set; }
        public string U_mkt_marca { get; set; }
        public string U_mkt_ejecucion { get; set; }
        public Nullable<int> U_opprId { get; set; }
        public Nullable<short> U_aprobado { get; set; }
        public string U_tipo_cal_imp { get; set; }
        public string U_ticketId { get; set; }
        public string U_obra { get; set; }
        public string U_PLAZO_ENT_DET { get; set; }
        public string U_tipo_transpor { get; set; }
        public Nullable<System.DateTime> U_fecha_disp_real { get; set; }
        public Nullable<System.DateTime> U_fecha_salida { get; set; }
        public Nullable<System.DateTime> U_fecha_llegada { get; set; }
        public Nullable<System.DateTime> U_salida_pto { get; set; }
        public Nullable<System.DateTime> U_llegada_pto { get; set; }
        public Nullable<short> U_seguro { get; set; }
        public Nullable<short> U_copia_doc { get; set; }
        public Nullable<short> U_recep_doc_origen { get; set; }
        public Nullable<System.DateTime> U_fecha_envio { get; set; }
        public Nullable<int> U_cotizacion_tablero { get; set; }
        public string U_gerente_cuenta { get; set; }
        public string U_folio { get; set; }
        public Nullable<int> U_siedi { get; set; }
        public Nullable<int> U_iluminacion { get; set; }
        public Nullable<short> U_prejudicial { get; set; }
        public Nullable<int> U_NroCotizacion { get; set; }
        public string U_lista_descuento { get; set; }
        public Nullable<int> U_lista_desc_nro { get; set; }
        public Nullable<System.DateTime> U_fecha_aprobacion { get; set; }
        public Nullable<short> U_hora_aprobacion { get; set; }
        public int U_fechas_confirmadas { get; set; }
        public Nullable<int> U_series_proyecc { get; set; }
        public string U_ejecutivo_cuenta { get; set; }
        public string U_TipoCont { get; set; }
        public string U_CDC { get; set; }
        public string U_DocElectronico { get; set; }
        public string U_SerieSet { get; set; }
        public string U_Departamentos { get; set; }
        public string U_NaturalezaReceptor { get; set; }
        public string U_TipoOpeSet { get; set; }
        public string U_TipoContRecep { get; set; }
        public Nullable<short> U_IndPresencia { get; set; }
        public string U_TipoPago { get; set; }
        public string U_CondOper { get; set; }
        public string U_CondOperCred { get; set; }
        public string U_CiudadEmisor { get; set; }
        public string U_ActEconomica { get; set; }
        public string U_NatVendedor { get; set; }
        public Nullable<short> U_TipTrans { get; set; }
    }
}
