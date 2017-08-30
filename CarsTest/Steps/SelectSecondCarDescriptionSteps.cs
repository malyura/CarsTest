using CarsTest.Models;
using CarsTest.Pages;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public class SelectSecondCarDescriptionSteps
    {  
        [When(@"I select in comboboxes random values Make, Model and Year car for Second car")]
        public void WhenISelectInComboboxesRandomValuesMakeModelAndYearCarForSecondCar()
        {
            var mainPage = new MainPage();
            mainPage.SelectRandomCarDescription();
        }

        [When(@"I Save selected values for Second car")]
        public void WhenISaveSelectedValuesForSecondCar()
        {
            var mainPage = new MainPage();
            var car = new CarProperties();
            mainPage.SaveCarDescription(car);
            ScenarioContext.Current.Set(car, "second_car_description");
        }

        [Then(@"Description page Second car is open")]
        public void ThenDescriptionPageSecondCarIsOpen()
        {
            var descriptionPage = new DescriptionPage();
            var car = ScenarioContext.Current["second_car_description"] as CarProperties;
            car.EqualCarDescription(descriptionPage.GetCar(), "Second car");
        }
    }
}
