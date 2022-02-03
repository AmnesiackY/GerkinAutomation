using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace AutoGerkin5
{
    [Binding]
    public class Autorization : BaseTest
    {
        public HomePage _homePage;
        public SearchPage _searchPage;


        [Given(@"User on Homepage")]
        public void GivenUserOnHomepage()
        {
            DriverHolder.driver = StartDriverWithUrl("https://kasta.ua");
            _homePage = new HomePage();
        }

        [When(@"User click Profile")]
        public void UserClickProfile()
        {
            _homePage.ClickProfile();
        }

        [When(@"User enter email")]
        public void WhenUserEnterEmail()
        {
            _homePage.EnterEmail();
        }

        [When(@"User submit choice")]
        public void WhenUserSubmitChoice()
        {
            _homePage.ClickSubmitButton();
        }

        [When(@"User enter password")]
        public void WhenUserEnterPassword()
        {
            _homePage.EnterPassword();
        }

        [When(@"User click submit button")]
        public void WhenUserClickSubmitButton()
        {
            _homePage.ClickSubmitButton();
        }
        [When(@"User click on search field")]
        public void WhenUserClickOnSearchField()
        {
            _homePage.ClickSearchField();
        }

        [Then(@"User is authorized")]
        public void ThenUserIsAuthorized()
        {
            IWebElement checkFavourites = DriverHolder.driver.FindElement(By.XPath("//span[contains(.,'Обране')]"));
            Assert.Equal("Обране", checkFavourites.Text);
            Thread.Sleep(2000);
        }


        [When(@"User enter '([^']*)' in search field")]
        public void WhenUserEnterInSearchField(string p0)
        {
            _homePage.EnterSearchRequest(p0);
        }

    }
}
