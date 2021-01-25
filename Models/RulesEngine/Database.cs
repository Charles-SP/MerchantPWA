using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Database
    {
        public Database()
        {
            ApplicationCreditProvider = new HashSet<ApplicationCreditProvider>();
            EnvironmentMainDatabase = new HashSet<Environment>();
            EnvironmentRulesEngineDb = new HashSet<Environment>();
            RepositoryDatabase = new HashSet<Repository>();
            RepositoryMainDatabase = new HashSet<Repository>();
            RepositoryRepositoryDatabase = new HashSet<Repository>();
            RepositoryRulesEngineDb = new HashSet<Repository>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Dbname { get; set; }
        public string Ipaddress { get; set; }
        public string Dns { get; set; }
        public long? AuthDirectoryId { get; set; }
        public long? DatabaseTypeId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AuthDirectory AuthDirectory { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationCreditProvider> ApplicationCreditProvider { get; set; }
        public virtual ICollection<Environment> EnvironmentMainDatabase { get; set; }
        public virtual ICollection<Environment> EnvironmentRulesEngineDb { get; set; }
        public virtual ICollection<Repository> RepositoryDatabase { get; set; }
        public virtual ICollection<Repository> RepositoryMainDatabase { get; set; }
        public virtual ICollection<Repository> RepositoryRepositoryDatabase { get; set; }
        public virtual ICollection<Repository> RepositoryRulesEngineDb { get; set; }
    }
}
