using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Passenger;
using Passenger.Drivers.RemoteWebDriver;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebCalculator.Specs.Pages;

namespace WebCalculator.Specs.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        PageObject<Calculator> _ctx;

        public CalculatorSteps()
        {
            var driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));

            var config = new PassengerConfiguration
            {
                WebRoot = "http://localhost:64795/"
            }.WithDriver(driver);

            _ctx = config.StartTestAt<Calculator>();

        }

        ~CalculatorSteps()
        {
            Thread.Sleep(2000);
            _ctx.Dispose();

        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _ctx.Page<Calculator>().FirstNumber.SendKeys(p0.ToString());
            Thread.Sleep(1000);
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            _ctx.Page<Calculator>().SecondNumber.SendKeys(p0.ToString());
            Thread.Sleep(1000);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _ctx.Page<Calculator>().Add.Click();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0.ToString(), _ctx.Page<Calculator>().Display.Text);
            Thread.Sleep(1000);
        }
    }
}
