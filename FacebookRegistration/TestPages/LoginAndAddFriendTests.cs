using FacebookRegistration.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace FacebookRegistration.TestPages
{
    public class LoginPageTest : Base
    {
        const string urlText = "https://www.facebook.com/";
        const string phoneNumber = "37455999964";
        const string password = "123456mher";
        const string expectedMessage = "Welcome to Facebook, Mher";
        const string friendsName = "Մհեր Թանգյան";
        LoginPageObject loginPageObject;
        AddFriendPage addFriend;


        [SetUp]
        public void Setup()
        {
            addFriend = new AddFriendPage();
            PageFactory.InitElements(GetDriver(), addFriend);
            loginPageObject = new LoginPageObject();
            PageFactory.InitElements(GetDriver(), loginPageObject);
            goToPage(urlText);

        }

        [Test]
        public void Login()
        {
            loginPageObject.SetLogin(phoneNumber)
                .SetPassword(password)
                .LoginToAccount();
            Assert.That(loginPageObject.getWelcomeMessage, Is.EqualTo(expectedMessage));


        }

        [Test]
        public void AddFriend()
        {
            const string expectedButtonText = "Add Friend";
            loginPageObject.SetLogin(phoneNumber)
                .SetPassword(password)
                .LoginToAccount();
            addFriend.FriendSearch(friendsName)
                .EnterClick()
                .MoveToFriendsProfile()
                .AddFriend();
            Thread.Sleep(5000);
            Assert.That(addFriend.GetAddFriendButtonText(), Is.Not.EqualTo(expectedButtonText));

        }

        [TearDown]
        public void Teardown()
        {
            GetDriver().Quit();
        }
    }
}