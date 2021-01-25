using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ReasonFields
    {
        public long Id { get; set; }
        public int? Type { get; set; }
        public string Title { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
