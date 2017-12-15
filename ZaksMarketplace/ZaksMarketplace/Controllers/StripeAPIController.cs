using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZaksMarketplace.Controllers
{
    public class StripeAPIController : Controller
    {
        // GET: StripeAPI
        public ActionResult Index()
        {
            var stripePublishKey = ConfigurationManager.AppSettings["pk_test_JyNSZgxjUr924r5R0s6kbLxL"];
            ViewBag.StripePublishKey = stripePublishKey;
            return View();
        }
    }
}