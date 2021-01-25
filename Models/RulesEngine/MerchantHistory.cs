using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantHistory
    {
        public long Id { get; set; }
        public long? Actor { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public long? MerchantHistoryTypeId { get; set; }
        public long? MerchantId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public DateTime? DateActioned { get; set; }

        public virtual AuthDirectory ActorNavigation { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual MerchantHistoryType MerchantHistoryType { get; set; }
        public virtual MerchantTerminal MerchantTerminal { get; set; }
    }
}
