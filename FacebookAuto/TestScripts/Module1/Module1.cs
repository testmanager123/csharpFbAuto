using FacebookAuto.BaseClass;
using FacebookAuto.PageObjects;
using NUnit.Framework;
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
            Console.WriteLine("test started");
            var fbHome = new FBHomePageObjects(driver);
            fbHome.fbReg();
        }

        [Test, Order(2)]
        public void fbForgotPwd()
        {
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

        [Test, Order(0)]
        public void generalURL()
        {
            Thread.Sleep(5000);
            String bURL = driver.Url;

        }

    }
}
