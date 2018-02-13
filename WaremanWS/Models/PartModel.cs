using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaremanWS.Models
{
    public class PartModel
    {
        public string Url { get; set; } 
        public string CompanyID { get; set; }
        public string ProductCode { get; set; }
        public string PartNumber { get; set; }
        public string PartTypeID { get; set; }
        public string AssetID { get; set; }
        public string PartName { get; set; }
        public string PartDescription { get; set; }
        public string PartLongDescription { get; set; }
        public string PartCategoryID { get; set; }
        public string PartCode { get; set; }
        public string PartFamilyID { get; set; }
        public string PartGroupID { get; set; }
        public string PartSubGroupID { get; set; }
        public string DrawingNos { get; set; }
        public string PartPosition { get; set; }
        public string SalesDescription { get; set; }
        public string PurchaseDescription { get; set; }
        public string PictureURL { get; set; }
        public string LargePictureURL { get; set; }
        public Nullable<double> PartWeight { get; set; }
        public Nullable<double> PartWeightMetric { get; set; }
        public Nullable<int> PartShipWeight { get; set; }
        public string PartSize { get; set; }
        public string PartSizeCmm { get; set; }
        public string PartDimentions { get; set; }
        public string PartDimentionsCmm { get; set; }
        public string PartColor { get; set; }
        public string PartStyle { get; set; }
        public string PartCareInstructions { get; set; }
        public string PartDefaultWarehouse { get; set; }
        public string PartDefaultWarehouseBin { get; set; }
        public string PartLocationX { get; set; }
        public string PartLocationY { get; set; }
        public string PartLocationZ { get; set; }
        public string DownloadLocation { get; set; }
        public string DownloadPassword { get; set; }
        public string PartUOM { get; set; }
        public Nullable<float> PartUOMConvert { get; set; }
        public string GLPartSalesAccount { get; set; }
        public string GLPartCOGSAccount { get; set; }
        public string GLInventoryAccount { get; set; }
        public string CurrencyID { get; set; }
        public Nullable<double> CurrencyExchangeRate { get; set; }
        public string PartPricingCode { get; set; }
        public string PricingMethods { get; set; }
        public Nullable<bool> Taxable { get; set; }
        public string VendorID { get; set; }
        public string LeadTime { get; set; }
        public string LeadTimeUnit { get; set; }
        public Nullable<double> ReOrderLevel { get; set; }
        public Nullable<double> ReOrderQty { get; set; }
        public Nullable<int> BuildTime { get; set; }
        public string BuildTimeUnit { get; set; }
        public Nullable<int> UseageRate { get; set; }
        public string UseageRateUnit { get; set; }
        public Nullable<int> SalesForecast { get; set; }
        public string SalesForecastUnit { get; set; }
        public Nullable<int> CalculatedCover { get; set; }
        public string CalculatedCoverUnits { get; set; }
        public bool IsAssembly { get; set; }
        public string PartAssembly { get; set; }
        public Nullable<decimal> AverageUnitPrice { get; set; }
        public Nullable<decimal> AverageTotalValue { get; set; }
        public Nullable<decimal> LastUnitPrice { get; set; }
        public Nullable<decimal> LastTotalValue { get; set; }
        public Nullable<double> QuantityALLStore { get; set; }
        public Nullable<double> QuantityReserved { get; set; }
        public Nullable<double> QuantityAvailable { get; set; }
        public Nullable<double> QuantityBackOrder { get; set; }
        public string TaxGroupID { get; set; }
        public Nullable<double> TaxPercent { get; set; }
        public bool IsActive { get; set; }
        public bool IsStockItem { get; set; }
        public bool OnHold { get; set; }
        public bool Hidden { get; set; }
        public string AuditUserID { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public Nullable<double> MinimumLevel { get; set; }
        public Nullable<double> MaximumLevel { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> UseSerialNr { get; set; }
        public string Notes { get; set; }
        public string LastSupplier { get; set; }
        public Nullable<float> YTDQuantity { get; set; }
        public string Status { get; set; }
        public string DiscountCode { get; set; }
        public Nullable<bool> UseExpiring { get; set; }
        public string GLInventoryVarAccount { get; set; }
        public string GLConsumptionAccount { get; set; }
        public Nullable<decimal> StandardPrice { get; set; }
        public System.Guid RecordID { get; set; }
        public string ArticleNo { get; set; }
        public string MakerCodeID { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public string UserCode1 { get; set; }
        public string UserCode2 { get; set; }
        public Nullable<int> UserCode3 { get; set; }
        public Nullable<int> UserCode4 { get; set; }
    }
}