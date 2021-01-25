﻿using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class CreditProviderMerchant
    {
        public long Id { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? MerchantId { get; set; }
        public string Reference { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
    }
}