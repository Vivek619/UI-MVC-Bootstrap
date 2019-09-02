using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace new3_30Aug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult posts()
        {
            return View();
        }

        public ActionResult categories()
        {
            return View();
        }
        public ActionResult users()
        {
            return View();
        }
        public ActionResult details()
        {
            return View();
        }
        public ActionResult settings()
        {
            return View();
        }
        public ActionResult profile()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}