using OpenQA.Selenium;
using Passenger.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalculator.Specs.Pages
{
    [Uri("/Manage")]
    public class ManageAccountSettings
    {
        [CssSelector("p.text-success")]
        public virtual IWebElement SuccessMessage { get; set; }
    }
}
