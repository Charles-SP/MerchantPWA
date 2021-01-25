using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Repository
    {
        public Repository()
        {
            AuthDirectory = new HashSet<AuthDirectory>();
            AuthDirectoryRepository = new HashSet<AuthDirectoryRepository>();
            Environment = new HashSet<Environment>();
            EnvironmentRepository = new HashSet<EnvironmentRepository>();
            InverseMainRepository = new HashSet<Repository>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string DefaultIdno { get; set; }
        public string DefaultMobile { get; set; }
        public decimal? DefaultAmount { get; set; }
        public int? DefaultBank { get; set; }
        public string DefaultOtp { get; set; }
        public long? Urlid { get; set; }
        public long? SystemQueueId { get; set; }
        public long? SwitchPayQueueId { get; set; }
        public long? FinanceQueueId { get; set; }
        public long? DealsQueueId { get; set; }
        public long? PaymentsQueueId { get; set; }
        public long? VerifyPopqueueId { get; set; }
        public long? ApprovePaymentQueueId { get; set; }
        public string EntryWorkflow { get; set; }
        public string DealAdminWorkflow { get; set; }
        public string DashboardWorkflow { get; set; }
        public long? MainDatabaseId { get; set; }
        public long? DatabaseId { get; set; }
        public long? RulesEngineDbid { get; set; }
        public long? MainRepositoryId { get; set; }
        public long? RepositoryTypeId { get; set; }
        public long? ServiceUserId { get; set; }
        public long? SwitchPayUserId { get; set; }
        public long? AdminUserId { get; set; }
        public long? IntegrationUserId { get; set; }
        public long? FirstEscalationUserId { get; set; }
        public long? SecondEscalationUserId { get; set; }
        public long? AcpasuserId { get; set; }
        public long? CompuscanUserId { get; set; }
        public long? VodacomUserId { get; set; }
        public long? ConnectMobileSmsuserId { get; set; }
        public long? ConnectMobileNiussduserId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public long? PaymentReceivedQueueId { get; set; }
        public long? CollectionQueueId { get; set; }
        public long? WorkflowQueueId { get; set; }
        public long? CommunicationQueueId { get; set; }
        public long? RepositoryDatabaseId { get; set; }

        public virtual AuthDirectory Acpasuser { get; set; }
        public virtual AuthDirectory AdminUser { get; set; }
        public virtual Queue ApprovePaymentQueue { get; set; }
        public virtual Queue CollectionQueue { get; set; }
        public virtual Queue CommunicationQueue { get; set; }
        public virtual AuthDirectory CompuscanUser { get; set; }
        public virtual AuthDirectory ConnectMobileNiussduser { get; set; }
        public virtual AuthDirectory ConnectMobileSmsuser { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual Database Database { get; set; }
        public virtual Queue DealsQueue { get; set; }
        public virtual Queue FinanceQueue { get; set; }
        public virtual AuthDirectory FirstEscalationUser { get; set; }
        public virtual AuthDirectory IntegrationUser { get; set; }
        public virtual Database MainDatabase { get; set; }
        public virtual Repository MainRepository { get; set; }
        public virtual Queue PaymentReceivedQueue { get; set; }
        public virtual Queue PaymentsQueue { get; set; }
        public virtual Database RepositoryDatabase { get; set; }
        public virtual RepositoryType RepositoryType { get; set; }
        public virtual Database RulesEngineDb { get; set; }
        public virtual AuthDirectory SecondEscalationUser { get; set; }
        public virtual AuthDirectory ServiceUser { get; set; }
        public virtual Queue SwitchPayQueue { get; set; }
        public virtual AuthDirectory SwitchPayUser { get; set; }
        public virtual Queue SystemQueue { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual Queue VerifyPopqueue { get; set; }
        public virtual AuthDirectory VodacomUser { get; set; }
        public virtual Queue WorkflowQueue { get; set; }
        public virtual ICollection<AuthDirectory> AuthDirectory { get; set; }
        public virtual ICollection<AuthDirectoryRepository> AuthDirectoryRepository { get; set; }
        public virtual ICollection<Environment> Environment { get; set; }
        public virtual ICollection<EnvironmentRepository> EnvironmentRepository { get; set; }
        public virtual ICollection<Repository> InverseMainRepository { get; set; }
    }
}
