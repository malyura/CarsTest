using System.Linq;
using CarsTest.Models;
using Framework;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Pages
{
    public class ComparePage:BasePage
    {
        private static By locCompair = By.XPath("//a[@id='compare-thumbnail']");
        private Button btnAdd = new Button(By.XPath("//cui-icon[@name='plus-line']"),"Open Add form");
        private ListElements lstEngines = new ListElements(By.XPath("//div[@id='researchCompareRoot']//cars-compare-compare-info[contains(@header,'Engine')]//span[contains(@class,'three-cars')]"), "cars engines list");
        private ListElements lstTransmissions = new ListElements(By.XPath("//div[@id='researchCompareRoot']//cars-compare-compare-info[@header='Transmission']//span[contains(@class,'three-cars')]"),"cars transmissions list");
        public ComparePage() : base(new Menu(locCompair, "Page SelectCompare is open"))
        {
        }

        public void ClickAddCar()
        {
            btnAdd.Click();
        }

        public CarProperties GetFirstCar()
        {
            var car = new CarProperties
            {
                Engine = lstEngines.GetTextFromListElements().First(),
                Transmission = lstTransmissions.GetTextFromListElements().First()
            };
            return car;
        }

        public CarProperties GetSecondCar()
        {
            var car = new CarProperties
            {
                Engine = lstEngines.GetTextFromListElements().Skip(1).First(),
                Transmission = lstTransmissions.GetTextFromListElements().Skip(1).First()
            };
            return car;
        }
    }
}
