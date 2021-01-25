using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class SupplierUrl
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string Url { get; set; }
        public string SecondaryUrl { get; set; }
        public int? FinancialInstitutionId { get; set; }
    }
}
