using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Initializing...");
        }

        [Test]
        public void ExecuteTest()
        {
            LoginPageObject login = new LoginPageObject();
            EAPageObjects page = login.Login("execute", "automation");
            _ = PropertiesCollection.driver.Manage().Timeouts().ImplicitWait;
            //new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(20)).Until(
            //        d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            page.FillUserForm("KK", "Karthik", "Automation");











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
