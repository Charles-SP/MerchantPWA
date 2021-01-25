using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Merchant.Models;
using Merchant.Models.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SwitchPayIntegration;
using SwitchPayIntegration.Models.SPApi;

namespace Merchant.Controllers
{
    public class CommonController : Controller
    {
        #region { Public Methods ]

        #region [Apply ]
        #region [ EndPoints ]
        private readonly StageRulesEngineContext _context;
        private readonly StageSwitchPayContext _appcontext;
        public static Merchants merchant { get; set; }
        public static ProductLinkGenerator productLinkGenerator { get; set; }
        public static MerchantTerminal merchantTerminal { get; set; }
        public IConfigurationRoot _configuration;
        public IConfigurationRoot _appConfiguration;
        #endregion

        #region [ StageRulesEngineContext ]
        public CommonController(StageRulesEngineContext context)
        {
            _context = context;

            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }
        #endregion

        #region [ Index ]
        public IActionResult Default(long mId)
        {
            merchant = _context.Merchant
    .FirstOrDefault(m => m.Id == Convert.ToInt64(mId));
            HttpContext.Session.SetString("mid", mId.ToString());

            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title
            };
            return View(model);
        }

        #endregion

        #region [ Welcome ]
        public IActionResult Welcome()
        {
            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {
                var provider = (from q in context.FinancialInstitution where q.Id == 14 select q.Title).FirstOrDefault();


                ApplicationModel model = new ApplicationModel
                {
                    Merchant = merchant.Title,
                    Provider = provider
                };
                return View(model);
            }
        }

        #endregion

        #region [ ProductInfo ]
        public IActionResult ProductInfo(decimal amount)
        {
            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {
                var provider = (from q in context.FinancialInstitution where q.Id == 14 select q.Title).FirstOrDefault();


                ApplicationModel model = new ApplicationModel
                {
                    FinanceAmount = amount,
                    Merchant = merchant.Title,
                    Provider = provider
                };

                HttpContext.Session.SetString("amount", amount.ToString());
                return View(model);
            }
        }

        public IActionResult Proposition()
        {
            return View();
        }


        #region [ CustomerInfo - GET ]
        [HttpGet]
        public IActionResult CustomerInfo(string mobile)
        {
            var amount = HttpContext.Session.GetString("amount");
            HttpContext.Session.SetString("mobile", mobile.ToString());

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            string banksResponse = (string)aPIClient.GetBanks(true);
            var response = JsonConvert.DeserializeObject<List<BankLists>>(banksResponse);

            ApplicationModel model = new ApplicationModel()
            {
                FinanceAmount = Convert.ToDecimal(amount),
                Merchant = merchant.Title,
                BankLookup = response.Select(a => new LookupModel
                {
                    Id = Convert.ToInt64(a.ID),
                    Name = a.Title
                }).ToList(),
            };

            return View(model);
        }

        #endregion

