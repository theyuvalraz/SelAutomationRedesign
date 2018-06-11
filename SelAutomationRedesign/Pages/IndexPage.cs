using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SelAutomationRedesign.Framework.Core;
using SelAutomationRedesign.Framework.UI;
using SelAutomationRedesign.Framework.UI.Controls;

namespace SelAutomationRedesign.Pages
{
    class IndexPage : Page
    {
        public Controller FeelingLuckyButton;

        public IndexPage(IWebDriver driverValue) : base(driverValue)
        {
            FeelingLuckyButton = new Controller(this, By.XPath( "//*/center/input[2]" ) );
        }

        public override Page Navigate()
        {
            var baseUrl = Configuration.Get( "BaseUrl" );
            Driver.Navigate().GoToUrl( baseUrl );
            return this;
        }
    }
}
