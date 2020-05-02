using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.BaseClass
{
    public class ExtentReport
    {
        public ExtentReports extent = null;
        public ExtentTest testex = null;
        [TestFixture]
        public class ExtentReports
        {
            //Instance of extents reports
            public static ExtentReports extent;
            public static ExtentTest test;
            public IWebDriver driver;

            public object LogStatus { get; private set; }

            [OneTimeSetUp]
            public void StartReport()
            {
                //To obtain the current solution path/project path
                string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
                string projectPath = new Uri(actualPath).LocalPath;

                //Append the html report file to current project path
                string reportPath = projectPath + "Reports\\TestRunReport.html";


                //Boolean value for replacing exisisting report
                extent = new ExtentReports();
                //Add QA system info to html report
                extent.AddSystemInfo("Host Name", "YourHostName");  
                var htmlReport = new ExtentHtmlReporter(reportPath);
                extent.AttachReporter(htmlReport);
                //Adding config.xml file
                //extent.LoadConfig(projectPath + "Extent-Config.xml"); //Get the config.xml file from http://extentreports.com

            }

            private void AttachReporter(ExtentHtmlReporter htmlReport)
            {
                throw new NotImplementedException();
            }

            private object AddSystemInfo(string v1, string v2)
            {
                throw new NotImplementedException();
            }

            [TearDown]
            public void AfterClass()
            {
                //StackTrace details for failed Testcases

                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stackTrace = " " + TestContext.CurrentContext.Result.StackTrace + " ";
                var errorMessage = TestContext.CurrentContext.Result.Message;

               /* if (status == TestStatus.Failed)
                {
                    test.Log(LogStatus.Fail, status + errorMessage);
                }
                */
                //End test report
                extent.EndTest(test);
                driver.Quit();
            }

            private void EndTest(ExtentTest test)
            {
                throw new NotImplementedException();
            }

            [OneTimeTearDown]
            public void EndReport()
            {
                //End Report
                extent.Flush();
                extent.Close();
            }

            private void Close()
            {
                throw new NotImplementedException();
            }

            private void Flush()
            {
                throw new NotImplementedException();
            }
        }
    }

}