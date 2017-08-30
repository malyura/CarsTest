using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Elements
{
    public class ListElements : BaseElement
    {
        public ListElements(By locator, string description) : base(locator, description)
        {
        }

        public IList<IWebElement> GetElements()
        {
            WaitListElementsIsVisible();
            return Driver.FindElements(Locator);
        }

        public List<string> GetTextFromListElements()
        {
            List<string> lstText = new List<string>();
            int attempts = 0;
            while (attempts < 5)
            {
                try
                {
                    foreach (var el in GetElements())
                    {
                        WaitElementIsVisible();
                        lstText.Add(el.Text);
                    }
                }
                catch (StaleElementReferenceException)
                {
                    lstText.Clear();
                }
                attempts++;
            }
            return lstText;
        }

        public IWebElement GetElementFromList(int index)
        {
            return GetElements()[index];
        }

        public int GetRandomIndexListElements()
        {
            WaitListElementsIsVisible();
            return new Random().Next(0, Driver.FindElements(Locator).Count);
        }

        private void WaitListElementsIsVisible()
        {
            Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(Locator));
        }
    }
}
