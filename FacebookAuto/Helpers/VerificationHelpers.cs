using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAuto.Helpers
{
    public class VerificationHelpers
    {
        public IWebDriver driver;
        /////class initilize
        public VerificationHelpers(IWebDriver driver)
        {
            this.driver = driver;
        }

        ///object exist or not
        public Boolean IsDisplayed(IWebElement TestElement)
        {
            try
            {
                return  TestElement.Displayed;   
            }
            catch(NoSuchElementException e)
            {
                //loginfo

                return false;
            }
        }



        ///object enabled or not
        public Boolean IsEnabled(IWebElement TestElement)
        {
            try
            {
                return TestElement.Enabled;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        ///get text
        public String  DataFromEditbox(IWebElement TestElement)
        {
            if(TestElement==null)
            {
                return null;
            }
            Boolean status = IsDisplayed(TestElement);
            if(status)
            {
                return TestElement.GetAttribute("value");
            }
            else
            {
                return null;
            }
        }
    }
}









