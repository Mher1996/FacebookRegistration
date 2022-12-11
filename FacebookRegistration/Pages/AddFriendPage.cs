using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace FacebookRegistration.Pages
{
    public class AddFriendPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@placeholder=\"Search Facebook\"]")]
        [CacheLookup]
        private IWebElement searchField;

        [FindsBy(How =How.XPath,Using = "//a[text()=\"Մհեր Թանգյան\"]")]
        [CacheLookup]
        private IWebElement friendsProfile;

        [FindsBy(How =How.XPath,Using= "//div[@class=\"x78zum5 x1a02dak x139jcc6 xcud41i x9otpla x1ke80iy\"]/div[1]/div/div/div")]
        [CacheLookup]
        private IWebElement addFriendButton;

        Helper helper=new Helper();

        public String GetAddFriendButtonText()
        {
            return addFriendButton.Text;
        }


        public AddFriendPage FriendSearch(string friendsName)
        {
            WaitForElement(searchField);
            helper.ScrollIntoWiew(searchField);
            searchField.Clear();
            searchField.Click();
            searchField.SendKeys(friendsName);
            return this;
            
        }

        public AddFriendPage MoveToFriendsProfile()
        {
            WaitForElement(friendsProfile);    
            IJavaScriptExecutor js = (IJavaScriptExecutor)GetWebDriver();
            js.ExecuteScript("arguments[0].click();", friendsProfile);
            return this;
        }
       

     
        public AddFriendPage EnterClick() {
        helper.ScrollIntoWiew( searchField);
            searchField.Click();
            helper.EnterPress(BasePage.GetWebDriver(), searchField);
            return this;
        }

        public AddFriendPage AddFriend()
        {
            WaitForElement(addFriendButton);
            IJavaScriptExecutor js = (IJavaScriptExecutor)GetWebDriver();
            js.ExecuteScript("arguments[0].click();", addFriendButton);

            return this;
        }







    }
}
