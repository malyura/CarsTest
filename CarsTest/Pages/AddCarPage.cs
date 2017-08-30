using CarsTest.Models;
using Framework;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Pages
{
    public class AddCarPage:BasePage
    {
        private static By locAddForm = By.XPath("//div[contains(@class,'modal-content')]");
        private Combobox cmbMake = new Combobox(By.XPath("//form[@id='addCarFormModal']//select[@name='makeDropdown']"),"combobox a Make");
        private Combobox cmbModel = new Combobox(By.XPath("//form[@id='addCarFormModal']//select[@name='modelDropdown']"), "combobox a Model");
        private Combobox cmbYear = new Combobox(By.XPath("//form[@id='addCarFormModal']//select[@name='yearDropdown']"), "combobox a Year");
        private Button btnDone = new Button(By.XPath("//button[contains(@data-linkname,'add-car-select')]"),"add second car");

        public AddCarPage() : base(new Menu(locAddForm, "Page SelectCompare is open"))
        {
        }

        public void AddSecondCar(CarProperties car)
        {
            cmbMake.SelectItemByText(car.Make);
            cmbModel.SelectItemByText(car.Model);
            cmbYear.SelectItemByText(car.Year);
        }

        public void ClickDone()
        {
            btnDone.Click();
        }
    }
}
