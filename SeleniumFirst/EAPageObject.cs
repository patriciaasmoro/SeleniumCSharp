﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }


        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string intial, string middleName, string firstName)
        {
            txtInitial.EnterText(intial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);                        

            Thread.Sleep(5000);
            btnSave.Submit();
        }
    }
}
