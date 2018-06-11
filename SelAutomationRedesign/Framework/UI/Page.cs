using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SelAutomationRedesign.Framework.UI
{
    class Page
    {
        public IWebDriver Driver { get; }

        public Page( IWebDriver driverValue )
        {
            Driver = driverValue;
        }

        public virtual Page Navigate()
        {
            return this;
        }

        public bool IsTextPresent( string text )
        {

            return true;
        }
    }
}
