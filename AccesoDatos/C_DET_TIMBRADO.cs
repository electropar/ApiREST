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
    
    public partial class C_DET_TIMBRADO
    {
        public string Code { get; set; }
        public int LineId { get; set; }
        public string Object { get; set; }
        public Nullable<int> LogInst { get; set; }
        public string U_tipo_documento { get; set; }
        public Nullable<int> U_establecimiento { get; set; }
        public Nullable<int> U_emision { get; set; }
        public Nullable<int> U_desde { get; set; }
        public Nullable<int> U_hasta { get; set; }
        public string U_serie { get; set; }
        public string U_sucursal { get; set; }
        public Nullable<short> U_activo { get; set; }
        public Nullable<int> U_docentry { get; set; }
        public Nullable<System.DateTime> U_vigencia_desde { get; set; }
        public Nullable<int> U_utilizado { get; set; }
    }
}