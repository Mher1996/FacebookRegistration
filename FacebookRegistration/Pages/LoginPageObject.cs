using FacebookRegistration.TestPages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookRegistration.Pages
{
    public class LoginPageObject : BasePage
    {
        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement emailField;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath,Using = "//*[@data-testid=\"royal_login_button\"]")]
        [CacheLookup]
        private IWebElement loginButton;

        [FindsBy(How =How.XPath,Using = "//*[@class=\"xg87l8a x1iymm2a\"]")]
        [CacheLookup]
        private IWebElement welcomeUser;



        Helper helper = new Helper();   


        public string getWelcomeMessage()
        {
            WaitForElement(welcomeUser);
            return welcomeUser.Text;
        }

        public LoginPageObject SetLogin(string emailText)
        {
            helper.ScrollIntoWiew(emailField);  
            emailField.Clear();
            emailField.Click();
            emailField.SendKeys(emailText);
            return this;

        }
        public LoginPageObject SetPassword(string passwordText)
        {
            helper.ScrollIntoWiew(passwordField);
            passwordField.Clear();
            passwordField.Click();
            passwordField.SendKeys(passwordText);
            return this;
        }
        public LoginPageObject LoginToAccount()
        {
            WaitForElement(loginButton);
            helper.ScrollIntoWiew(loginButton);
            loginButton.Click();
            return this;
        }

        

    }
}
