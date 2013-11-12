using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationTier.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Users will have the power to search through our existing collection";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mission Statement";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "USIMAC Contact Page";

            return View();
        }
    }
}
