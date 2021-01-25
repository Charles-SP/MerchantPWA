using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class ApplicationStats
    {
        public long Id { get; set; }
        public string CreditCheckResult { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateAuthorised { get; set; }
        public DateTime? DateCreditCheck { get; set; }
        public DateTime? DateBankChecked { get; set; }
        public DateTime? DateCaptured { get; set; }
        public DateTime? DateMarketing { get; set; }
        public DateTime? DateTerms { get; set; }
        public DateTime? DateFirstSentToBank { get; set; }
        public DateTime? DateSentToBank { get; set; }
        public DateTime? DateFirstOfferMade { get; set; }
        public DateTime? DateOfferMade { get; set; }
        public DateTime? DateFirstOfferAccepted { get; set; }
        public DateTime? DateOfferAccepted { get; set; }
        public DateTime? DateFirstOfferRejected { get; set; }
        public DateTime? DateOfferRejected { get; set; }
        public DateTime? DateFirstDeclined { get; set; }
        public DateTime? DateDeclined { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateAccepted { get; set; }
        public DateTime? DateRejected { get; set; }
        public DateTime? DateDomandate { get; set; }
        public DateTime? DateContracted { get; set; }
        public DateTime? DateCollected { get; set; }
        public DateTime? DatePaymentUploaded { get; set; }
        public DateTime? DatePaymentVerified { get; set; }
        public DateTime? DatePaymentReceived { get; set; }
        public DateTime? DateDisbursed { get; set; }
        public DateTime? DateCancelled { get; set; }
        public DateTime? DateExpired { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool? Authorised { get; set; }
        public bool? CreditCheck { get; set; }
        public int? BankChecked { get; set; }
        public bool? Captured { get; set; }
        public bool? Marketing { get; set; }
        public bool? Terms { get; set; }
        public int? SentToBank { get; set; }
        public int? OfferMade { get; set; }
        public int? OfferAccepted { get; set; }
        public int? OfferRejected { get; set; }
        public int? Declined { get; set; }
        public bool? Pending { get; set; }
        public bool? Approved { get; set; }
        public bool? Accepted { get; set; }
        public bool? Rejected { get; set; }
        public bool? Domandate { get; set; }
        public bool? Contracted { get; set; }
        public bool? Collected { get; set; }
        public bool? PaymentUploaded { get; set; }
        public bool? PaymentVerified { get; set; }
        public bool? PaymentReceived { get; set; }
        public bool? Disbursed { get; set; }
        public bool? Cancelled { get; set; }
        public bool? Expired { get; set; }
        public bool? Completed { get; set; }
        public DateTime? DateLastUpdated { get; set; }

        public virtual Application IdNavigation { get; set; }
    }
}
