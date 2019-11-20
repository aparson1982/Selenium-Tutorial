using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Tutorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Initializing...");
        }

        [Test]
        public void ExecuteTest()
        {
            //Initalize the page by calling its reference
            EAPageObjects page = new EAPageObjects();
            page.txtInitial.SendKeys("Execute Automation");
            page.btnSave.Click();











            //SeleniumSetMethod.SelectDropDown("TitleId", "Ms.", PropertyType.Id);

            //SeleniumSetMethod.EnterText("Initial", "Testing", PropertyType.Name);
            //SeleniumSetMethod.EnterText("FirstName", "Jesus", PropertyType.Id);
            //SeleniumSetMethod.EnterText("MiddleName", "Carrillo", PropertyType.Id);

            //Console.WriteLine("The value from my Title is:  " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is:  " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Console.WriteLine("The value from Title using GetTextDDL is:  " + SeleniumGetMethods.GetTextFromDDL(webDriver, "TitleId", "Id");

            //SeleniumSetMethod.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
