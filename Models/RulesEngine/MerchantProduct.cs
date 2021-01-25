using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantProduct
    {
        public long Id { get; set; }
        public long Spid { get; set; }
        public string MerchantId { get; set; }
        public long ProductId { get; set; }
        public decimal ProductFee { get; set; }
        public decimal ProductAmount { get; set; }
        public DateTime DateUpdated { get; set; }
        public int? IsActive { get; set; }

        public virtual Product Product { get; set; }
        public virtual Merchants Sp { get; set; }
    }
}
