using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class ApplicationRepositoryHistory
    {
        public long Id { get; set; }
        public long? Actor { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public long? ActionId { get; set; }
        public long? ApplicationId { get; set; }
        public long? DatabaseId { get; set; }
        public DateTime? HistoryDate { get; set; }

        public virtual Action Action { get; set; }
        public virtual AuthDirectory ActorNavigation { get; set; }
        public virtual ApplicationRepository ApplicationRepository { get; set; }
    }
}
