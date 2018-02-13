using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Wareman.Service;

namespace WaremanWS.Models
{
    public class POModel
    {
        //private System.Web.Http.Routing.UrlHelper _UrlHelper;

        //public POModel(HttpRequestMessage request)
        //{
        //    _UrlHelper = new System.Web.Http.Routing.UrlHelper(request);
        //}

        public string Url { get; set; } 
        public int Sno { get; set; }
        public string CompanyID { get; set; }                        //
        public string PONumber { get; set; }                         //
        public Nullable<System.DateTime> PODate { get; set; }        //
        public string CurrencyID { get; set; }                       //
        public string RequisitionNumber { get; set; }                //
        public bool IsCompleted { get; set; }                        //
        public Nullable<System.DateTime> CompletedDate { get; set; } //
        public Nullable<System.DateTime> PODueDate { get; set; }     //
        public string SupplierId { get; set; }                       //
        public string TermsId { get; set; }                          //
        public string ReqShipAction { get; set; }                    //
        public string AssetID { get; set; }
        public string BudgetCode { get; set; }
        public string UnitCode { get; set; }
        public string StateCode { get; set; }
        public string HHNumber { get; set; }
        public string HHSTS { get; set; }
        public string BBSTS { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> TotalValue { get; set; }
        public Nullable<decimal> ReceivedTotalValue { get; set; }
        public string BBNumber { get; set; }
        public string FUpNumber { get; set; }
        public string ShipInfoID { get; set; }
        public string OrderTo { get; set; }
        public string Remarks { get; set; }
        public short StatusID { get; set; }
        public string UserID { get; set; }
        public string Importance { get; set; }
        public string StatusReason { get; set; }
        public string InvoiceNumber { get; set; }
        public string DeliveryNumber { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public string AuditUserID { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public string PoSourceID { get; set; }
        public string DeliverAddress1 { get; set; }
        public string DeliverAddress2 { get; set; }
        public string DeliverAddress3 { get; set; }
        public string DeliverAddress4 { get; set; }
        public string DeliverAttention { get; set; }
        public Nullable<System.DateTime> ProposedDate { get; set; }
        public string VendorAddress1 { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorAddress3 { get; set; }
        public string VendorAddress4 { get; set; }
        public string VendorContact { get; set; }
        public string InvoiceAddress1 { get; set; }
        public string InvoiceAddress2 { get; set; }
        public string invoiceAddress3 { get; set; }
        public string InvoiceAddress4 { get; set; }
        public string InvoiceContact { get; set; }
        public string CostCode { get; set; }
        public Nullable<bool> IsSigned { get; set; }
        public Nullable<System.DateTime> DateSigned { get; set; }
        public string SignedBy { get; set; }
        public string CurrencySeperator { get; set; }
        public Nullable<bool> CalculateTax { get; set; }
        public Nullable<bool> TaxInclusive { get; set; }
        public Nullable<float> TaxRate { get; set; }
        public Nullable<decimal> TotalTaxValue { get; set; }
        public Nullable<decimal> FreightCharges { get; set; }
        public Nullable<decimal> LocalTransport { get; set; }
        public Nullable<decimal> OtherCharges { get; set; }
        public string PoTypeID { get; set; }
        public string DivisionID { get; set; }
        public string RefDoc1 { get; set; }
        public Nullable<System.DateTime> RefDoc1Date { get; set; }
        public string RefDoc2 { get; set; }
        public Nullable<System.DateTime> RefDoc2Date { get; set; }
        public string ReasonCode { get; set; }
        public int PrintOption { get; set; }
    
        public virtual ICollection<PO_Detail> PO_Detail { get; set; }
    }
}