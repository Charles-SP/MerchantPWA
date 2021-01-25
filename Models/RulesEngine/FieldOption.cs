using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class FieldOption
    {
        public long Id { get; set; }
        public long? FieldDefinitionId { get; set; }
        public string Title { get; set; }
        public long? Code { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual FieldDefinition FieldDefinition { get; set; }
    }
}
