using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class Pmirecon
    {
        public long I { get; set; }
        public long? Id { get; set; }
        public long? MerchantId { get; set; }
        public string Combined { get; set; }
        public int? Action { get; set; }
        public long? AuditTypeId { get; set; }
        public bool? Cancelled { get; set; }
        public bool? Collected { get; set; }
        public bool? Paid { get; set; }
        public bool? Queued { get; set; }
        public bool? Expired { get; set; }
        public bool? Test { get; set; }
        public string Reference { get; set; }
    }
}
