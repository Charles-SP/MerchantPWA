using System;
using System.Collections.Generic;

namespace Merchant.Models.Application
{
    public partial class SecondaryFields
    {
        public long Id { get; set; }
        public long ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int LoanTerm { get; set; }
        public string CompanyName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string EmploymentStatus { get; set; }
        public string EmploymentTitle { get; set; }
        public string SalaryDate { get; set; }
        public string SalaryFrequency { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal NettIncome { get; set; }
        public decimal LivingExpenses { get; set; }
    }
}
