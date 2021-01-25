using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ProductBand
    {
        public ProductBand()
        {
            ProductBandTerms = new HashSet<ProductBandTerms>();
        }

        public long Id { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? ProductId { get; set; }
        public long? BandTypeId { get; set; }
        public long? MerchantId { get; set; }
        public int? Minimum { get; set; }
        public int? Maximum { get; set; }
        public string Floor { get; set; }
        public decimal? Ceiling { get; set; }
        public long? EnvironmentRepositoryId { get; set; }
        public decimal? Subscription { get; set; }
        public double? Commission { get; set; }
        public decimal? ActivationFee { get; set; }
        public double? Deposit { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual BandType BandType { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual EnvironmentRepository EnvironmentRepository { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual Product Product { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ProductBandTerms> ProductBandTerms { get; set; }
    }
}
