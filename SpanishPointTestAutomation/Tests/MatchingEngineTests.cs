using NUnit.Framework;
using SpanishPointTestAutomation.Pages;
using System.Collections.Generic;
namespace SpanishPointTestAutomation.Tests
{
    [TestFixture]
    public class MatchingEngineTests:BaseTest
    {
       [Test]
       public void CheckProductsSupportedInRMModule()
       {
       LoadApplication();
       MatchingEnginePage MatchingEngineModule = new MatchingEnginePage(driver);
       MatchingEngineModule.ClickOnModule();
       MatchingEngineModule.ClickOnRMModule();
       RepertoireManagementModulePage RMModule = new RepertoireManagementModulePage(driver);
       RMModule.ScrollToAdditionalFeatures();
       RMModule.ClickOnProductSupport();
       IList<string> productsSupported= RMModule.GetListOfProductsSupported();
       Assert.AreEqual(productsSupported[0], "Cue Sheet / AV Work");
       Assert.AreEqual( productsSupported[1], "Recording");
       Assert.AreEqual(productsSupported[2], "Bundle");
       Assert.AreEqual(productsSupported[3], "Advertisement ");
       }
    }
    
}
