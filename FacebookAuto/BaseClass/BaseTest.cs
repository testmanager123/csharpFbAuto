using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookAuto.BaseClass
{
    [TestFixture]
    public class BaseTest
    {
        public ExtentReports extent = null;
        public ExtentTest test = null;
        public IWebDriver driver = null;
        [OneTimeSetUp]
        public void extentStart()
        {
            extent = new ExtentReports();

            string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + @"../../").FullName;
            String path = directory + "\\Results\\Reports\\myReport.html";
            var htmlReport = new ExtentHtmlReporter(path);
            extent.AttachReporter(htmlReport);
        }

        [OneTimeTearDown]
        public void extentClose()
        {
            extent.Flush();
        }

        [SetUp]
        public void OpenApp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.facebook.com");
        }

        [TearDown]
        public void CloseApp()
        {
            Thread.Sleep(10000);
            driver.Close();
            driver.Quit();
        }
    }
}