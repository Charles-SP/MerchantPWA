using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Merchant.Models
{
    public partial class StageRulesEngineContext : DbContext
    {
        public StageRulesEngineContext()
        {
        }

        public StageRulesEngineContext(DbContextOptions<StageRulesEngineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<ApplicationCreditProvider> ApplicationCreditProvider { get; set; }
        public virtual DbSet<ApplicationRepository> ApplicationRepository { get; set; }
        public virtual DbSet<ApplicationRepositoryHistory> ApplicationRepositoryHistory { get; set; }
        public virtual DbSet<ApplicationStats> ApplicationStats { get; set; }
        public virtual DbSet<AuditType> AuditType { get; set; }
        public virtual DbSet<AuthDirectory> AuthDirectory { get; set; }
        public virtual DbSet<AuthDirectoryRepository> AuthDirectoryRepository { get; set; }
        public virtual DbSet<BandType> BandType { get; set; }
        public virtual DbSet<Bureau> Bureau { get; set; }
        public virtual DbSet<BusinessSize> BusinessSize { get; set; }
        public virtual DbSet<BusinessStructure> BusinessStructure { get; set; }
        public virtual DbSet<Channel> Channel { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CollectionStatus> CollectionStatus { get; set; }
        public virtual DbSet<Component> Component { get; set; }
        public virtual DbSet<ComponentHistory> ComponentHistory { get; set; }
        public virtual DbSet<ComponentHistoryType> ComponentHistoryType { get; set; }
        public virtual DbSet<ContractTerm> ContractTerm { get; set; }
        public virtual DbSet<Cpstransactions> Cpstransactions { get; set; }
        public virtual DbSet<CreditProviderAuditType> CreditProviderAuditType { get; set; }
        public virtual DbSet<CreditProviderMerchant> CreditProviderMerchant { get; set; }
        public virtual DbSet<Database> Database { get; set; }
        public virtual DbSet<DatabaseType> DatabaseType { get; set; }
        public virtual DbSet<DebitOrder> DebitOrder { get; set; }
        public virtual DbSet<DebitOrderFile> DebitOrderFile { get; set; }
        public virtual DbSet<DebitOrderFileItems> DebitOrderFileItems { get; set; }
        public virtual DbSet<DebitOrderHistory> DebitOrderHistory { get; set; }
        public virtual DbSet<DebitOrderType> DebitOrderType { get; set; }
        public virtual DbSet<DeclineReason> DeclineReason { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<Environment> Environment { get; set; }
        public virtual DbSet<EnvironmentRepository> EnvironmentRepository { get; set; }
        public virtual DbSet<EnvironmentType> EnvironmentType { get; set; }
        public virtual DbSet<FieldCategory> FieldCategory { get; set; }
        public virtual DbSet<FieldCategoryEntity> FieldCategoryEntity { get; set; }
        public virtual DbSet<FieldDefinition> FieldDefinition { get; set; }
        public virtual DbSet<FieldDefinitionEntity> FieldDefinitionEntity { get; set; }
        public virtual DbSet<FieldOption> FieldOption { get; set; }
        public virtual DbSet<FieldType> FieldType { get; set; }
        public virtual DbSet<FinancialInstitution> FinancialInstitution { get; set; }
        public virtual DbSet<Footprint> Footprint { get; set; }
        public virtual DbSet<HistoryType> HistoryType { get; set; }
        public virtual DbSet<Importmerchant> Importmerchant { get; set; }
        public virtual DbSet<Industry> Industry { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Merchants> Merchant { get; set; }
        public virtual DbSet<MerchantBankDetails> MerchantBankDetails { get; set; }
        public virtual DbSet<MerchantDetails> MerchantDetails { get; set; }
        public virtual DbSet<MerchantFlags> MerchantFlags { get; set; }
        public virtual DbSet<MerchantHistory> MerchantHistory { get; set; }
        public virtual DbSet<MerchantHistoryType> MerchantHistoryType { get; set; }
        public virtual DbSet<MerchantMaster> MerchantMaster { get; set; }
        public virtual DbSet<MerchantMasterAudit> MerchantMasterAudit { get; set; }
        public virtual DbSet<MerchantProduct> MerchantProduct { get; set; }
        public virtual DbSet<MerchantSource> MerchantSource { get; set; }
        public virtual DbSet<MerchantTerminal> MerchantTerminal { get; set; }
        public virtual DbSet<Metric> Metric { get; set; }
        public virtual DbSet<NewMerchantTerminals> NewMerchantTerminals { get; set; }
        public virtual DbSet<NewMerchants> NewMerchants { get; set; }
        public virtual DbSet<Otp> Otp { get; set; }
        public virtual DbSet<Otptype> Otptype { get; set; }
        public virtual DbSet<Outcome> Outcome { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBand> ProductBand { get; set; }
        public virtual DbSet<ProductBandTerms> ProductBandTerms { get; set; }
        public virtual DbSet<ProductLinkGenerator> ProductLinkGenerator { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<ReasonFields> ReasonFields { get; set; }
        public virtual DbSet<ReasonTypes> ReasonTypes { get; set; }
        public virtual DbSet<Repository> Repository { get; set; }
        public virtual DbSet<RepositoryType> RepositoryType { get; set; }
        public virtual DbSet<SalesChannel> SalesChannel { get; set; }
        public virtual DbSet<Suburb> Suburb { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierUrl> SupplierUrl { get; set; }
        public virtual DbSet<TerminalDeactivation> TerminalDeactivation { get; set; }
        public virtual DbSet<TerminalMetric> TerminalMetric { get; set; }
        public virtual DbSet<TerminalProduct> TerminalProduct { get; set; }
        public virtual DbSet<TerminalType> TerminalType { get; set; }
        public virtual DbSet<TypeOfBusiness> TypeOfBusiness { get; set; }
        public virtual DbSet<TypeOfService> TypeOfService { get; set; }
        public virtual DbSet<UniversalBankCodes> UniversalBankCodes { get; set; }
        public virtual DbSet<Url> Url { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<WelcomeMail> WelcomeMail { get; set; }

        // Unable to generate entity type for table 'dbo.MerchantAccLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditType_backup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TimeOut_Rules'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Calender'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Import'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_ColourType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_ReportType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_Table'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OverideFSPRanges'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=db.switchpay.local; Database=StageRulesEngine; user id=switchpayadm; password=8HtYY53B!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.RaisesAlert).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ActionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Action_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ActionUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Action_AuthDirectory1");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ApplicationCreditProvider>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.DatabaseId })
                    .HasName("PK_ApplicationCreditProvider_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.Accepted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.Completed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Contracted).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.DateAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateContracted).HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDeclined).HasColumnType("datetime");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateLastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfferAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateOfferMade).HasColumnType("datetime");

                entity.Property(e => e.DateOfferRejected).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentReceived).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentUploaded).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentVerified).HasColumnType("datetime");

                entity.Property(e => e.DateRejected).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Declined).HasDefaultValueSql("((0))");

                entity.Property(e => e.Expired).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfferAccepted).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfferMade).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfferRejected).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentUploaded).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentVerified).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pending).HasDefaultValueSql("((1))");

                entity.Property(e => e.Rejected).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sent).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreditProvider)
                    .WithMany(p => p.ApplicationCreditProvider)
                    .HasForeignKey(d => d.CreditProviderId)
                    .HasConstraintName("FK_ApplicationCreditProvider_FinancialInstitution");

                entity.HasOne(d => d.Database)
                    .WithMany(p => p.ApplicationCreditProvider)
                    .HasForeignKey(d => d.DatabaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationCreditProvider_Database");
            });

            modelBuilder.Entity<ApplicationRepository>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.DatabaseId });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeclineReason).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.FinanceAmount).HasColumnType("money");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.FirstName).HasMaxLength(500);

                entity.Property(e => e.GrossIncome).HasColumnType("money");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Installment).HasColumnType("money");

                entity.Property(e => e.InternalAuditTypeId).HasColumnName("InternalAuditTypeID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAuthorised).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCollected).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsComplete).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeclined).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsExpired).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MerchantIdentifier).HasMaxLength(50);

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.NettIncome).HasColumnType("money");

                entity.Property(e => e.OfferAmount).HasColumnType("money");

                entity.Property(e => e.OfferInstallment).HasColumnType("money");

                entity.Property(e => e.Priority).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Surname).HasMaxLength(500);

                entity.Property(e => e.TerminalIdentifier).HasMaxLength(50);

                entity.Property(e => e.TerminalTypeId).HasColumnName("TerminalTypeID");

                entity.Property(e => e.Test).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AuditType)
                    .WithMany(p => p.ApplicationRepositoryAuditType)
                    .HasForeignKey(d => d.AuditTypeId)
                    .HasConstraintName("FK_ApplicationRepository_AuditType1");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ApplicationRepository)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_ApplicationRepository_Channel");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ApplicationRepositoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ApplicationRepository_AuthDirectory");

                entity.HasOne(d => d.CreditProvider)
                    .WithMany(p => p.ApplicationRepositoryCreditProvider)
                    .HasForeignKey(d => d.CreditProviderId)
                    .HasConstraintName("FK_ApplicationRepository_FinancialInstitution");

                entity.HasOne(d => d.EnvironmentRepository)
                    .WithMany(p => p.ApplicationRepository)
                    .HasForeignKey(d => d.EnvironmentRepositoryId)
                    .HasConstraintName("FK_ApplicationRepository_EnvironmentRepository");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.ApplicationRepositoryFinancialInstitution)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_ApplicationRepository_FinancialInstitution1");

                entity.HasOne(d => d.InternalAuditType)
                    .WithMany(p => p.ApplicationRepositoryInternalAuditType)
                    .HasForeignKey(d => d.InternalAuditTypeId)
                    .HasConstraintName("FK_ApplicationRepository_AuditType");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.ApplicationRepository)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_ApplicationRepository_Merchant");

                entity.HasOne(d => d.MerchantTerminal)
                    .WithMany(p => p.ApplicationRepository)
                    .HasForeignKey(d => d.MerchantTerminalId)
                    .HasConstraintName("FK_ApplicationRepository_MerchantTerminal");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ApplicationRepository)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ApplicationRepository_Product");

                entity.HasOne(d => d.TerminalType)
                    .WithMany(p => p.ApplicationRepository)
                    .HasForeignKey(d => d.TerminalTypeId)
                    .HasConstraintName("FK_ApplicationRepository_TerminalType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ApplicationRepositoryUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_ApplicationRepository_AuthDirectory1");
            });

            modelBuilder.Entity<ApplicationRepositoryHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ApplicationRepositoryHistory)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_ApplicationRepositoryHistory_Action");

                entity.HasOne(d => d.ActorNavigation)
                    .WithMany(p => p.ApplicationRepositoryHistory)
                    .HasForeignKey(d => d.Actor)
                    .HasConstraintName("FK_ApplicationRepositoryHistory_AuthDirectory");

                entity.HasOne(d => d.ApplicationRepository)
                    .WithMany(p => p.ApplicationRepositoryHistory)
                    .HasForeignKey(d => new { d.ApplicationId, d.DatabaseId })
                    .HasConstraintName("FK_ApplicationRepositoryHistory_ApplicationRepository");
            });

            modelBuilder.Entity<ApplicationStats>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accepted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Authorised).HasDefaultValueSql("((0))");

                entity.Property(e => e.BankChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.Captured).HasDefaultValueSql("((0))");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.Completed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Contracted).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.DateAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateAuthorised).HasColumnType("datetime");

                entity.Property(e => e.DateBankChecked).HasColumnType("datetime");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.DateCollected).HasColumnType("datetime");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateContracted).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeclined).HasColumnType("datetime");

                entity.Property(e => e.DateDisbursed).HasColumnType("datetime");

                entity.Property(e => e.DateDomandate)
                    .HasColumnName("DateDOMandate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateFirstDeclined).HasColumnType("datetime");

                entity.Property(e => e.DateFirstOfferAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateFirstOfferMade).HasColumnType("datetime");

                entity.Property(e => e.DateFirstOfferRejected).HasColumnType("datetime");

                entity.Property(e => e.DateFirstSentToBank).HasColumnType("datetime");

                entity.Property(e => e.DateLastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMarketing).HasColumnType("datetime");

                entity.Property(e => e.DateOfferAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateOfferMade).HasColumnType("datetime");

                entity.Property(e => e.DateOfferRejected).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentReceived).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentUploaded).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentVerified).HasColumnType("datetime");

                entity.Property(e => e.DateSentToBank).HasColumnType("datetime");

                entity.Property(e => e.DateTerms).HasColumnType("datetime");

                entity.Property(e => e.Declined).HasDefaultValueSql("((0))");

                entity.Property(e => e.Disbursed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Domandate)
                    .HasColumnName("DOMandate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Expired).HasDefaultValueSql("((0))");

                entity.Property(e => e.Marketing).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfferAccepted).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentUploaded).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentVerified).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pending).HasDefaultValueSql("((0))");

                entity.Property(e => e.SentToBank).HasDefaultValueSql("((0))");

                entity.Property(e => e.Terms).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AuditType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Approval).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Capitec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Cpdescription).HasColumnName("CPDescription");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Decline).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.Expire).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanzie).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nas)
                    .HasColumnName("NAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nedbank).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdateRulesEngine).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AuthDirectory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RemoteId).HasColumnName("RemoteID");

                entity.Property(e => e.RepositoryId).HasColumnName("RepositoryID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_AuthDirectory_AuthDirectory");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.AuthDirectory)
                    .HasForeignKey(d => d.RepositoryId)
                    .HasConstraintName("FK_AuthDirectory_Repository");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.InverseUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_AuthDirectory_AuthDirectory1");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.AuthDirectory)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthDirectory_UserType");
            });

            modelBuilder.Entity<AuthDirectoryRepository>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthDirectoryId).HasColumnName("AuthDirectoryID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemoteId).HasColumnName("RemoteID");

                entity.Property(e => e.RepositoryId).HasColumnName("RepositoryID");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AuthDirectory)
                    .WithMany(p => p.AuthDirectoryRepositoryAuthDirectory)
                    .HasForeignKey(d => d.AuthDirectoryId)
                    .HasConstraintName("FK_AuthDirectoryRepository_AuthDirectory2");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AuthDirectoryRepositoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_AuthDirectoryRepository_AuthDirectory");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.AuthDirectoryRepository)
                    .HasForeignKey(d => d.RepositoryId)
                    .HasConstraintName("FK_AuthDirectoryRepository_Repository");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.AuthDirectoryRepositoryUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_AuthDirectoryRepository_AuthDirectory1");
            });

            modelBuilder.Entity<BandType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Bureau>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CurrentObligations).HasColumnType("money");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.OutcomeId).HasColumnName("OutcomeID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<BusinessSize>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<BusinessStructure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Province");
            });

            modelBuilder.Entity<CollectionStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableName).HasMaxLength(150);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ComponentCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Component_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ComponentUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Component_AuthDirectory1");
            });

            modelBuilder.Entity<ComponentHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actor).HasDefaultValueSql("((1))");

                entity.Property(e => e.ComponentHistoryTypeId).HasColumnName("ComponentHistoryTypeID");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.DateActioned)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.Pkid).HasColumnName("PKID");

                entity.HasOne(d => d.ActorNavigation)
                    .WithMany(p => p.ComponentHistory)
                    .HasForeignKey(d => d.Actor)
                    .HasConstraintName("FK_History_History1");

                entity.HasOne(d => d.ComponentHistoryType)
                    .WithMany(p => p.ComponentHistory)
                    .HasForeignKey(d => d.ComponentHistoryTypeId)
                    .HasConstraintName("FK_ComponentHistory_ComponentHistoryType");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.ComponentHistory)
                    .HasForeignKey(d => d.ComponentId)
                    .HasConstraintName("FK_History_Component");
            });

            modelBuilder.Entity<ComponentHistoryType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ComponentHistoryTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_HistoryType_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ComponentHistoryTypeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_HistoryType_AuthDirectory1");
            });

            modelBuilder.Entity<ContractTerm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Cpstransactions>(entity =>
            {
                entity.ToTable("CPSTransactions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account).HasMaxLength(50);

                entity.Property(e => e.AccountAvailableBalance).HasMaxLength(50);

                entity.Property(e => e.AccountBookBalance).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Channel).HasMaxLength(30);

                entity.Property(e => e.Cisnumber)
                    .HasColumnName("CISNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.DebitCredit).HasMaxLength(50);

                entity.Property(e => e.DestinationKey).HasMaxLength(50);

                entity.Property(e => e.InstanceName).HasMaxLength(50);

                entity.Property(e => e.InstanceNumber).HasMaxLength(40);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessKey).HasMaxLength(50);

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.ProfileNumber).HasMaxLength(50);

                entity.Property(e => e.ResendKey).HasMaxLength(50);

                entity.Property(e => e.StatementDate).HasMaxLength(8);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.TranType).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasMaxLength(50);

                entity.Property(e => e.TransactionKey).HasMaxLength(50);

                entity.Property(e => e.UserRef).HasMaxLength(50);
            });

            modelBuilder.Entity<CreditProviderAuditType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CreditProviderMerchant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CreditProviderMerchantCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_CreditProviderMerchant_AuthDirectory");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.CreditProviderMerchant)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_CreditProviderMerchant_FinancialInstitution");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.CreditProviderMerchant)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_CreditProviderMerchant_Merchant");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.CreditProviderMerchantUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_CreditProviderMerchant_AuthDirectory1");
            });

            modelBuilder.Entity<Database>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthDirectoryId).HasColumnName("AuthDirectoryID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DatabaseTypeId).HasColumnName("DatabaseTypeID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dbname)
                    .HasColumnName("DBName")
                    .HasMaxLength(500);

                entity.Property(e => e.Dns)
                    .HasColumnName("DNS")
                    .HasMaxLength(500);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AuthDirectory)
                    .WithMany(p => p.DatabaseAuthDirectory)
                    .HasForeignKey(d => d.AuthDirectoryId)
                    .HasConstraintName("FK_Database_AuthDirectory1");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.DatabaseUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Database_AuthDirectory2");
            });

            modelBuilder.Entity<DatabaseType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DatabaseTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_DatabaseType_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.DatabaseTypeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_DatabaseType_AuthDirectory1");
            });

            modelBuilder.Entity<DebitOrder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountHolder).HasMaxLength(500);

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Bank).HasMaxLength(500);

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DebitOrderTypeId).HasColumnName("DebitOrderTypeID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.Requested).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Successful).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.DebitOrderType)
                    .WithMany(p => p.DebitOrder)
                    .HasForeignKey(d => d.DebitOrderTypeId)
                    .HasConstraintName("FK_DebitOrder_DebitOrderType");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.DebitOrder)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_DebitOrder_Merchant");

                entity.HasOne(d => d.MerchantTerminal)
                    .WithMany(p => p.DebitOrder)
                    .HasForeignKey(d => d.MerchantTerminalId)
                    .HasConstraintName("FK_DebitOrder_MerchantTerminal");
            });

            modelBuilder.Entity<DebitOrderFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DebitDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<DebitOrderFileItems>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DebitOrderFileId).HasColumnName("DebitOrderFileID");

                entity.Property(e => e.DebitOrderHistoryId).HasColumnName("DebitOrderHistoryID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.DebitOrderFile)
                    .WithMany(p => p.DebitOrderFileItems)
                    .HasForeignKey(d => d.DebitOrderFileId)
                    .HasConstraintName("FK_DebitOrderFileItems_DebitOrderFile");

                entity.HasOne(d => d.DebitOrderHistory)
                    .WithMany(p => p.DebitOrderFileItems)
                    .HasForeignKey(d => d.DebitOrderHistoryId)
                    .HasConstraintName("FK_DebitOrderFileItems_DebitOrderHistory");
            });

            modelBuilder.Entity<DebitOrderHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountHolder).HasMaxLength(500);

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AwaitingRelease).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bank).HasMaxLength(500);

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.DatePrepared).HasColumnType("datetime");

                entity.Property(e => e.DateReleased).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebitDate).HasColumnType("datetime");

                entity.Property(e => e.DebitOrderId).HasColumnName("DebitOrderID");

                entity.Property(e => e.DebitOrderTypeId).HasColumnName("DebitOrderTypeID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.Released).HasDefaultValueSql("((0))");

                entity.Property(e => e.Switchpay).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DebitOrder)
                    .WithMany(p => p.DebitOrderHistory)
                    .HasForeignKey(d => d.DebitOrderId)
                    .HasConstraintName("FK_DebitOrderHistory_DebitOrder");

                entity.HasOne(d => d.DebitOrderType)
                    .WithMany(p => p.DebitOrderHistory)
                    .HasForeignKey(d => d.DebitOrderTypeId)
                    .HasConstraintName("FK_DebitOrderHistory_DebitOrderType");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.DebitOrderHistory)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_DebitOrderHistory_Merchant");

                entity.HasOne(d => d.MerchantTerminal)
                    .WithMany(p => p.DebitOrderHistory)
                    .HasForeignKey(d => d.MerchantTerminalId)
                    .HasConstraintName("FK_DebitOrderHistory_MerchantTerminal");

                entity.HasOne(d => d.ApplicationRepository)
                    .WithMany(p => p.DebitOrderHistory)
                    .HasForeignKey(d => new { d.ApplicationId, d.DatabaseId })
                    .HasConstraintName("FK_DebitOrderHistory_ApplicationRepository");
            });

            modelBuilder.Entity<DebitOrderType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<DeclineReason>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Environment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acpasurlid).HasColumnName("ACPASURLID");

                entity.Property(e => e.AcpasuserId).HasColumnName("ACPASUserID");

                entity.Property(e => e.AdminUserId)
                    .HasColumnName("AdminUserID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.Apiurlid).HasColumnName("APIURLID");

                entity.Property(e => e.CompuScanUrlid).HasColumnName("CompuScanURLID");

                entity.Property(e => e.CompuscanUserId).HasColumnName("CompuscanUserID");

                entity.Property(e => e.ConnectMobileNiussdurlid).HasColumnName("ConnectMobileNIUSSDURLID");

                entity.Property(e => e.ConnectMobileNiussduserId).HasColumnName("ConnectMobileNIUSSDUserID");

                entity.Property(e => e.ConnectMobileSmsurlid).HasColumnName("ConnectMobileSMSURLID");

                entity.Property(e => e.ConnectMobileSmsuserId).HasColumnName("ConnectMobileSMSUserID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultAmount).HasColumnType("money");

                entity.Property(e => e.DefaultIdno)
                    .HasColumnName("DefaultIDNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultMobile).HasMaxLength(50);

                entity.Property(e => e.DefaultOtp)
                    .HasColumnName("DefaultOTP")
                    .HasMaxLength(10);

                entity.Property(e => e.EnvironmentTypeId).HasColumnName("EnvironmentTypeID");

                entity.Property(e => e.ExternalWebApiurlid).HasColumnName("ExternalWebAPIURLID");

                entity.Property(e => e.FirstEscalationUserId)
                    .HasColumnName("FirstEscalationUserID")
                    .HasDefaultValueSql("((17))");

                entity.Property(e => e.ImagesUrlid).HasColumnName("ImagesURLID");

                entity.Property(e => e.IntegrationUserId)
                    .HasColumnName("IntegrationUserID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.InternalWebApiurlid).HasColumnName("InternalWebAPIURLID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MainDatabaseId).HasColumnName("MainDatabaseID");

                entity.Property(e => e.MainEnvironmentId).HasColumnName("MainEnvironmentID");

                entity.Property(e => e.MainRepositoryId).HasColumnName("MainRepositoryID");

                entity.Property(e => e.PortalUrlid).HasColumnName("PortalURLID");

                entity.Property(e => e.RulesEngineDbid).HasColumnName("RulesEngineDBID");

                entity.Property(e => e.SecondEscalationUserId)
                    .HasColumnName("SecondEscalationUserID")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.SecondaryProcessUrlid).HasColumnName("SecondaryProcessURLID");

                entity.Property(e => e.ServiceUserId)
                    .HasColumnName("ServiceUserID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.SwitchPayUserId)
                    .HasColumnName("SwitchPayUserID")
                    .HasDefaultValueSql("((16))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.Urlprefix)
                    .HasColumnName("URLPrefix")
                    .HasMaxLength(50);

                entity.Property(e => e.Ussdurlid).HasColumnName("USSDURLID");

                entity.Property(e => e.VodacomHttpurlid).HasColumnName("VodacomHTTPURLID");

                entity.Property(e => e.VodacomResturlid).HasColumnName("VodacomRESTURLID");

                entity.Property(e => e.VodacomSoapurlid).HasColumnName("VodacomSOAPURLID");

                entity.Property(e => e.VodacomUserId).HasColumnName("VodacomUserID");

                entity.Property(e => e.WebLinkUrlid).HasColumnName("WebLinkURLID");

                entity.HasOne(d => d.Acpasurl)
                    .WithMany(p => p.EnvironmentAcpasurl)
                    .HasForeignKey(d => d.Acpasurlid)
                    .HasConstraintName("FK_Environment_URL8");

                entity.HasOne(d => d.Acpasuser)
                    .WithMany(p => p.EnvironmentAcpasuser)
                    .HasForeignKey(d => d.AcpasuserId)
                    .HasConstraintName("FK_Environment_AuthDirectory8");

                entity.HasOne(d => d.AdminUser)
                    .WithMany(p => p.EnvironmentAdminUser)
                    .HasForeignKey(d => d.AdminUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory");

                entity.HasOne(d => d.Apiurl)
                    .WithMany(p => p.EnvironmentApiurl)
                    .HasForeignKey(d => d.Apiurlid)
                    .HasConstraintName("FK_Environment_URL");

                entity.HasOne(d => d.CompuScanUrl)
                    .WithMany(p => p.EnvironmentCompuScanUrl)
                    .HasForeignKey(d => d.CompuScanUrlid)
                    .HasConstraintName("FK_Environment_URL9");

                entity.HasOne(d => d.CompuscanUser)
                    .WithMany(p => p.EnvironmentCompuscanUser)
                    .HasForeignKey(d => d.CompuscanUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory10");

                entity.HasOne(d => d.ConnectMobileNiussdurl)
                    .WithMany(p => p.EnvironmentConnectMobileNiussdurl)
                    .HasForeignKey(d => d.ConnectMobileNiussdurlid)
                    .HasConstraintName("FK_Environment_URL13");

                entity.HasOne(d => d.ConnectMobileNiussduser)
                    .WithMany(p => p.EnvironmentConnectMobileNiussduser)
                    .HasForeignKey(d => d.ConnectMobileNiussduserId)
                    .HasConstraintName("FK_Environment_AuthDirectory12");

                entity.HasOne(d => d.ConnectMobileSmsurl)
                    .WithMany(p => p.EnvironmentConnectMobileSmsurl)
                    .HasForeignKey(d => d.ConnectMobileSmsurlid)
                    .HasConstraintName("FK_Environment_URL15");

                entity.HasOne(d => d.ConnectMobileSmsuser)
                    .WithMany(p => p.EnvironmentConnectMobileSmsuser)
                    .HasForeignKey(d => d.ConnectMobileSmsuserId)
                    .HasConstraintName("FK_Environment_AuthDirectory13");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EnvironmentCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Environment_AuthDirectory1");

                entity.HasOne(d => d.EnvironmentType)
                    .WithMany(p => p.Environment)
                    .HasForeignKey(d => d.EnvironmentTypeId)
                    .HasConstraintName("FK_Environment_EnvironmentType");

                entity.HasOne(d => d.ExternalWebApiurl)
                    .WithMany(p => p.EnvironmentExternalWebApiurl)
                    .HasForeignKey(d => d.ExternalWebApiurlid)
                    .HasConstraintName("FK_Environment_URL1");

                entity.HasOne(d => d.FirstEscalationUser)
                    .WithMany(p => p.EnvironmentFirstEscalationUser)
                    .HasForeignKey(d => d.FirstEscalationUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory2");

                entity.HasOne(d => d.ImagesUrl)
                    .WithMany(p => p.EnvironmentImagesUrl)
                    .HasForeignKey(d => d.ImagesUrlid)
                    .HasConstraintName("FK_Environment_URL2");

                entity.HasOne(d => d.IntegrationUser)
                    .WithMany(p => p.EnvironmentIntegrationUser)
                    .HasForeignKey(d => d.IntegrationUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory3");

                entity.HasOne(d => d.InternalWebApiurl)
                    .WithMany(p => p.EnvironmentInternalWebApiurl)
                    .HasForeignKey(d => d.InternalWebApiurlid)
                    .HasConstraintName("FK_Environment_URL3");

                entity.HasOne(d => d.MainDatabase)
                    .WithMany(p => p.EnvironmentMainDatabase)
                    .HasForeignKey(d => d.MainDatabaseId)
                    .HasConstraintName("FK_Environment_Database");

                entity.HasOne(d => d.MainEnvironment)
                    .WithMany(p => p.InverseMainEnvironment)
                    .HasForeignKey(d => d.MainEnvironmentId)
                    .HasConstraintName("FK_Environment_Environment");

                entity.HasOne(d => d.MainRepository)
                    .WithMany(p => p.Environment)
                    .HasForeignKey(d => d.MainRepositoryId)
                    .HasConstraintName("FK_Environment_Repository");

                entity.HasOne(d => d.PortalUrl)
                    .WithMany(p => p.EnvironmentPortalUrl)
                    .HasForeignKey(d => d.PortalUrlid)
                    .HasConstraintName("FK_Environment_URL4");

                entity.HasOne(d => d.RulesEngineDb)
                    .WithMany(p => p.EnvironmentRulesEngineDb)
                    .HasForeignKey(d => d.RulesEngineDbid)
                    .HasConstraintName("FK_Environment_Database1");

                entity.HasOne(d => d.SecondEscalationUser)
                    .WithMany(p => p.EnvironmentSecondEscalationUser)
                    .HasForeignKey(d => d.SecondEscalationUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory4");

                entity.HasOne(d => d.SecondaryProcessUrl)
                    .WithMany(p => p.EnvironmentSecondaryProcessUrl)
                    .HasForeignKey(d => d.SecondaryProcessUrlid)
                    .HasConstraintName("FK_Environment_URL5");

                entity.HasOne(d => d.ServiceUser)
                    .WithMany(p => p.EnvironmentServiceUser)
                    .HasForeignKey(d => d.ServiceUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory5");

                entity.HasOne(d => d.SwitchPayUser)
                    .WithMany(p => p.EnvironmentSwitchPayUser)
                    .HasForeignKey(d => d.SwitchPayUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory6");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.EnvironmentUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Environment_AuthDirectory7");

                entity.HasOne(d => d.Ussdurl)
                    .WithMany(p => p.EnvironmentUssdurl)
                    .HasForeignKey(d => d.Ussdurlid)
                    .HasConstraintName("FK_Environment_URL6");

                entity.HasOne(d => d.VodacomHttpurl)
                    .WithMany(p => p.EnvironmentVodacomHttpurl)
                    .HasForeignKey(d => d.VodacomHttpurlid)
                    .HasConstraintName("FK_Environment_URL10");

                entity.HasOne(d => d.VodacomResturl)
                    .WithMany(p => p.EnvironmentVodacomResturl)
                    .HasForeignKey(d => d.VodacomResturlid)
                    .HasConstraintName("FK_Environment_URL11");

                entity.HasOne(d => d.VodacomSoapurl)
                    .WithMany(p => p.EnvironmentVodacomSoapurl)
                    .HasForeignKey(d => d.VodacomSoapurlid)
                    .HasConstraintName("FK_Environment_URL12");

                entity.HasOne(d => d.VodacomUser)
                    .WithMany(p => p.EnvironmentVodacomUser)
                    .HasForeignKey(d => d.VodacomUserId)
                    .HasConstraintName("FK_Environment_AuthDirectory9");

                entity.HasOne(d => d.WebLinkUrl)
                    .WithMany(p => p.EnvironmentWebLinkUrl)
                    .HasForeignKey(d => d.WebLinkUrlid)
                    .HasConstraintName("FK_Environment_URL7");
            });

            modelBuilder.Entity<EnvironmentRepository>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnvironmentId).HasColumnName("EnvironmentID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.RepositoryId).HasColumnName("RepositoryID");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EnvironmentRepositoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_EnvironmentRepository_AuthDirectory");

                entity.HasOne(d => d.Environment)
                    .WithMany(p => p.EnvironmentRepository)
                    .HasForeignKey(d => d.EnvironmentId)
                    .HasConstraintName("FK_EnvironmentRepository_Environment");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.EnvironmentRepository)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_EnvironmentRepository_FinancialInstitution");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.EnvironmentRepository)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_EnvironmentRepository_Merchant");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.EnvironmentRepository)
                    .HasForeignKey(d => d.RepositoryId)
                    .HasConstraintName("FK_EnvironmentRepository_Repository");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.EnvironmentRepositoryUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_EnvironmentRepository_AuthDirectory1");
            });

            modelBuilder.Entity<EnvironmentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FieldCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<FieldCategoryEntity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FieldCategoryId).HasColumnName("FieldCategoryID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.FieldCategory)
                    .WithMany(p => p.FieldCategoryEntity)
                    .HasForeignKey(d => d.FieldCategoryId)
                    .HasConstraintName("FK_FieldCategoryEntity_FieldCategory");
            });

            modelBuilder.Entity<FieldDefinition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultValue).HasMaxLength(500);

                entity.Property(e => e.FieldCategoryId).HasColumnName("FieldCategoryID");

                entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegEx).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.FieldCategory)
                    .WithMany(p => p.FieldDefinition)
                    .HasForeignKey(d => d.FieldCategoryId)
                    .HasConstraintName("FK_FieldDefinition_FieldCategory");

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.FieldDefinition)
                    .HasForeignKey(d => d.FieldTypeId)
                    .HasConstraintName("FK_FieldDefinition_FieldType");
            });

            modelBuilder.Entity<FieldDefinitionEntity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(500);

                entity.Property(e => e.FieldCategoryId).HasColumnName("FieldCategoryID");

                entity.Property(e => e.FieldDefinitionId).HasColumnName("FieldDefinitionID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.RegEx).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.FieldCategory)
                    .WithMany(p => p.FieldDefinitionEntity)
                    .HasForeignKey(d => d.FieldCategoryId)
                    .HasConstraintName("FK_FieldDefinitionEntity_FieldCategory");

                entity.HasOne(d => d.FieldDefinition)
                    .WithMany(p => p.FieldDefinitionEntity)
                    .HasForeignKey(d => d.FieldDefinitionId)
                    .HasConstraintName("FK_FieldDefinitionEntity_FieldDefinition");
            });

            modelBuilder.Entity<FieldOption>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FieldDefinitionId).HasColumnName("FieldDefinitionID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.FieldDefinition)
                    .WithMany(p => p.FieldOption)
                    .HasForeignKey(d => d.FieldDefinitionId)
                    .HasConstraintName("FK_FieldOption_FieldDefinition");
            });

            modelBuilder.Entity<FieldType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<FinancialInstitution>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.IdforBankList).HasColumnName("IDForBankList");

                entity.Property(e => e.IdforTerminal).HasColumnName("IDForTerminal");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCreditProvider).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOnBankList).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOnTerminalList).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RangeMax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RangeMin).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FinancialInstitutionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_FinancialInstitution_AuthDirectory");

                entity.HasOne(d => d.PrimaryUserNavigation)
                    .WithMany(p => p.FinancialInstitutionPrimaryUserNavigation)
                    .HasForeignKey(d => d.PrimaryUser)
                    .HasConstraintName("FK_FinancialInstitution_AuthDirectory2");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.FinancialInstitutionUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_FinancialInstitution_AuthDirectory1");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.FinancialInstitution)
                    .HasForeignKey(d => d.Urlid)
                    .HasConstraintName("FK_FinancialInstitution_URL");
            });

            modelBuilder.Entity<Footprint>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HistoryType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CausesNotification).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.IsBankStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<Importmerchant>(entity =>
            {
                entity.ToTable("importmerchant");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountHolderName).HasMaxLength(255);

                entity.Property(e => e.AccountNumber).HasMaxLength(255);

                entity.Property(e => e.AcquiringBank).HasMaxLength(255);

                entity.Property(e => e.ActivationAmount).HasColumnType("money");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.ActivationFee).HasDefaultValueSql("((1))");

                entity.Property(e => e.AdditionalValueAdded).HasMaxLength(2000);

                entity.Property(e => e.Agent).HasMaxLength(500);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.Bank).HasMaxLength(255);

                entity.Property(e => e.BillingEmail).HasMaxLength(500);

                entity.Property(e => e.BillingFirstName).HasMaxLength(255);

                entity.Property(e => e.BillingLastName).HasMaxLength(255);

                entity.Property(e => e.BillingMobile).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.BranchNumber).HasMaxLength(255);

                entity.Property(e => e.BusinessStructure).HasMaxLength(255);

                entity.Property(e => e.CompanyEmail).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebitOrderReference).HasMaxLength(255);

                entity.Property(e => e.Designation).HasMaxLength(255);

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.EftdeviceSupplier)
                    .HasColumnName("EFTDeviceSupplier")
                    .HasMaxLength(255);

                entity.Property(e => e.Eftpos)
                    .HasColumnName("EFTPOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eftposamount)
                    .HasColumnName("EFTPOSAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Eftposdate)
                    .HasColumnName("EFTPOSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eftposperiod).HasColumnName("EFTPOSPeriod");

                entity.Property(e => e.EftvaslayerSerialNumber)
                    .HasColumnName("EFTVASLayerSerialNumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.EntityType).HasMaxLength(255);

                entity.Property(e => e.FaxNumber).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Footprint).HasMaxLength(255);

                entity.Property(e => e.HearAboutSp)
                    .HasColumnName("HearAboutSP")
                    .HasMaxLength(255);

                entity.Property(e => e.HearOther).HasMaxLength(255);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPostalDifferent).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTrusteeJuristicPerson).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LayBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.LayByAmount).HasColumnType("money");

                entity.Property(e => e.LayByDate).HasColumnType("datetime");

                entity.Property(e => e.Lbmfee)
                    .HasColumnName("LBMFee")
                    .HasColumnType("money");

                entity.Property(e => e.MerchantCommission).HasColumnType("money");

                entity.Property(e => e.MerchantLaybyDeposit).HasColumnType("money");

                entity.Property(e => e.MerchantLogo).HasColumnType("image");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.NonEftdevicePeriod).HasColumnName("NonEFTDevicePeriod");

                entity.Property(e => e.NonEftdevuceDate)
                    .HasColumnName("NonEFTDevuceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NonEmvdevice)
                    .HasColumnName("NonEMVDevice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NonEmvdeviceAmount)
                    .HasColumnName("NonEMVDeviceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.OtherEntity).HasMaxLength(500);

                entity.Property(e => e.ParentMerchant).HasMaxLength(50);

                entity.Property(e => e.ParentMerchantBankDetails).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentMerchantId).HasColumnName("ParentMerchantID");

                entity.Property(e => e.Pblm)
                    .HasColumnName("PBLM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pblmamount)
                    .HasColumnName("PBLMAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Pblmdate)
                    .HasColumnName("PBLMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pblmfee)
                    .HasColumnName("PBLMFee")
                    .HasColumnType("money");

                entity.Property(e => e.Pblmperiod).HasColumnName("PBLMPeriod");

                entity.Property(e => e.PblserialNumber)
                    .HasColumnName("PBLSerialNumber")
                    .HasMaxLength(255);

                entity.Property(e => e.PhysicalCity).HasMaxLength(255);

                entity.Property(e => e.PhysicalCode).HasMaxLength(255);

                entity.Property(e => e.PhysicalProvince).HasMaxLength(255);

                entity.Property(e => e.PhysicalSuburb).HasMaxLength(255);

                entity.Property(e => e.PostalCity).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.PostalProvince).HasMaxLength(255);

                entity.Property(e => e.PostalSuburb).HasMaxLength(255);

                entity.Property(e => e.PrimaryContactNumber).HasMaxLength(255);

                entity.Property(e => e.PrimaryContactPerson).HasMaxLength(255);

                entity.Property(e => e.PrimaryEmail).HasMaxLength(255);

                entity.Property(e => e.PrimaryLastName).HasMaxLength(255);

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reference).HasMaxLength(500);

                entity.Property(e => e.RegisteredName).HasMaxLength(255);

                entity.Property(e => e.RegisteredNumber).HasMaxLength(255);

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.SalesChannel).HasMaxLength(500);

                entity.Property(e => e.TelNumber).HasMaxLength(255);

                entity.Property(e => e.Term8).HasMaxLength(255);

                entity.Property(e => e.Term9).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.TotalBranches).HasMaxLength(255);

                entity.Property(e => e.Transferred).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeOfAccount).HasMaxLength(500);

                entity.Property(e => e.TypeOfBusiness).HasMaxLength(255);

                entity.Property(e => e.TypeOfProductService).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(1000);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(500);
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActNo).HasMaxLength(50);

                entity.Property(e => e.ActivationAmount).HasMaxLength(50);

                entity.Property(e => e.ActivationText).HasMaxLength(500);

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateGenerated).HasMaxLength(50);

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DebitOrderFileId).HasColumnName("DebitOrderFileID");

                entity.Property(e => e.DebitOrderHistoryId).HasColumnName("DebitOrderHistoryID");

                entity.Property(e => e.Generated).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName).HasMaxLength(500);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(500);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.SubTotal).HasMaxLength(50);

                entity.Property(e => e.SubsAmount).HasMaxLength(50);

                entity.Property(e => e.SubsNo).HasMaxLength(50);

                entity.Property(e => e.SubsText).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(50);

                entity.Property(e => e.VatNo).HasMaxLength(50);

                entity.HasOne(d => d.DebitOrderFile)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.DebitOrderFileId)
                    .HasConstraintName("FK_Invoice_DebitOrderFile");

                entity.HasOne(d => d.DebitOrderHistory)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.DebitOrderHistoryId)
                    .HasConstraintName("FK_Invoice_DebitOrderHistory");
            });

            modelBuilder.Entity<Merchants>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AuthDirectoryId).HasColumnName("AuthDirectoryID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultAmount).HasColumnType("money");

                entity.Property(e => e.DefaultIdno)
                    .HasColumnName("DefaultIDNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultMobile).HasMaxLength(50);

                entity.Property(e => e.DefaultOtp)
                    .HasColumnName("DefaultOTP")
                    .HasMaxLength(10);

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.ParentMerchantId).HasColumnName("ParentMerchantID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.RegisteredNumber).HasMaxLength(50);

                entity.Property(e => e.SalesChannelId).HasColumnName("SalesChannelID");

                entity.Property(e => e.ShortName).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TypeOfBusinessId).HasColumnName("TypeOfBusinessID");

                entity.Property(e => e.TypeOfBusinessOther).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Merchant)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_Merchant_Agent");

                entity.HasOne(d => d.AuthDirectory)
                    .WithMany(p => p.MerchantAuthDirectory)
                    .HasForeignKey(d => d.AuthDirectoryId)
                    .HasConstraintName("FK_Merchant_AuthDirectory2");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MerchantCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Merchant_AuthDirectory");

                entity.HasOne(d => d.EnvironmentRepositoryNavigation)
                    .WithMany(p => p.MerchantNavigation)
                    .HasForeignKey(d => d.EnvironmentRepositoryId)
                    .HasConstraintName("FK_Merchant_EnvironmentRepository");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.Merchant)
                    .HasForeignKey(d => d.IndustryId)
                    .HasConstraintName("FK_Merchant_Industry");

                entity.HasOne(d => d.ParentMerchant)
                    .WithMany(p => p.InverseParentMerchant)
                    .HasForeignKey(d => d.ParentMerchantId)
                    .HasConstraintName("FK_Merchant_Merchant");

                entity.HasOne(d => d.SalesChannel)
                    .WithMany(p => p.Merchant)
                    .HasForeignKey(d => d.SalesChannelId)
                    .HasConstraintName("FK_Merchant_SalesChannel");

                entity.HasOne(d => d.TypeOfBusiness)
                    .WithMany(p => p.Merchant)
                    .HasForeignKey(d => d.TypeOfBusinessId)
                    .HasConstraintName("FK_Merchant_TypeOfBusiness");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MerchantUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Merchant_AuthDirectory1");
            });

            modelBuilder.Entity<MerchantBankDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.BankBranch).HasMaxLength(150);

                entity.Property(e => e.BranchNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebitOrderReference).HasMaxLength(50);

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.UseParent).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.MerchantBankDetails)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_MerchantBankDetails_AccountType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MerchantBankDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MerchantBankDetails_AuthDirectory");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.MerchantBankDetails)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_MerchantBankDetails_FinancialInstitution");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantBankDetails)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_MerchantBankDetails_Merchant");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MerchantBankDetailsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_MerchantBankDetails_AuthDirectory1");
            });

            modelBuilder.Entity<MerchantDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.ActivationFee).HasColumnType("money");

                entity.Property(e => e.AllTerminals).HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.BillingEmail).HasMaxLength(500);

                entity.Property(e => e.BillingFirstName).HasMaxLength(50);

                entity.Property(e => e.BillingPhone).HasMaxLength(10);

                entity.Property(e => e.BillingSurname).HasMaxLength(50);

                entity.Property(e => e.BusinessSizeId).HasColumnName("BusinessSizeID");

                entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");

                entity.Property(e => e.CompanyEmail).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FootprintId).HasColumnName("FootprintID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsJuristicPerson).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPostalDifferent).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MerchantSourceId).HasColumnName("MerchantSourceID");

                entity.Property(e => e.MerchantSourceOther).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhysicalAddress).HasMaxLength(500);

                entity.Property(e => e.PhysicalCity).HasMaxLength(150);

                entity.Property(e => e.PhysicalCode).HasMaxLength(10);

                entity.Property(e => e.PhysicalProvince).HasMaxLength(50);

                entity.Property(e => e.PhysicalSuburb).HasMaxLength(250);

                entity.Property(e => e.PostalAddress).HasMaxLength(500);

                entity.Property(e => e.PostalCity).HasMaxLength(150);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PostalProvince).HasMaxLength(50);

                entity.Property(e => e.PostalSuburb).HasMaxLength(250);

                entity.Property(e => e.PrimaryEmail).HasMaxLength(500);

                entity.Property(e => e.PrimaryName).HasMaxLength(500);

                entity.Property(e => e.PrimaryPhone).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.TypeOfServiceId).HasColumnName("TypeOfServiceID");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Website).HasMaxLength(500);

                entity.HasOne(d => d.BusinessSize)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.BusinessSizeId)
                    .HasConstraintName("FK_MerchantDetails_BusinessSize");

                entity.HasOne(d => d.BusinessStructure)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.BusinessStructureId)
                    .HasConstraintName("FK_MerchantDetails_BusinessStructure");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MerchantDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MerchantDetails_AuthDirectory");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_MerchantDetails_Designation");

                entity.HasOne(d => d.Footprint)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.FootprintId)
                    .HasConstraintName("FK_MerchantDetails_Footprint");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.MerchantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MerchantDetails_Merchant");

                entity.HasOne(d => d.MerchantSource)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.MerchantSourceId)
                    .HasConstraintName("FK_MerchantDetails_MerchantSource");

                entity.HasOne(d => d.TypeOfService)
                    .WithMany(p => p.MerchantDetails)
                    .HasForeignKey(d => d.TypeOfServiceId)
                    .HasConstraintName("FK_MerchantDetails_TypeOfService");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MerchantDetailsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_MerchantDetails_MerchantDetails");
            });

            modelBuilder.Entity<MerchantFlags>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerchantHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateActioned)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.MerchantHistoryTypeId).HasColumnName("MerchantHistoryTypeID");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.HasOne(d => d.ActorNavigation)
                    .WithMany(p => p.MerchantHistory)
                    .HasForeignKey(d => d.Actor)
                    .HasConstraintName("FK_MerchantHistory_AuthDirectory");

                entity.HasOne(d => d.MerchantHistoryType)
                    .WithMany(p => p.MerchantHistory)
                    .HasForeignKey(d => d.MerchantHistoryTypeId)
                    .HasConstraintName("FK_MerchantHistory_MerchantHistory");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantHistory)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_MerchantHistory_Merchant");

                entity.HasOne(d => d.MerchantTerminal)
                    .WithMany(p => p.MerchantHistory)
                    .HasForeignKey(d => d.MerchantTerminalId)
                    .HasConstraintName("FK_MerchantHistory_MerchantTerminal");
            });

            modelBuilder.Entity<MerchantHistoryType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MerchantHistoryTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MHistoryType_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MerchantHistoryTypeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_MHistoryType_AuthDirectory1");
            });

            modelBuilder.Entity<MerchantMaster>(entity =>
            {
                entity.Property(e => e.AccountHolder)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompEntityName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompRegNo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceCommRate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FinanceSubscrFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.GroupMerchRef)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LaybyCommRate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LaybySubscrFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Midref)
                    .IsRequired()
                    .HasColumnName("MIDRef")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StoreDisplayName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradingName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerchantMasterAudit>(entity =>
            {
                entity.Property(e => e.AccountHolder)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditAction)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompEntityName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompRegNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceCommRate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FinanceSubscrFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.GroupMerchRef)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LaybyCommRate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LaybySubscrFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Midref)
                    .HasColumnName("MIDRef")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StoreDisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerchantProduct>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MerchantId)
                    .HasColumnName("MerchantID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MerchantProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MerchantP__Produ__09CA388A");

                entity.HasOne(d => d.Sp)
                    .WithMany(p => p.MerchantProduct)
                    .HasForeignKey(d => d.Spid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MerchantPr__SPID__08D61451");
            });

            modelBuilder.Entity<MerchantSource>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MerchantTerminal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.ContractTermId).HasColumnName("ContractTermID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Eftvasserial)
                    .HasColumnName("EFTVASSerial")
                    .HasMaxLength(255);

                entity.Property(e => e.Emvposamount)
                    .HasColumnName("EMVPOSAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Emvposdate)
                    .HasColumnName("EMVPOSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Emvposperiod).HasColumnName("EMVPOSPeriod");

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActivation).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEftpos)
                    .HasColumnName("IsEFTPOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLayBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNonEftdevice)
                    .HasColumnName("IsNonEFTDevice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPblm)
                    .HasColumnName("IsPBLM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LayByDate).HasColumnType("datetime");

                entity.Property(e => e.LaybyMax).HasColumnType("money");

                entity.Property(e => e.LaybyMin).HasColumnType("money");

                entity.Property(e => e.Lbmamount)
                    .HasColumnName("LBMAMount")
                    .HasColumnType("money");

                entity.Property(e => e.Lbmfee).HasColumnName("LBMFee");

                entity.Property(e => e.Lbyperiod)
                    .HasColumnName("LBYPeriod")
                    .HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.NonEftdeviceAmount)
                    .HasColumnName("NonEFTDeviceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NonEftdeviceDate)
                    .HasColumnName("NonEFTDeviceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NonEftdevicePeriod)
                    .HasColumnName("NonEFTDevicePeriod")
                    .HasMaxLength(10);

                entity.Property(e => e.OverideFsp).HasColumnName("OverideFSP");

                entity.Property(e => e.Pblmamount)
                    .HasColumnName("PBLMAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Pblmax)
                    .HasColumnName("PBLMax")
                    .HasColumnType("money");

                entity.Property(e => e.Pblmdate)
                    .HasColumnName("PBLMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pblmfee).HasColumnName("PBLMFee");

                entity.Property(e => e.Pblmin)
                    .HasColumnName("PBLMin")
                    .HasColumnType("money");

                entity.Property(e => e.Pblmperiod).HasColumnName("PBLMPeriod");

                entity.Property(e => e.Pblserial)
                    .HasColumnName("PBLSerial")
                    .HasMaxLength(255);

                entity.Property(e => e.Ranking).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TerminalActivationFee).HasColumnType("money");

                entity.Property(e => e.TerminalTypeId).HasColumnName("TerminalTypeID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.MerchantTerminal)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_MerchantTerminal_Channel");

                entity.HasOne(d => d.ContractTerm)
                    .WithMany(p => p.MerchantTerminal)
                    .HasForeignKey(d => d.ContractTermId)
                    .HasConstraintName("FK_MerchantTerminal_ContractTerm");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MerchantTerminalCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MerchantTerminal_AuthDirectory");

                entity.HasOne(d => d.EnvironmentRepository)
                    .WithMany(p => p.MerchantTerminal)
                    .HasForeignKey(d => d.EnvironmentRepositoryId)
                    .HasConstraintName("FK_MerchantTerminal_EnvironmentRepository");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.MerchantTerminal)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_MerchantTerminal_FinancialInstitution");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantTerminal)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_MerchantTerminal_Merchant");

                entity.HasOne(d => d.TerminalType)
                    .WithMany(p => p.MerchantTerminal)
                    .HasForeignKey(d => d.TerminalTypeId)
                    .HasConstraintName("FK_MerchantTerminal_TerminalType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MerchantTerminalUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_MerchantTerminal_AuthDirectory1");
            });

            modelBuilder.Entity<Metric>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Maximum).HasMaxLength(50);

                entity.Property(e => e.Minimum).HasMaxLength(50);

                entity.Property(e => e.RaiseAlert).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MetricCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Metric_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MetricUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Metric_AuthDirectory1");
            });

            modelBuilder.Entity<NewMerchantTerminals>(entity =>
            {
                entity.Property(e => e.ActivationDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantFee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyFee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnType("xml");

                entity.Property(e => e.Term)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewMerchants>(entity =>
            {
                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mid)
                    .HasColumnName("MID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnType("xml");

                entity.Property(e => e.TradingName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.ToTable("OTP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.OtptypeId).HasColumnName("OTPTypeID");

                entity.Property(e => e.Redeemed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Otptype>(entity =>
            {
                entity.ToTable("OTPType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OtptypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_OTPType_AuthDirectory");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.OtptypeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_OTPType_AuthDirectory1");
            });

            modelBuilder.Entity<Outcome>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationFee).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.Subscription).HasColumnType("money");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Product_AuthDirectory");

                entity.HasOne(d => d.EnvironmentRepository)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.EnvironmentRepositoryId)
                    .HasConstraintName("FK_Product_EnvironmentRepository1");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_Product_FinancialInstitution");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_Product_Merchant");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProductUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Product_AuthDirectory1");
            });

            modelBuilder.Entity<ProductBand>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationFee).HasColumnType("money");

                entity.Property(e => e.BandTypeId).HasColumnName("BandTypeID");

                entity.Property(e => e.Ceiling).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.Floor).HasMaxLength(10);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Subscription).HasColumnType("money");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BandType)
                    .WithMany(p => p.ProductBand)
                    .HasForeignKey(d => d.BandTypeId)
                    .HasConstraintName("FK_ProductBand_BandType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductBandCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ProductBand_AuthDirectory");

                entity.HasOne(d => d.EnvironmentRepository)
                    .WithMany(p => p.ProductBand)
                    .HasForeignKey(d => d.EnvironmentRepositoryId)
                    .HasConstraintName("FK_ProductBand_EnvironmentRepository");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.ProductBand)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_ProductBand_FinancialInstitution");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductBand)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductBand_Product");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProductBandUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_ProductBand_AuthDirectory1");
            });

            modelBuilder.Entity<ProductBandTerms>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationFee).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductBandId).HasColumnName("ProductBandID");

                entity.Property(e => e.Subscription).HasColumnType("money");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProductBand)
                    .WithMany(p => p.ProductBandTerms)
                    .HasForeignKey(d => d.ProductBandId)
                    .HasConstraintName("FK_ProductBandTerms_ProductBand");
            });

            modelBuilder.Entity<ProductLinkGenerator>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__ProductL__C51F0F1E37188360");

                entity.Property(e => e.Gid).HasColumnName("GId");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.LinkDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("money");

                entity.Property(e => e.TerminalNr).HasColumnName("TerminalNR");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Queue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemoteId).HasColumnName("RemoteID");

                entity.Property(e => e.RepositoryId).HasColumnName("RepositoryID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ReasonFields>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<ReasonTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Repository>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcpasuserId).HasColumnName("ACPASUserID");

                entity.Property(e => e.AdminUserId)
                    .HasColumnName("AdminUserID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.ApprovePaymentQueueId).HasColumnName("ApprovePaymentQueueID");

                entity.Property(e => e.CollectionQueueId).HasColumnName("CollectionQueueID");

                entity.Property(e => e.CommunicationQueueId).HasColumnName("CommunicationQueueID");

                entity.Property(e => e.CompuscanUserId).HasColumnName("CompuscanUserID");

                entity.Property(e => e.ConnectMobileNiussduserId).HasColumnName("ConnectMobileNIUSSDUserID");

                entity.Property(e => e.ConnectMobileSmsuserId).HasColumnName("ConnectMobileSMSUserID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DashboardWorkflow)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'Dashboard')");

                entity.Property(e => e.DatabaseId)
                    .HasColumnName("DatabaseID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealAdminWorkflow)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'Deal Admin')");

                entity.Property(e => e.DealsQueueId)
                    .HasColumnName("DealsQueueID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.DefaultAmount).HasColumnType("money");

                entity.Property(e => e.DefaultIdno)
                    .HasColumnName("DefaultIDNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultMobile).HasMaxLength(50);

                entity.Property(e => e.DefaultOtp)
                    .HasColumnName("DefaultOTP")
                    .HasMaxLength(10);

                entity.Property(e => e.EntryWorkflow)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'New Bank Workflow')");

                entity.Property(e => e.FinanceQueueId)
                    .HasColumnName("FinanceQueueID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.FirstEscalationUserId)
                    .HasColumnName("FirstEscalationUserID")
                    .HasDefaultValueSql("((17))");

                entity.Property(e => e.IntegrationUserId)
                    .HasColumnName("IntegrationUserID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MainDatabaseId)
                    .HasColumnName("MainDatabaseID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MainRepositoryId)
                    .HasColumnName("MainRepositoryID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.PaymentReceivedQueueId).HasColumnName("PaymentReceivedQueueID");

                entity.Property(e => e.PaymentsQueueId)
                    .HasColumnName("PaymentsQueueID")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.RepositoryDatabaseId).HasColumnName("RepositoryDatabaseID");

                entity.Property(e => e.RepositoryTypeId)
                    .HasColumnName("RepositoryTypeID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.RulesEngineDbid)
                    .HasColumnName("RulesEngineDBID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.SecondEscalationUserId)
                    .HasColumnName("SecondEscalationUserID")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ServiceUserId)
                    .HasColumnName("ServiceUserID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.SwitchPayQueueId)
                    .HasColumnName("SwitchPayQueueID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.SwitchPayUserId)
                    .HasColumnName("SwitchPayUserID")
                    .HasDefaultValueSql("((16))");

                entity.Property(e => e.SystemQueueId)
                    .HasColumnName("SystemQueueID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.Property(e => e.VerifyPopqueueId).HasColumnName("VerifyPOPQueueID");

                entity.Property(e => e.VodacomUserId).HasColumnName("VodacomUserID");

                entity.Property(e => e.WorkflowQueueId).HasColumnName("WorkflowQueueID");

                entity.HasOne(d => d.Acpasuser)
                    .WithMany(p => p.RepositoryAcpasuser)
                    .HasForeignKey(d => d.AcpasuserId)
                    .HasConstraintName("FK_Repository_AuthDirectory8");

                entity.HasOne(d => d.AdminUser)
                    .WithMany(p => p.RepositoryAdminUser)
                    .HasForeignKey(d => d.AdminUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory");

                entity.HasOne(d => d.ApprovePaymentQueue)
                    .WithMany(p => p.RepositoryApprovePaymentQueue)
                    .HasForeignKey(d => d.ApprovePaymentQueueId)
                    .HasConstraintName("FK_Repository_Queue5");

                entity.HasOne(d => d.CollectionQueue)
                    .WithMany(p => p.RepositoryCollectionQueue)
                    .HasForeignKey(d => d.CollectionQueueId)
                    .HasConstraintName("FK_Repository_Queue8");

                entity.HasOne(d => d.CommunicationQueue)
                    .WithMany(p => p.RepositoryCommunicationQueue)
                    .HasForeignKey(d => d.CommunicationQueueId)
                    .HasConstraintName("FK_Repository_Queue10");

                entity.HasOne(d => d.CompuscanUser)
                    .WithMany(p => p.RepositoryCompuscanUser)
                    .HasForeignKey(d => d.CompuscanUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory9");

                entity.HasOne(d => d.ConnectMobileNiussduser)
                    .WithMany(p => p.RepositoryConnectMobileNiussduser)
                    .HasForeignKey(d => d.ConnectMobileNiussduserId)
                    .HasConstraintName("FK_Repository_AuthDirectory10");

                entity.HasOne(d => d.ConnectMobileSmsuser)
                    .WithMany(p => p.RepositoryConnectMobileSmsuser)
                    .HasForeignKey(d => d.ConnectMobileSmsuserId)
                    .HasConstraintName("FK_Repository_AuthDirectory11");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RepositoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Repository_AuthDirectory1");

                entity.HasOne(d => d.Database)
                    .WithMany(p => p.RepositoryDatabase)
                    .HasForeignKey(d => d.DatabaseId)
                    .HasConstraintName("FK_Repository_Database");

                entity.HasOne(d => d.DealsQueue)
                    .WithMany(p => p.RepositoryDealsQueue)
                    .HasForeignKey(d => d.DealsQueueId)
                    .HasConstraintName("FK_Repository_Queue");

                entity.HasOne(d => d.FinanceQueue)
                    .WithMany(p => p.RepositoryFinanceQueue)
                    .HasForeignKey(d => d.FinanceQueueId)
                    .HasConstraintName("FK_Repository_Queue1");

                entity.HasOne(d => d.FirstEscalationUser)
                    .WithMany(p => p.RepositoryFirstEscalationUser)
                    .HasForeignKey(d => d.FirstEscalationUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory2");

                entity.HasOne(d => d.IntegrationUser)
                    .WithMany(p => p.RepositoryIntegrationUser)
                    .HasForeignKey(d => d.IntegrationUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory3");

                entity.HasOne(d => d.MainDatabase)
                    .WithMany(p => p.RepositoryMainDatabase)
                    .HasForeignKey(d => d.MainDatabaseId)
                    .HasConstraintName("FK_Repository_Database1");

                entity.HasOne(d => d.MainRepository)
                    .WithMany(p => p.InverseMainRepository)
                    .HasForeignKey(d => d.MainRepositoryId)
                    .HasConstraintName("FK_Repository_Repository");

                entity.HasOne(d => d.PaymentReceivedQueue)
                    .WithMany(p => p.RepositoryPaymentReceivedQueue)
                    .HasForeignKey(d => d.PaymentReceivedQueueId)
                    .HasConstraintName("FK_Repository_Queue7");

                entity.HasOne(d => d.PaymentsQueue)
                    .WithMany(p => p.RepositoryPaymentsQueue)
                    .HasForeignKey(d => d.PaymentsQueueId)
                    .HasConstraintName("FK_Repository_Queue2");

                entity.HasOne(d => d.RepositoryDatabase)
                    .WithMany(p => p.RepositoryRepositoryDatabase)
                    .HasForeignKey(d => d.RepositoryDatabaseId)
                    .HasConstraintName("FK_Repository_Database3");

                entity.HasOne(d => d.RepositoryType)
                    .WithMany(p => p.Repository)
                    .HasForeignKey(d => d.RepositoryTypeId)
                    .HasConstraintName("FK_Repository_RepositoryType");

                entity.HasOne(d => d.RulesEngineDb)
                    .WithMany(p => p.RepositoryRulesEngineDb)
                    .HasForeignKey(d => d.RulesEngineDbid)
                    .HasConstraintName("FK_Repository_Database2");

                entity.HasOne(d => d.SecondEscalationUser)
                    .WithMany(p => p.RepositorySecondEscalationUser)
                    .HasForeignKey(d => d.SecondEscalationUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory4");

                entity.HasOne(d => d.ServiceUser)
                    .WithMany(p => p.RepositoryServiceUser)
                    .HasForeignKey(d => d.ServiceUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory5");

                entity.HasOne(d => d.SwitchPayQueue)
                    .WithMany(p => p.RepositorySwitchPayQueue)
                    .HasForeignKey(d => d.SwitchPayQueueId)
                    .HasConstraintName("FK_Repository_Queue3");

                entity.HasOne(d => d.SwitchPayUser)
                    .WithMany(p => p.RepositorySwitchPayUser)
                    .HasForeignKey(d => d.SwitchPayUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory6");

                entity.HasOne(d => d.SystemQueue)
                    .WithMany(p => p.RepositorySystemQueue)
                    .HasForeignKey(d => d.SystemQueueId)
                    .HasConstraintName("FK_Repository_Queue4");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.RepositoryUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Repository_AuthDirectory7");

                entity.HasOne(d => d.VerifyPopqueue)
                    .WithMany(p => p.RepositoryVerifyPopqueue)
                    .HasForeignKey(d => d.VerifyPopqueueId)
                    .HasConstraintName("FK_Repository_Queue6");

                entity.HasOne(d => d.VodacomUser)
                    .WithMany(p => p.RepositoryVodacomUser)
                    .HasForeignKey(d => d.VodacomUserId)
                    .HasConstraintName("FK_Repository_AuthDirectory12");

                entity.HasOne(d => d.WorkflowQueue)
                    .WithMany(p => p.RepositoryWorkflowQueue)
                    .HasForeignKey(d => d.WorkflowQueueId)
                    .HasConstraintName("FK_Repository_Queue9");
            });

            modelBuilder.Entity<RepositoryType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SalesChannel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Suburb>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_Supplier_FinancialInstitution");
            });

            modelBuilder.Entity<SupplierUrl>(entity =>
            {
                entity.ToTable("SupplierURL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.SecondaryUrl).HasColumnName("SecondaryURL");

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<TerminalDeactivation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MerchantId)
                    .HasColumnName("MerchantID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.ProductAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TerminalDeactivation)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TerminalD__Produ__2C1F508E");

                entity.HasOne(d => d.Sp)
                    .WithMany(p => p.TerminalDeactivation)
                    .HasForeignKey(d => d.Spid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TerminalDe__SPID__2B2B2C55");
            });

            modelBuilder.Entity<TerminalMetric>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.MetricId).HasColumnName("MetricID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TerminalMetricCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TerminalMetric_AuthDirectory");

                entity.HasOne(d => d.MerchantTerminal)
                    .WithMany(p => p.TerminalMetric)
                    .HasForeignKey(d => d.MerchantTerminalId)
                    .HasConstraintName("FK_TerminalMetric_MerchantTerminal");

                entity.HasOne(d => d.Metric)
                    .WithMany(p => p.TerminalMetric)
                    .HasForeignKey(d => d.MetricId)
                    .HasConstraintName("FK_TerminalMetric_Metric");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TerminalMetricUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_TerminalMetric_AuthDirectory1");
            });

            modelBuilder.Entity<TerminalProduct>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.ActivationFee).HasColumnType("money");

                entity.Property(e => e.ContractTermId).HasColumnName("ContractTermID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Subscription).HasColumnType("money");

                entity.Property(e => e.Term).HasDefaultValueSql("((12))");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ContractTerm)
                    .WithMany(p => p.TerminalProduct)
                    .HasForeignKey(d => d.ContractTermId)
                    .HasConstraintName("FK_TerminalProduct_ContractTerm");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TerminalProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TerminalProduct_AuthDirectory");

                entity.HasOne(d => d.EnvironmentRepository)
                    .WithMany(p => p.TerminalProduct)
                    .HasForeignKey(d => d.EnvironmentRepositoryId)
                    .HasConstraintName("FK_TerminalProduct_EnvironmentRepository");

                entity.HasOne(d => d.FinancialInstitution)
                    .WithMany(p => p.TerminalProduct)
                    .HasForeignKey(d => d.FinancialInstitutionId)
                    .HasConstraintName("FK_TerminalProduct_FinancialInstitution");

                entity.HasOne(d => d.MerchantTerminal)
                    .WithMany(p => p.TerminalProduct)
                    .HasForeignKey(d => d.MerchantTerminalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminalProduct_MerchantTerminal");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TerminalProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TerminalProduct_Product");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TerminalProductUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_TerminalProduct_AuthDirectory1");
            });

            modelBuilder.Entity<TerminalType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TerminalTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TerminalType_AuthDirectory111");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TerminalTypeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_TerminalType_AuthDirectory11");
            });

            modelBuilder.Entity<TypeOfBusiness>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TypeOfService>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UniversalBankCodes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialInstitutionId).HasColumnName("FinancialInstitutionID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Url>(entity =>
            {
                entity.ToTable("URL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthUserId).HasColumnName("AuthUserID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dns)
                    .HasColumnName("DNS")
                    .HasMaxLength(500);

                entity.Property(e => e.FailOver1).HasMaxLength(500);

                entity.Property(e => e.FailOver2).HasMaxLength(500);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Port).HasMaxLength(10);

                entity.Property(e => e.PostFix).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<WelcomeMail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Spid).HasColumnName("SPID");
            });
        }
    }
}
