using System;
using NLog;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Framework
{
    [Binding]
    public abstract class BaseTest
    {
        protected IWebDriver Driver = Browser.GetDriver();
        protected Logger Logger = LogManager.GetCurrentClassLogger();

        [BeforeScenario()]
        public void TestInitialize()
        {
            Logger.Debug("Add implicitly wait");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.ImplicitlyWait);
            Logger.Debug("Maximaze window browser");
            Driver.Manage().Window.Maximize();
            Logger.Debug("Navigate to URL");
            Browser.Navigate(Config.Url);
        }

        [AfterScenario()]
        public void TestCleanup()
        {
            Logger.Debug("Quit browser");
            Browser.Quit();
        }
    }
}
