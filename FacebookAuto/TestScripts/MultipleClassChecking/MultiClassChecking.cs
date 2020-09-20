using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace FacebookAuto.TestScripts.MultipleClassChecking
{
    [TestFixture]
    public class MultiClassChecking : BaseTest
    {
       
         
        [Test]
        public void MyFirstName()
        {
            string Cname = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;
            
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info(TestContext.CurrentContext.Test.Name + "  Method Start");

            try
            {
                test.Log(Status.Info, Cname);
                node = test.CreateNode(TestContext.CurrentContext.Test.Name +" Method Step").Info("method steps are executing");

                var fbh = new FBHomePageObjects(driver);
                Boolean status = fbh.VerifyDisplayedFirstNameOnFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "firstname displayed");
                }
                else
                {
                    node.Log(Status.Fail, "firstname not displayed");
                }

                status = fbh.VerifyEnabledFirstNameOnFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "firstname enabled");
                }
                else
                {
                    node.Log(Status.Fail, "firstname not enabled");
                }

                fbh.EnterFirstName();
                node.Log(Status.Info, "firstname entered");
                test.Log(Status.Pass, "My fristname information");
            }

            catch (NoSuchElementException e)
            {
                test.Log(Status.Fail, "My firstname information is different");
                throw;
            }
        }

        [Test]
        public void MyLastName()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info(TestContext.CurrentContext.Test.Name+"  Method Start");
            try
            {
                node = test.CreateNode("Method Step").Info("method steps are executing");

                var fbh = new FBHomePageObjects(driver);
                Boolean status = fbh.VerifyDisplayedLastNameOnFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "Lastname displayed");
                }
                else
                {
                    node.Log(Status.Fail, "lastname not displayed");
                }

                status = fbh.VerifyEnabledFirstNameOnFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "Lastname enabled");
                }
                else
                {
                    node.Log(Status.Fail, "Lastname not enabled");
                }

                fbh.EnterLastName();
                node.Log(Status.Info, "Lastname entered");
                test.Log(Status.Pass, "My Lastname information");
            }

            catch (NoSuchElementException e)
            {
                test.Log(Status.Fail, "My Lastname information is different");
                throw;
            }
        }

    }
}

