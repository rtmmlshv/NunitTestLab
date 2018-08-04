using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace NunitTestLab.Pages
{
    class ResultPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='rso']/div/div/div[1]//span[@class='st']")]
        private IWebElement searchResultBlock { get; set; }

        public ResultPage(IWebDriver driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        public bool searchResultText(string searchwords)
        {
            return searchResultBlock.Text.Contains(searchwords);
        }
    }
}
