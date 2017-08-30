using System;
using OpenQA.Selenium;
using Framework.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using OpenQA.Selenium.Support.UI;

namespace Framework
{
    public abstract class BasePage
    {
        protected IWebDriver Driver = Browser.GetDriver();
        protected Logger Logger = LogManager.GetCurrentClassLogger();
        protected WebDriverWait Wait;

        protected BasePage(BaseElement element)
        {
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Config.ExplicitlyWait));
            element.WaitElementIsVisible();
            Assert.IsTrue(element.IsPresent(), "Element is not present");
        }

        protected void LoadPage(string url)
        {
            Logger.Info("Go to url " + url);
            Browser.Navigate(url);
        }
    }
}
