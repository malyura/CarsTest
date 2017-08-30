using CarsTest.Models;
using CarsTest.Pages;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public class SaveFirstCarConfigurationSteps
    {
        [When(@"I press link Trim comparison")]
        public void WhenIPressLinkTrimComparison()
        {
            var descriptionPage = new DescriptionPage();
            descriptionPage.OpenCarConfiguration();
        }

        [Then(@"Configuration page is open")]
        public void ThenConfigurationPageIsOpen()
        {
            var configurationPage = new ConfigurationPage();
        }

        [When(@"I save Engines and Transmissions configuration for First car")]
        public void WhenISaveEnginesAndTransmissionsConfigurationForFirstCar()
        {
            var configurationPage = new ConfigurationPage();
            var car = ScenarioContext.Current["first_car_description"] as CarProperties;
            configurationPage.SaveCarConfiguration(car);
            ScenarioContext.Current.Set(car, "first_car");
        }

        [When(@"I open main page")]
        public void WhenIOpenMainPage()
        {
            var configurationPage = new ConfigurationPage();
            configurationPage.OpenMainPage();
        }

        [Then(@"Main page is open")]
        public void ThenMainPageIsOpen()
        {
            var mainPage = new MainPage();
        }
    }
}
