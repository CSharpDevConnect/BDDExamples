using OpenQA.Selenium;
using Passenger.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalculator.Specs.Pages
{
    [Uri("/Manage/ChangePassword")]
    public class ChangePassword
    {
        [Id]
        public virtual IWebElement OldPassword { get; set; }

        [Id]
        public virtual IWebElement NewPassword { get; set; }

        [Id]
        public virtual IWebElement ConfirmPassword { get; set; }

        [CssSelector(".btn.btn-default")]
        public virtual IWebElement ChangePasswordButton { get; set; }

        internal void FillInForm(string oldPassword, string newPassword)
        {
            OldPassword.SendKeys(oldPassword);
            NewPassword.SendKeys(newPassword);
            ConfirmPassword.SendKeys(newPassword);
        }
    }
}
