﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
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
            var test = extent.CreateTest("nytestRun");

            test.Info("test start");
            var hfb = new FBHomePageObjects(driver);
            hfb.fbReg();
            test.Info("test completed");
            test.Pass("properly executed");

           
        }
    }
}
