﻿using System.Web.Mvc;
using SimpleCalculator.TwoArguments;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multiply", Text ="multiply"
                },
                new SelectListItem()
                {
                    Value = "sum", Text ="sum"
                },
                new SelectListItem()
                {
                    Value = "minus", Text ="minus"
                },
                new SelectListItem()
                {
                    Value = "division", Text ="division"
                }
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

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculate(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multiply", Text ="multiply"
                },
                new SelectListItem()
                {
                    Value = "sum", Text ="sum"
                },
                new SelectListItem()
                {
                    Value = "minus", Text ="minus"
                },
                new SelectListItem()
                {
                    Value = "division", Text ="division"
                }
            };
            return View();
        }
    }
}