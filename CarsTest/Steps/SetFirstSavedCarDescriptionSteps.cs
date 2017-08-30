using CarsTest.Models;
using CarsTest.Pages;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public class SetFirstSavedCarDescriptionSteps
    {
        [When(@"I press button Compare cars")]
        public void WhenIPressButtonCompareCars()
        {
            var researchPage = new ResearchPage();
            researchPage.OpenSelectComparePage();
        }

        [Then(@"Select compare page is open")]
        public void ThenSelectComparePageIsOpen()
        {
            var selComparePage = new SelectComparePage();
        }

        [When(@"I select First saved model car")]
        public void WhenISelectFirstSavedModelCar()
        {
            var selComparePage = new SelectComparePage();
            var carFirst = ScenarioContext.Current["first_car"] as CarProperties;
            selComparePage.SelectFirstCarDescription(carFirst);
        }

        [When(@"I press button Start compare now")]
        public void WhenIPressButtonStartCompareNow()
        {
            var selComparePage = new SelectComparePage();
            selComparePage.OpenCompairPage();
        }

        [Then(@"Compare page is open")]
        public void ThenComparePageIsOpen()
        {
            var comparePage = new ComparePage();
        }
    }
}
