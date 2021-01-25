using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merchant.Models
{
    public class LookupModel
    {
        #region :: Properties ::

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public string Label { get; set; } = string.Empty;

        #endregion
    }
}
