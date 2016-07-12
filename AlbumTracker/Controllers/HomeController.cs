using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Not Just Another AlbumTracker";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "AlbumTracker";

            return View();
        }
    }
}