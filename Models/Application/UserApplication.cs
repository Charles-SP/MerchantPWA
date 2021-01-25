using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class UserApplication
    {
        public int Id { get; set; }
        public long? ApplicationId { get; set; }
        public long? UserId { get; set; }
        public int? Lock { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Description { get; set; }
    }
}
