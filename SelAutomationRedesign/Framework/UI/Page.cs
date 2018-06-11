using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SelAutomationRedesign.Framework.UI.Controls;

namespace SelAutomationRedesign.Framework.UI
{
    public abstract class Page
    {
        public IWebDriver Driver { get; }

        protected Page( IWebDriver driverValue )
        {
            Driver = driverValue;
        }

        public virtual Page Navigate()
        {
            return this;
        }

        public bool IsTextPresent( string text )
        {
            var locatorText = string.Format( $"//*[text()='{text}' or contains(text(), '{text}')]" );
            var element = new Controller( this, By.XPath( locatorText ) );
            return element.Displayed();
        }
    }
}
