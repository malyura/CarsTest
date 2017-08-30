using System.Text.RegularExpressions;
using CarsTest.Models;
using Framework;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Pages
{
    public class DescriptionPage:BasePage
    {
        private static By locCarDescription = By.XPath("//div[contains(@class,'specs-table')]");
        private Tab tabTrims = new Tab(By.XPath("//a[contains(@href,'trims')]"),"tab Trims");
        private Link linkCarConfig = new Link(By.XPath("//div[@id='mmy-trims']//a[contains(@href,'trims')]"),"link Configuration page");
        private Label lblDescription = new Label(By.XPath("//div[contains(@class,'title-year')]//h1"),"car description");

        public DescriptionPage() : base(new Menu(locCarDescription,"Description page is open"))
        {
        }

        public CarProperties GetCar()
        {
            var car = new CarProperties
            {
                Make = lblDescription.GetText(),
                Model = lblDescription.GetText(),
                Year = Regex.Match(lblDescription.GetText(), @"^\d+").Value
            };
            return car;
        }

        public void OpenCarConfiguration()
        {
            tabTrims.Click();
            Wait.Until(result => tabTrims.GetAttribute("class").Contains("active"));           
            linkCarConfig.Click();
        }
    }
}
