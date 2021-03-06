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
    
    public partial class PCIResponseTicketsReport
    {
        public int TicketId { get; set; }
        public string ExternalReferenceNo { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public string FullName { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string PriorityName { get; set; }
        public string AssigneeName { get; set; }
        public string ApplicationName { get; set; }
        public bool IsMajorIncident { get; set; }
        public string Description { get; set; }
        public string RootCause { get; set; }
        public string Resolution { get; set; }
        public string Notes { get; set; }
        public Nullable<int> EscalationGroupId { get; set; }
        public string EscalationGroupName { get; set; }
        public string SourceName { get; set; }
        public System.DateTime ReportedDate { get; set; }
        public Nullable<System.DateTime> ResolvedDate { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime LastModificationDate { get; set; }
        public string RootCause_Lv1_Category { get; set; }
        public Nullable<int> RootCauseID_Lv1_Category { get; set; }
        public string RootCause_Lv2_Category { get; set; }
        public Nullable<int> RootCauseID_Lv2_Category { get; set; }
        public string RootCause_Lv3_Category { get; set; }
        public Nullable<int> RootCauseID_Lv3_Category { get; set; }
        public string ReportedIssue_Lv1_Category { get; set; }
        public string ReportedIssue_Lv2_Category { get; set; }
        public string ReportedIssue_Lv3_Category { get; set; }
        public string Action1_Lv1_Category { get; set; }
        public string Action1_Lv2_Category { get; set; }
        public string Action1_Lv3_Category { get; set; }
        public string Action2_Lv1_Category { get; set; }
        public string Action2_Lv2_Category { get; set; }
        public string Action2_Lv3_Category { get; set; }
        public string Action3_Lv1_Category { get; set; }
        public string Action3_Lv2_Category { get; set; }
        public string Action3_Lv3_Category { get; set; }
        public string ProductionUnitName { get; set; }
        public string PU_Desc { get; set; }
        public Nullable<int> ProductionUnitId { get; set; }
    }
}
