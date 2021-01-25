using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class Audit
    {
        public long Id { get; set; }
        public DateTime? AuditDate { get; set; }
        public long? ApplicationId { get; set; }
        public long? AuditTypeId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public long? CreditProviderId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Ipaddress { get; set; }
        public long? ActorId { get; set; }

        public virtual Application Application { get; set; }
    }
}
