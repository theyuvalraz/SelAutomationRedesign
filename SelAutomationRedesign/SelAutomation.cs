using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Remote;
using SelAutomationRedesign.Framework.Core;
using SelAutomationRedesign.Pages;

namespace SelAutomationRedesign
{
    [TestFixture]
    public class SelAutomation
    {
        private IWebDriver _driver;
        private IndexPage _indexPage;


        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments( "--lang=en-GB", "start-maximized");
            _driver = new ChromeDriver( options );
            _indexPage = new IndexPage(_driver);
            
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }


        [TestCase]
        public void BasicsTest()
        {
            _indexPage.Navigate();
            Assert.That( _driver.Title == "Google");
        }

        [TestCase]
        public void LuckyTest()
        {
            _indexPage.Navigate();
            Assert.That( _indexPage.FeelingLuckyButton.Element.GetAttribute( "value" ) == "I\'m Feeling Lucky" );
            _indexPage.FeelingLuckyButton.Click();
            Assert.That( _driver.Title == "Google Doodles" );
        }

    }
}
