using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SpecFlow.Assist;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        //Anti-Context Injection Code - its 100% wrong but for example its fine

        LoginPage loginPage = null;

        // Current youtube tutorial https://youtu.be/O5oHiBD5Lvk?t=1965
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginPage = new LoginPage(webDriver); // this is the constructor

        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            //Now comes the concepts of using tables in Specflow or parameters
            //from the feature files
            //table. when you add the table. you will notice alot of options due to
            //the specfloc.assit dynamic. also click the plus sign to see the imports
            dynamic data = table.CreateDynamicInstance();
            // this will read data from the table and store it in data
            loginPage.Login((string)data.UserName, (string)data.Password);
            //this will cast a string from data and use the table name as in the feature file.
            //  | UserName | Password | reading the data from here
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see the Employee details link")]
        public void ThenIShouldSeeTheEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsEmployeeDetailsExist(), Is.True);
               
        }

      

    }
}
