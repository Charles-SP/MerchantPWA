using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Merchant.Models.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationModel = Merchant.Models.ApplicationModel;
using SPAPIResponse = SwitchPayIntegration.Models.SPApi.SPApiResponse;
using SwitchPayIntegration.Models.SPApi;
using Microsoft.Extensions.Configuration;
using System.IO;
using Merchant.Models;
using SwitchPayIntegration;
using Newtonsoft.Json;
using SwitchPayIntegration.Models.Innervation;
using Microsoft.VisualBasic;

namespace Merchant.Controllers
{

    /// <summary>
    /// All Actions are based on screen flow and process.
    /// </summary>
    public class QRController : Controller
    {
        #region [ EndPoints ]
        private readonly StageRulesEngineContext _context;
        public static Merchants merchant { get; set; }
        public static ProductLinkGenerator productLinkGenerator { get; set; }
        public static MerchantTerminal merchantTerminal { get; set; }
        public static Inneredge.CreateQueryCodeResponse QueryCodeResult { get; set; }
        public static Inneredge.CreateMobileNotifyResponse MobileNotifyResult { get; set; }
        public IConfigurationRoot _configuration;
        public IConfigurationRoot _appConfiguration;
        #endregion

        #region [ StageRulesEngineContext ]
        public QRController(StageRulesEngineContext context)
        {
            _context = context;

            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }
        #endregion

        #region [ Apply ]

