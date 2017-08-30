using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework
{
    public class Browser
    {
        private static IWebDriver driver;
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                switch (Config.Browser)
                {
                    case BrowserTypes.FIREFOX:
                        driver = new FirefoxDriver();
                        break;

                    case BrowserTypes.CHROME:
                        driver = new ChromeDriver();
                        break;

                    case BrowserTypes.Unknown:
                        throw new IndexOutOfRangeException("Unknown browser type");

                    default:
                    {
                        throw new IndexOutOfRangeException("Incorrect browser type");
                    }
                }
            }
            return driver;
        }

        public static void Quit()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

        public static void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
