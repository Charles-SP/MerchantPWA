using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class Otp
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? KeyId { get; set; }
        public long? OtptypeId { get; set; }
        public bool? Redeemed { get; set; }
        public bool? Expired { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
    }
}
