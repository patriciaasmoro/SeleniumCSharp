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

            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {

            //Initialise the page by calling its reference
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("Mitrais Software");

            page.btnSave.Click();


            //SeleniumTest.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //SeleniumTest.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is:" + SeleniumGetControl.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is:" + SeleniumGetControl.GetText("Initial", PropertyType.Name));

            //SeleniumTest.Click("Save", PropertyType.Name);
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
