using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class CollectionStatus
    {
        public long Id { get; set; }
        public long? AuditTypeId { get; set; }
        public long? FinancialInstitutionId { get; set; }
    }
}
