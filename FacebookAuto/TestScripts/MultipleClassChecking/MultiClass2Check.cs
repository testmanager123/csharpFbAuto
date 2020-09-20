using AventStack.ExtentReports;
using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.TestScripts.MultipleClassChecking
{
    [TestFixture]
    class MultiClass2Check : BaseTest
    {
        [Test]
        public void MyEmailOnFBHome()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info(TestContext.CurrentContext.Test.Name + "  Method Start");
            try
            {
                node = test.CreateNode(TestContext.CurrentContext.Test.Name).Info("method steps are executing");

                var fbh = new FBHomePageObjects(driver);
                Boolean status = fbh.VerifyDisplayedEmailForFbRegFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "Email displayed");
                }
                else
                {
                    node.Log(Status.Fail, "Email not displayed");
                }

                status = fbh.VerifyEnabledEmailForFbRegOnFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "Email enabled");
                }
                else
                {
                    node.Log(Status.Fail, "Email not enabled");
                }

                fbh.EnterEmailForFBReg();
                node.Log(Status.Info, "Email entered");
                test.Log(Status.Pass, "My Email information");
            }

            catch (NoSuchElementException e)
            {
                test.Log(Status.Fail, "My Email information is different " + e);
                throw;
            }
        }

        [Test]
        public void MyRetypeEmailOnFBHome()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name).Info(TestContext.CurrentContext.Test.Name + "  Method Start");
            try
            {
                node = test.CreateNode(TestContext.CurrentContext.Test.Name).Info("method steps are executing");

                var fbh = new FBHomePageObjects(driver);
                Boolean status = fbh.VerifyDisplayedRetypeEmailForFbRegFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "Retype Email displayed");
                }
                else
                {
                    node.Log(Status.Fail, "Retype Email not displayed");
                }

                status = fbh.VerifyEnabledRetypeEmailForFbRegOnFBHomePage;
                if (status)
                {
                    node.Log(Status.Info, "Retype Email enabled");
                }
                else
                {
                    node.Log(Status.Fail, "Retype Email not enabled");
                }

                fbh.EnterRetypeEmailForFBReg();
                node.Log(Status.Info, "Retype Email entered");
                test.Log(Status.Pass, "My Retype Email information");
            }

            catch (NoSuchElementException e)
            {
                test.Log(Status.Fail, "My Retype Email information is different   " +e);
                throw;
            }
        }
    }
}
