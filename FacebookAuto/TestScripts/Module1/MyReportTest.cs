using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.TestScripts.Module1
{
    [TestFixture]
    public class MyReportTest : BaseTest 
    {      
        [Test]
        public void myTestRun()
        {
            test = extent.CreateTest("nytestRun").Info("start ned test");
            try
            {
                test.Log(Status.Info, "start test");
                var hfb = new FBHomePageObjects(driver);
                ///enter firstname  
                hfb.EnterFirstName();
                test.Log(Status.Info, "test completed");
                test.Log(Status.Pass, "properly executed");
            }
            catch(NoSuchElementException e)
            {
                test.Log(Status.Fail, "test failed " + e);
                throw;
            }
           
        }
    }
}













