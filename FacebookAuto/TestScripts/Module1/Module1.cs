using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info("TestMethod1 is running");
            try
            {
                //Console.WriteLine("test started");
                test.Log(Status.Info, "execution start of fbReg");
                var fbHome = new FBHomePageObjects(driver);
                fbHome.EnterFirstName();
                test.Log(Status.Info, "registereed");
                test.Log(Status.Pass, "my test is passed");
            }
            catch(NoSuchElementException e)
            {
                test.Log(Status.Fail, "failed " + e);
                throw;
            }
        }

        [Test, Order(2), Category("thisIsOrder")]
        public void fbForgotPwd()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info("new test execution start");
            try
            {
                test.Log(Status.Info, "for got pwd");
                Thread.Sleep(5000);
                var fbHome = new FBHomePageObjects(driver);
                fbHome.ClickOnforgotPwd();
                var recovEmail = new ForgotPwdPageObjects(driver);
                recovEmail.recoveryEmailProcess();
                test.Log(Status.Info, "for got pwd worked");
                test.Log(Status.Pass, "test passed");
            }
            catch(NoSuchElementException e)
            {
                test.Log(Status.Fail, "test forgot pwd failed " + e);
                throw;
            }

        }

        [Test, Order(1)]
        public void general()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info("capture current url");
            try
            {
                Thread.Sleep(5000);
                test.Log(Status.Info, "capture url");
                String bT = driver.Title;
                test.Log(Status.Info, bT);
                test.Log(Status.Info, "it updated");
                test.Log(Status.Info, "it updated with shyam");

                test.Log(Status.Pass, "Title properly captured");
                
            }
            catch (NoSuchElementException e)
            {
                test.Log(Status.Fail, "test failed " + e);
                throw;
            }
            
            
            
        }

        [Test, Order(4)]
        public void generalURL()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info("capture current url");
            
            try
            {
                Thread.Sleep(5000);
                test.Log(Status.Info, "capture url");
                String bURL = driver.Url;
                test.Log(Status.Info, bURL);
                test.Log(Status.Pass, "URL properly captured");
            }
            catch(NoSuchElementException e)
            {
                test.Log(Status.Fail, "test failed " + e);
                throw;
            }
            
            
            
        }

    }
}
