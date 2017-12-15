using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZaksMarketplace.Models;

namespace ZaksMarketplace.Controllers
{
    public class AdminAnalyticsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: AdminAnalytics
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calc()
        {
            List<int> results = new List<int>();

            var result = db.EoDLunchModels.Where
                (x => x.GrilledCheese > 0).Select(m => m.Id);

            foreach (var thing in result)
            {
                results.Add(thing);
            }

            int count = results.Count;

            ViewBag.Banana = count;
            return View(ViewBag.Banana);
        }
    }
}