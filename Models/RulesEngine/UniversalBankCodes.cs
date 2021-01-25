using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class UniversalBankCodes
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long FinancialInstitutionId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
