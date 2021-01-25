using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class DebitOrderFileItems
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public long? DebitOrderFileId { get; set; }
        public long? DebitOrderHistoryId { get; set; }

        public virtual DebitOrderFile DebitOrderFile { get; set; }
        public virtual DebitOrderHistory DebitOrderHistory { get; set; }
    }
}
