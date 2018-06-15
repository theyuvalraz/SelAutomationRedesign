using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SelAutomationRedesign.Framework.UI.Controls
{
    class SelectList : Controller
    {
        public SelectList(Page page, By locator) : base(page, locator)
        {
        }

        public SelectElement Select => new SelectElement( Element );

        public new string Text
        {
            get => Text();
            set => Select.SelectByText( value );
        }

    }
}
