﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaremanWS.Models
{
    public class RequisitionModel
    {
        public string Url { get; set; } 
        public string CompanyID { get; set; }
        public string TransactionID { get; set; }
        public string RequisitionNumber { get; set; }
        public int LineNumber { get; set; }
        public string ProductCode { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string UOMID { get; set; }
        public string CategoryID { get; set; }
        public float QuantityRequested { get; set; }
        public Nullable<float> QuantityQuoted { get; set; }
        public float QuantityIssued { get; set; }
        public float QuantityUsed { get; set; }
        public bool UsedInPO { get; set; }
        public string PONumber { get; set; }
        public Nullable<float> CurrencyRate { get; set; }
        public Nullable<float> AveragePrice { get; set; }
        public Nullable<float> LastPurchasePrice { get; set; }
        public Nullable<double> ProductAverageValue { get; set; }
        public Nullable<double> ProductLastPriceValue { get; set; }
        public bool IsClosed { get; set; }
        public string Remarks { get; set; }
        public string PartCode { get; set; }
        public string AuditUserID { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public bool IsBrowseCleared { get; set; }
        public Nullable<float> OpeningBalance { get; set; }
        public Nullable<float> POQuantity { get; set; }
        public Nullable<float> BOQuantity { get; set; }
        public string WarehouseID { get; set; }
        public string LocationID { get; set; }
        public string CurrencyId { get; set; }
        public Nullable<float> QuantityReturned { get; set; }
        public string BudgetCode { get; set; }
        public string UnitCode { get; set; }
        public string StateCode { get; set; }
        public string ReqUserID { get; set; }
        public string PROReference { get; set; }
        public System.Guid RecordID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string DivisionID { get; set; }
        public string ArticleNo { get; set; }
    }
}