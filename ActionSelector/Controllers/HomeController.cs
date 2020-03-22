using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelector.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("Home")]
        [HttpGet]
        public string Index()
        {
            return "Index Action Method is called.";
        }

        [ActionName("List")]
        [AcceptVerbs(HttpVerbs.Get)]
        public ViewResult Details()
        {
            return View("Details");
        }
    }
}