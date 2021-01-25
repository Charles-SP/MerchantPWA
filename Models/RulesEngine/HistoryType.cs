using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class HistoryType
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool? CausesNotification { get; set; }
        public bool? IsBankStatus { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
