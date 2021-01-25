using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ApplicationRepository
    {
        public ApplicationRepository()
        {
            ApplicationRepositoryHistory = new HashSet<ApplicationRepositoryHistory>();
            DebitOrderHistory = new HashSet<DebitOrderHistory>();
        }

        public long Id { get; set; }
        public long DatabaseId { get; set; }
        public long? EnvironmentRepositoryId { get; set; }
        public long? InternalAuditTypeId { get; set; }
        public long? AuditTypeId { get; set; }
        public long? MerchantId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? CreditProviderId { get; set; }
        public long? ChannelId { get; set; }
        public long? ProductId { get; set; }
        public long? TerminalTypeId { get; set; }
        public string Title { get; set; }
        public string Reference { get; set; }
        public string Idnumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MobileNumber { get; set; }
        public decimal? GrossIncome { get; set; }
        public decimal? NettIncome { get; set; }
        public decimal? FinanceAmount { get; set; }
        public decimal? OfferAmount { get; set; }
        public int? Term { get; set; }
        public int? OfferTerm { get; set; }
        public decimal? Installment { get; set; }
        public decimal? OfferInstallment { get; set; }
        public double? Rate { get; set; }
        public string Priority { get; set; }
        public string MerchantIdentifier { get; set; }
        public string TerminalIdentifier { get; set; }
        public string DeclineReason { get; set; }
        public string Comments { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? Test { get; set; }
        public bool? IsAuthorised { get; set; }
        public bool? IsCollected { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsDeclined { get; set; }
        public bool? IsCancelled { get; set; }
        public bool? IsExpired { get; set; }
        public bool? IsArchived { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AuditType AuditType { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual FinancialInstitution CreditProvider { get; set; }
        public virtual EnvironmentRepository EnvironmentRepository { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual AuditType InternalAuditType { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual MerchantTerminal MerchantTerminal { get; set; }
        public virtual Product Product { get; set; }
        public virtual TerminalType TerminalType { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepositoryHistory> ApplicationRepositoryHistory { get; set; }
        public virtual ICollection<DebitOrderHistory> DebitOrderHistory { get; set; }
    }
}
