using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thomas.Irwin.Ryan.Falcon.Lab6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "My 🌮 CMS";

            return View();
        }
    }
}
