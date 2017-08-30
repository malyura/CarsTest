using CarsTest.Menus;
using CarsTest.Models;
using CarsTest.Pages;
using Framework;
using TechTalk.SpecFlow;

namespace CarsTest.Steps
{
    [Binding]
    public class SelectFirstCarDescriptionSteps:BaseTest
    {
        [Given(@"Cars main page is open")]
        public void GivenCarsMainPageIsOpen()
        {
            var mainPage = new MainPage();
        }

        [When(@"I press tab Read Specs & Reviews")]
        public void WhenIPressTabReadSpecsReviews()
        {
            var mainPage = new MainPage();
            mainPage.SearchMenu.SelectTab(MenuSearchItems.ReadSpecsAndReview);
        }

        [Then(@"Tab Read Specs & Reviews is open")]
        public void ThenTabReadSpecsReviewsIsOpen()
        {
            var mainPage = new MainPage();
        }

        [When(@"I select in comboboxes random values Make, Model and Year for First car")]
        public void WhenISelectInComboboxesRandomValuesMakeModelAndYearForFirstCar()
        {
            var mainPage = new MainPage();
            mainPage.SelectRandomCarDescription();
        }

        [When(@"I Save selected values for First car")]
        public void WhenISaveSelectedValuesForFirstCar()
        {
            var mainPage = new MainPage();
            var car = new CarProperties();
            mainPage.SaveCarDescription(car);
            ScenarioContext.Current.Set(car, "first_car_description");
        }

        [When(@"I press button Search")]
        public void WhenIPressButtonSearch()
        {
            var mainPage = new MainPage();
            mainPage.OpenCarDescription();
        }

        [Then(@"Description page First car is open")]
        public void ThenDescriptionPageFirstCarIsOpen()
        {
            var descriptionPage = new DescriptionPage();
            var car = ScenarioContext.Current["first_car_description"] as CarProperties;
            car.EqualCarDescription(descriptionPage.GetCar(),"First car");
        }
    }
}
