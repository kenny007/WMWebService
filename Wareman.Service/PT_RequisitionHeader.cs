//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wareman.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class PT_RequisitionHeader
    {
        public PT_RequisitionHeader()
        {
            this.PT_RequisitionDetail = new HashSet<PT_RequisitionDetail>();
        }
    
        public string CompanyID { get; set; }
        public string RequisitionNumber { get; set; }
        public Nullable<int> UniqueDocNo { get; set; }
        public string UserDocNumber { get; set; }
        public string Description { get; set; }
        public string FaultID { get; set; }
        public string TaskID { get; set; }
        public Nullable<System.DateTime> RequisitionDate { get; set; }
        public string ImportanceID { get; set; }
        public string CategoryID { get; set; }
        public string EmployeeID { get; set; }
        public string AssetID { get; set; }
        public string BudgetCode { get; set; }
        public string UnitCode { get; set; }
        public string StateCode { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> PartsOrdered { get; set; }
        public string PONumber { get; set; }
        public string CurrencyID { get; set; }
        public Nullable<double> TotalAverageValue { get; set; }
        public Nullable<double> TotalLastPriceValue { get; set; }
        public string ProjectID { get; set; }
        public Nullable<int> PrintingCount { get; set; }
        public string Status { get; set; }
        public Nullable<bool> Approved { get; set; }
        public bool IsAutoCreated { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsClosed { get; set; }
        public Nullable<bool> PartsIssued { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public string AuditUserID { get; set; }
        public string ReqShipAction { get; set; }
        public string SiteID { get; set; }
        public Nullable<bool> HasPO { get; set; }
        public string OrderBy { get; set; }
        public string VendorID { get; set; }
        public string EmployeeName { get; set; }
        public string DocCreatorID { get; set; }
        public int RequestTypeID { get; set; }
        public int ChargeTo { get; set; }
        public string GLAccountNumber { get; set; }
        public string GLAccountName { get; set; }
        public string SourceCostCentre { get; set; }
        public Nullable<double> MeterReading { get; set; }
        public Nullable<bool> SvcChargeUpdated { get; set; }
        public string SvcAuditUserID { get; set; }
        public Nullable<System.DateTime> SvcAuditDatetime { get; set; }
        public Nullable<bool> Cancelled { get; set; }
        public Nullable<System.DateTime> DateCancelled { get; set; }
        public string cancelledBy { get; set; }
        public string CancelReason { get; set; }
        public string RequisitionNo2 { get; set; }
        public string ReapairBox { get; set; }
        public System.Guid RecordID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string DivisionID { get; set; }
        public Nullable<int> JobID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string ReasonCode { get; set; }
    
        public virtual ICollection<PT_RequisitionDetail> PT_RequisitionDetail { get; set; }
        public virtual PT_RequisitionHeader PT_RequisitionHeader1 { get; set; }
        public virtual PT_RequisitionHeader PT_RequisitionHeader2 { get; set; }
    }
}