using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class FinancialInstitution
    {
        public FinancialInstitution()
        {
            ApplicationCreditProvider = new HashSet<ApplicationCreditProvider>();
            ApplicationRepositoryCreditProvider = new HashSet<ApplicationRepository>();
            ApplicationRepositoryFinancialInstitution = new HashSet<ApplicationRepository>();
            CreditProviderMerchant = new HashSet<CreditProviderMerchant>();
            EnvironmentRepository = new HashSet<EnvironmentRepository>();
            MerchantBankDetails = new HashSet<MerchantBankDetails>();
            MerchantTerminal = new HashSet<MerchantTerminal>();
            Product = new HashSet<Product>();
            ProductBand = new HashSet<ProductBand>();
            Supplier = new HashSet<Supplier>();
            TerminalProduct = new HashSet<TerminalProduct>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long? PrimaryUser { get; set; }
        public bool? IsCreditProvider { get; set; }
        public bool? IsOnBankList { get; set; }
        public long? IdforTerminal { get; set; }
        public long? IdforBankList { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsOnTerminalList { get; set; }
        public long? Urlid { get; set; }
        public int? Ranking { get; set; }
        public decimal? RangeMin { get; set; }
        public decimal? RangeMax { get; set; }
        public int? Overide { get; set; }

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual AuthDirectory PrimaryUserNavigation { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual Url Url { get; set; }
        public virtual ICollection<ApplicationCreditProvider> ApplicationCreditProvider { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepositoryCreditProvider { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepositoryFinancialInstitution { get; set; }
        public virtual ICollection<CreditProviderMerchant> CreditProviderMerchant { get; set; }
        public virtual ICollection<EnvironmentRepository> EnvironmentRepository { get; set; }
        public virtual ICollection<MerchantBankDetails> MerchantBankDetails { get; set; }
        public virtual ICollection<MerchantTerminal> MerchantTerminal { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductBand> ProductBand { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProduct { get; set; }
    }
}
