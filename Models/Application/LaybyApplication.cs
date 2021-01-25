using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class LaybyApplication
    {
        public int IntentId { get; set; }
        public string Merchantref { get; set; }
        public string Merchantid { get; set; }
        public string Terminalid { get; set; }
        public string Idnumber { get; set; }
        public string MobileNr { get; set; }
        public int? Bankid { get; set; }
        public decimal? Amount { get; set; }
        public int? LaybyPeriod { get; set; }
        public decimal? Otp { get; set; }
        public int? Redeemed { get; set; }
        public Guid? EntityId { get; set; }
        public string EntityRefererence { get; set; }
        public Guid? Userid { get; set; }
        public string Url { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }
    }
}
