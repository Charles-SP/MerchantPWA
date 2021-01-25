using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class DebitOrderHistory
    {
        public DebitOrderHistory()
        {
            DebitOrderFileItems = new HashSet<DebitOrderFileItems>();
            Invoice = new HashSet<Invoice>();
        }

        public long Id { get; set; }
        public bool? AwaitingRelease { get; set; }
        public bool? Released { get; set; }
        public bool? Paid { get; set; }
        public bool? Switchpay { get; set; }
        public long? ApplicationId { get; set; }
        public long? DatabaseId { get; set; }
        public long? DebitOrderId { get; set; }
        public long? DebitOrderTypeId { get; set; }
        public long? MerchantId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public string Title { get; set; }
        public DateTime? DebitDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public DateTime? DateReleased { get; set; }
        public DateTime? DatePaid { get; set; }
        public decimal? Amount { get; set; }
        public string Bank { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public string Reference { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ApplicationRepository ApplicationRepository { get; set; }
        public virtual DebitOrder DebitOrder { get; set; }
        public virtual DebitOrderType DebitOrderType { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual MerchantTerminal MerchantTerminal { get; set; }
        public virtual ICollection<DebitOrderFileItems> DebitOrderFileItems { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
