using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookAuto.BaseClass
{
    public class BaseTest
    {
        public ExtentReports extent = null;
        public ExtentTest test = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Srinivas\Desktop\CSharpFramework\FacebookAuto\FacebookAuto\Results\FBAutomation.html");
            extent.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.facebook.com");
            Thread.Sleep(5000);
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
        }

    }
}
