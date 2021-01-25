using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class TerminalProduct
    {
        public long Id { get; set; }
        public long MerchantTerminalId { get; set; }
        public long? EnvironmentRepositoryId { get; set; }
        public long? ProductId { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? ContractTermId { get; set; }
        public decimal? Subscription { get; set; }
        public double? MerchantFee { get; set; }
        public int? Term { get; set; }
        public DateTime? ActivationDate { get; set; }
        public decimal? ActivationFee { get; set; }
        public double? Deposit { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual ContractTerm ContractTerm { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual EnvironmentRepository EnvironmentRepository { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual MerchantTerminal MerchantTerminal { get; set; }
        public virtual Product Product { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
    }
}
