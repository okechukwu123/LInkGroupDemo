using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests_Two.PageObject
{
    public class LinkGroupHomePage
    {
        IWebDriver driver;
        public LinkGroupHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement Homepage => driver.FindElement(By.CssSelector("[alt='Link Group logo']"));
        public IWebElement Contact => driver.FindElement(By.LinkText("Contact"));
        public IWebElement Cookies => driver.FindElement(By.CssSelector("[class='cc-btn cc-dismiss']"));


        public string PageDisplayed()
        {
            Console.WriteLine(driver.Title);
            return driver.Title;

        }
        public void ClickOnContact()
        {
            Contact.Click();


        }
        public void ClickOnCookies()
        {
            Cookies.Click();


        }
    }
}
