using System;
using System.Configuration;

namespace Framework
{
    public class Config
    {
        public static BrowserTypes Browser
        {
            get
            {
                BrowserTypes val;
                if (Enum.TryParse(GetConfiguration("browser"), true, out val))
                {
                    return val;
                }
                return BrowserTypes.Unknown;
            }
        }
        public static string Url => GetConfiguration("url");
        public static int ImplicitlyWait => GetConfigurationToInt("implicit_wait");
        public static int ExplicitlyWait => GetConfigurationToInt("explicit_wait");
        public static string CarConfigFile => GetConfiguration("car_configuration");
        public static string CarDescriptionFile => GetConfiguration("car_description");

        private static string GetConfiguration(string value)
        {
            return ConfigurationManager.AppSettings[value];
        }

        private static int GetConfigurationToInt(string value)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings[value]);
        }
    }
}
