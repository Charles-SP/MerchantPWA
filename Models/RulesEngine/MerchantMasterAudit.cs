using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantMasterAudit
    {
        public int Id { get; set; }
        public int MerchantId { get; set; }
        public string RecordId { get; set; }
        public string Status { get; set; }
        public string Midref { get; set; }
        public string TerminalId { get; set; }
        public bool? IsFinanceSubscr { get; set; }
        public decimal? FinanceSubscrFee { get; set; }
        public decimal? FinanceCommRate { get; set; }
        public bool? IsLaybySubscr { get; set; }
        public decimal? LaybySubscrFee { get; set; }
        public decimal? LaybyCommRate { get; set; }
        public string GroupMerchRef { get; set; }
        public string EntityType { get; set; }
        public string CompEntityName { get; set; }
        public string CompRegNo { get; set; }
        public string TradingName { get; set; }
        public string StoreDisplayName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BankName { get; set; }
        public string AccountHolder { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public int? BranchCode { get; set; }
        public int? Flags { get; set; }
        public bool? IsActive { get; set; }
        public string AuditAction { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
