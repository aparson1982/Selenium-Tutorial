﻿using OpenQA.Selenium;
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
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if(elementType == PropertyType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == PropertyType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }
            
        }



        public static void Click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == PropertyType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
        }



        public static void SelectDropDown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
               new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == PropertyType.Name)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
