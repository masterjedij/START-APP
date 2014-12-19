using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace START.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About START";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact The Developers";
            ViewBag.Address = "Physical Address:";

            return View();
        }
    }
}