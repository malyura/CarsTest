using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Elements
{
    public class Combobox : BaseElement
    {
        public Combobox(By locator, string description) : base(locator, description)
        {
        }

        public string GetTextFromSelectedItem()
        {
            var select = new SelectElement(Driver.FindElement(Locator));
            return select.SelectedOption.Text;
        }

        public void SelectItemByIndex(int index)
        {
            var indXpath = index + 1;
            Logger.Info("Select " + Description + " index " + indXpath);
            var select = new SelectElement(Driver.FindElement(Locator));
            select.SelectByIndex(indXpath);
        }

        public void SelectItemByText(string text)
        {
            Logger.Info("Select " + Description + " item " + text);
            var select = new SelectElement(Driver.FindElement(Locator));
            select.SelectByText(text);
        }
    }
}
