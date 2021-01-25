using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class DebitOrderFile
    {
        public DebitOrderFile()
        {
            DebitOrderFileItems = new HashSet<DebitOrderFileItems>();
            Invoice = new HashSet<Invoice>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DebitDate { get; set; }

        public virtual ICollection<DebitOrderFileItems> DebitOrderFileItems { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
