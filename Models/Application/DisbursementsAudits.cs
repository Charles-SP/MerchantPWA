using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class DisbursementsAudits
    {
        public int Id { get; set; }
        public string BatchRef { get; set; }
        public int? Appid { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
