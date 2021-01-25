﻿using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Importmerchant
    {
        public long Id { get; set; }
        public Guid? SId { get; set; }
        public long? FileNo { get; set; }
        public string Title { get; set; }
        public string Reference { get; set; }
        public bool? Pblm { get; set; }
        public decimal? Pblmamount { get; set; }
        public bool? LayBy { get; set; }
        public decimal? LayByAmount { get; set; }
        public bool? NonEmvdevice { get; set; }
        public decimal? NonEmvdeviceAmount { get; set; }
        public bool? Eftpos { get; set; }
        public decimal? Eftposamount { get; set; }
        public string AcquiringBank { get; set; }
        public string TypeOfAccount { get; set; }
        public string EntityType { get; set; }
        public string OtherEntity { get; set; }
        public string RegisteredName { get; set; }
        public string RegisteredNumber { get; set; }
        public string AdditionalValueAdded { get; set; }
        public string Vat { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CompanyEmail { get; set; }
        public string PrimaryContactPerson { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string BillingEmail { get; set; }
        public string CompanyAddress { get; set; }
        public string PhysicalSuburb { get; set; }
        public string PhysicalCode { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalProvince { get; set; }
        public string PostalAdress { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalCode { get; set; }
        public string PostalCity { get; set; }
        public string PostalProvince { get; set; }
        public string Website { get; set; }
        public string TypeOfBusiness { get; set; }
        public string TypeOfProductService { get; set; }
        public string Footprint { get; set; }
        public string BusinessStructure { get; set; }
        public string TotalBranches { get; set; }
        public string HearAboutSp { get; set; }
        public string HearOther { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string BranchNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string Designation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public decimal? Amount { get; set; }
        public long? Mid { get; set; }
        public string Url { get; set; }
        public string DisplayName { get; set; }
        public string DebitOrderReference { get; set; }
        public string BillingFirstName { get; set; }
        public string PrimaryLastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string EftdeviceSupplier { get; set; }
        public string BillingLastName { get; set; }
        public string BillingMobile { get; set; }
        public string PblserialNumber { get; set; }
        public string EftvaslayerSerialNumber { get; set; }
        public int? TotalTrustees { get; set; }
        public int? YearsInBusiness { get; set; }
        public int? MothsInBusiness { get; set; }
        public int? Eftposperiod { get; set; }
        public int? Term1 { get; set; }
        public int? Term2 { get; set; }
        public int? Term3 { get; set; }
        public int? Term4 { get; set; }
        public int? Term5 { get; set; }
        public int? Term6 { get; set; }
        public int? Term7 { get; set; }
        public string Term8 { get; set; }
        public string Term9 { get; set; }
        public int? Term10 { get; set; }
        public int? NonEftdevicePeriod { get; set; }
        public int? LayByPeriod { get; set; }
        public int? Pblmperiod { get; set; }
        public decimal? MerchantCommission { get; set; }
        public decimal? MerchantLaybyDeposit { get; set; }
        public decimal? Pblmfee { get; set; }
        public decimal? Lbmfee { get; set; }
        public DateTime? ActivationDate { get; set; }
        public decimal? ActivationAmount { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? LayByDate { get; set; }
        public DateTime? Eftposdate { get; set; }
        public DateTime? NonEftdevuceDate { get; set; }
        public DateTime? Pblmdate { get; set; }
        public bool? ActivationFee { get; set; }
        public bool? IsTrusteeJuristicPerson { get; set; }
        public bool? IsPostalDifferent { get; set; }
        public bool? ParentMerchantBankDetails { get; set; }
        public long? ParentMerchantId { get; set; }
        public string ParentMerchant { get; set; }
        public string SalesChannel { get; set; }
        public string Agent { get; set; }
        public byte[] MerchantLogo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Description { get; set; }
        public bool? Processed { get; set; }
        public bool? Transferred { get; set; }
    }
}