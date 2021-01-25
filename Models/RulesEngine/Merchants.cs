using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Merchants
    {
        public Merchants()
        {
            ApplicationRepository = new HashSet<ApplicationRepository>();
            CreditProviderMerchant = new HashSet<CreditProviderMerchant>();
            DebitOrder = new HashSet<DebitOrder>();
            DebitOrderHistory = new HashSet<DebitOrderHistory>();
            EnvironmentRepository = new HashSet<EnvironmentRepository>();
            InverseParentMerchant = new HashSet<Merchants>();
            MerchantBankDetails = new HashSet<MerchantBankDetails>();
            MerchantDetails = new HashSet<MerchantDetails>();
            MerchantHistory = new HashSet<MerchantHistory>();
            MerchantProduct = new HashSet<MerchantProduct>();
            MerchantTerminal = new HashSet<MerchantTerminal>();
            Product = new HashSet<Product>();
            TerminalDeactivation = new HashSet<TerminalDeactivation>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Reference { get; set; }
        public string ShortName { get; set; }
        public long? EnvironmentRepositoryId { get; set; }
        public long? ParentMerchantId { get; set; }
        public long? ChannelId { get; set; }
        public long? AuthDirectoryId { get; set; }
        public string RegisteredNumber { get; set; }
        public long? AgentId { get; set; }
        public long? SalesChannelId { get; set; }
        public long? TypeOfBusinessId { get; set; }
        public string TypeOfBusinessOther { get; set; }
        public long? IndustryId { get; set; }
        public string Location { get; set; }
        public string DefaultIdno { get; set; }
        public string DefaultMobile { get; set; }
        public decimal? DefaultAmount { get; set; }
        public int? DefaultBank { get; set; }
        public string DefaultOtp { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string RegisteredName { get; set; }
        public int? Pending { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual AuthDirectory AuthDirectory { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual EnvironmentRepository EnvironmentRepositoryNavigation { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual Merchants ParentMerchant { get; set; }
        public virtual SalesChannel SalesChannel { get; set; }
        public virtual TypeOfBusiness TypeOfBusiness { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepository { get; set; }
        public virtual ICollection<CreditProviderMerchant> CreditProviderMerchant { get; set; }
        public virtual ICollection<DebitOrder> DebitOrder { get; set; }
        public virtual ICollection<DebitOrderHistory> DebitOrderHistory { get; set; }
        public virtual ICollection<EnvironmentRepository> EnvironmentRepository { get; set; }
        public virtual ICollection<Merchants> InverseParentMerchant { get; set; }
        public virtual ICollection<MerchantBankDetails> MerchantBankDetails { get; set; }
        public virtual ICollection<MerchantDetails> MerchantDetails { get; set; }
        public virtual ICollection<MerchantHistory> MerchantHistory { get; set; }
        public virtual ICollection<MerchantProduct> MerchantProduct { get; set; }
        public virtual ICollection<MerchantTerminal> MerchantTerminal { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<TerminalDeactivation> TerminalDeactivation { get; set; }
    }
}
