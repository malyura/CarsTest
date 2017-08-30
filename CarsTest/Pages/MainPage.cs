using CarsTest.Menus;
using CarsTest.Models;
using Framework;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Pages
{
    public class MainPage:BasePage
    {
        private static By locMainPage = By.XPath("//cui-tabs[@id='superwidget']");
        private Combobox cmbMake = new Combobox(By.XPath("//cui-tabs[@id='superwidget']//select[contains(@ng-options,'make')]"), "combobox a Make");
        private Combobox cmbModel = new Combobox(By.XPath("//cui-tabs[@id='superwidget']//select[contains(@ng-options,'model')]"), "combobox a Model");
        private Combobox cmbYear = new Combobox(By.XPath("//cui-tabs[@id='superwidget']//select[contains(@ng-options,'year')]"), "combobox a Year");
        private ListElements lstMake = new ListElements(By.XPath("//cui-tabs[@id='superwidget']//select[contains(@ng-options,'make')]//option[@label]"),"list a Make" );
        private ListElements lstModel = new ListElements(By.XPath("//cui-tabs[@id='superwidget']//select[contains(@ng-options,'model')]//option[@label]"), "list a Model");
        private ListElements lstYear = new ListElements(By.XPath("//cui-tabs[@id='superwidget']//select[contains(@ng-options,'year')]//option[@label]"), "list a Year");
        private Button btnSearch = new Button(By.XPath("//cui-tabs[@id='superwidget']//input[contains(@type,'submit')]"),"search button");

        public MainPage() : base(new Menu(locMainPage,"Main page is open"))
        {
        }

        public MenuSearch SearchMenu => new MenuSearch();

        public void SaveCarDescription(CarProperties car)
        {
            car.Make = cmbMake.GetTextFromSelectedItem();
            car.Model = cmbModel.GetTextFromSelectedItem();
            car.Year = cmbYear.GetTextFromSelectedItem();
        }

        public void SelectRandomCarDescription()
        {
            cmbMake.SelectItemByIndex(lstMake.GetRandomIndexListElements());
            cmbModel.SelectItemByIndex(lstModel.GetRandomIndexListElements());
            cmbYear.SelectItemByIndex(lstYear.GetRandomIndexListElements());   
        }

        public void OpenCarDescription()
        {
            btnSearch.Submit();
        }
    }
}
