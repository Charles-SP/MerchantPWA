using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class FieldDefinitionEntity
    {
        public long Id { get; set; }
        public int? Sequence { get; set; }
        public long? CreditProviderId { get; set; }
        public long? MerchantId { get; set; }
        public long? FieldCategoryId { get; set; }
        public long? FieldDefinitionId { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string RegEx { get; set; }
        public int? Minimum { get; set; }
        public int? Maximum { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsRequired { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual FieldCategory FieldCategory { get; set; }
        public virtual FieldDefinition FieldDefinition { get; set; }
    }
}