        #region [ CustomerInfo - POST ]
        [HttpPost]
        public IActionResult CustomerInfo(string name, string surname, string idNumber, int bankID)
        {
            HttpContext.Session.SetString("firstName", name);
            HttpContext.Session.SetString("surname", surname);
            HttpContext.Session.SetString("IdNumber", idNumber);
            HttpContext.Session.SetString("bank", bankID.ToString());
            var mId = HttpContext.Session.GetString("mid");
            var mobile = HttpContext.Session.GetString("mobile");
            var amount = HttpContext.Session.GetString("amount");

            merchant = _context.Merchant
                .FirstOrDefault(m => m.Id == Convert.ToInt64(mId));

            merchantTerminal = _context.MerchantTerminal
    .FirstOrDefault(m => m.MerchantId == Convert.ToInt64(mId));

            ApplicationModel model = new ApplicationModel
            {
                FinanceAmount = Convert.ToDecimal(amount),
                Merchant = merchant.Title
            };

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            try
            {
                var result = aPIClient.CreateApplication(Convert.ToInt64(mId), merchantTerminal.Reference, Convert.ToDouble(amount), idNumber, mobile, bankID, "", false, "", name, surname, Convert.ToDouble(0), 0);
                var _result = Newtonsoft.Json.JsonConvert.DeserializeObject<SPApiResponse>(result);
                var appID = _result.Header.Select(s => s.ApplicationID).FirstOrDefault();
                HttpContext.Session.SetString("appID", appID.ToString());

                if (appID == 0)
                {
                    RedirectToAction("Home/Error");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Authorise");
        }

        #endregion
        #region [ Authorise - GET ]
        [HttpGet]
        public ActionResult Authorise()
        {
            var mid = HttpContext.Session.GetString("mid");
            var amount = HttpContext.Session.GetString("amount");
            var mobile = HttpContext.Session.GetString("mobile");

            ApplicationModel model = new ApplicationModel()
            {
                FinanceAmount = Convert.ToDecimal(amount),
                Merchant = merchant.Title,
                MobileNumber = mobile
            };

            return View(model);
        }

        #endregion

        #region [ Authorise - POST ]
        [HttpPost]
        public ActionResult Authorise(string otp)
        {
            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            var appID = HttpContext.Session.GetString("appID");
            var mobile = HttpContext.Session.GetString("mobile");
            var idNumber = HttpContext.Session.GetString("IdNumber");
            var mid = HttpContext.Session.GetString("mid");
            var amount = HttpContext.Session.GetString("amount");

            string secondaryURL = _configuration["SecondaryURL:SecondaryEndpoint"].ToString();

            ApplicationModel model = new ApplicationModel()
            {
                FinanceAmount = Convert.ToDecimal(amount),
                Merchant = merchant.Title,
                SecondaryURL = secondaryURL + appID
            };

            var result = aPIClient.SubmitOTP(Convert.ToInt64(mid), merchantTerminal.Eftvasserial, otp, Convert.ToInt64(appID), "", mobile, idNumber, false);
            var _result = JsonConvert.DeserializeObject<SPApiResponse>(result);
            HttpContext.Session.SetString("appID", appID);

            return Redirect(model.SecondaryURL);
        }

        #endregion


        #region [ First Phase Done ]
        public IActionResult Done()
        {
            return View();
        }

        #endregion

        #region [ Authorise Successfull ]
        public IActionResult Success()
        {
            var appID = HttpContext.Session.GetString("appID");
            var mobile = HttpContext.Session.GetString("mobile");
            var idNumber = HttpContext.Session.GetString("IdNumber");
            var mid = HttpContext.Session.GetString("mid");
            var amount = HttpContext.Session.GetString("amount");

            string secondaryURL = _configuration["SecondaryURL:SecondaryEndpoint"].ToString();

            ApplicationModel model = new ApplicationModel
            {
                FinanceAmount = Convert.ToDecimal(amount),
                Merchant = merchant.Title,
                SecondaryURL = secondaryURL + appID
            };
            return View(model);
        }

        #endregion

        #endregion

        #endregion

        #region[ QR Apply ]

        #region [ Index ]

        [HttpGet]
        public ActionResult Goods(int gId, long? mId)
        {
            HttpContext.Session.SetString("mID", mId.ToString());
            HttpContext.Session.SetString("gID", gId.ToString());
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {

                productLinkGenerator = (from q in context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();

                if (productLinkGenerator.SubscribedProduct == 1)
                {
                    return RedirectToAction("Finance");
                }
                else if (productLinkGenerator.SubscribedProduct == 2)
                {
                    return RedirectToAction("Layby");
                }
                else if (productLinkGenerator.SubscribedProduct == 3)
                {
                    return RedirectToAction("Subscription");
                }

                ApplicationModel model = new ApplicationModel()
                {
                    Deposit = productLinkGenerator.Deposit
                };

                return View();
            }
        }
        #endregion

        #region [ Subscription ]

        [HttpGet]
        public ActionResult Subscription()
        {
            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {
                var mId = HttpContext.Session.GetString("mID");
                var gId = HttpContext.Session.GetString("gID");
                var productLinkGenerator = (from q in context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();
                var provider = (from q in context.FinancialInstitution where q.Id == 13 select q.Title).FirstOrDefault();
                var merchant = (from q in context.Merchant where q.Id == Convert.ToInt64(mId) select q).FirstOrDefault();
                ApplicationModel model = new ApplicationModel()
                {
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    ProductName = productLinkGenerator.ProductName,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName,
                    Terms = productLinkGenerator.Terms,
                    MonthlyPayment = productLinkGenerator.MonthlyPayment,
                    Deposit = productLinkGenerator.Deposit,
                    Provider = provider
                };

                return View(model);
            }
        }

        #endregion

        #region [ Finance ]

        [HttpGet]
        public ActionResult Finance()
        {

            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {
                var gId = HttpContext.Session.GetString("gID");
                var mId = HttpContext.Session.GetString("mID");

                var productLinkGenerator = (from q in context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();
                var merchant = (from q in context.Merchant where q.Id == Convert.ToInt64(mId) select q).FirstOrDefault();
                ApplicationModel model = new ApplicationModel()
                {
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    ProductName = productLinkGenerator.ProductName,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName
                };

                return View(model);
            }
        }

        #endregion

        #region [ Layby ]

        public ActionResult Layby()
        {
            var terms = productLinkGenerator.Terms;
            List<string> term = new List<string>();
            string[] array = terms.Split(',');

            var a = array.ToList();



            ApplicationModel model = new ApplicationModel()
            {
                Merchant = merchant.Title,
                FinanceAmount = productLinkGenerator.ProductPrice,
                ProductName = productLinkGenerator.ProductName,
                SubscribedProduct = productLinkGenerator.SubscribedProduct,
                Terms = productLinkGenerator.Terms,
                MonthlyPayment = productLinkGenerator.MonthlyPayment,
                SubscribedProductName = productLinkGenerator.SubscribedProductName

            };

            return View(model);
        }

        #endregion

        #region [ CustomerInfo ]

        [HttpPost]
        public ActionResult Customer(string mobile)
        {
            var mId = HttpContext.Session.GetString("mID");
            var builder = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            string result = (string)aPIClient.GetBanks(true);
            var response = JsonConvert.DeserializeObject<List<BankLists>>(result);

            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {
                var merchant = (from q in context.Merchant where q.Id == Convert.ToInt64(mId) select q).FirstOrDefault();

                ApplicationModel model = new ApplicationModel()
                {
                    MerchantID = productLinkGenerator.MerchantId,
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName,
                    Deposit = productLinkGenerator.Deposit,
                    MonthlyPayment = productLinkGenerator.MonthlyPayment,
                    SubscribedProduct = productLinkGenerator.SubscribedProduct,
                    Terms = productLinkGenerator.Terms,
                    MobileNumber = mobile,
                    BankLookup = response.Select(a => new LookupModel
                    {
                        Id = Convert.ToInt64(a.ID),
                        Name = a.Title
                    }).ToList(),

                };


                HttpContext.Session.SetString("mobile", mobile);

                return View(model);
            }
        }


        #endregion

        #region [ CustomerAdditionalInfo ]
        [HttpGet]
        public ActionResult CustomerAdditionalInfo(string firstName, string surName, string IdNumber, int bankID)
        {
            HttpContext.Session.SetString("firstName", firstName);
            HttpContext.Session.SetString("surname", surName);
            HttpContext.Session.SetString("IdNumber", IdNumber);
            HttpContext.Session.SetString("bank", bankID.ToString());
            var mId = HttpContext.Session.GetString("mID");

            using (StageRulesEngineContext context = new StageRulesEngineContext())
            {
                var gId = HttpContext.Session.GetString("gID");
                var productLinkGenerator = (from q in context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();
                var merchant = (from q in context.Merchant where q.Id == Convert.ToInt64(mId) select q).FirstOrDefault();
                var model = new ApplicationModel()
                {
                    MerchantID = productLinkGenerator.MerchantId,
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName,
                    Deposit = productLinkGenerator.Deposit,
                    MonthlyPayment = productLinkGenerator.MonthlyPayment,
                    SubscribedProduct = productLinkGenerator.SubscribedProduct,
                    Terms = productLinkGenerator.Terms
                };

                HttpContext.Session.SetString("finance", model.FinanceAmount.ToString());

                return View(model);
            }
        }

        [HttpPost]
        public ActionResult CustomerAdditionalInfo(ApplicationModel model)
        {
            var salary = model.Salary;
            var expenses = model.Expenses;
            var firstName = HttpContext.Session.GetString("firstName");
            var surName = HttpContext.Session.GetString("surname");
            var idNumber = HttpContext.Session.GetString("IdNumber");
            var mobile = HttpContext.Session.GetString("mobile");
            long mID = Convert.ToInt64(HttpContext.Session.GetString("mID"));
            string finance = HttpContext.Session.GetString("finance");
            int bankID = Convert.ToInt32(HttpContext.Session.GetString("bank"));
            var gId = HttpContext.Session.GetString("gID");

            var builder = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);
            using (StageRulesEngineContext r_context = new StageRulesEngineContext())
            {
                var merchantTerminal = (from q in r_context.MerchantTerminal where q.MerchantId == Convert.ToInt64(mID) select q).FirstOrDefault();
                var productLinkGenerator = (from q in r_context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();
                try
                {
                    var result = aPIClient.CreateApplication(mID, merchantTerminal.Eftvasserial, Convert.ToDouble(finance), idNumber, mobile, bankID, "", false, "", firstName, surName, Convert.ToDouble(salary), 0);
                    var _result = Newtonsoft.Json.JsonConvert.DeserializeObject<SPApiResponse>(result);
                    var appID = _result.Header.Select(s => s.ApplicationID).FirstOrDefault();
                    HttpContext.Session.SetString("appID", appID.ToString());

                    if (appID == 0)
                    {
                        RedirectToAction("Home/Error");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction("AuthoriseApply");
            }
        }

        #endregion

        #region [ Authorise ]
        [HttpGet]
        public ActionResult AuthoriseApply()
        {
            var mobile = HttpContext.Session.GetString("mobile");
            var appId = HttpContext.Session.GetString("appID");
            using (StageRulesEngineContext r_context = new StageRulesEngineContext())
            {
                var gId = HttpContext.Session.GetString("gID");
                var productLinkGenerator = (from q in r_context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();
                var merchantTerminal = (from q in r_context.MerchantTerminal where q.MerchantId == Convert.ToInt64(productLinkGenerator.MerchantId) select q).FirstOrDefault();
                var merchant = (from q in r_context.Merchant where q.Id == Convert.ToInt64(productLinkGenerator.MerchantId) select q).FirstOrDefault();
                ApplicationModel model = new ApplicationModel()
                {
                    MerchantID = productLinkGenerator.MerchantId,
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    MobileNumber = mobile,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName,
                    Term = productLinkGenerator.Terms,
                    Deposit = productLinkGenerator.Deposit,
                    MonthlyPayment = productLinkGenerator.MonthlyPayment
                };

                using (StageSwitchPayContext context = new StageSwitchPayContext())
                {
                    Models.Application.Application app = context.Application.Where(a => a.Id == Convert.ToInt64(appId)).FirstOrDefault();
                    app.Term = Convert.ToInt32(productLinkGenerator.Terms);
                    context.SaveChanges();
                }
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult AuthoriseApply(string otp)
        {
            string appID = HttpContext.Session.GetString("appID");
            var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            var appRef = HttpContext.Session.GetString("appRef");
            var mobile = HttpContext.Session.GetString("mobile");
            var terminalID = HttpContext.Session.GetString("terminalID");
            var idNumber = HttpContext.Session.GetString("IdNumber");
            var gID = HttpContext.Session.GetString("gID").ToString();

            using (StageRulesEngineContext r_context = new StageRulesEngineContext())
            {
                var gId = HttpContext.Session.GetString("gID");
                var productLinkGenerator = (from q in r_context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();
                var merchantTerminal = (from q in r_context.MerchantTerminal where q.MerchantId == Convert.ToInt64(productLinkGenerator.MerchantId) select q).FirstOrDefault();
                var merchant = (from q in r_context.Merchant where q.Id == Convert.ToInt64(productLinkGenerator.MerchantId) select q).FirstOrDefault();
                ApplicationModel model = new ApplicationModel()
                {
                    MerchantID = productLinkGenerator.MerchantId,
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    MobileNumber = mobile,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName
                };

                productLinkGenerator.ApplicationId = Convert.ToInt64(appID);
                _context.SaveChanges();

                var result = aPIClient.SubmitOTP(Convert.ToInt64(productLinkGenerator.MerchantId), merchantTerminal.Eftvasserial, otp, Convert.ToInt64(appID), appRef, mobile, idNumber, false);
                var _result = Newtonsoft.Json.JsonConvert.DeserializeObject<SPApiResponse>(result);

                var redirectTo = (_configuration["SecondaryURL:SecondaryEndpoint"] + Convert.ToInt64(appID)).ToString();
                return Redirect(redirectTo);
            }
        }

        public ActionResult Redirect()
        {
            return View();
        }

        public ActionResult Outcome()
        {
            var mId = Convert.ToInt64(HttpContext.Session.GetString("mID"));
            using (StageRulesEngineContext r_context = new StageRulesEngineContext())
            {
                var gId = HttpContext.Session.GetString("gID");
                var merchantTerminal = (from q in r_context.MerchantTerminal where q.MerchantId == Convert.ToInt64(mId) select q).FirstOrDefault();
                var merchant = (from q in r_context.Merchant where q.Id == Convert.ToInt64(mId) select q).FirstOrDefault();
                var productLinkGenerator = (from q in r_context.ProductLinkGenerator where q.Gid == Convert.ToInt32(gId) select q).FirstOrDefault();



                var terms = productLinkGenerator.Terms;
                string[] array = terms.Split(',');

                var tms = array.ToList();

                ApplicationModel model = new ApplicationModel()
                {
                    Merchant = merchant.Title,
                    FinanceAmount = productLinkGenerator.ProductPrice,
                    ProductName = productLinkGenerator.ProductName,
                    SubscribedProduct = productLinkGenerator.SubscribedProduct,
                    Terms = productLinkGenerator.Terms,
                    MonthlyPayment = productLinkGenerator.MonthlyPayment,
                    SubscribedProductName = productLinkGenerator.SubscribedProductName,
                    TermsLookup = (from a in tms
                                   select new LookupModel()
                                   {
                                       Id = Convert.ToInt64(a),
                                       Name = a.ToString()
                                   }).ToList(),
                    Deposit = productLinkGenerator.Deposit,
                    IsLayby = merchantTerminal.IsLayBy

                };
                return View(model);
            }
        }

        #endregion

        #endregion



        #endregion

    }
}
