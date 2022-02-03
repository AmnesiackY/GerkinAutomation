using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace AutoGerkin5
{
    [Binding]
    public class Search : BaseTest
    {
        private HomePage _homePage;
        private SearchPage _searchPage; 

        [Given(@"User on homepage")]
        public void GivenUserOnHomepage()
        {
            DriverHolder.driver = StartDriverWithUrl("https://kasta.ua");
            _homePage = new HomePage();
        }

        [Then(@"User on the page Nike")]
        public void ThenUserOnThePageNike()
        {
            IWebElement checkNike = DriverHolder.driver.FindElement(By.XPath("//header/h2"));
            Assert.Equal("Nike",checkNike.Text);
            Thread.Sleep(2000);
        }

        [Then(@"User on the page Tommy Hilfiger")]
        public void ThenUserOnThePageTommyHilfiger()
        {
            IWebElement checkTommy = DriverHolder.driver.FindElement(By.XPath("//header/h2"));
            Assert.Equal("Tommy Hilfiger", checkTommy.Text);
            Thread.Sleep(2000);
        }

        [Then(@"User on the page Reserved")]
        public void ThenUserOnThePageReserved()
        {
            IWebElement checkReserved = DriverHolder.driver.FindElement(By.XPath("//header/h2"));
            Assert.Equal("Reserved", checkReserved.Text);
            Thread.Sleep(2000);
        }

        [Then(@"User on page Nike")]
        public void ThenUserOnPageNike()
        {
            IWebElement checkNike = DriverHolder.driver.FindElement(By.XPath("//section/div/div/div/p"));
            Assert.Equal("Найвідоміший бренд в світі спортивної моди відомий перш за все взуттям," +
            " яке розробляється з урахуванням особливостей кожного виду спорту і рухів тіла. «Найк» " +
            "— це взуття, одяг і різноманітні аксесуари для тих, хто підтримує своє тіло у формі і " +
            "не йде на компроміс між комфортом і красою. Купити спортивний одяг, взуття та аксесуари Nike («Найк») " +
            "за приємною ціною можна в інтернет-магазині Kasta.", checkNike.Text);

        }

        [When(@"User click on category Обувь in navigation menu")]
        public void WhenUserClickOnCategoryОбувьInNavigationMenu()
        {
            _homePage.ClickShoesCategory();
        }

        [Then(@"User on page Обувь")]
        public void ThenUserOnPageОбувь()
        {
            IWebElement shoesCheck = DriverHolder.driver.FindElement(By.XPath("/html/body/div/div/div[3]/div[1]/div[4]/div[2]/div/div[4]/div/h2"));
            Assert.Equal("Акції", shoesCheck.Text);
        }


        [When(@"User click Актуальное in menu of filters")]
        public void WhenUserClickАктуальноеInMenuOfFilters()
        {
            _homePage.ClickButtonActual();
        }

        [Then(@"User on the page of the discounts")]
        public void ThenUserOnThePageOfTheDiscounts()
        {
            IWebElement checkDiscountPage = DriverHolder.driver.FindElement(By.XPath("//h1"));
            Assert.Equal("Жіноче взуття - Каталог 2022", checkDiscountPage.Text);
            Thread.Sleep(2000);
        }


        [When(@"User enter '([^']*)'")]
        public void WhenUserEnter(string p0)
        {
            _homePage.EnterSearchRequest(p0);
        }

        [When(@"User click on Search field")]
        public void WhenUserClickOnSearchField()
        {
            
        }
        [Then(@"User on the page Lacoste")]
        public void ThenUserOnThePageLacoste()
        {
            IWebElement checkLacoste = DriverHolder.driver.FindElement(By.XPath("//h2[contains(.,'Lacoste')]"));
            Assert.Equal("Lacoste", checkLacoste.Text);
            Thread.Sleep(2000);
        }
    }
}
