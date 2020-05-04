using FacebookAuto.BaseClass;
using FacebookAuto.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.PageObjects
{
    class FBHomePageObjects
    {
        public IWebDriver driver;
        

        public FBHomePageObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        
        //define objects 
        //firstname
        [FindsBy(How =How.Name, Using ="firstname")]
        public IWebElement firstNameOnFBHome { get; set; }

        //lastname
        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement lastNameOnFBHome { get; set; }

        //Email Or Mobile
        [FindsBy(How = How.Name, Using = "reg_email__")]
        public IWebElement EmailOrMobileOnFBHome { get; set; }

        //Retype Email Or Mobile
        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        public IWebElement RetypeEmailOrMobileOnFBHome { get; set; }

        //password
        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        public IWebElement PasswordOnFBHome { get; set; }

        //month
        [FindsBy(How = How.Id, Using = "month")]
        public IWebElement monthOnFBHome { get; set; }

        //day
        [FindsBy(How = How.Id, Using = "day")]
        public IWebElement dayOnFBHome { get; set; }

        //year
        [FindsBy(How = How.Id, Using = "year")]
        public IWebElement yearOnFBHome { get; set; }


        //forgot Pwd
        [FindsBy(How = How.LinkText, Using = "Forgotten account?")]
        public IWebElement forgotPwdLinkOnFBHome { get; set; }



        ///define methods
        public void fbReg()
        {            
            firstNameOnFBHome.SendKeys("tester");
            lastNameOnFBHome.SendKeys("developer");
            new SelectElement(monthOnFBHome).SelectByText("Feb");
        }

        public void forgotPwd()
        {
            forgotPwdLinkOnFBHome.Click();
        }

        ///enter firstname 
        public void EnterFirstName()
        {
            firstNameOnFBHome.SendKeys("devViewer");
        }


        ///enter lastname 
        public void EnterLastName()
        {
            lastNameOnFBHome.SendKeys("devManager");
        }

        ///enter mobile for fbReg
        public void EnterMobileForFBReg()
        {
            EmailOrMobileOnFBHome.SendKeys("9876543210");
        }

        ///enter Email
        public void EnterEmailForFBReg()
        {
            EmailOrMobileOnFBHome.SendKeys("abc@example.com");
        }

        ///enter Retype Email
        public void EnterRetypeEmailForFBReg()
        {
            RetypeEmailOrMobileOnFBHome.SendKeys("abc@example.com");
        }

        ///enter Password
        public void EnterPasswordForFBReg()
        {
            PasswordOnFBHome.SendKeys("password1");
        }



        //select Month
        public void SelectMonth()
        {
            new SelectElement(monthOnFBHome).SelectByText("Feb");
        }

        //select Day
        public void SelectDay()
        {
            new SelectElement(dayOnFBHome).SelectByValue("15");
        }

        //select Year
        public void SelectYear()
        {
            new SelectElement(yearOnFBHome).SelectByValue("1989");
        }


        //////////verificaion methods
        /////firstname exist or not 
        public Boolean VerifyDisplayedFirstNameOnFBHomePage
        {
            get 
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(firstNameOnFBHome);
                return status;

            }
        }

        /////firstname enabled or not 
        public Boolean VerifyEnabledFirstNameOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(firstNameOnFBHome);
                return status;

            }
        }
        /////Lastname exist or not 
        public Boolean VerifyDisplayedLastNameOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(lastNameOnFBHome);
                return status;

            }
        }

        /////Lastname enabled or not 
        public Boolean VerifyEnabledLastNameOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(lastNameOnFBHome);
                return status;

            }
        }

        /////Email exist or not 
        public Boolean VerifyDisplayedEmailForFbRegFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(EmailOrMobileOnFBHome);
                return status;

            }
        }

        /////Email enabled or not 
        public Boolean VerifyEnabledEmailForFbRegOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(EmailOrMobileOnFBHome);
                return status;

            }
        }

        /////Retype Email exist or not 
        public Boolean VerifyDisplayedRetypeEmailForFbRegFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(RetypeEmailOrMobileOnFBHome);
                return status;

            }
        }

        /////Retype Email enabled or not 
        public Boolean VerifyEnabledRetypeEmailForFbRegOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(RetypeEmailOrMobileOnFBHome);
                return status;

            }
        }

        /////Password exist or not 
        public Boolean VerifyDisplayedPasswordForFbRegFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(PasswordOnFBHome);
                return status;

            }
        }

        /////Password enabled or not 
        public Boolean VerifyEnabledPasswordForFbRegOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(PasswordOnFBHome);
                return status;

            }
        }

        /////Month exist or not 
        public Boolean VerifyDisplayedMonthForFbRegFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(monthOnFBHome);
                return status;

            }
        }

        /////Month enabled or not 
        public Boolean VerifyEnabledMonthForFbRegOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(monthOnFBHome);
                return status;

            }
        }

        /////day exist or not 
        public Boolean VerifyDisplayedDayForFbRegFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(dayOnFBHome);
                return status;

            }
        }

        /////Day enabled or not 
        public Boolean VerifyEnabledDayForFbRegOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(dayOnFBHome);
                return status;

            }
        }

        /////Year exist or not 
        public Boolean VerifyDisplayedYearForFbRegFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsDisplayed(yearOnFBHome);
                return status;

            }
        }

        /////Year enabled or not 
        public Boolean VerifyEnabledYearForFbRegOnFBHomePage
        {
            get
            {
                Boolean status = new VerificationHelpers(driver).IsEnabled(yearOnFBHome);
                return status;

            }
        }
    }
}












