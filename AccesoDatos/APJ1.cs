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
    
    public partial class APJ1
    {
        public int DocEntry { get; set; }
        public int StepCode { get; set; }
        public Nullable<int> Father { get; set; }
        public Nullable<int> VisOrder { get; set; }
        public Nullable<int> Level { get; set; }
        public string StepName { get; set; }
        public string StepInfo { get; set; }
        public string StepNotes { get; set; }
        public string StepLink { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string IsComplete { get; set; }
        public int LogInstanc { get; set; }
        public string Owner { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<decimal> Duration { get; set; }
        public Nullable<decimal> PlanTime { get; set; }
        public Nullable<int> AtcEntry { get; set; }
        public Nullable<decimal> TotalPTime { get; set; }
        public Nullable<int> QueryID { get; set; }
    }
}
