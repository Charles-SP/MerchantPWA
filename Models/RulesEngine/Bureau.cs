using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Bureau
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Idnumber { get; set; }
        public int? CreditScore { get; set; }
        public int? NoOfJudgments { get; set; }
        public int? NoOfDefaults { get; set; }
        public int? NoOfArrears { get; set; }
        public decimal? CurrentObligations { get; set; }
        public long? OutcomeId { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
    }
}
