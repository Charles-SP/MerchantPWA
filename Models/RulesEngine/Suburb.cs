using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Suburb
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CityId { get; set; }
        public string PostalCode { get; set; }
    }
}
