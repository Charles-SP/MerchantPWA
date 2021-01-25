using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            MerchantBankDetails = new HashSet<MerchantBankDetails>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<MerchantBankDetails> MerchantBankDetails { get; set; }
    }
}
