using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NunitTestLab.Pages;

namespace NunitTestLab.TestCases
{
    [TestFixture]
    public class GoogleSearchTextTest
    {
        public static IWebDriver driver;

        [Test]
        public void TextSearchTest()
        {
            // initialize webdriver
            driver = new FirefoxDriver();
            driver.Url = "http://google.com";

            //Create object for homepage
            var homePage = new HomePage(driver);
            //create object for resultpage
            var resultPage = new ResultPage(driver);

            //test
            homePage.fillSearchField("SomeText");
            homePage.clickSearchButton();
            // assert searched text
            Assert.AreEqual(resultPage.searchResultText("SomeTextResult"), true);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
