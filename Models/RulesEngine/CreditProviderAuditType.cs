using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class CreditProviderAuditType
    {
        public long Id { get; set; }
        public int? Sequence { get; set; }
        public long? CreditProviderId { get; set; }
        public long? AuditTypeId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
