using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class AuthDirectoryRepository
    {
        public long Id { get; set; }
        public long? AuthDirectoryId { get; set; }
        public Guid? RemoteId { get; set; }
        public long? RepositoryId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AuthDirectory AuthDirectory { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual Repository Repository { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
    }
}
