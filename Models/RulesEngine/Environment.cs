using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Environment
    {
        public Environment()
        {
            EnvironmentRepository = new HashSet<EnvironmentRepository>();
            InverseMainEnvironment = new HashSet<Environment>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Urlprefix { get; set; }
        public long? WebLinkUrlid { get; set; }
        public long? Apiurlid { get; set; }
        public long? PortalUrlid { get; set; }
        public long? Ussdurlid { get; set; }
        public long? ImagesUrlid { get; set; }
        public long? SecondaryProcessUrlid { get; set; }
        public long? InternalWebApiurlid { get; set; }
        public long? ExternalWebApiurlid { get; set; }
        public long? Acpasurlid { get; set; }
        public long? CompuScanUrlid { get; set; }
        public long? VodacomHttpurlid { get; set; }
        public long? VodacomSoapurlid { get; set; }
        public long? VodacomResturlid { get; set; }
        public long? ConnectMobileNiussdurlid { get; set; }
        public long? ConnectMobileSmsurlid { get; set; }
        public long? MainDatabaseId { get; set; }
        public long? RulesEngineDbid { get; set; }
        public long? MainRepositoryId { get; set; }
        public long? MainEnvironmentId { get; set; }
        public long? EnvironmentTypeId { get; set; }
        public string DefaultIdno { get; set; }
        public string DefaultMobile { get; set; }
        public decimal? DefaultAmount { get; set; }
        public int? DefaultBank { get; set; }
        public string DefaultOtp { get; set; }
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
        public bool? IsActive { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Port { get; set; }

        public virtual Url Acpasurl { get; set; }
        public virtual AuthDirectory Acpasuser { get; set; }
        public virtual AuthDirectory AdminUser { get; set; }
        public virtual Url Apiurl { get; set; }
        public virtual Url CompuScanUrl { get; set; }
        public virtual AuthDirectory CompuscanUser { get; set; }
        public virtual Url ConnectMobileNiussdurl { get; set; }
        public virtual AuthDirectory ConnectMobileNiussduser { get; set; }
        public virtual Url ConnectMobileSmsurl { get; set; }
        public virtual AuthDirectory ConnectMobileSmsuser { get; set; }
        public virtual AuthDirectory CreatedByNavigation { get; set; }
        public virtual EnvironmentType EnvironmentType { get; set; }
        public virtual Url ExternalWebApiurl { get; set; }
        public virtual AuthDirectory FirstEscalationUser { get; set; }
        public virtual Url ImagesUrl { get; set; }
        public virtual AuthDirectory IntegrationUser { get; set; }
        public virtual Url InternalWebApiurl { get; set; }
        public virtual Database MainDatabase { get; set; }
        public virtual Environment MainEnvironment { get; set; }
        public virtual Repository MainRepository { get; set; }
        public virtual Url PortalUrl { get; set; }
        public virtual Database RulesEngineDb { get; set; }
        public virtual AuthDirectory SecondEscalationUser { get; set; }
        public virtual Url SecondaryProcessUrl { get; set; }
        public virtual AuthDirectory ServiceUser { get; set; }
        public virtual AuthDirectory SwitchPayUser { get; set; }
        public virtual AuthDirectory UpdatedByNavigation { get; set; }
        public virtual Url Ussdurl { get; set; }
        public virtual Url VodacomHttpurl { get; set; }
        public virtual Url VodacomResturl { get; set; }
        public virtual Url VodacomSoapurl { get; set; }
        public virtual AuthDirectory VodacomUser { get; set; }
        public virtual Url WebLinkUrl { get; set; }
        public virtual ICollection<EnvironmentRepository> EnvironmentRepository { get; set; }
        public virtual ICollection<Environment> InverseMainEnvironment { get; set; }
    }
}
