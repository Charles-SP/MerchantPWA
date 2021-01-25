using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class TypeOfBusiness
    {
        public TypeOfBusiness()
        {
            Merchant = new HashSet<Merchants>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Merchants> Merchant { get; set; }
    }
}
