using Framework;
using Framework.Elements;
using OpenQA.Selenium;

namespace CarsTest.Pages
{
    public class ResearchPage:BasePage
    {
        private static By locResearchPage = By.XPath("//section[@id='research-comparisons']");
        private Button btnCompare = new Button(By.XPath("//section[@id='research-comparisons']//a[contains(@class,'comparisons')]"), "button Compare");
        
        public ResearchPage() : base(new Menu(locResearchPage,"Main page is open"))
        {
        }

        public void OpenSelectComparePage()
        {
            btnCompare.Click();
        }
    }
}
