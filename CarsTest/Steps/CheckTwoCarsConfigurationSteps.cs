using CarsTest.Models;
using CarsTest.Pages;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public class CheckTwoCarsConfigurationSteps
    {
        [When(@"I check description car on Compare page")]
        public void WhenICheckDescriptionCarOnComparePage()
        {
            var comparePage = new ComparePage();
        }

        [Then(@"Configuration first and second car are the same")]
        public void ThenConfigurationFirstAndSecondCarAreTheSame()
        {
            var comparePage = new ComparePage();
            var carFirst = ScenarioContext.Current["first_car"] as CarProperties;
            var carSecond = ScenarioContext.Current["second_car"] as CarProperties;
            carFirst.EqualCarConfig(comparePage.GetFirstCar(), "First car");
            carSecond.EqualCarConfig(comparePage.GetSecondCar(),"Second car");
        }
    }
}
