using CarsTest.Models;
using CarsTest.Pages;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public class SetSecondSavedCarDescriptionSteps
    {
        [When(@"I press Add another car")]
        public void WhenIPressAddAnotherCar()
        {
            var comparePage = new ComparePage();
            comparePage.ClickAddCar();
        }

        [Then(@"Add car page is open")]
        public void ThenAddCarPageIsOpen()
        {
            var addCar = new AddCarPage();
        }

        [When(@"I select Second saved model car")]
        public void WhenISelectSecondSavedModelCar()
        {
            var addCar = new AddCarPage();
            var carSecond = ScenarioContext.Current["second_car"] as CarProperties;
            addCar.AddSecondCar(carSecond);
        }

        [When(@"I press button Done")]
        public void WhenIPressButtonDone()
        {
            var addCarPage = new AddCarPage();
            addCarPage.ClickDone();
        }
    }
}
