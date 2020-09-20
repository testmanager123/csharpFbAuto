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
        public ExtentReports extent=null;
        public ExtentTest test = null;
        public ExtentTest node = null;

        public IWebDriver driver = null;
        [OneTimeSetUp]
        public void extentStart()
        {

            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("de-AT");
            //extent = new ExtentReports();
            
            string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + @"../../").FullName;
            String path = directory + "\\Results\\Reports\\myReport.html";
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(path);
            extent = new ExtentReports();   
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
            //Thread.Sleep(60000);
        }

        [TearDown]
        public void CloseApp()
        {
            Thread.Sleep(10000);
            driver.Close();
            driver.Quit();
        }

        public static string GetScreenShot(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            ////screenshot name filename
            String filename = DateTime.Now.ToString("dddd-dd-MMMM-yyyy-HH-mm-ss-");

            string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + @"../../").FullName;
            String path = directory + "\\ScreenShot\\ErrorScreenshots\\" + filename+screenShotName + ".png";
            string localpath = new Uri(path).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;
        }
    }
}










