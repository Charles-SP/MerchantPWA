using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class UserType
    {
        public UserType()
        {
            AuthDirectory = new HashSet<AuthDirectory>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<AuthDirectory> AuthDirectory { get; set; }
    }
}
