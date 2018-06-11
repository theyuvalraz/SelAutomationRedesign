using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelAutomationRedesign
{
    [TestFixture]
    public class SelAutomation
    {
        private IWebDriver _driver;

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


        [TestCase()]
        public void TestOne()
        {
            _driver.Navigate().GoToUrl("http://www.google.com");
        }

    }
}
