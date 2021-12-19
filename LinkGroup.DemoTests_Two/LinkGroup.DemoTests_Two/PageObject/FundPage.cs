using LinkGroup.DemoTests_Two.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests_Two.PageObject
{
    public class FundPage
    {
        IWebDriver driver;
        public FundPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public IList<IWebElement> InvestmentManagerLink => driver.FindElements(By.CssSelector("[class='nav-link btn-link']"));
        public IWebElement FundBtn => driver.FindElement(By.CssSelector("[class='nav-link dropdown-toggle']"));
        public IWebElement cookiess => driver.FindElement(By.CssSelector("[aria-label='dismiss cookie message']"));

        public void ClickOnFund()
        {
            FundBtn.ActionClick();
            cookiess.JavascriptExcutor();

        }

        public void Fundmanagers(string Investors)
        {

            foreach (var item in InvestmentManagerLink)
            {
                if (item.Text.Contains(Investors))
                {
                    item.Click();
                    break;
                }


            }

        }
    }
}