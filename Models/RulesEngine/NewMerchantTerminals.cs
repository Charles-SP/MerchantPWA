using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class NewMerchantTerminals
    {
        public int Id { get; set; }
        public int? MerchantId { get; set; }
        public string TerminalId { get; set; }
        public string MonthlyFee { get; set; }
        public string ApplicationType { get; set; }
        public string MerchantFee { get; set; }
        public string Term { get; set; }
        public string ActivationDate { get; set; }
        public string Result { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
