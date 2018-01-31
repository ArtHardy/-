using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    [Authorize]
    public class MyController : Controller
    {
        [HttpGet]
        public ActionResult Index(long? id)
        {
            ViewData.Model = $"{id}";

            ViewData["age"] = 30;
            ViewData.Add("isAdmin", false);

            ViewBag.lastname = "Varankin";

            ViewBag.Cities = new string[] { "Москва", "Питер" };

            return View("Name");
        }

        [HttpPost]
        public ActionResult Index(string firstname)
        {
            ViewData["age"] = 30;
            ViewData.Add("isAdmin", false);

            ViewBag.lastname = "Varankin";

            ViewBag.Cities = new string[] { "Москва", "Питер" };

            return View("Name", model: firstname);
        }
    }
}