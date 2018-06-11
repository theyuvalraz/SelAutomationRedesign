using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SelAutomationRedesign.Framework.Core
{
    public static class Configuration
    {
        public static string Get( string value )
        {
            return ConfigurationManager.AppSettings[value];
        }
    }
}
