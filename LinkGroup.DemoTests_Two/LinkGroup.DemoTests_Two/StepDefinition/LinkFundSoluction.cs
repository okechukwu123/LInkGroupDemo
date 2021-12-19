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
    public sealed class LinkFundSoluction
    {
        FundPage fundPage;
        [Given(@"I have opened the Found Soluction page")]
        public void GivenIHaveOpenedTheFoundSoluctionPage()
        {
            fundPage = new FundPage(CustomBaseClass.MyDriver);
            DriverClass.StartTest(TestConfig.LinkFundUrl);

        }
        [When(@"I view Funds")]
        public void WhenIViewFunds()
        {

            fundPage = new FundPage(CustomBaseClass.MyDriver);
            fundPage.ClickOnFund();
        }
        [Then(@"I can select the investment manager for ""(.*)""Investors")]
        public void ThenICanSelectTheInvestmentManagerForInvestors(string Investors)
        {
            CustomBaseClass.Thinktime(3);
            fundPage = new FundPage(CustomBaseClass.MyDriver);
            fundPage.Fundmanagers(Investors);
            CustomBaseClass.Thinktime(3);

            Console.WriteLine(CustomBaseClass.MyDriver.Title);

            Assert.That(CustomBaseClass.MyDriver.Title.Contains(Investors));
            DriverClass.CloseTest();

        }

    }
}
