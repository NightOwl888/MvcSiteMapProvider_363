using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_363.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home";

            return View();
        }

        public ActionResult GettingStarted()
        {
            ViewBag.Message = "Getting Started";

            return View();
        }

        public ActionResult Intro()
        {
            ViewBag.Message = "Intro";

            return View();
        }

        public ActionResult Installation()
        {
            ViewBag.Message = "Installation";

            return View();
        }

        public ActionResult Usage()
        {
            ViewBag.Message = "Usage";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Details";

            return View();
        }

        public ActionResult Feature1()
        {
            ViewBag.Message = "Feature1";

            return View();
        }

        public ActionResult Feature2()
        {
            ViewBag.Message = "Feature2";

            return View();
        }

        public ActionResult Other()
        {
            ViewBag.Message = "Other";

            return View();
        }

        public ActionResult License()
        {
            ViewBag.Message = "License";

            return View();
        }

        public ActionResult Support()
        {
            ViewBag.Message = "Support";

            return View();
        }
    }
}
