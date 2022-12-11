using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookRegistration.Pages
{
    public class Helper
    {
        public void ScrollIntoWiew(IWebElement element)
        {
            ((IJavaScriptExecutor)BasePage.GetWebDriver())
              .ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }

        public void EnterPress(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Enter).Perform();


        }
    }
}