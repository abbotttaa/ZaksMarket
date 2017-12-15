using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZaksMarketplace.Models;

namespace ZaksMarketplace.Controllers
{
    public class SpecialLunchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: SpecialLunch
        public ActionResult Index()
        {
            return View(db.Speacial.ToList());
        }
        [HttpGet]
        public ActionResult MakeSpecial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MakeSpecial(SpeacialLunchModels Model)
        {
            db.Speacial.Add(Model);
            DateTime d = DateTime.Parse(Model.DateOffered);
            Model.DateOffered = d.ToString("MM/dd/yyyy");
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult SignUp()
        {
            return View();
        }
    }
}