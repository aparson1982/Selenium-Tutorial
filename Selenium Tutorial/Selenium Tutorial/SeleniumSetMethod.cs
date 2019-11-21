using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Tutorial
{
    class SeleniumSetMethod
    {
        /// <summary>
        /// Enter Text
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <param name="elementType"></param>
        public static void EnterText(IWebElement element, string value)
        {

            element.SendKeys(value);
            
        }



        public static void Click(IWebElement element)
        {
            element.Click();
        }



        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
