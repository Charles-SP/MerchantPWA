using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class FieldType
    {
        public FieldType()
        {
            FieldDefinition = new HashSet<FieldDefinition>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string DataType { get; set; }
        public string ClassName { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<FieldDefinition> FieldDefinition { get; set; }
    }
}
