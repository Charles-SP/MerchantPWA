using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ApplicationCreditProvider
    {
        public long Id { get; set; }
        public long DatabaseId { get; set; }
        public long? CreditProviderId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateOfferMade { get; set; }
        public DateTime? DateOfferAccepted { get; set; }
        public DateTime? DateOfferRejected { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateDeclined { get; set; }
        public DateTime? DateAccepted { get; set; }
        public DateTime? DateRejected { get; set; }
        public DateTime? DateContracted { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateCancelled { get; set; }
        public DateTime? DateExpired { get; set; }
        public DateTime? DatePaymentUploaded { get; set; }
        public DateTime? DatePaymentVerified { get; set; }
        public DateTime? DatePaymentReceived { get; set; }
        public bool? Sent { get; set; }
        public bool? OfferMade { get; set; }
        public bool? OfferAccepted { get; set; }
        public bool? OfferRejected { get; set; }
        public bool? Approved { get; set; }
        public bool? Declined { get; set; }
        public bool? Accepted { get; set; }
        public bool? Rejected { get; set; }
        public bool? Contracted { get; set; }
        public bool? PaymentUploaded { get; set; }
        public bool? PaymentVerified { get; set; }
        public bool? PaymentReceived { get; set; }
        public bool? Completed { get; set; }
        public bool? Cancelled { get; set; }
        public bool? Expired { get; set; }
        public bool? Pending { get; set; }
        public DateTime? DateLastUpdated { get; set; }

        public virtual FinancialInstitution CreditProvider { get; set; }
        public virtual Database Database { get; set; }
    }
}
