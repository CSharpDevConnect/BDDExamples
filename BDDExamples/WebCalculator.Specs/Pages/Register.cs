using OpenQA.Selenium;
using Passenger.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalculator.Specs.Pages
{
    [Uri("/Account/Register")]
    public class Register
    {
        [Id]
        public virtual IWebElement Email { get; set; }

        [Id]
        public virtual IWebElement Password { get; set; }

        [Id]
        public virtual IWebElement ConfirmPassword { get; set; }

        [CssSelector(".btn.btn-default")]
        public virtual IWebElement RegisterButton { get; set; }

        internal void FillInForm(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            ConfirmPassword.SendKeys(password);
        }
    }
}
