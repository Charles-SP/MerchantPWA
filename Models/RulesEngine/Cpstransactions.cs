using System;
using System.Collections.Generic;

namespace Merchant.Models
{
    public partial class Cpstransactions
    {
        public int Id { get; set; }
        public string Cisnumber { get; set; }
        public string ProfileNumber { get; set; }
        public string Product { get; set; }
        public string InstanceNumber { get; set; }
        public string InstanceName { get; set; }
        public string StatementDate { get; set; }
        public string TransactionKey { get; set; }
        public string ProcessKey { get; set; }
        public string ResendKey { get; set; }
        public string DestinationKey { get; set; }
        public string Account { get; set; }
        public string TranType { get; set; }
        public string Channel { get; set; }
        public string Amount { get; set; }
        public string DebitCredit { get; set; }
        public string TransactionDate { get; set; }
        public string Time { get; set; }
        public string AccountBookBalance { get; set; }
        public string AccountAvailableBalance { get; set; }
        public string UserRef { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
