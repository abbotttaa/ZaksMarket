using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZaksMarketplace.Models;

namespace ZaksMarketplace.Controllers
{
    public class CateringInvoiceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CateringInvoice
        public ActionResult Index()
        {    
            return View();
        }

        public ActionResult StartTicket()
        {
            List<CateringInvoiceModels> MyInvoice = db.Invoices.ToList();
            return View(MyInvoice);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(CateringInvoiceModels Model)
        {
            
            db.Invoices.Add(Model);
            Model.DatePlaced = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime d = DateTime.Parse(Model.DateRequested);
            Model.DateRequested = d.ToString("MM/dd/yyyy");
            
            db.SaveChanges();
            return RedirectToAction("AddToCateringOrder", "CateringMenu");
        }
    }
}