using FacebookAuto.BaseClass;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using FacebookAuto.PageObjects;

namespace FacebookAuto.TestScripts
{
    [TestFixture]
    class ObjectsVerification : BaseTest
    {
        [Test]
        public void FBObjectsVerification()
        {
            test = extent.CreateTest("FBObjectsVerification").Info("FB Objects Verification");
            test.Log(Status.Info, "Test Execution Start");
            var fbObjects = new FBHomePageObjects(driver);
            Boolean status = fbObjects.VerifyDisplayedFirstNameOnFBHomePage;
            if(status)
            {
                test.Log(Status.Info, "Firstname should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Firstname not displayed");
            }

            status = fbObjects.VerifyEnabledFirstNameOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Firstname should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Firstname not enabled");
            }

            ///enter firstname 
            fbObjects.EnterFirstName();
            test.Log(Status.Info, "First Name entered");

            ////-------
            status = fbObjects.VerifyDisplayedLastNameOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Lastname should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Lasstname not displayed");
            }

            status = fbObjects.VerifyEnabledLastNameOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Lastname should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Lastname not enabled");
            }
            /////enter Last Name
            fbObjects.EnterLastName();
            test.Log(Status.Info, "Last Name Entered");
            ////-----------
            status = fbObjects.VerifyDisplayedEmailForFbRegFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Email should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Email not displayed");
            }

            status = fbObjects.VerifyEnabledEmailForFbRegOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Email should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Email not enabled");
            }
            ////enter Email
            fbObjects.EnterEmailForFBReg();
            test.Log(Status.Info, "Email Entered");
            /////---------

            status = fbObjects.VerifyDisplayedRetypeEmailForFbRegFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Retype Email should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Retype Email not displayed");
            }

            status = fbObjects.VerifyEnabledRetypeEmailForFbRegOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Retype Email should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Retype Email not enabled");
            }
            /////enter retype email
            fbObjects.EnterRetypeEmailForFBReg();
            test.Log(Status.Info, "Retype Email Entered");
            ////---------
            status = fbObjects.VerifyDisplayedPasswordForFbRegFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Password should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Password not displayed");
            }

            status = fbObjects.VerifyEnabledPasswordForFbRegOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Password should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Password not enabled");
            }
            /////enter Password
            fbObjects.EnterPasswordForFBReg();
            test.Log(Status.Info, "Password Entered");
            //////------

            status = fbObjects.VerifyDisplayedMonthForFbRegFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Month should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Month not displayed");
            }

            status = fbObjects.VerifyEnabledMonthForFbRegOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Month should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Month not enabled");
            }
            /////Month Selected
            fbObjects.SelectMonth();
            test.Log(Status.Info, "Month Selected");

            //////------

            status = fbObjects.VerifyDisplayedDayForFbRegFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Day should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Day not displayed");
            }

            status = fbObjects.VerifyEnabledDayForFbRegOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Day should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Day not enabled");
            }
            /////Day Selected
            fbObjects.SelectDay();
            test.Log(Status.Info, "Day Selected");

            //////------

            status = fbObjects.VerifyDisplayedYearForFbRegFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Year should be displayed");
            }
            else
            {
                test.Log(Status.Info, "Year not displayed");
            }

            status = fbObjects.VerifyEnabledYearForFbRegOnFBHomePage;
            if (status)
            {
                test.Log(Status.Info, "Year should be Enabled");
            }
            else
            {
                test.Log(Status.Info, "Year not enabled");
            }
            /////Day Selected
            fbObjects.SelectYear();
            test.Log(Status.Info, "Year Selected");

            test.Log(Status.Pass, "Details Entered");


        }
    }
}











