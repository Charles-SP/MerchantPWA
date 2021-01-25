using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class CpsbankAudit
    {
        public int Id { get; set; }
        public long ApplicationId { get; set; }
        public long? UserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? BankId { get; set; }
        public long? MerchantId { get; set; }
        public string AccountNumber { get; set; }
        public string Comments { get; set; }
    }
}
