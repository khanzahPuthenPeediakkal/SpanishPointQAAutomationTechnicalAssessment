using OpenQA.Selenium;
using SpanishPointTestAutomation.Helpers;
namespace SpanishPointTestAutomation.Pages
{   
    public class MatchingEnginePage
    {
        private readonly IWebDriver driver;
        private  IWebElement ModulesElement => driver.FindElement(By.XPath("//a[contains(@href,'Modules')]"));
        private IWebElement RMModuleElement => driver.FindElement(By.XPath("//a[text()='Repertoire Management Module']"));
        public MatchingEnginePage(IWebDriver _driver)
        {
            driver = _driver;
        }
         public void ClickOnModule()
        {
            DriverHelper.MoveToElement(ModulesElement, driver);
        }
        public void ClickOnRMModule()
        {
            DriverHelper.WaitForElement(RMModuleElement,driver, 5, "ToBeClickable");
            RMModuleElement.Click();
        }
    }
}
