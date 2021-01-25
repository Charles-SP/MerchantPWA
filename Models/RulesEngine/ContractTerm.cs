using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ContractTerm
    {
        public ContractTerm()
        {
            MerchantTerminal = new HashSet<MerchantTerminal>();
            TerminalProduct = new HashSet<TerminalProduct>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<MerchantTerminal> MerchantTerminal { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProduct { get; set; }
    }
}
