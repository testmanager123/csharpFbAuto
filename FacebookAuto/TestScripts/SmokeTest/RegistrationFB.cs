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
           //test.Info("method started");
            var fbHome = new FBHomePageObjects(driver);
            fbHome.fbReg();
           // test.Info("execution completed");
       
        }
    }
}
