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
    
    public partial class PayEmployee
    {
        public string CompanyID { get; set; }
        public string DivisionID { get; set; }
        public string DepartmentID { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeTypeID { get; set; }
        public string EmployeeTitle { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string EmployeeCategoryID { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeePasswordOld { get; set; }
        public Nullable<System.DateTime> EmployeePasswordDate { get; set; }
        public Nullable<bool> EmployeePasswordExpires { get; set; }
        public string BankID { get; set; }
        public string BankAccountNo { get; set; }
        public string BankID2 { get; set; }
        public string BankAccountNo2 { get; set; }
        public string Nationality { get; set; }
        public string EthnicGroup { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public Nullable<int> NoOfChildren { get; set; }
        public Nullable<int> NOfDependant { get; set; }
        public string BloodGroup { get; set; }
        public string Genotype { get; set; }
        public Nullable<float> EmployeeWeight { get; set; }
        public Nullable<float> EmployeeHeight { get; set; }
        public string StatusID { get; set; }
        public string JobRole { get; set; }
        public string JobCategory { get; set; }
        public Nullable<bool> ActiveYN { get; set; }
        public string EmployeeAddress1 { get; set; }
        public string EmployeeAddress2 { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeFax { get; set; }
        public string EmployeeNationalID { get; set; }
        public string EmployeeEmailAddress { get; set; }
        public string EmployeeDepartmentID { get; set; }
        public string EmployeeSection { get; set; }
        public string EmployeeRegionID { get; set; }
        public string EmployeeBranchID { get; set; }
        public string EmployeeSourceID { get; set; }
        public string EmployeeIndustryID { get; set; }
        public string EmployeeManager { get; set; }
        public string PictureURL { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<System.DateTime> DateConfirmed { get; set; }
        public Nullable<bool> Commissionable { get; set; }
        public Nullable<double> CommissionPerc { get; set; }
        public string CommissionCalcMethod { get; set; }
        public string GradeId { get; set; }
        public string GradeStep { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinAddr1 { get; set; }
        public string NextOfKinAddr2 { get; set; }
        public string NextOfKinNumber { get; set; }
        public string PermanetAddress1 { get; set; }
        public string PermanetAddress2 { get; set; }
        public Nullable<bool> NSITFEnabled { get; set; }
        public string NSITFNumber { get; set; }
        public Nullable<System.DateTime> NSITFStartDate { get; set; }
        public Nullable<bool> NHFEnabled { get; set; }
        public string NHFNumber { get; set; }
        public Nullable<System.DateTime> NHFStartDate { get; set; }
        public Nullable<bool> TaxExcempted { get; set; }
        public Nullable<bool> AutomaticTaxRelief { get; set; }
        public Nullable<decimal> TaxOfficeAnualReturn { get; set; }
        public Nullable<decimal> TaxOfficeMonthlyReturn { get; set; }
        public string TaxID { get; set; }
        public string TaxStateID { get; set; }
        public string NSITFStateID { get; set; }
        public string NHFStateID { get; set; }
        public string InsuranceCoyID { get; set; }
        public string InsuranceNo { get; set; }
        public Nullable<double> EmployeeHoursPerDay { get; set; }
        public string EmployeeID2 { get; set; }
        public Nullable<bool> UseTimeSheet { get; set; }
        public Nullable<decimal> MonthToDateGross { get; set; }
        public Nullable<decimal> MonthToDateFederal { get; set; }
        public Nullable<decimal> MonthToDateState { get; set; }
        public Nullable<decimal> MonthToDateLocal { get; set; }
        public Nullable<decimal> MonthToDateOther { get; set; }
        public Nullable<decimal> QuarterToDateGross { get; set; }
        public Nullable<decimal> QuarterToDateFederal { get; set; }
        public Nullable<decimal> QuarterToDateState { get; set; }
        public Nullable<decimal> QuarterToDateLocal { get; set; }
        public Nullable<decimal> QuarterToDateOther { get; set; }
        public Nullable<decimal> YearToDateGross { get; set; }
        public Nullable<decimal> YearToDateFederal { get; set; }
        public Nullable<decimal> YearToDateState { get; set; }
        public Nullable<decimal> YearToDateLocal { get; set; }
        public Nullable<decimal> YearToDateOther { get; set; }
        public Nullable<bool> DenyLogon { get; set; }
        public string RequestID { get; set; }
        public string ApprovalID { get; set; }
        public string RequestType { get; set; }
        public bool HasFingerPrint { get; set; }
        public bool HasPhoto { get; set; }
        public string ClockInLocID { get; set; }
        public Nullable<bool> GratuityPaid { get; set; }
        public Nullable<System.DateTime> GratuityDate { get; set; }
        public Nullable<bool> Approved { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string Notes { get; set; }
        public string EnteredBy { get; set; }
        public string AuditCompanyID { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public string AuditUserID { get; set; }
        public string LockedBy { get; set; }
        public Nullable<System.DateTime> LockTS { get; set; }
        public bool IsHandled { get; set; }
        public string ProcessType { get; set; }
        public string CostCentreID { get; set; }
        public Nullable<int> TAUserID { get; set; }
        public Nullable<bool> HasNOT { get; set; }
        public Nullable<bool> HasWOT { get; set; }
        public Nullable<bool> HasPHOT { get; set; }
    }
}
