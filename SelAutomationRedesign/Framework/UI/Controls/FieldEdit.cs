using OpenQA.Selenium;

namespace SelAutomationRedesign.Framework.UI.Controls
{
    internal class FieldEdit : Controller
    {
        public FieldEdit(Page page, By locator) : base(page, locator)
        {
        }

        public new string Text
        {
            get => Text();
            set
            {
                Click();
                Element.Clear();
                Element.SendKeys(value);
            }
        }
    }
}