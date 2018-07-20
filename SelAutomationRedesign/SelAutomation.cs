using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SelAutomationRedesign.Pages;
using WebAutomation.Core;

namespace SelAutomationRedesign
{
    [TestFixture]
    [Property("type", "ui")]
    public class SelAutomation
    {
        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--lang=en-GB", "start-maximized");
            ATDriver = AutomationDriverFactory.Get();
            ATDriver.WebDriver = new ChromeDriver( "C:\\yuvalMisc\\ChromeDriver\\chromedriver.exe", options);
            ;
        }


        [TearDown]
        public void TearDown()
        {
            ATDriver.WebDriver.Quit();
        }

        public IAutomationDriver ATDriver { get; set; }

        [Test]
        public void GlobalElementTest()
        {
            ATDriver.WebDriver.Navigate().GoToUrl("https://github.com/theyuvalraz");
            var GithubPage = ATDriver.Get<Github>();
            GithubPage.GlobalHeaderMenu_Features.Perform.Click();
            Assert.That(GithubPage.GlobalHeaderMenu_Explore.WillBe.Present);
            Assert.That(GithubPage.GlobalHeaderMenu_Features.WillBe.Present);
            Assert.That(GithubPage.GlobalHeaderMenu_Business.WillBe.Present);
            Assert.That(GithubPage.GlobalHeaderMenu_Marketplace.WillBe.Present);
            Assert.That(GithubPage.GlobalHeaderMenu_Pricing.WillBe.Present);
        }


        [Test]
        public void LuckyTest_WebAutomation()
        {
            ATDriver.WebDriver.Navigate().GoToUrl("http://www.google.com");
            var searchPage = ATDriver.Get<GoogleSearchPage>();
            searchPage.SearchFeelingLuckyButton.Perform.Click();
            Assert.That(ATDriver.WebDriver.Title == "Google Doodles");
        }

        [Test]
        public void SearchTest_WebAutomation()
        {
            ATDriver.WebDriver.Navigate().GoToUrl("http://www.google.com");
            var searchPage = ATDriver.Get<GoogleSearchPage>();
            searchPage.SearchSearchField.Perform.Fill("Yuval Raz github");
            searchPage.SearchFeelingLuckyButton.Perform.Click();
            Assert.That(ATDriver.WebDriver.Url == "https://github.com/theyuvalraz");
        }
    }
}
