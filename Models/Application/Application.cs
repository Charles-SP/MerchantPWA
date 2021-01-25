using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class Application
    {
        public Application()
        {
            ApplicationFieldValue = new HashSet<ApplicationFieldValue>();
            Audit = new HashSet<Audit>();
        }

        public long Id { get; set; }
        public long? EnvironmentRepositoryId { get; set; }
        public long? MerchantId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public long? InternalAuditTypeId { get; set; }
        public long? AuditTypeId { get; set; }
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
        public int Term { get; set; }
        public int? OfferTerm { get; set; }
        public decimal? Installment { get; set; }
        public decimal? OfferInstallment { get; set; }
        public double? Rate { get; set; }
        public string Priority { get; set; }
        public string AcceptPin { get; set; }
        public bool? IsAuthorised { get; set; }
        public string CollectPin { get; set; }
        public bool? IsCollected { get; set; }
        public string MerchantIdentifier { get; set; }
        public string TerminalIdentifier { get; set; }
        public string DeclineReason { get; set; }
        public string Comments { get; set; }
        public long? UpdateBy { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? Test { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsDeclined { get; set; }
        public bool? IsCancelled { get; set; }
        public bool? IsExpired { get; set; }
        public bool? IsArchived { get; set; }
        public bool? IsDeleted { get; set; }
        public string BatchRef { get; set; }
        public int? ReasonId { get; set; }
        public int? SecondaryUrlid { get; set; }

        public virtual ApplicationStats ApplicationStats { get; set; }
        public virtual ICollection<ApplicationFieldValue> ApplicationFieldValue { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }
    }
}
