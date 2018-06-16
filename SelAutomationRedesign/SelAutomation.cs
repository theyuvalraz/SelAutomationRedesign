using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelAutomationRedesign.Pages;
using WebAutomation.Core;

namespace SelAutomationRedesign
{
    [TestFixture]
    public class SelAutomation
    {
        [SetUp]
        public void Setup()
        {
            
            var options = new ChromeOptions();
            options.AddArguments("--lang=en-GB", "start-maximized");
            _driver = new ChromeDriver(options);
            _indexPage = new GoogleSearchPage_old(_driver);
            ATDriver = AutomationDriverFactory.Get();
            ATDriver.WebDriver = _driver;

        }


        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
        public IAutomationDriver ATDriver { get; set; }

        private IWebDriver _driver;
        private GoogleSearchPage_old _indexPage;


        [TestCase]
        public void BasicsTest()
        {
            _indexPage.Navigate();
            Assert.That(_driver.Title == "Google");
        }

        [TestCase]
        public void LuckyTest()
        {
            _indexPage.Navigate();
            Assert.That(_indexPage.FeelingLuckyButton.Element.GetAttribute("value") == "I\'m Feeling Lucky");
            _indexPage.FeelingLuckyButton.Click();
            Assert.That(_driver.Title == "Google Doodles");
        }

        [TestCase]
        public void LuckyTest_WebAutomation()
        {
            ATDriver.WebDriver.Navigate().GoToUrl( "http://www.google.com" );
            var searchPage = ATDriver.Get<GoogleSearchPage>();
            searchPage.SearchFeelingLuckyButton.Perform.Click();
            Assert.That( ATDriver.WebDriver.Title == "Google Doodles" );
        }

        [TestCase]
        public void SearchTest()
        {
            _indexPage.Navigate();
            _indexPage.SearchField.Text = "theyuvalraz";
            _indexPage.FeelingLuckyButton.Click();
            Assert.That(_driver.Url == "https://github.com/theyuvalraz");
        }

        [TestCase]
        public void SearchTest_WebAutomation()
        {
            ATDriver.WebDriver.Navigate().GoToUrl( "http://www.google.com" );
            var searchPage = ATDriver.Get<GoogleSearchPage>();
            searchPage.SearchSearchField.Perform.Fill("theyuvalraz");
            searchPage.SearchFeelingLuckyButton.Perform.Click();
            Assert.That( ATDriver.WebDriver.Url == "https://github.com/theyuvalraz" );
        }
    }
}