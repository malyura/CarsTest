using System;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Menus
{
    public class MenuBuy
    {
        private Menu menuBuy = new Menu(By.XPath("//a[contains(@menu-name,'Buy')]//cui-icon[@name='chevron']"), "open menu Buy");
        private Link linkFindCarForSale = new Link(By.XPath("//a[contains(@href,'cars.com/shop') and not (contains(@name,'research'))]"), "link shop page");
        private Link linkResearchCarModel = new Link(By.XPath("//a[contains(@href,'cars.com/research') and contains(@name,'research')]"), "link shop page");

        public void SelectItem(MenuBuyItems items)
        {
            menuBuy.Click();
            switch (items)
            {
                case MenuBuyItems.FindCarsForSale:
                    linkFindCarForSale.Click();
                    break;

                case MenuBuyItems.ResearchCarModel:
                    linkResearchCarModel.Click();
                    break;

                default:
                {
                    throw new IndexOutOfRangeException("Incorrect item");
                }
            }
        }
    }
}

