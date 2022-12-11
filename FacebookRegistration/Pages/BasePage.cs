using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookRegistration.Pages
{
    public class BasePage
    {
        static IWebDriver myDriver;
        static WebDriverWait wait;


        static void setWebDriver()
        {
            ChromeOptions options=new ChromeOptions();
            options.AddArguments("--disable-notifications");
            myDriver = new ChromeDriver(options);
        }
        public static IWebDriver GetWebDriver()
        {
            if (myDriver == null)
            {
                setWebDriver();
            }
            return myDriver;
        }
        public static WebDriverWait GetWait()
        {
            if (wait == null)
            {
                wait = new WebDriverWait(myDriver, TimeSpan.FromSeconds(20));
            }
            return wait;
        }
        public static void WaitForElement(IWebElement element)
        {
            GetWait().Until(GetWebDriver => element.Displayed);
        }
        public static void WaitElementIsLocated(IWebElement element)
        {
            GetWait().Until(GetWebDriver => element.Location) ;
        }










    }
}
