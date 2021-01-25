using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantFlags
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
