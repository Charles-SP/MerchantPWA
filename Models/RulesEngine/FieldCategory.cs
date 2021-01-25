using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class FieldCategory
    {
        public FieldCategory()
        {
            FieldCategoryEntity = new HashSet<FieldCategoryEntity>();
            FieldDefinition = new HashSet<FieldDefinition>();
            FieldDefinitionEntity = new HashSet<FieldDefinitionEntity>();
        }

        public long Id { get; set; }
        public int? Sequence { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<FieldCategoryEntity> FieldCategoryEntity { get; set; }
        public virtual ICollection<FieldDefinition> FieldDefinition { get; set; }
        public virtual ICollection<FieldDefinitionEntity> FieldDefinitionEntity { get; set; }
    }
}
