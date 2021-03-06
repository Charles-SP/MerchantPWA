﻿using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantHistoryType
    {
        public MerchantHistoryType()
        {
            MerchantHistory = new HashSet<MerchantHistory>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<MerchantHistory> MerchantHistory { get; set; }
    }
}
