using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Channel
    {
        public Channel()
        {
            ApplicationRepository = new HashSet<ApplicationRepository>();
            MerchantTerminal = new HashSet<MerchantTerminal>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ApplicationRepository> ApplicationRepository { get; set; }
        public virtual ICollection<MerchantTerminal> MerchantTerminal { get; set; }
    }
}
