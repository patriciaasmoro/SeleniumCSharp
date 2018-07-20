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

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            //Fill User Details
            pageEA.FillUserForm("Ms.", "SM", "Patricia", "Stella Maris");
            
        }

        //[Test]
        //public void NextTest()
        //{
        //    Console.WriteLine("Next method");
        //}

        [TearDown]
        public void Cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
