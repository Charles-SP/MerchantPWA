using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class XdspreVet
    {
        public int Id { get; set; }
        public string ApplicationId { get; set; }
        public string Pass { get; set; }
        public long? Score { get; set; }
        public string Description { get; set; }
    }
}
