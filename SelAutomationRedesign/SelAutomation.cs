using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelAutomationRedesign.Framework.Core;
namespace SelAutomationRedesign
{
    [TestFixture]
    public class SelAutomation
    {
        private IWebDriver _driver;
        private readonly string _baseUrl = Configuration.Get("BaseUrl");

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }


        [TestCase]
        public void TestOne()
        {
            _driver.Navigate().GoToUrl( _baseUrl );
            Assert.That( _driver.Title == "Google"); 
        }

    }
}
