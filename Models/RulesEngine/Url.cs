using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Url
    {
        public Url()
        {
            EnvironmentAcpasurl = new HashSet<Environment>();
            EnvironmentApiurl = new HashSet<Environment>();
            EnvironmentCompuScanUrl = new HashSet<Environment>();
            EnvironmentConnectMobileNiussdurl = new HashSet<Environment>();
            EnvironmentConnectMobileSmsurl = new HashSet<Environment>();
            EnvironmentExternalWebApiurl = new HashSet<Environment>();
            EnvironmentImagesUrl = new HashSet<Environment>();
            EnvironmentInternalWebApiurl = new HashSet<Environment>();
            EnvironmentPortalUrl = new HashSet<Environment>();
            EnvironmentSecondaryProcessUrl = new HashSet<Environment>();
            EnvironmentUssdurl = new HashSet<Environment>();
            EnvironmentVodacomHttpurl = new HashSet<Environment>();
            EnvironmentVodacomResturl = new HashSet<Environment>();
            EnvironmentVodacomSoapurl = new HashSet<Environment>();
            EnvironmentWebLinkUrl = new HashSet<Environment>();
            FinancialInstitution = new HashSet<FinancialInstitution>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Dns { get; set; }
        public string PostFix { get; set; }
        public string Port { get; set; }
        public long? AuthUserId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string FailOver1 { get; set; }
        public string FailOver2 { get; set; }

        public virtual ICollection<Environment> EnvironmentAcpasurl { get; set; }
        public virtual ICollection<Environment> EnvironmentApiurl { get; set; }
        public virtual ICollection<Environment> EnvironmentCompuScanUrl { get; set; }
        public virtual ICollection<Environment> EnvironmentConnectMobileNiussdurl { get; set; }
        public virtual ICollection<Environment> EnvironmentConnectMobileSmsurl { get; set; }
        public virtual ICollection<Environment> EnvironmentExternalWebApiurl { get; set; }
        public virtual ICollection<Environment> EnvironmentImagesUrl { get; set; }
        public virtual ICollection<Environment> EnvironmentInternalWebApiurl { get; set; }
        public virtual ICollection<Environment> EnvironmentPortalUrl { get; set; }
        public virtual ICollection<Environment> EnvironmentSecondaryProcessUrl { get; set; }
        public virtual ICollection<Environment> EnvironmentUssdurl { get; set; }
        public virtual ICollection<Environment> EnvironmentVodacomHttpurl { get; set; }
        public virtual ICollection<Environment> EnvironmentVodacomResturl { get; set; }
        public virtual ICollection<Environment> EnvironmentVodacomSoapurl { get; set; }
        public virtual ICollection<Environment> EnvironmentWebLinkUrl { get; set; }
        public virtual ICollection<FinancialInstitution> FinancialInstitution { get; set; }
    }
}
