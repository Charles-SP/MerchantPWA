using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Queue
    {
        public Queue()
        {
            RepositoryApprovePaymentQueue = new HashSet<Repository>();
            RepositoryCollectionQueue = new HashSet<Repository>();
            RepositoryCommunicationQueue = new HashSet<Repository>();
            RepositoryDealsQueue = new HashSet<Repository>();
            RepositoryFinanceQueue = new HashSet<Repository>();
            RepositoryPaymentReceivedQueue = new HashSet<Repository>();
            RepositoryPaymentsQueue = new HashSet<Repository>();
            RepositorySwitchPayQueue = new HashSet<Repository>();
            RepositorySystemQueue = new HashSet<Repository>();
            RepositoryVerifyPopqueue = new HashSet<Repository>();
            RepositoryWorkflowQueue = new HashSet<Repository>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public Guid? RemoteId { get; set; }
        public long? RepositoryId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Repository> RepositoryApprovePaymentQueue { get; set; }
        public virtual ICollection<Repository> RepositoryCollectionQueue { get; set; }
        public virtual ICollection<Repository> RepositoryCommunicationQueue { get; set; }
        public virtual ICollection<Repository> RepositoryDealsQueue { get; set; }
        public virtual ICollection<Repository> RepositoryFinanceQueue { get; set; }
        public virtual ICollection<Repository> RepositoryPaymentReceivedQueue { get; set; }
        public virtual ICollection<Repository> RepositoryPaymentsQueue { get; set; }
        public virtual ICollection<Repository> RepositorySwitchPayQueue { get; set; }
        public virtual ICollection<Repository> RepositorySystemQueue { get; set; }
        public virtual ICollection<Repository> RepositoryVerifyPopqueue { get; set; }
        public virtual ICollection<Repository> RepositoryWorkflowQueue { get; set; }
    }
}
