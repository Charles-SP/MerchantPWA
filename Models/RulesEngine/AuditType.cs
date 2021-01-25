using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class AuditType
    {
        public AuditType()
        {
            ApplicationRepositoryAuditType = new HashSet<ApplicationRepository>();
            ApplicationRepositoryInternalAuditType = new HashSet<ApplicationRepository>();
        }

        public long Id { get; set; }
        public int? Sequence { get; set; }
        public long? ActionId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Cpdescription { get; set; }
        public bool? Expire { get; set; }
        public bool? Approval { get; set; }
        public bool? Decline { get; set; }
        public bool? Cancel { get; set; }
        public bool? Status { get; set; }
        public bool? UpdateRulesEngine { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public string MerchantPortalDescription { get; set; }
        public bool? Capitec { get; set; }
        public bool? Loanzie { get; set; }
        public bool? Nedbank { get; set; }
        public bool? AuditStatus { get; set; }
        public bool? Nas { get; set; }
        public bool? EndPoint { get; set; }

        public virtual ICollection<ApplicationRepository> ApplicationRepositoryAuditType { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepositoryInternalAuditType { get; set; }
    }
}
