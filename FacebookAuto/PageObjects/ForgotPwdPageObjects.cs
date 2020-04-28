using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.PageObjects
{
    class ForgotPwdPageObjects
    {
        public IWebDriver driver;
        public ForgotPwdPageObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        ///define objects 
        
        ///Recovery Email
        [FindsBy(How =How.Id, Using = "identify_email")]
        public IWebElement RecoveryEmail { get; set; }

        //search button
        [FindsBy(How =How.Id, Using = "u_0_2")]
        public IWebElement searchButton { get; set; }



        ///recovery email process
        public void recoveryEmailProcess()
        {
            RecoveryEmail.SendKeys("abc@gnail.com");
            searchButton.Click();
        }


    }
}
