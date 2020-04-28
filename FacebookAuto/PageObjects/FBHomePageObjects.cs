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

    }
}

