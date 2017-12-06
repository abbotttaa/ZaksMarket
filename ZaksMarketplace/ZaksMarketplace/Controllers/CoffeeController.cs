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
    public class CoffeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Coffee
        public ActionResult Index()
        {
            return View(db.CoffeeModels.ToList());
        }

        // GET: Coffee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(coffeeModels);
        }

        // GET: Coffee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coffee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Year,Month,Day,RegularCoffee,DecafCoffee,Latte")] CoffeeModels coffeeModels)
        {
            if (ModelState.IsValid)
            {
                db.CoffeeModels.Add(coffeeModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coffeeModels);
        }

        // GET: Coffee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(coffeeModels);
        }

        // POST: Coffee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Year,Month,Day,RegularCoffee,DecafCoffee,Latte")] CoffeeModels coffeeModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coffeeModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coffeeModels);
        }

        // GET: Coffee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(coffeeModels);
        }

        // POST: Coffee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            db.CoffeeModels.Remove(coffeeModels);
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
