using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.TestScripts.SmokeTest
{
    [TestFixture]
    public class RegistrationFB : BaseTest
    {
        
        [Test]
        public void MyFBReg()
        {
            test = extent.CreateTest("MyFBReg").Info("Fb Reg start");
            try
            {
                test.Log(Status.Info, "method started");
                var fbHome = new FBHomePageObjects(driver);
                ///enter firstname
                fbHome.EnterFirstName();
                test.Log(Status.Info, "execution completed");
                test.Log(Status.Pass, "details entered");
            }
            catch(NoSuchElementException e)
            {
                test.Log(Status.Fail, "test failed");
                throw;
            }
        }
    }
}
