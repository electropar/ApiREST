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
    
    public partial class C_PIC_RESUMEN
    {
        public int DocEntry { get; set; }
        public int LineId { get; set; }
        public Nullable<int> VisOrder { get; set; }
        public string Object { get; set; }
        public Nullable<int> LogInst { get; set; }
        public Nullable<int> U_cobrado { get; set; }
        public Nullable<int> U_no_cobrado { get; set; }
        public Nullable<int> U_cobrado_otra_fec { get; set; }
        public Nullable<int> U_efectivo_cobrado { get; set; }
        public Nullable<int> U_efectivo_otra_fec { get; set; }
        public Nullable<int> U_tarjeta_cobrado { get; set; }
        public Nullable<int> U_tarjeta_otra_fec { get; set; }
        public Nullable<int> U_trans_cobrado { get; set; }
        public Nullable<int> U_trans_otra_fec { get; set; }
        public Nullable<int> U_nota_credito_hoy { get; set; }
        public Nullable<int> U_nota_credito_otra { get; set; }
        public Nullable<int> U_retencion_hoy { get; set; }
        public Nullable<int> U_retencion_otra_fec { get; set; }
        public Nullable<int> U_canje_hoy { get; set; }
        public Nullable<int> U_canje_otra_fec { get; set; }
        public Nullable<decimal> U_total { get; set; }
        public Nullable<decimal> U_cheque_cobrado { get; set; }
        public Nullable<decimal> U_cheque_otra_fec { get; set; }
    }
}
