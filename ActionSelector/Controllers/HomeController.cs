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
        [HttpGet] // Use can user [AcceptVerb attribute instead of this attribute.]
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

        [NonAction]
        public string NonActionMethod()
        {
            return "This is non action method attribute example";
        }

        public string NonActionMethod2()
        {
            return "This is non action method attribute examples";
        }
    }
}