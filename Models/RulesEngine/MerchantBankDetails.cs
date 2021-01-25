using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantBankDetails
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? MerchantId { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public string BankBranch { get; set; }
        public string BranchNumber { get; set; }
        public string AccountNumber { get; set; }
        public long? AccountTypeId { get; set; }
        public double? Deposit { get; set; }
        public double? MerchantCommission { get; set; }
        public string DebitOrderReference { get; set; }
        public bool? UseParent { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
    }
}
