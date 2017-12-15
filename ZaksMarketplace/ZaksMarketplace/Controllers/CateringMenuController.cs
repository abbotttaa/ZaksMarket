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
    public class CateringMenuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CateringMenuModels
        public ActionResult Index()
        {
            return View(db.Menus.ToList());
        }

        // GET: CateringMenuModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CateringMenuModels cateringMenuModels = db.Menus.Find(id);
            if (cateringMenuModels == null)
            {
                return HttpNotFound();
            }
            return View(cateringMenuModels);
        }

        // GET: CateringMenuModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CateringMenuModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ChefSalad,CranSalad,CaeserSalad,RanchDressingCup,BalsamicDressingCup,Tuna,ChickenSaladSam,ColdItalian,BuffaloRanch,BuffaloBleu,TurkeyClub,BLTCClub,PortabelloWrap,GrilledCheese,TurkeyApple,HamCheese,BLTCWrap,PotatoChips,SweetpotatoChips,Frys,VeggieMix,Coke,DietCoke,Sprite,Rootbeer,MountainDew,DrPepper,DietSprite,SmallHorderves,MediumHorderves,LargeHorderves,PotatoSalad,TacoPlatter,VegiesDip")] CateringMenuModels cateringMenuModels)
        {
            if (ModelState.IsValid)
            {
                db.Menus.Add(cateringMenuModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cateringMenuModels);
        }

        // GET: CateringMenuModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CateringMenuModels cateringMenuModels = db.Menus.Find(id);
            if (cateringMenuModels == null)
            {
                return HttpNotFound();
            }
            return View(cateringMenuModels);
        }

        // POST: CateringMenuModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ChefSalad,CranSalad,CaeserSalad,RanchDressingCup,BalsamicDressingCup,Tuna,ChickenSaladSam,ColdItalian,BuffaloRanch,BuffaloBleu,TurkeyClub,BLTCClub,PortabelloWrap,GrilledCheese,TurkeyApple,HamCheese,BLTCWrap,PotatoChips,SweetpotatoChips,Frys,VeggieMix,Coke,DietCoke,Sprite,Rootbeer,MountainDew,DrPepper,DietSprite,SmallHorderves,MediumHorderves,LargeHorderves,PotatoSalad,TacoPlatter,VegiesDip")] CateringMenuModels cateringMenuModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cateringMenuModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cateringMenuModels);
        }

        // GET: CateringMenuModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CateringMenuModels cateringMenuModels = db.Menus.Find(id);
            if (cateringMenuModels == null)
            {
                return HttpNotFound();
            }
            return View(cateringMenuModels);
        }

        // POST: CateringMenuModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CateringMenuModels cateringMenuModels = db.Menus.Find(id);
            db.Menus.Remove(cateringMenuModels);
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

        [HttpGet]
        public ActionResult AddToCateringOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddToCateringOrder(CateringMenuModels Model)
        {

            db.Menus.Add(Model);
            db.SaveChanges();
            return RedirectToAction("ConfirmCater", "Home");
        }
    }
}
