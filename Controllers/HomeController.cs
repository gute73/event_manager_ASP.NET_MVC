using EventManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManager.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Events.OrderByDescending(e => e.EventDate).ThenByDescending(e => e.EventTime).Where(e => e.EventDate >= DateTime.Now).ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}