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
    public class BaseTest
    {
      /*  public ExtentReports extent = null;
        public ExtentTest test = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();


            string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + @"../../../").FullName;
            directory = directory + "\\Results\\";
            DirectoryInfo path = Directory.GetParent(directory).CreateSubdirectory("Reports");
            
            var htmlReporter = new ExtentHtmlReporter(path + "\\Extent.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }*/

        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();  
            // driver = new InternetExplorerDriver();
            //driver = new FirefoxDriver();
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
