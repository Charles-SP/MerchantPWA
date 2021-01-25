using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class NewMerchants
    {
        public int Id { get; set; }
        public long MerchantId { get; set; }
        public string TradingName { get; set; }
        public string ContactName { get; set; }
        public string BankAccountNumber { get; set; }
        public string Mid { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Result { get; set; }
        public DateTime CreateDate { get; set; }
        public int Flags { get; set; }
    }
}
