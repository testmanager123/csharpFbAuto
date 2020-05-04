using AventStack.ExtentReports;
using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookAuto.TestScripts.Module1
{
    [TestFixture]
    public class Module1 : BaseTest
    {
       
        [Test, Order(3)]
        public void TestMethod1()
        {
            test = extent.CreateTest("TestMethod1").Info("TestMethod1 is running");
            //Console.WriteLine("test started");
            test.Log(Status.Info, "execution start of fbReg");
            var fbHome = new FBHomePageObjects(driver);
            fbHome.fbReg();
            test.Log(Status.Info, "registereed");
            test.Log(Status.Pass, "my test is passed");
        }

        [Test, Order(2), Category("thisIsOrder")]
        public void fbForgotPwd()
        {
            test = extent.CreateTest("fbForgotPwd").Info("new test execution start");
            Thread.Sleep(5000);
            var fbHome = new FBHomePageObjects(driver);
            fbHome.forgotPwd();
            var recovEmail = new ForgotPwdPageObjects(driver);
            recovEmail.recoveryEmailProcess();
        }

        [Test, Order(1)]
        public void general()
        {
            Thread.Sleep(5000);
            String bT= driver.Title;
            
        }

        [Test, Order(4)]
        public void generalURL()
        {
            Thread.Sleep(5000);
            String bURL = driver.Url;
            var fbH = new FBHomePageObjects(driver);
            fbH.forgotPwd();
            var rec = new ForgotPwdPageObjects(driver);
            rec.recoveryEmailProcess();
        }

    }
}
