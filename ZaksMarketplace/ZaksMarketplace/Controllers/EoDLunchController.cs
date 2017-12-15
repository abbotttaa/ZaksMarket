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
    public class EoDLunchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        

        // GET: EoDLunch
        public ActionResult Index()
        {
            return View(db.EoDLunchModels.ToList());
        }

        // GET: EoDLunch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EoDLunchModels eoDLunchModels = db.EoDLunchModels.Find(id);
            if (eoDLunchModels == null)
            {
                return HttpNotFound();
            }
            return View(eoDLunchModels);
        }

        // GET: EoDLunch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EoDLunch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Date,ChefSalad,CranSalad,CaeserSalad,RanchDressingCup,BalsamicDressingCup,Tuna,ChickenSaladSam,ColdItalian,BuffaloRanch,BuffaloBleu,TurkeyClub,BLTCClub,PortabelloWrap,GrilledCheese,TurkeyApple,HamCheese,BLTCWrap")] EoDLunchModels eoDLunchModels)
        {
            if (ModelState.IsValid)
            {
                
                db.EoDLunchModels.Add(eoDLunchModels);
                DateTime Clock = DateTime.Now;
                eoDLunchModels.DayOfWeek = (int)Clock.DayOfWeek;
                eoDLunchModels.DaysWeather = WeatherAPI.CallAPICurrentWeather();
                eoDLunchModels.Date = DateTime.Now.ToString("dd/MM/yyyy");
                db.SaveChanges();
                return RedirectToAction("EmployeeTools", "Home");
            }

            return View(eoDLunchModels);
        }

        // GET: EoDLunch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EoDLunchModels eoDLunchModels = db.EoDLunchModels.Find(id);
            if (eoDLunchModels == null)
            {
                return HttpNotFound();
            }
            return View(eoDLunchModels);
        }

        // POST: EoDLunch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Date,ChefSalad,CranSalad,CaeserSalad,RanchDressingCup,BalsamicDressingCup,Tuna,ChickenSaladSam,ColdItalian,BuffaloRanch,BuffaloBleu,TurkeyClub,BLTCClub,PortabelloWrap,GrilledCheese,TurkeyApple,HamCheese,BLTCWrap")] EoDLunchModels eoDLunchModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eoDLunchModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eoDLunchModels);
        }

        // GET: EoDLunch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EoDLunchModels eoDLunchModels = db.EoDLunchModels.Find(id);
            if (eoDLunchModels == null)
            {
                return HttpNotFound();
            }
            return View(eoDLunchModels);
        }

        // POST: EoDLunch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EoDLunchModels eoDLunchModels = db.EoDLunchModels.Find(id);
            db.EoDLunchModels.Remove(eoDLunchModels);
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
