using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class ApplicationVariables
    {
        public Guid Id { get; set; }
        public long ApplicationId { get; set; }
        public decimal Amount { get; set; }
        public string Scope { get; set; }
        public string Code { get; set; }
        public string State { get; set; }
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string HeavyAccessToken { get; set; }
        public string AccessToken { get; set; }
        public string LoanAuthCode { get; set; }
        public string LoanRequestId { get; set; }
        public string PersonalLoanOfferId { get; set; }
        public string RefreshToken { get; set; }
        public string Merchant { get; set; }
    }
}
