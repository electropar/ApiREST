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
    
    public partial class OWFI
    {
        public int WFInstID { get; set; }
        public Nullable<int> ExecID { get; set; }
        public Nullable<int> TemplateID { get; set; }
        public string Creator { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<short> StartTime { get; set; }
        public Nullable<short> EndTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<short> IsAutoStar { get; set; }
    }
}
