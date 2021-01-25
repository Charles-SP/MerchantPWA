using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantDetails
    {
        public long Id { get; set; }
        public long MerchantId { get; set; }
        public string Title { get; set; }
        public string Vatnumber { get; set; }
        public string PrimaryName { get; set; }
        public string PrimaryPhone { get; set; }
        public string PrimaryEmail { get; set; }
        public bool? AllTerminals { get; set; }
        public string AdditionalValueAdded { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string CompanyEmail { get; set; }
        public string Website { get; set; }
        public string BillingEmail { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        public string PhysicalSuburb { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalProvince { get; set; }
        public string PhysicalCode { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalCity { get; set; }
        public string PostalProvince { get; set; }
        public string PostalCode { get; set; }
        public long? TypeOfServiceId { get; set; }
        public long? FootprintId { get; set; }
        public long? BusinessStructureId { get; set; }
        public long? BusinessSizeId { get; set; }
        public long? MerchantSourceId { get; set; }
        public string MerchantSourceOther { get; set; }
        public long? DesignationId { get; set; }
        public int? Trustees { get; set; }
        public int? YearsInBusiness { get; set; }
        public int? MonthsInBusiness { get; set; }
        public bool? IsJuristicPerson { get; set; }
        public bool? IsPostalDifferent { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public decimal? ActivationFee { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingSurname { get; set; }
        public string BillingPhone { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual BusinessSize BusinessSize { get; set; }
        public virtual BusinessStructure BusinessStructure { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Footprint Footprint { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual MerchantSource MerchantSource { get; set; }
        public virtual TypeOfService TypeOfService { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
    }
}
