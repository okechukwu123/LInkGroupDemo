using LinkGroup.DemoTests_Two.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LinkGroup.DemoTests_Two.Driver
{
    public static class DriverClass
    {


        public static void StartTest(string BaseURL)
        {
            try
            {

                ChromeOptions ChromeOptions = new ChromeOptions();
                ChromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                ChromeOptions.AddArguments("--start-maximized");
                ChromeOptions.AddArguments("--no-sandbox");
                //ChromeOptions.AddArgument("--headless");
                CustomBaseClass.MyDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ChromeOptions);
                CustomBaseClass.MyDriver.Navigate().GoToUrl(BaseURL);

                Console.WriteLine("Browser loaded, Test Passed");
            }
            catch (Exception testInitiationException)
            {
                Console.WriteLine("Failed Initiation : {0}", testInitiationException.Message);

                Assert.Fail();
            }
        }


        // Tears down test and throws exception
        public static void CloseTest()
        {
            try
            {
                CustomBaseClass.MyDriver.Close();
                CustomBaseClass.MyDriver.Quit();

                Console.WriteLine("Test Completes successfully");
            }
            catch (WebDriverException testClosingException)
            {
                Console.WriteLine("Driver Failed to close the browser: {0}", testClosingException.Message);
            }

        }


    }
}
