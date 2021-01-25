using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ProductLinkGenerator
    {
        public int Gid { get; set; }
        public long? MerchantId { get; set; }
        public long? TerminalNr { get; set; }
        public int? SubscribedProduct { get; set; }
        public long? ApplicationId { get; set; }
        public string LinkDescription { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string UniqueProductRef { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string Terms { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public string SubscribedProductName { get; set; }
        public string QRImage { get; set; }
    }
}
