using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class BusinessSize
    {
        public BusinessSize()
        {
            MerchantDetails = new HashSet<MerchantDetails>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public int? Minimum { get; set; }
        public int? Maximum { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<MerchantDetails> MerchantDetails { get; set; }
    }
}
