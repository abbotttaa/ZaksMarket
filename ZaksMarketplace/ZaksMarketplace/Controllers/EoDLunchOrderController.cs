using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZaksMarketplace.Models;

namespace ZaksMarketplace.Controllers
{
    public class EoDLunchOrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: EoDLunchOrder
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            string tomorrowWeather = WeatherAPI.CallAPITomorrowWeather();
            ViewBag.weather = tomorrowWeather;
            return View();
        }
        [HttpPost]
        public ActionResult Create(EoDLunchOrderModels Model)
        {
            db.Lunch.Add(Model);
            DateTime Clock = DateTime.Now;
            Model.DayOfWeek = (int)Clock.DayOfWeek;
            Model.TomorrowsWeather = WeatherAPI.CallAPITomorrowWeather();
            Model.Date = DateTime.Now.ToString("dd/MM/yyyy");
            db.SaveChanges();
            return RedirectToAction("Bingus", "EoDLunchOrderController");
            

        }
        public ActionResult Bingus()
        {
            return View();
        }
    }
}