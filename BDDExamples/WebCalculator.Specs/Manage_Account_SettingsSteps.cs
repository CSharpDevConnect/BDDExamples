using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Passenger;
using Passenger.Drivers.RemoteWebDriver;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using WebCalculator.Specs.Pages;

namespace WebCalculator.Specs
{
    [Binding]
    public class Manage_Account_SettingsSteps
    {
        PageObject<ManageAccountSettings> _ctx;

        string oldPassword = "Testing123!";

        public Manage_Account_SettingsSteps()
        {
            var driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));

            var config = new PassengerConfiguration
            {
                WebRoot = "http://localhost:64795/"
            }.WithDriver(driver);

            _ctx = config.StartTestAt<ManageAccountSettings>();

        }

        ~Manage_Account_SettingsSteps()
        {
            _ctx.Dispose();
        }

        [Given(@"A user is registered and logged in")]
        public void GivenTheUserIsRegisteredAndLoggedIn()
        {
            var email = string.Format("{0}@{1}.com", RandomString(5), RandomString(5));
            try
            {
                _ctx.VerifyRedirectionTo<Login>();
            }
            catch
            {
                _ctx.GoTo<Login>();
            }

            var login = _ctx.Page<Login>();
            login.FillInForm(email, oldPassword);
            login.LogIn.Click();
            if (!login.IsLoggedIn)
            {
                var register = _ctx.GoTo<Register>();
                register.FillInForm(email, oldPassword);
                register.RegisterButton.Click();
            }
        }

        [Given(@"I have navigated to the change password form")]
        public void GivenIHaveNavigatedToTheChangePasswordForm()
        {
            _ctx.GoTo<ChangePassword>();
        }

        [Given(@"I have filled in the Change Password Form correctly")]
        public void GivenIHaveFilledInTheChangePasswordFormCorrectly()
        {
            var newPassword = "123Test!";
            _ctx.Page<ChangePassword>().FillInForm(oldPassword, newPassword);
        }

        [When(@"I press Change Password")]
        public void WhenIPressChangePassword()
        {
            _ctx.Page<ChangePassword>().ChangePasswordButton.Click();
        }

        [Then(@"I see the confirmation message '(.*)' on the manage account settings screen")]
        public void ThenISeeTheConfirmationMessageOnTheManageAccountSettingsScreen(string p0)
        {
            _ctx.VerifyRedirectionTo<ManageAccountSettings>();
            Assert.AreEqual(p0, _ctx.Page<ManageAccountSettings>().SuccessMessage.Text);
        }

        [When(@"I navigate to the manage logins page")]
        public void WhenINavigateToTheManageLoginsPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see my list of external logins")]
        public void ThenISeeMyListOfExternalLogins()
        {
            ScenarioContext.Current.Pending();
        }


        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
