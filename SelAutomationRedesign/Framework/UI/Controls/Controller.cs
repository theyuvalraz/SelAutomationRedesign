using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SelAutomationRedesign.Framework.Core;

namespace SelAutomationRedesign.Framework.UI.Controls
{
    public class Controller
    {
        public By Locator { get; }
        public Page Page { get;}
        public IWebElement Element => Page.Driver.FindElement( Locator );

        public Controller(Page page, By locator)
        {
            Page = page;
            Locator = locator;
        }

        public bool Displayed( int timeout )
        {
            try
            {
                var wait = new WebDriverWait( Page.Driver , TimeSpan.FromSeconds( timeout ) );
                wait.Until( drv => drv.FindElement( Locator ).Displayed );
            }
            catch (WebDriverException)
            {
                return false;
            }
            return true;
        }

        public bool Displayed()
        {
            return Displayed( Configuration.Timeout );
        }

        public string Text()
        {
            Assert.True( Displayed(), "Unable to Locate Element" );
            return Element.Text;
        }

        public virtual void Click()
        {
            Assert.True( Displayed(), "Unable to Locate Element" );
            Element.Click();
        }

    }
}