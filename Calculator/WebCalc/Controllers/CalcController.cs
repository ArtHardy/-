using CalcConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var calc = new Calc();

            var model = new CalcModel()
            {
                Operations = calc.GetOperationNames()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Exec(string operation, string args)
        {
            var calc = new Calc();

            var result = calc.Exec(operation, args.Split(new[] { ' ', ',' }));

            var model = new CalcModel()
            {
                Operations = calc.GetOperationNames(),
                Result = result
            };

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult ExecAjax(string operation, string args)
        {
            var calc = new Calc();

            var result = calc.Exec(operation, args.Split(new[] { ' ', ',' }));

            return PartialView("Result", result);
        }
    }
}