        #region [ Index ]
        public IActionResult Index(long mId)
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
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title
            };
            return View(model);
        }

        #endregion

        #region [ Proposition ]
        public IActionResult Proposition()
        {
            return View();
        }

        #endregion

        #region [ ProductInfo ]
        public IActionResult ProductInfo(decimal amount)
        {

            ApplicationModel model = new ApplicationModel
            {
                FinanceAmount = amount,
                Merchant = merchant.Title

            };

            HttpContext.Session.SetString("amount", amount.ToString());
            return View(model);
        }

        #endregion

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
                var _result = Newtonsoft.Json.JsonConvert.DeserializeObject<SPAPIResponse>(result);
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

        public void ResendOTP()
        {
            var appID = HttpContext.Session.GetString("appID");
            var mobile = HttpContext.Session.GetString("mobile");
            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            using (StageSwitchPayContext context = new StageSwitchPayContext())
            {
                var otp = (from q in context.Application where q.Id == Convert.ToInt64(appID) select q.AcceptPin).FirstOrDefault();
                aPIClient.SubmitSMS(mobile, "Enter Apply Code " + otp + "to approve your application and to consent to credit check with Credit Bureaus. App Ref# " + appID + ". Queries 0861995008" );
            }
        }

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
                MobileNumber = mobile,
                SecondaryURL = secondaryURL + appID
            };

            var result = aPIClient.SubmitOTP(Convert.ToInt64(mid), merchantTerminal.Eftvasserial, otp, Convert.ToInt64(appID), "", mobile, idNumber, false);
            var _result = JsonConvert.DeserializeObject<SPAPIResponse>(result);

            HttpContext.Session.SetString("appID", appID);

            if (_result != null && _result.Messages.Any())
            {
                var _mes = _result.Messages.FirstOrDefault();
                switch (_mes.Code)
                {
                    case "0":
                        return Redirect("Complete");
                    case "1":
                        return Redirect("AuthoriseApplyError");
                    case "99":
                    default:
                        return Redirect("AuthoriseApplyError");
                }
            }
 
            return RedirectToAction("Complete");
        }

        #region [ AuthoriseApplyError ]
        public IActionResult AuthoriseApplyError()
        {
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title,
            };
            return View(model);
        }
        #endregion

        #endregion


        #region [ Complete ]
        public IActionResult Complete()
        {
            var appID = HttpContext.Session.GetString("appID");
            string secondaryURL = _configuration["SecondaryURL:SecondaryEndpoint"].ToString();

            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title,
                SecondaryURL = secondaryURL + appID
            };
            return View(model);
        }

        #endregion

        #endregion

        #region [ Collection ]

        #region [ Scan ]
        public IActionResult Scan()
        {
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title
            };
            return View(model);
        }

        #endregion

        #region [ Collect ]
        [HttpGet]
        public IActionResult Collect()
        {
            var mId = HttpContext.Session.GetString("mid");
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount.text;
            var p_amount = decimal.Parse(QueryCodeResult.queryResFields.purchaseAmount.text) / 100;
            merchant = _context.Merchant
.FirstOrDefault(m => m.Id == Convert.ToInt64(mId));
            HttpContext.Session.SetString("mid", mId.ToString());

            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title,
                PurchaseAmount = QueryCodeResult.queryResFields.purchaseAmount.text

            };

            HttpContext.Session.SetString("merchant", merchant.Title);
            return View(model);
        }

        [HttpPost]
        public IActionResult Collect(ApplicationModel iModel)
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            var p_amount = decimal.Parse(QueryCodeResult.queryResFields.purchaseAmount.text) / 100;

            var mId = HttpContext.Session.GetString("mid");
            HttpContext.Session.SetString("mid", mId.ToString());

            merchantTerminal = _context.MerchantTerminal.FirstOrDefault(m => m.Id == Convert.ToInt64(mId));
            HttpContext.Session.SetString("mid", mId.ToString());

            var _idNumber = iModel.IDNumber;


            using (StageSwitchPayContext context = new StageSwitchPayContext())
            {
                var app = new Models.Application.Application();
                long appID = (from q in context.Application where q.MerchantId == Convert.ToInt64(mId) && q.Idnumber == _idNumber select q.Id).FirstOrDefault();

                var isApproved = from q in context.Audit
                                 where q.ApplicationId == appID && q.AuditTypeId.ToString().Contains("12")
                                 select q.AuditTypeId;


                if (isApproved.Any())
                {
                    app = context.Application
                   .Where(a => a.Id == appID)
                   .FirstOrDefault();

                    if (app == null)
                    {
                        return RedirectToAction("Unsuccessfull");
                    };
                    if (app.Idnumber != _idNumber)
                    {
                        return RedirectToAction("InvalidID");
                    };

                    if (!Convert.ToDecimal(app.FinanceAmount).Equals(p_amount))
                    {
                        return RedirectToAction("WrongPurchaseAmount");
                    }

                    HttpContext.Session.SetString("appId", app.Id.ToString());
                    HttpContext.Session.SetString("mobile", app.MobileNumber);
                    HttpContext.Session.SetString("amount", app.FinanceAmount.ToString());
                    HttpContext.Session.SetString("idNumber", app.Idnumber);
                }

                else if (isApproved.Any() == false)
                {
                    return RedirectToAction("Unsuccessfull");
                }

                return RedirectToAction("CollectionInfo");
            }

        }

        #endregion

        #region [ CollectionInfo ]

        public IActionResult CollectionInfo()
        {

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            var appId = HttpContext.Session.GetString("appId");
            var mobile = HttpContext.Session.GetString("mobile");
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;

            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title,
                ApplicationId = Convert.ToInt64(appId),
                MobileNumber = mobile,
                PurchaseAmount = purchaseAmount.text
            };

            aPIClient.SendRedeemAuthSMS(Convert.ToInt64(appId));

            return View(model);
        }

        #endregion

        #region [ AuthoriseCollect ]
        public IActionResult AuthoriseCollect()
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            var mobile = HttpContext.Session.GetString("mobile");

            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title,
                MobileNumber = mobile,
                PurchaseAmount = purchaseAmount.text

            };
            return View(model);
        }

        public void ResendCollectionCode()
        {
            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            var appId = HttpContext.Session.GetString("appId");

            aPIClient.SendRedeemAuthSMS(Convert.ToInt64(appId));
        }

        [HttpPost]
        public IActionResult AuthoriseCollect(string otp)
        {

            var builder = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            var amount = HttpContext.Session.GetString("amount");
            var appId = HttpContext.Session.GetString("appId");
            var mobile = HttpContext.Session.GetString("mobile");
            var idNumber = HttpContext.Session.GetString("idNumber");

            using (StageRulesEngineContext _context = new StageRulesEngineContext())
            {
                var merchantTerminal = (from q in _context.MerchantTerminal where q.MerchantId == Convert.ToInt64(merchant.Id) select q.Eftvasserial).FirstOrDefault();
                HttpContext.Session.SetString("otp", otp);

                ApplicationModel model = new ApplicationModel
                {
                    Merchant = merchant.Title,
                    MobileNumber = mobile,
                    FinanceAmount = Convert.ToDecimal(amount),
                };
                var result = aPIClient.SubmitRedeemOTP(merchant.Id, merchantTerminal, otp, Convert.ToInt64(appId), "", mobile, idNumber);
                var _result = Newtonsoft.Json.JsonConvert.DeserializeObject<SPAPIResponse>(result);


                if (_result != null && _result.Messages.Any())
                {
                    var _mes = _result.Messages.FirstOrDefault();
                    switch (_mes.Code)
                    {
                        case "0":
                            return Redirect("CollectionOutcome");
                        case "1":
                            return Redirect("AuthoriseError");
                        case "99":
                        default:
                            return Redirect("AuthoriseError");
                    }
                }

                return Redirect("CollectionOutcome");
            }
        }

        #region [ AuthoriseError ]
        public IActionResult AuthoriseError()
        {
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title,
            };
            return View(model);
        }
        #endregion

        #endregion

        #region [ Verify ]
        public IActionResult Verify()
        {
            ApplicationModel model = new ApplicationModel
            {
            };
            return View();
        }

        public IActionResult WrongPurchaseAmount()
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title
            };
            return View(model);
        }
        public IActionResult Cancelled()
        {

            return View();
        }


        public IActionResult Unsuccessfull()
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title
            };
            return View(model);
        }


        public IActionResult InvalidID()
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            ApplicationModel model = new ApplicationModel
            {
                Merchant = merchant.Title
            };
            return View(model);
        }


        #region [ CollectionOutcome ]
        public IActionResult CollectionOutcome()
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            var amount = HttpContext.Session.GetString("amount");

            ApplicationModel model = new ApplicationModel
            {
                PurchaseAmount = purchaseAmount.text,
                Merchant = merchant.Title,
            };
            return View(model);
        }

        #region [ CollectionOutcome ]
        public IActionResult CollectionComplete()
        {
            var purchaseAmount = QueryCodeResult.queryResFields.purchaseAmount;
            var mId = HttpContext.Session.GetString("mid");
            string redirectURL = _configuration["QRURL:Endpoint"].ToString();

            ApplicationModel model = new ApplicationModel
            {
                PurchaseAmount = purchaseAmount.text,
                Merchant = merchant.Title,
                MerchantID = Convert.ToInt64(mId),
                QrRedirect = redirectURL + Convert.ToInt64(mId)
            };
            return View(model);

        }

        #endregion

        #endregion

        #region [ SureSwipe Requests ]

        #region [ RequestCode ]
        [HttpGet]
        public async Task<JsonResult> RequestCode(string code)
        {
            bool isSuccess = false;
            var result = await RequestCodeAsync(code);
            if (result == "Success")
            {
                isSuccess = true;
            }
            return Json(isSuccess);
        }

        #endregion

        #region [ MobileNotifyRequest ]
        [HttpGet]
        public async Task<JsonResult> MobileNotifyRequest()
        {
            var appId = HttpContext.Session.GetString("appId");
            var mid = HttpContext.Session.GetString("mid");
            var mobile = HttpContext.Session.GetString("mobile");
            var idNumber = HttpContext.Session.GetString("idNumber");
            var otp = HttpContext.Session.GetString("otp");
            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            using (StageSwitchPayContext context = new StageSwitchPayContext())
            {
                var app = context.Application.FirstOrDefault(x => x.Id == Convert.ToInt64(appId));

                var result = await MobileNotifyRequestAsync();

                if (result == "00")
                {
                    return Json(result);
                }

                if (result == "03" || result == "91" || result == "96")
                {
                    // Validate entity is not null
                    if (app != null)
                    {
                        app.AuditTypeId = 83;
                        app.InternalAuditTypeId = 83;
                        context.SaveChanges();
                    }

                    List<Audit> audit = (from q in context.Audit
                                         where (q.AuditTypeId == 25) && (q.ApplicationId == Convert.ToInt64(appId))
                                         select q).ToList();

                    context.Audit.RemoveRange(audit);
                    context.SaveChanges();

                    aPIClient.SaveAudit(Convert.ToInt64(appId), 83, "16", 0, "", "Remote Collection Request Failed - Sure Swipe");
                }

                return Json(result);
            }
        }

        #endregion

        #endregion

        #region [ Private Methods ]

        #region [ RequestCodeAsync ]
        private async Task<string> RequestCodeAsync(string code)
        {
            var mobile = HttpContext.Session.GetString("mobile");
            var appId = HttpContext.Session.GetString("appId");
            var mid = HttpContext.Session.GetString("mid");

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);
            var refCode = aPIClient.GenerateKey(2);

            var referenceId = refCode + DateTime.Now.ToString("yyMMdd") + DateTime.Now.ToString("HHmm");

            SwitchPayIntegration.APIInnerEdge aPIInnerEdge = new APIInnerEdge();
            //aPIInnerEdge.EndPoint = "http://10.0.6.36:9182";
            aPIInnerEdge.EndPoint = _configuration["InnerEdgeIntegration:EndPoint"].ToString();

            Inneredge.CreateQueryCodeRequest createQuery = new Inneredge.CreateQueryCodeRequest
            {
                merchantID = "100000000012345", // per merchant | 
                laneID = "00000011", // keep same or input 8 char string Terminal/VirtualTerminal ID
                referenceID = referenceId,// unique reference from switchpay
                localDate = DateTime.Now.ToString("yyyy-MM-dd"), // Date Now
                localTime = DateTime.Now.ToString("HH:mm:ss"), // Time Now
                code = code, // QR scanned code received
                processorID = "0013" // same always
            };

            string JsonCreateQuery = JsonConvert.SerializeObject(createQuery);
            object myJson = await aPIInnerEdge.CreateQueryCodeRequestAsync(JsonCreateQuery);

            QueryCodeResult = (Inneredge.CreateQueryCodeResponse)JsonConvert.DeserializeObject<Inneredge.CreateQueryCodeResponse>((string)myJson);
            HttpContext.Session.SetString("amount", QueryCodeResult.queryResFields.purchaseAmount.text);
            return QueryCodeResult.responseMessage;
        }

        #endregion

        #region [ MobileNotifyRequestAsync ]
        private async Task<string> MobileNotifyRequestAsync()
        {
            var mobile = HttpContext.Session.GetString("mobile");
            var appId = HttpContext.Session.GetString("appId");
            var mid = HttpContext.Session.GetString("mid");
            var idNumber = HttpContext.Session.GetString("idNumber");
            var otp = HttpContext.Session.GetString("otp");

            string switchEndpoint = _configuration["Integration:EndPoint"].ToString();
            integrationSPApi aPIClient = new integrationSPApi(switchEndpoint);

            using (StageSwitchPayContext spcontext = new StageSwitchPayContext())
            {
                var FirstName = (from q in spcontext.Application where q.Id == Convert.ToInt64(appId) select q.FirstName).FirstOrDefault();

                var s = QueryCodeResult;
                SwitchPayIntegration.APIInnerEdge aPIInnerEdge = new APIInnerEdge();
                //aPIInnerEdge.EndPoint = "http://10.0.6.36:9182";
                aPIInnerEdge.EndPoint = _configuration["InnerEdgeIntegration:EndPoint"].ToString();
                Inneredge.CreateMobileNotifyRequest createQuery = new Inneredge.CreateMobileNotifyRequest
                {
                    merchantID = s.merchantID,
                    laneID = s.laneID,
                    referenceID = s.referenceID,
                    localDate = s.localDate,
                    localTime = s.localTime,
                    merchantCode = s.queryResFields.merchantCode,
                    currency = s.queryResFields.purchaseAmount.currency,
                    purchaseAmount = s.queryResFields.purchaseAmount.text,
                    mobileNumber = mobile,
                    requestID = s.queryResFields.requestID,
                    code = s.queryResFields.code,
                    transactionId = appId, // App ID,
                    status = "SUCCESS",
                    processorID = "0013",
                    // alternate ID on Merchant

                    tenderType = "SwitchPay",
                    settlementSource = "SwitchPay",

                    amountCurrency = s.queryResFields.purchaseAmount.currency,
                    amount = s.queryResFields.purchaseAmount.text,

                    authCode = "DEBUG",
                    acquirerResponse = "00",
                    retrievalReferenceNumber = appId.ToString(), // SwitchPay App ID

                    accountType = "DEFAULT",
                    binLast4 = "", // not required to follow up
                    cardHolderName = FirstName,
                    cardType = "CREDIT"
                };

                string JsonCreateQuery = JsonConvert.SerializeObject(createQuery);
                object myJson = await aPIInnerEdge.CreateMobileNotifyRequestAsync(JsonCreateQuery);

                MobileNotifyResult = (Inneredge.CreateMobileNotifyResponse)JsonConvert.DeserializeObject<Inneredge.CreateMobileNotifyResponse>((string)myJson);

                Models.Application.Application app = spcontext.Application.Where(a => a.Id == Convert.ToInt64(appId)).FirstOrDefault();
                app.Reference = MobileNotifyResult.referenceID;
                spcontext.SaveChanges();
            }

            if (MobileNotifyResult.responseCode == "00")
            {
                var s = aPIClient.SubmitRedeemOTP(Convert.ToInt64(mid), "", otp, Convert.ToInt64(appId), "", mobile, idNumber);
            }

            return MobileNotifyResult.responseCode;
        }
        #endregion

        #endregion
    }
    #endregion
}
#endregion