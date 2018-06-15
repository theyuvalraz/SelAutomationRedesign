using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SelAutomationRedesign.Framework.UI.Controls
{
    internal class SelectList : Controller
    {
        public SelectList(Page page, By locator) : base(page, locator)
        {
        }

        public SelectElement Select => new SelectElement(Element);

        public new string Text
        {
            get => Text();
            set => Select.SelectByText(value);
        }
    }
}