using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class Settings
    {
        public long Id { get; set; }
        public long DatabaseId { get; set; }
        public long EnvironmentId { get; set; }
        public long RepositoryId { get; set; }
        public long RulesEngineId { get; set; }
        public string RulesEngineDbname { get; set; }
        public long EnvironmentRepositoryId { get; set; }
        public string MainRepository { get; set; }
        public long? UpdateBy { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
