using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNetCoreDemo.Pages
{
    public class LoginPage
    {
        //To create a contructor short cut type 'ctor' and double TAB
        //Ctrl. control dont selects the 'using' packages to import
        //Also you can Ctrl. for webDriver will also ask you to create and assign property 
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        //We create the actual page elements
        //Use Lambda expressing for the elements
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUserName => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("Password"));
        // you can use CssSelector by using .and the class name
        //e.g. class="btn btn-default"  you can make it ".btn btn-default'
        //Test is out and the 1 or 1 should be found. chropth  uses CSSselector
        public IWebElement btnLogin => WebDriver.FindElement(By.XPath("//input[@type='submit']"));
        //Employee Details
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        //The we will have methods to performs the actions

        //Because the method only has 1 line. you can write it this way using lambda expression
        public void ClickLogin() => lnkLogin.Click();
       
        //you can implement the method this way
        //public void ClickLogin()
        //{
        //    lnkLogin.Click();
                
        //}



        //Or you can write the method the classical way
        /*public void ClickLogin()

         { 
         lnkLogin.Click();
         }
        */
        public void Login(String username, String password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
        }
        public void ClickLoginButton() => btnLogin.Click();

        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;
    }
}
