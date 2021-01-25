using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Merchant.Models.Application
{
    public partial class StageSwitchPayContext : DbContext
    {
        public StageSwitchPayContext()
        {
        }

        public StageSwitchPayContext(DbContextOptions<StageSwitchPayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apifunctions> Apifunctions { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ApplicationFieldValue> ApplicationFieldValue { get; set; }
        public virtual DbSet<ApplicationStats> ApplicationStats { get; set; }
        public virtual DbSet<ApplicationVariables> ApplicationVariables { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<CpsbankAudit> CpsbankAudit { get; set; }
        public virtual DbSet<DisbursementsAudits> DisbursementsAudits { get; set; }
        public virtual DbSet<LaybyApplication> LaybyApplication { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Otp> Otp { get; set; }
        public virtual DbSet<Pmirecon> Pmirecon { get; set; }
        public virtual DbSet<SecondaryFields> SecondaryFields { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<TermsConditionsAudit> TermsConditionsAudit { get; set; }
        public virtual DbSet<UserApplication> UserApplication { get; set; }
        public virtual DbSet<XdspreVet> XdspreVet { get; set; }

        // Unable to generate entity type for table 'dbo.ExceptionInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempApplication'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempAudit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_Application'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_ApplicationFieldValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_ApplicationStats'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_ApplicationVariables'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_Audit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_SecondaryFields'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditTimeout_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CPSPayments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CPSTransactions'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=db.switchpay.local; Database=StageSwitchPay; user id=switchpayadm; password=8HtYY53B!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Apifunctions>(entity =>
            {
                entity.ToTable("APIFunctions");

                entity.Property(e => e.FunctionExceptionTime).HasColumnType("datetime");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Functionresult).HasMaxLength(50);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasIndex(e => e.Idnumber)
                    .HasName("IX_Application_IDNumber_9C614");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptPin)
                    .HasColumnName("AcceptPIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.BatchRef).HasMaxLength(50);

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.CollectPin)
                    .HasColumnName("CollectPIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeclineReason).HasMaxLength(500);

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

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SecondaryUrlid).HasColumnName("SecondaryURLID");

                entity.Property(e => e.Surname).HasMaxLength(500);

                entity.Property(e => e.TerminalIdentifier).HasMaxLength(50);

                entity.Property(e => e.TerminalTypeId).HasColumnName("TerminalTypeID");

                entity.Property(e => e.Test).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ApplicationFieldValue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FieldDefinitionEntityId).HasColumnName("FieldDefinitionEntityID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TerminalTypeId).HasColumnName("TerminalTypeID");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationFieldValue)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationFieldValue_Application1");
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

                entity.Property(e => e.CreditCheck).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.DateCreditCheck).HasColumnType("datetime");

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

                entity.Property(e => e.DateRejected).HasColumnType("datetime");

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

                entity.Property(e => e.Rejected).HasDefaultValueSql("((0))");

                entity.Property(e => e.SentToBank).HasDefaultValueSql("((0))");

                entity.Property(e => e.Terms).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ApplicationStats)
                    .HasForeignKey<ApplicationStats>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStats_Application");
            });

            modelBuilder.Entity<ApplicationVariables>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessToken)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("ClientID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HeavyAccessToken)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAuthCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRequestId)
                    .HasColumnName("LoanRequestID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Merchant)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalLoanOfferId)
                    .HasColumnName("PersonalLoanOfferID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefreshToken)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Scope)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Secret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasIndex(e => e.ApplicationId)
                    .HasName("IX_Audit_ApplicationID_77D2E");

                entity.HasIndex(e => new { e.ApplicationId, e.AuditTypeId })
                    .HasName("IX_Audit_AuditTypeID_DAF3C");

                entity.HasIndex(e => new { e.ApplicationId, e.CreditProviderId })
                    .HasName("IX_Audit_ApplicationID_CreditProviderID_541CA");

                entity.HasIndex(e => new { e.ApplicationId, e.AuditTypeId, e.AuditDate })
                    .HasName("IX_Audit_AuditTypeID_AuditDate_B3F76");

                entity.HasIndex(e => new { e.ApplicationId, e.AuditTypeId, e.CreditProviderId })
                    .HasName("IX_Audit_ApplicationID_AuditTypeID_CreditProviderID_09622");

                entity.HasIndex(e => new { e.ApplicationId, e.CreditProviderId, e.AuditTypeId })
                    .HasName("IX_Audit_ApplicationID_CreditProviderID_AuditTypeID_56FCC");

                entity.HasIndex(e => new { e.AuditTypeId, e.AuditDate, e.ApplicationId })
                    .HasName("IX_Audit_AuditDate_ApplicationID_752EC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActorId)
                    .HasColumnName("ActorID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.CreditProviderId).HasColumnName("CreditProviderID");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.MerchantTerminalId).HasColumnName("MerchantTerminalID");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Audit)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_Audit_Application");
            });

            modelBuilder.Entity<CpsbankAudit>(entity =>
            {
                entity.ToTable("CPSBankAudit");

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("Account Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DisbursementsAudits>(entity =>
            {
                entity.Property(e => e.BatchRef).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LaybyApplication>(entity =>
            {
                entity.HasKey(e => e.IntentId);

                entity.Property(e => e.IntentId).HasColumnName("IntentID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Merchantid).HasMaxLength(50);

                entity.Property(e => e.Merchantref).HasMaxLength(255);

                entity.Property(e => e.MobileNr).HasMaxLength(50);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Terminalid).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.ToTable("OTP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.OtptypeId).HasColumnName("OTPTypeID");

                entity.Property(e => e.Title).HasMaxLength(10);
            });

            modelBuilder.Entity<Pmirecon>(entity =>
            {
                entity.HasKey(e => e.I);

                entity.ToTable("PMIRecon");

                entity.Property(e => e.Action).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.Combined).HasMaxLength(50);

                entity.Property(e => e.Expired).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Queued).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.Test).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SecondaryFields>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmploymentDate).HasColumnType("date");

                entity.Property(e => e.EmploymentStatus)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmploymentTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.GrossIncome).HasColumnType("money");

                entity.Property(e => e.LivingExpenses).HasColumnType("money");

                entity.Property(e => e.NettIncome).HasColumnType("money");

                entity.Property(e => e.SalaryDate)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SalaryFrequency)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnvironmentId).HasColumnName("EnvironmentID");

                entity.Property(e => e.EnvironmentRepositoryId).HasColumnName("EnvironmentRepositoryID");

                entity.Property(e => e.MainRepository)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RepositoryId).HasColumnName("RepositoryID");

                entity.Property(e => e.RulesEngineDbname)
                    .IsRequired()
                    .HasColumnName("RulesEngineDBName")
                    .HasMaxLength(200);

                entity.Property(e => e.RulesEngineId).HasColumnName("RulesEngineID");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TermsConditionsAudit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<UserApplication>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<XdspreVet>(entity =>
            {
                entity.ToTable("XDSPreVet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(50);

                entity.Property(e => e.Pass).HasMaxLength(50);
            });
        }
    }
}
