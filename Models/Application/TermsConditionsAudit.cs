using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class TermsConditionsAudit
    {
        public long Id { get; set; }
        public long ApplicationId { get; set; }
        public bool IsAccepted { get; set; }
        public string Description { get; set; }
    }
}
