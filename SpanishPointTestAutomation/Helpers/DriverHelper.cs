using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpanishPointTestAutomation.Helpers
{
    public class DriverHelper
    {public static void MoveToElement(IWebElement element,IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
        public static void ScrollToElement(IWebElement element,IWebDriver driver)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public static void WaitForElement(IWebElement element,IWebDriver driver,double timeInSeconds, string expectedConditions)
        {  
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeInSeconds));
            switch(expectedConditions)
            {
                case "ToBeClickable":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                    break;
                case "IsVisible":
                    //write code for other conditions
                    break;
            }
        }
    }
}
