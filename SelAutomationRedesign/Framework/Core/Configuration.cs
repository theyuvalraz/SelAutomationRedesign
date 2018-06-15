using System.Configuration;

namespace SelAutomationRedesign.Framework.Core
{
    public static class Configuration
    {
        public static int Timeout => int.Parse(Get("timeout"));

        public static string Get(string value)
        {
            return ConfigurationManager.AppSettings[value];
        }
    }
}