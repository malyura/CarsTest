using System;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Menus
{
    public class MenuSearch
    {
        private Tab tabSpecsReviews = new Tab(By.XPath("//a[contains(@data-linkname,'Research')]"), "Open Specs & Reviews tab");

        public void SelectTab(MenuSearchItems tabName)
        {
            switch (tabName)
            {
                case MenuSearchItems.ReadSpecsAndReview:
                    tabSpecsReviews.Click();
                    break;

                default:
                {
                    throw new IndexOutOfRangeException("Incorrect tab");
                }
            }
        }

    }
}
