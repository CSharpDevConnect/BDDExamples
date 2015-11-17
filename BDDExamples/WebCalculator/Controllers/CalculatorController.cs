using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Display()
        {
            return View(new SimpleCalculator.Calculator());
        }

        // POST: Add
        [HttpPost]
        public ActionResult Add(int firstNumber, int secondNumber)
        {
            var calc = new SimpleCalculator.Calculator() { FirstNumber = firstNumber, SecondNumber = secondNumber };
            return PartialView(calc.Add());
        }
    }
}