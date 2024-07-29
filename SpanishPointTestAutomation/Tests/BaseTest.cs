using NUnit.Framework;
using OpenQA.Selenium;
using SpanishPointTestAutomation.TestConfig;

namespace SpanishPointTestAutomation.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void InitializeBrowser()
        {
            string browser = ConfigurationManager.GetBrowser();
            driver = BrowseFactory.BrowserManagement.OpenBrowser(browser);
        }

        public void LoadApplication()
        {
            string url =ConfigurationManager.GetUrl();
            driver.Url = url;
            driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
