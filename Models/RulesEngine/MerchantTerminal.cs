using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class MerchantTerminal
    {
        public MerchantTerminal()
        {
            ApplicationRepository = new HashSet<ApplicationRepository>();
            DebitOrder = new HashSet<DebitOrder>();
            DebitOrderHistory = new HashSet<DebitOrderHistory>();
            MerchantHistory = new HashSet<MerchantHistory>();
            TerminalMetric = new HashSet<TerminalMetric>();
            TerminalProduct = new HashSet<TerminalProduct>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public long? EnvironmentRepositoryId { get; set; }
        public string Reference { get; set; }
        public long? MerchantId { get; set; }
        public long? FinancialInstitutionId { get; set; }
        public long? ContractTermId { get; set; }
        public long? ChannelId { get; set; }
        public long? TerminalTypeId { get; set; }
        public long? SupplierId { get; set; }
        public string Pblserial { get; set; }
        public string Eftvasserial { get; set; }
        public int? Pblmperiod { get; set; }
        public int? LayByPeriod { get; set; }
        public int? Emvposperiod { get; set; }
        public string NonEftdevicePeriod { get; set; }
        public double? Pblmfee { get; set; }
        public double? Lbmfee { get; set; }
        public decimal? Pblmamount { get; set; }
        public decimal? Lbmamount { get; set; }
        public decimal? Emvposamount { get; set; }
        public decimal? NonEftdeviceAmount { get; set; }
        public DateTime? Pblmdate { get; set; }
        public DateTime? LayByDate { get; set; }
        public DateTime? Emvposdate { get; set; }
        public DateTime? NonEftdeviceDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public decimal? TerminalActivationFee { get; set; }
        public string Location { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsActivation { get; set; }
        public bool? IsPblm { get; set; }
        public bool? IsLayBy { get; set; }
        public bool? IsEftpos { get; set; }
        public bool? IsNonEftdevice { get; set; }
        public decimal? Pblmin { get; set; }
        public decimal? Pblmax { get; set; }
        public decimal? LaybyMin { get; set; }
        public decimal? LaybyMax { get; set; }
        public string Lbyperiod { get; set; }
        public string Ranking { get; set; }
        public int? OverideFsp { get; set; }
        public int? OverideBank { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual ContractTerm ContractTerm { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual EnvironmentRepository EnvironmentRepository { get; set; }
        public virtual FinancialInstitution FinancialInstitution { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual TerminalType TerminalType { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicationRepository> ApplicationRepository { get; set; }
        public virtual ICollection<DebitOrder> DebitOrder { get; set; }
        public virtual ICollection<DebitOrderHistory> DebitOrderHistory { get; set; }
        public virtual ICollection<MerchantHistory> MerchantHistory { get; set; }
        public virtual ICollection<TerminalMetric> TerminalMetric { get; set; }
        public virtual ICollection<TerminalProduct> TerminalProduct { get; set; }
    }
}
