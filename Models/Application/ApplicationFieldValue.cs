using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class ApplicationFieldValue
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? ApplicationId { get; set; }
        public long? TerminalTypeId { get; set; }
        public long? FieldDefinitionEntityId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Application Application { get; set; }
    }
}
