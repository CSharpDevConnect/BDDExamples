using OpenQA.Selenium;
using Passenger.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalculator.Specs.Pages
{
    [Uri("/Account/Login")]
    public class Login
    {
        [Id]
        public virtual IWebElement Email { get; set; }

        [Id]
        public virtual IWebElement Password { get; set; }

        [CssSelector(".btn.btn-default")]
        public virtual IWebElement LogIn { get; set; }

        [Id("registerLink")]
        public virtual IWebElement RegisterLink { get; set; }

        public void FillInForm(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
        }

        public bool IsLoggedIn { get { return !RegisterLink.Displayed && !RegisterLink.Enabled; } }
    }
}
