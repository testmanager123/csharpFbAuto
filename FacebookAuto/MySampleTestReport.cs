using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookAuto
{
    [TestFixture]
    class MySampleTestReport
    {
        ExtentReports extent = null;
        ExtentTest test = null;
        IWebDriver driver = null;
        


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



        [Test]
        public void fbRegReport()
        {

            try
            {
                test = extent.CreateTest("Test").Info("Test fbReg Report started");

                driver = new ChromeDriver();
                test.Log(Status.Info, "instance created");
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://www.facebook.com");
                test.Log(Status.Info, "url entered");
                IWebElement fname = driver.FindElement(By.Name("firstname"));
                test.Log(Status.Info, "indetify the firstname ");
                fname.SendKeys("manager");
                test.Log(Status.Info, "Firstname entered ");
                IWebElement lname = driver.FindElement(By.Name("lastname"));
                test.Log(Status.Info, "indetify the lastname ");
                lname.SendKeys("viewer");
                test.Log(Status.Info, "Lastname entered ");


                Thread.Sleep(5000);
                driver.Close();
                driver.Quit();
                test.Log(Status.Pass, "test passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }


        [Test]
        public void fbForgotPwd()
        {

            try
            {
                test = extent.CreateTest("Test2").Info("Test fbForgotPwd Report started");

                driver = new ChromeDriver();
                test.Log(Status.Info, "instance created");
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://www.facebook.com");
                test.Log(Status.Info, "url entered");
                String MainT = driver.Title;
                IWebElement forgotLink = driver.FindElement(By.LinkText("Forgotten account?"));
                test.Log(Status.Info, "indetify the forgot pwde ");
                forgotLink.Click();
                test.Log(Status.Info, "click on forgot link ");
                Assert.AreNotEqual(driver.Title, MainT);
                test.Log(Status.Pass, "new page displayed");

                Thread.Sleep(5000);
                driver.Close();
                driver.Quit();
                test.Log(Status.Pass, "test passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }

     }
 }
