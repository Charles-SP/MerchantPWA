using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Invoice
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public string SubTotal { get; set; }
        public string Vat { get; set; }
        public string Total { get; set; }
        public long? DebitOrderFileId { get; set; }
        public string SubsNo { get; set; }
        public string ActNo { get; set; }
        public string SubsText { get; set; }
        public string ActivationText { get; set; }
        public string SubsAmount { get; set; }
        public string ActivationAmount { get; set; }
        public string Pobox { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string MerchantName { get; set; }
        public long? DebitOrderHistoryId { get; set; }
        public long? MerchantId { get; set; }
        public long? ApplicationId { get; set; }
        public bool? Generated { get; set; }
        public string VatNo { get; set; }
        public string DateGenerated { get; set; }

        public virtual DebitOrderFile DebitOrderFile { get; set; }
        public virtual DebitOrderHistory DebitOrderHistory { get; set; }
    }
}
