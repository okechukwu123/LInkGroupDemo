using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests_Two.PageObject
{
    public class ContactPage
    {
        IWebDriver driver;
        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement ContactPageHeader => driver.FindElement(By.CssSelector("#page-wrap>div>div.contentHeader>div>h1"));
        public string GetContactPageHeader()
        {
            return ContactPageHeader.Text;


        }
    }

}
