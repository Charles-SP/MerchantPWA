using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class Apifunctions
    {
        public int Id { get; set; }
        public string FunctionName { get; set; }
        public DateTime? FunctionExceptionTime { get; set; }
        public string Functionresult { get; set; }
    }
}
