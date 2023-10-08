using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Athoy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}