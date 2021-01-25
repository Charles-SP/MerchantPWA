using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class EnvironmentRepository
    {
        public EnvironmentRepository()
        {
            ApplicationRepository = new HashSet<ApplicationRepository>();
            MerchantNavigation = new HashSet<Merchants>();
            MerchantTerminal = new HashSet<MerchantTerminal>();
            Product = new HashSet<Product>();
            ProductBand = new HashSet<ProductBand>();
            TerminalProduct = new HashSet<TerminalProduct>();
        }

        public long Id { get; set; }
        public long? EnvironmentId { get; set; }
        public long? RepositoryId { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? MerchantId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual Environment Environment { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual Repository Repository { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepository { get; set; }
        public virtual ICollection<Merchants> MerchantNavigation { get; set; }
        public virtual ICollection<MerchantTerminal> MerchantTerminal { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductBand> ProductBand { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProduct { get; set; }
    }
}
