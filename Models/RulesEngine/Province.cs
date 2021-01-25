using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Province
    {
        public Province()
        {
            City = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CountryId { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
