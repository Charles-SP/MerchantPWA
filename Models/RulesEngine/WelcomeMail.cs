using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class WelcomeMail
    {
        public int Id { get; set; }
        public long? Spid { get; set; }
        public string EmailAddr { get; set; }
        public int? Product { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Status { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
