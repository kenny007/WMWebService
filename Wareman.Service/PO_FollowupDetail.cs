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
    
    public partial class PO_FollowupDetail
    {
        public string TransactionID { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public string FollowupNumber { get; set; }
        public string ProductCode { get; set; }
        public string PartNumber { get; set; }
        public string AliasNumber { get; set; }
        public string PartName { get; set; }
        public Nullable<float> PoQuantity { get; set; }
        public float BBQuantity { get; set; }
        public float HHQuantity { get; set; }
        public Nullable<float> QuantityArrived { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> SourceUnitPrice { get; set; }
        public Nullable<float> SourceDiscountRate { get; set; }
        public Nullable<decimal> SourceAmount { get; set; }
        public decimal BaseUnitPrice { get; set; }
        public bool Closed { get; set; }
        public string AuditUserID { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public string DivisionID { get; set; }
    
        public virtual PO_FollowupHeader PO_FollowupHeader { get; set; }
    }
}
