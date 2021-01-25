using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ComponentHistory
    {
        public long Id { get; set; }
        public long? Actor { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public long? ComponentHistoryTypeId { get; set; }
        public long? ComponentId { get; set; }
        public long? Pkid { get; set; }
        public DateTime? DateActioned { get; set; }

        public virtual AuthDirectory ActorNavigation { get; set; }
        public virtual Component Component { get; set; }
        public virtual ComponentHistoryType ComponentHistoryType { get; set; }
    }
}
