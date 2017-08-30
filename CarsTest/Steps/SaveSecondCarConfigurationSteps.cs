using CarsTest.Menus;
using CarsTest.Models;
using CarsTest.Pages;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public sealed class SaveSecondCarConfigurationSteps
    {
        [When(@"I save Engines and Transmissions configuration for Second car")]
        public void WhenISaveEnginesAndTransmissionsConfigurationForSecondCar()
        {
            var configurationPage = new ConfigurationPage();
            var car = ScenarioContext.Current["second_car_description"] as CarProperties;
            configurationPage.SaveCarConfiguration(car);
            ScenarioContext.Current.Set(car, "second_car");
        }

        [When(@"I press menu Buy -> Research car models")]
        public void WhenIPressMenuBuy_ResearchCarModels()
        {
            var configurationPage = new ConfigurationPage();
            configurationPage.BuyMenu.SelectItem(MenuBuyItems.ResearchCarModel);
        }

        [Then(@"Research page is open")]
        public void ThenResearchPageIsOpen()
        {
            var researchPage = new ResearchPage();
        }
    }
}
