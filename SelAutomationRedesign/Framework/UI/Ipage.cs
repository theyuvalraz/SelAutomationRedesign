using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SelAutomationRedesign.Framework.UI
{
    interface IPage
    {
        IWebDriver Driver { get; }
        Page Navigate();
        bool IsTextPresent(string text);
    }
}
