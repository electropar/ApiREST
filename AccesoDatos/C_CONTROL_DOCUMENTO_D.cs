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
    
    public partial class C_CONTROL_DOCUMENTO_D
    {
        public int DocEntry { get; set; }
        public int LineId { get; set; }
        public Nullable<int> VisOrder { get; set; }
        public string Object { get; set; }
        public Nullable<int> LogInst { get; set; }
        public string U_nro_documento { get; set; }
        public Nullable<System.DateTime> U_fecha_doc { get; set; }
        public string U_tipo_doc { get; set; }
        public string U_cliente { get; set; }
        public Nullable<decimal> U_total { get; set; }
        public Nullable<short> U_cobrador { get; set; }
        public Nullable<short> U_archivo { get; set; }
        public Nullable<System.DateTime> U_update_fecha_doc { get; set; }
        public Nullable<short> U_UserSign { get; set; }
        public short U_devuelto { get; set; }
        public string U_actividad { get; set; }
    }
}