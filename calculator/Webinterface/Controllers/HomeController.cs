using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using calculator.TwoArg;

namespace Webinterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operations = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "+", Value = "plus"},
                new SelectListItem() {Text = "-", Value = "minus"},
                new SelectListItem() {Text = "*", Value = "generation"},
                new SelectListItem() {Text = "division", Value = "division"},
                new SelectListItem() {Text = "xdegreey", Value = "xdegreey"},
                new SelectListItem() {Text = "xTo1dY", Value = "xTo1dY"},
                new SelectListItem() {Text = "logxy", Value = "logxy"},
                new SelectListItem() {Text = "Ostxy", Value = "Ostxy"},
                new SelectListItem() {Text = "min", Value = "min"},
                new SelectListItem() {Text = "max", Value = "max"},
                new SelectListItem() {Text = "Average", Value = "Average"},
                new SelectListItem() {Text = "Geometric", Value = "Geometric"}

            };
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

        public ActionResult Calculate(double first, double second, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(first, second);
            return View(result);

        }
}
}