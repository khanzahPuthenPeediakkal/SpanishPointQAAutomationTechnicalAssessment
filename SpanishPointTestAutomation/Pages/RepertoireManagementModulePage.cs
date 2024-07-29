using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpanishPointTestAutomation.Helpers;
using System;
using System.Collections.Generic;

namespace SpanishPointTestAutomation.Pages
{
    public class RepertoireManagementModulePage
    {
        IWebDriver driver;
        private IWebElement AdditionalFeatureElement => driver.FindElement(By.XPath("//h2[text()='Additional Features']"));
        private IWebElement ProductSupportedElement => driver.FindElement(By.XPath("(//span[text()='Products Supported']//parent::a)[1]"));
        private IList<IWebElement> ListOfproductSupportedElement => driver.FindElements(By.XPath("(//div[contains(@class,'wpb_text_column')]//ul)[2]//li//span"));

        public  RepertoireManagementModulePage(IWebDriver _driver) 
        {
            driver = _driver;
        }
        public void ScrollToAdditionalFeatures()
        {
           DriverHelper.ScrollToElement(AdditionalFeatureElement,driver);
        }
        public void ClickOnProductSupport()
        {
            DriverHelper.MoveToElement(ProductSupportedElement,driver);
            DriverHelper.WaitForElement(ProductSupportedElement, driver, 5, "ToBeClickable");
            ProductSupportedElement.Click();
        }
        public IList<string> GetListOfProductsSupported()
        {
            var Product = new List<string>();

            foreach (var productSupportedElement in ListOfproductSupportedElement)
            {
                DriverHelper.MoveToElement(productSupportedElement,driver);
                string Productname = productSupportedElement.Text;              
                Product.Add(Productname);                
            }            
            return Product;
        }
    }
}
