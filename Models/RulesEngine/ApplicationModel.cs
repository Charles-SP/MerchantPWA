using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Merchant.Models
{
    public class ApplicationModel : ProductLinkGenerator
    {
        public string CurrencyFormat(decimal amount)
        {
            CultureInfo CInfo = new CultureInfo("en-IN");
            string returnAmt = amount.ToString("N", CInfo);
            return returnAmt;
        }


        public string FirstName { get; set; }

        public bool? IsLayby { get; set; }

        public string SurName { get; set; }

        public string IDNumber { get; set; }

        public string MobileNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Merchant { get; set; }

        public long? MerchantID { get; set; }

        public string Provider { get; set; }

        public decimal? FinanceAmount { get; set; }
        public string FinanceAmountToString
        {
            get
            {
                return FinanceAmount.Value.ToString("#,##0.00");
            }
        }

        public decimal? MonthlyPayment { get; set; }

        public string QrRedirect { get; set; }

        public string PurchaseAmount { get; set; }

        public decimal GetPurchsePriceConverted
        {
            get
            {
                return (decimal)(decimal.Parse(PurchaseAmount) / 100);

            }
        }

        public string GetPurchsePriceConvertedToString {
            get
            {
                return GetPurchsePriceConverted.ToString("#,##0.00");
            }
        }

        public int BankID { get; set; }

        public string Bank { get; set; }

        public string Term { get; set; }

        public string EmployementStatus { get; set; }

        public string EmploymentLevel { get; set; }

        public int EmploymentStatusID { get; set; }

        public int EmploymentLevelID { get; set; }

        public decimal Salary { get; set; }

        public decimal Expenses { get; set; }

        public decimal? Deposit { get; set; }

        public string SubscribedProductName { get; set; }

        public List<LookupModel> LevelLookup { get; set; }


        public List<LookupModel> StatusLookup { get; set; }

        public List<LookupModel> TermsLookup { get; set; }

        public List<LookupModel> BankLookup { get; set; }


        public string SelectedTerm { get; set; }

        public string SecondaryURL { get; set; }

    }
}
