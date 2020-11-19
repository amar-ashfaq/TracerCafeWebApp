using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TracerCafeWebApp.Controllers
{
    public class HomeController : Controller
    {
        //ViewBag - A property that is considered to be a dynamic object. It allows one to dynamically share data between Controllers & Views.  
        public ActionResult Index()
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