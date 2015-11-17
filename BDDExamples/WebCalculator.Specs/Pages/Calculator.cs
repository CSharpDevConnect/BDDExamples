using OpenQA.Selenium;
using Passenger.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalculator.Specs.Pages
{
    [Uri("/Calculator/Display")]
    public class Calculator
    {
        [Id("firstNumber")]
        public virtual IWebElement FirstNumber { get; set; }

        [Id("secondNumber")]
        public virtual IWebElement SecondNumber { get; set; }

        [Id]
        public virtual IWebElement Display { get; set; }

        [Id("add")]
        public virtual IWebElement Add { get; set; }
    }
}
