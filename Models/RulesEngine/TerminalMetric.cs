using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class TerminalMetric
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? MerchantTerminalId { get; set; }
        public long? MetricId { get; set; }
        public string Location { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual MerchantTerminal MerchantTerminal { get; set; }
        public virtual Metric Metric { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
    }
}
