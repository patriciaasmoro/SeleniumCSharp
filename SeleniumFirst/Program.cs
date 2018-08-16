using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
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
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {

            ExcelLib.PopulateInCollection(@"F:\Projects\CDC\Tester\Data.xlsx");

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"),ExcelLib.ReadData(1,"Password"));

            //Fill User Details
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));
            
        }

        [TearDown]
        public void Cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
