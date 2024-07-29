using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpanishPointTestAutomation.BrowseFactory
{
    public  class BrowserManagement
    {
        static IWebDriver driver = null;
        public static IWebDriver OpenBrowser(string browserName)
        {
            switch (browserName)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "FireFox":
                    //code to intilize ff
                    break;
            }
            return driver;
        }
    }
}
