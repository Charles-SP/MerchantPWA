using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class DebitOrder
    {
        public DebitOrder()
        {
            DebitOrderHistory = new HashSet<DebitOrderHistory>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? DebitOrderTypeId { get; set; }
        public long? MerchantId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public int? StatusId { get; set; }
        public string Bank { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal? Amount { get; set; }
        public bool? Requested { get; set; }
        public bool? Successful { get; set; }

        public virtual DebitOrderType DebitOrderType { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual MerchantTerminal MerchantTerminal { get; set; }
        public virtual ICollection<DebitOrderHistory> DebitOrderHistory { get; set; }
    }
}
