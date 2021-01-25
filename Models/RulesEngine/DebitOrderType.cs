using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class DebitOrderType
    {
        public DebitOrderType()
        {
            DebitOrder = new HashSet<DebitOrder>();
            DebitOrderHistory = new HashSet<DebitOrderHistory>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public string Code { get; set; }

        public virtual ICollection<DebitOrder> DebitOrder { get; set; }
        public virtual ICollection<DebitOrderHistory> DebitOrderHistory { get; set; }
    }
}
