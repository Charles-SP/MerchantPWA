using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Product
    {
        public Product()
        {
            ApplicationRepository = new HashSet<ApplicationRepository>();
            MerchantProduct = new HashSet<MerchantProduct>();
            ProductBand = new HashSet<ProductBand>();
            TerminalDeactivation = new HashSet<TerminalDeactivation>();
            TerminalProduct = new HashSet<TerminalProduct>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? MerchantId { get; set; }
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

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual EnvironmentRepository EnvironmentRepository { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepository { get; set; }
        public virtual ICollection<MerchantProduct> MerchantProduct { get; set; }
        public virtual ICollection<ProductBand> ProductBand { get; set; }
        public virtual ICollection<TerminalDeactivation> TerminalDeactivation { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProduct { get; set; }
    }
}
