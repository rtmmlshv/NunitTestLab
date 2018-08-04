using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace NunitTestLab.Pages
{
    class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='lst-ib']")]
        private IWebElement searchField { get; set; }

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        // Sendkeys to search field
        public void fillSearchField(string searchText)
        {
            searchField.SendKeys(searchText);
        }

        // Click search button
        public void clickSearchButton()
        {
            searchField.Submit();
        }
    }
}
