using OpenQA.Selenium;
using SelAutomationRedesign.Framework.Core;
using SelAutomationRedesign.Framework.UI;
using SelAutomationRedesign.Framework.UI.Controls;

namespace SelAutomationRedesign.Pages
{
    internal class GoogleSearchPage : Page
    {
        public Controller FeelingLuckyButton;
        public Controller SearchButton;
        public FieldEdit SearchField;


        public GoogleSearchPage(IWebDriver driverValue) : base(driverValue)
        {
            FeelingLuckyButton = new Controller(this, By.XPath("//*/center/input[2]"));
            SearchButton = new Controller(this, By.XPath("//*/center/input[1]"));
            SearchField = new FieldEdit(this, By.Name("q"));
        }

        public override Page Navigate()
        {
            var baseUrl = Configuration.Get("BaseUrl");
            Driver.Navigate().GoToUrl(baseUrl);
            return this;
        }
    }
}