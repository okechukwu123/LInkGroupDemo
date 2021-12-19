using LinkGroup.DemoTests_Two.Driver;
using LinkGroup.DemoTests_Two.PageObject;
using LinkGroup.DemoTests_Two.TestData;
using LinkGroup.DemoTests_Two.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests_Two.StepDefinition
{
    [Binding]
    public sealed class LinkGroupHomePageStep
    {
        LinkGroupHomePage homePage;
        ContactPage contactPage;
        [When(@"I open the home page")]
        public void WhenIOpenTheHomePage()
        {
            DriverClass.StartTest(TestConfig.LinkGrouplUrl);
            homePage = new LinkGroupHomePage(CustomBaseClass.MyDriver);
        }
        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            var isPageDisplayed = homePage.PageDisplayed();

            Assert.That(isPageDisplayed.Contains("Link Group"));
            DriverClass.CloseTest();
        }


        [When(@"I have agreed to the cookie policy")]
        public void WhenIHaveAgreedToTheCookiePolicy()
        {
            homePage.ClickOnCookies();
        }
        [When(@"I select Contact")]
        public void WhenISelectContact()
        {
            homePage.ClickOnContact();
        }
        [Then(@"the Contact page is displayed")]
        public void ThenTheContactPageIsDisplayed()
        {
            contactPage = new ContactPage(CustomBaseClass.MyDriver);
            var _PageHeader = contactPage.GetContactPageHeader();
            Assert.That(_PageHeader.Contains("Contact"));
            DriverClass.CloseTest();
        }



    }
}

