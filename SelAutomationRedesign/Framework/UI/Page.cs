using OpenQA.Selenium;
using SelAutomationRedesign.Framework.UI.Controls;

namespace SelAutomationRedesign.Framework.UI
{
    public abstract class Page
    {
        protected Page(IWebDriver driverValue)
        {
            Driver = driverValue;
        }

        public IWebDriver Driver { get; }

        public virtual Page Navigate()
        {
            return this;
        }

        public bool IsTextPresent(string text)
        {
            var locatorText = string.Format($"//*[text()='{text}' or contains(text(), '{text}')]");
            var element = new Controller(this, By.XPath(locatorText));
            return element.Displayed();
        }
    }
}