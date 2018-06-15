using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SelAutomationRedesign.Framework.UI.Controls
{
    class FieldEdit : Controller
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
