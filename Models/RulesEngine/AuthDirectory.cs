using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class AuthDirectory
    {
        public AuthDirectory()
        {
            ActionCreatedByNavigation = new HashSet<Action>();
            ActionUpdatedByNavigation = new HashSet<Action>();
            ApplicationRepositoryCreatedByNavigation = new HashSet<ApplicationRepository>();
            ApplicationRepositoryHistory = new HashSet<ApplicationRepositoryHistory>();
            ApplicationRepositoryUpdatedByNavigation = new HashSet<ApplicationRepository>();
            AuthDirectoryRepositoryAuthDirectory = new HashSet<AuthDirectoryRepository>();
            AuthDirectoryRepositoryCreatedByNavigation = new HashSet<AuthDirectoryRepository>();
            AuthDirectoryRepositoryUpdatedByNavigation = new HashSet<AuthDirectoryRepository>();
            ComponentCreatedByNavigation = new HashSet<Component>();
            ComponentHistory = new HashSet<ComponentHistory>();
            ComponentHistoryTypeCreatedByNavigation = new HashSet<ComponentHistoryType>();
            ComponentHistoryTypeUpdatedByNavigation = new HashSet<ComponentHistoryType>();
            ComponentUpdatedByNavigation = new HashSet<Component>();
            CreditProviderMerchantCreatedByNavigation = new HashSet<CreditProviderMerchant>();
            CreditProviderMerchantUpdatedByNavigation = new HashSet<CreditProviderMerchant>();
            DatabaseAuthDirectory = new HashSet<Database>();
            DatabaseTypeCreatedByNavigation = new HashSet<DatabaseType>();
            DatabaseTypeUpdatedByNavigation = new HashSet<DatabaseType>();
            DatabaseUpdatedByNavigation = new HashSet<Database>();
            EnvironmentAcpasuser = new HashSet<Environment>();
            EnvironmentAdminUser = new HashSet<Environment>();
            EnvironmentCompuscanUser = new HashSet<Environment>();
            EnvironmentConnectMobileNiussduser = new HashSet<Environment>();
            EnvironmentConnectMobileSmsuser = new HashSet<Environment>();
            EnvironmentCreatedByNavigation = new HashSet<Environment>();
            EnvironmentFirstEscalationUser = new HashSet<Environment>();
            EnvironmentIntegrationUser = new HashSet<Environment>();
            EnvironmentRepositoryCreatedByNavigation = new HashSet<EnvironmentRepository>();
            EnvironmentRepositoryUpdatedByNavigation = new HashSet<EnvironmentRepository>();
            EnvironmentSecondEscalationUser = new HashSet<Environment>();
            EnvironmentServiceUser = new HashSet<Environment>();
            EnvironmentSwitchPayUser = new HashSet<Environment>();
            EnvironmentUpdatedByNavigation = new HashSet<Environment>();
            EnvironmentVodacomUser = new HashSet<Environment>();
            FinancialInstitutionCreatedByNavigation = new HashSet<FinancialInstitution>();
            FinancialInstitutionPrimaryUserNavigation = new HashSet<FinancialInstitution>();
            FinancialInstitutionUpdatedByNavigation = new HashSet<FinancialInstitution>();
            InverseCreatedByNavigation = new HashSet<AuthDirectory>();
            InverseUpdatedByNavigation = new HashSet<AuthDirectory>();
            MerchantAuthDirectory = new HashSet<Merchants>();
            MerchantBankDetailsCreatedByNavigation = new HashSet<MerchantBankDetails>();
            MerchantBankDetailsUpdatedByNavigation = new HashSet<MerchantBankDetails>();
            MerchantCreatedByNavigation = new HashSet<Merchants>();
            MerchantDetailsCreatedByNavigation = new HashSet<MerchantDetails>();
            MerchantDetailsUpdatedByNavigation = new HashSet<MerchantDetails>();
            MerchantHistory = new HashSet<MerchantHistory>();
            MerchantHistoryTypeCreatedByNavigation = new HashSet<MerchantHistoryType>();
            MerchantHistoryTypeUpdatedByNavigation = new HashSet<MerchantHistoryType>();
            MerchantTerminalCreatedByNavigation = new HashSet<MerchantTerminal>();
            MerchantTerminalUpdatedByNavigation = new HashSet<MerchantTerminal>();
            MerchantUpdatedByNavigation = new HashSet<Merchants>();
            MetricCreatedByNavigation = new HashSet<Metric>();
            MetricUpdatedByNavigation = new HashSet<Metric>();
            OtptypeCreatedByNavigation = new HashSet<Otptype>();
            OtptypeUpdatedByNavigation = new HashSet<Otptype>();
            ProductBandCreatedByNavigation = new HashSet<ProductBand>();
            ProductBandUpdatedByNavigation = new HashSet<ProductBand>();
            ProductCreatedByNavigation = new HashSet<Product>();
            ProductUpdatedByNavigation = new HashSet<Product>();
            RepositoryAcpasuser = new HashSet<Repository>();
            RepositoryAdminUser = new HashSet<Repository>();
            RepositoryCompuscanUser = new HashSet<Repository>();
            RepositoryConnectMobileNiussduser = new HashSet<Repository>();
            RepositoryConnectMobileSmsuser = new HashSet<Repository>();
            RepositoryCreatedByNavigation = new HashSet<Repository>();
            RepositoryFirstEscalationUser = new HashSet<Repository>();
            RepositoryIntegrationUser = new HashSet<Repository>();
            RepositorySecondEscalationUser = new HashSet<Repository>();
            RepositoryServiceUser = new HashSet<Repository>();
            RepositorySwitchPayUser = new HashSet<Repository>();
            RepositoryUpdatedByNavigation = new HashSet<Repository>();
            RepositoryVodacomUser = new HashSet<Repository>();
            TerminalMetricCreatedByNavigation = new HashSet<TerminalMetric>();
            TerminalMetricUpdatedByNavigation = new HashSet<TerminalMetric>();
            TerminalProductCreatedByNavigation = new HashSet<TerminalProduct>();
            TerminalProductUpdatedByNavigation = new HashSet<TerminalProduct>();
            TerminalTypeCreatedByNavigation = new HashSet<TerminalType>();
            TerminalTypeUpdatedByNavigation = new HashSet<TerminalType>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public Guid? RemoteId { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public long UserTypeId { get; set; }
        public long? RepositoryId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual Repository Repository { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Action> ActionCreatedByNavigation { get; set; }
        public virtual ICollection<Action> ActionUpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepositoryCreatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepositoryHistory> ApplicationRepositoryHistory { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepositoryUpdatedByNavigation { get; set; }
        public virtual ICollection<AuthDirectoryRepository> AuthDirectoryRepositoryAuthDirectory { get; set; }
        public virtual ICollection<AuthDirectoryRepository> AuthDirectoryRepositoryCreatedByNavigation { get; set; }
        public virtual ICollection<AuthDirectoryRepository> AuthDirectoryRepositoryUpdatedByNavigation { get; set; }
        public virtual ICollection<Component> ComponentCreatedByNavigation { get; set; }
        public virtual ICollection<ComponentHistory> ComponentHistory { get; set; }
        public virtual ICollection<ComponentHistoryType> ComponentHistoryTypeCreatedByNavigation { get; set; }
        public virtual ICollection<ComponentHistoryType> ComponentHistoryTypeUpdatedByNavigation { get; set; }
        public virtual ICollection<Component> ComponentUpdatedByNavigation { get; set; }
        public virtual ICollection<CreditProviderMerchant> CreditProviderMerchantCreatedByNavigation { get; set; }
        public virtual ICollection<CreditProviderMerchant> CreditProviderMerchantUpdatedByNavigation { get; set; }
        public virtual ICollection<Database> DatabaseAuthDirectory { get; set; }
        public virtual ICollection<DatabaseType> DatabaseTypeCreatedByNavigation { get; set; }
        public virtual ICollection<DatabaseType> DatabaseTypeUpdatedByNavigation { get; set; }
        public virtual ICollection<Database> DatabaseUpdatedByNavigation { get; set; }
        public virtual ICollection<Environment> EnvironmentAcpasuser { get; set; }
        public virtual ICollection<Environment> EnvironmentAdminUser { get; set; }
        public virtual ICollection<Environment> EnvironmentCompuscanUser { get; set; }
        public virtual ICollection<Environment> EnvironmentConnectMobileNiussduser { get; set; }
        public virtual ICollection<Environment> EnvironmentConnectMobileSmsuser { get; set; }
        public virtual ICollection<Environment> EnvironmentCreatedByNavigation { get; set; }
        public virtual ICollection<Environment> EnvironmentFirstEscalationUser { get; set; }
        public virtual ICollection<Environment> EnvironmentIntegrationUser { get; set; }
        public virtual ICollection<EnvironmentRepository> EnvironmentRepositoryCreatedByNavigation { get; set; }
        public virtual ICollection<EnvironmentRepository> EnvironmentRepositoryUpdatedByNavigation { get; set; }
        public virtual ICollection<Environment> EnvironmentSecondEscalationUser { get; set; }
        public virtual ICollection<Environment> EnvironmentServiceUser { get; set; }
        public virtual ICollection<Environment> EnvironmentSwitchPayUser { get; set; }
        public virtual ICollection<Environment> EnvironmentUpdatedByNavigation { get; set; }
        public virtual ICollection<Environment> EnvironmentVodacomUser { get; set; }
        public virtual ICollection<FinancialInstitution> FinancialInstitutionCreatedByNavigation { get; set; }
        public virtual ICollection<FinancialInstitution> FinancialInstitutionPrimaryUserNavigation { get; set; }
        public virtual ICollection<FinancialInstitution> FinancialInstitutionUpdatedByNavigation { get; set; }
        public virtual ICollection<AuthDirectory> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<AuthDirectory> InverseUpdatedByNavigation { get; set; }
        public virtual ICollection<Merchants> MerchantAuthDirectory { get; set; }
        public virtual ICollection<MerchantBankDetails> MerchantBankDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<MerchantBankDetails> MerchantBankDetailsUpdatedByNavigation { get; set; }
        public virtual ICollection<Merchants> MerchantCreatedByNavigation { get; set; }
        public virtual ICollection<MerchantDetails> MerchantDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<MerchantDetails> MerchantDetailsUpdatedByNavigation { get; set; }
        public virtual ICollection<MerchantHistory> MerchantHistory { get; set; }
        public virtual ICollection<MerchantHistoryType> MerchantHistoryTypeCreatedByNavigation { get; set; }
        public virtual ICollection<MerchantHistoryType> MerchantHistoryTypeUpdatedByNavigation { get; set; }
        public virtual ICollection<MerchantTerminal> MerchantTerminalCreatedByNavigation { get; set; }
        public virtual ICollection<MerchantTerminal> MerchantTerminalUpdatedByNavigation { get; set; }
        public virtual ICollection<Merchants> MerchantUpdatedByNavigation { get; set; }
        public virtual ICollection<Metric> MetricCreatedByNavigation { get; set; }
        public virtual ICollection<Metric> MetricUpdatedByNavigation { get; set; }
        public virtual ICollection<Otptype> OtptypeCreatedByNavigation { get; set; }
        public virtual ICollection<Otptype> OtptypeUpdatedByNavigation { get; set; }
        public virtual ICollection<ProductBand> ProductBandCreatedByNavigation { get; set; }
        public virtual ICollection<ProductBand> ProductBandUpdatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductUpdatedByNavigation { get; set; }
        public virtual ICollection<Repository> RepositoryAcpasuser { get; set; }
        public virtual ICollection<Repository> RepositoryAdminUser { get; set; }
        public virtual ICollection<Repository> RepositoryCompuscanUser { get; set; }
        public virtual ICollection<Repository> RepositoryConnectMobileNiussduser { get; set; }
        public virtual ICollection<Repository> RepositoryConnectMobileSmsuser { get; set; }
        public virtual ICollection<Repository> RepositoryCreatedByNavigation { get; set; }
        public virtual ICollection<Repository> RepositoryFirstEscalationUser { get; set; }
        public virtual ICollection<Repository> RepositoryIntegrationUser { get; set; }
        public virtual ICollection<Repository> RepositorySecondEscalationUser { get; set; }
        public virtual ICollection<Repository> RepositoryServiceUser { get; set; }
        public virtual ICollection<Repository> RepositorySwitchPayUser { get; set; }
        public virtual ICollection<Repository> RepositoryUpdatedByNavigation { get; set; }
        public virtual ICollection<Repository> RepositoryVodacomUser { get; set; }
        public virtual ICollection<TerminalMetric> TerminalMetricCreatedByNavigation { get; set; }
        public virtual ICollection<TerminalMetric> TerminalMetricUpdatedByNavigation { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProductCreatedByNavigation { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProductUpdatedByNavigation { get; set; }
        public virtual ICollection<TerminalType> TerminalTypeCreatedByNavigation { get; set; }
        public virtual ICollection<TerminalType> TerminalTypeUpdatedByNavigation { get; set; }
    }
}
