using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, string description) : base(locator, description)
        {
        }

        public void Submit()
        {
            WaitElementIsVisible();
            Assert.IsTrue(IsPresent(), "Element is not present");
            Logger.Info("Submit " + Description);
            Driver.FindElement(Locator).Submit();
        }

    }
}
