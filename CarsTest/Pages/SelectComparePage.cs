using CarsTest.Models;
using Framework;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Pages
{
    public class SelectComparePage : BasePage
    {
        private static By locCompareMenu = By.XPath("//div[contains(@class,'research-compare')]//form[@name='addCarForm']");
        private Combobox cmbMake = new Combobox(By.XPath("//select[@id='make-dropdown']"),"combobox a Make");
        private Combobox cmbModel = new Combobox(By.XPath("//select[@id='model-dropdown']"), "combobox a Model");
        private Combobox cmbYear = new Combobox(By.XPath("//select[@id='year-dropdown']"), "combobox a Year");
        private Button btnStartCompare = new Button(By.XPath("//button[contains(@data-linkname,'Compare')]"),"button Start compare");
        
        public SelectComparePage() : base(new Menu(locCompareMenu, "Page SelectCompare is open"))
        {
        }

        public void SelectFirstCarDescription(CarProperties car)
        {
            cmbMake.SelectItemByText(car.Make);
            cmbModel.SelectItemByText(car.Model);
            cmbYear.SelectItemByText(car.Year);
        }

        public void OpenCompairPage()
        {
            btnStartCompare.Click();
        }

    }
}
