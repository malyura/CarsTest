using CarsTest.Menus;
using CarsTest.Models;
using Framework;
using OpenQA.Selenium;
using Framework.Elements;

namespace CarsTest.Pages
{
    public class ConfigurationPage:BasePage
    {
        private static By locCarConfig = By.XPath("//div[contains(@class,'trim_listings')]");
        private Label lblEngine = new Label(By.XPath("//div[contains(@class,'trim-card')]//div[contains(@class,'cell-bg grow-2')]"),"engine config");
        private Label lblTransmission = new Label(By.XPath("//div[contains(@class,'trim-card')]//div[contains(@class,'cell grow-2')]"),"transmission config");

        public ConfigurationPage() : base(new Menu(locCarConfig,"Configuration page is open"))
        {
        }

        public MenuBuy BuyMenu => new MenuBuy();

        public void SaveCarConfiguration(CarProperties car)
        {
            car.Engine = lblEngine.GetText();
            car.Transmission = lblTransmission.GetText();
        }

        public void OpenMainPage()
        {
            LoadPage(Config.Url);
        }
       
    }
}
