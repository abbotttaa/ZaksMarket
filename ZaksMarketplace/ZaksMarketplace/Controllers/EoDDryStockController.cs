using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZaksMarketplace.Models;

namespace ZaksMarketplace.Controllers
{
    public class EoDDryStockController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EoDDryStock
        public ActionResult Index()
        {
            return View(db.EoDDryStockModels.ToList());
        }

        // GET: EoDDryStock/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EoDDryStockModels eoDDryStockModels = db.EoDDryStockModels.Find(id);
            if (eoDDryStockModels == null)
            {
                return HttpNotFound();
            }
            return View(eoDDryStockModels);
        }

        // GET: EoDDryStock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EoDDryStock/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Date,DietCoke,Coke,Sprite,ChewyBar,Water,CupSleeve,CupPack,CupLid,Sugar,SugarInTheRaw,Creamer,Napkins,StirSicks,Chips,CoffeeFilter,Candy")] EoDDryStockModels eoDDryStockModels)
        {
            if (ModelState.IsValid)
            {
                db.EoDDryStockModels.Add(eoDDryStockModels);
                eoDDryStockModels.Date = DateTime.Now.ToString("dd/MM/yyyy");
                db.SaveChanges();
                return RedirectToAction("EmployeeTools", "Home");
            }

            return View(eoDDryStockModels);
        }

        // GET: EoDDryStock/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EoDDryStockModels eoDDryStockModels = db.EoDDryStockModels.Find(id);
            if (eoDDryStockModels == null)
            {
                return HttpNotFound();
            }
            return View(eoDDryStockModels);
        }

        // POST: EoDDryStock/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Date,DietCoke,Coke,Sprite,ChewyBar,Water,CupSleeve,CupPack,CupLid,Sugar,SugarInTheRaw,Creamer,Napkins,StirSicks,Chips,CoffeeFilter,Candy")] EoDDryStockModels eoDDryStockModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eoDDryStockModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eoDDryStockModels);
        }

        // GET: EoDDryStock/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EoDDryStockModels eoDDryStockModels = db.EoDDryStockModels.Find(id);
            if (eoDDryStockModels == null)
            {
                return HttpNotFound();
            }
            return View(eoDDryStockModels);
        }

        // POST: EoDDryStock/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EoDDryStockModels eoDDryStockModels = db.EoDDryStockModels.Find(id);
            db.EoDDryStockModels.Remove(eoDDryStockModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
