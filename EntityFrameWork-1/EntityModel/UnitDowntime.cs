//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameWork_1.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnitDowntime
    {
        public int UnitDowntimeID { get; set; }
        public int ProductionUnitId { get; set; }
        public int TEDed_Id { get; set; }
        public Nullable<System.DateTime> Start_Time { get; set; }
        public Nullable<System.DateTime> End_Time { get; set; }
        public string FaultName { get; set; }
    
        public virtual ProductionUnit ProductionUnit { get; set; }
        public virtual ProductionUnit ProductionUnit1 { get; set; }
    }
}
