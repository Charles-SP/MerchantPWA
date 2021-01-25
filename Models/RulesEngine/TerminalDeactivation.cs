using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class TerminalDeactivation
    {
        public long Id { get; set; }
        public long Spid { get; set; }
        public string MerchantId { get; set; }
        public long? MerchantTerminalId { get; set; }
        public string Reference { get; set; }
        public long ProductId { get; set; }
        public decimal ProductFee { get; set; }
        public decimal ProductAmount { get; set; }
        public int? UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDeleted { get; set; }
        public int? IsDeleted { get; set; }

        public virtual Product Product { get; set; }
        public virtual Merchants Sp { get; set; }
    }
}
