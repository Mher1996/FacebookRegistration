using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace FacebookRegistration.TestPages
{
    public class Base
    {
        public static IWebDriver GetDriver()
        {
            return Pages.BasePage.GetWebDriver();
        }
        public static WebDriverWait GetWait()
        {
            return Pages.BasePage.GetWait();
        }

       
        public static void goToPage(string urlText)
        {
            GetDriver().Navigate().GoToUrl(urlText);
            GetDriver().Manage().Window.Maximize();
        }
        



    }
}
