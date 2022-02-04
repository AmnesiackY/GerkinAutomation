using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace AutoGerkin5
{
    [Binding]
    public class CatalogPage : BaseTest
    {
        public HomePage _homePage;
        public SearchPage _searchPage;

        [Given(@"User on HomePage")]
        public void GivenUserOnHomePage()
        {
            DriverHolder.driver = StartDriverWithUrl("https://kasta.ua");
            _homePage = new HomePage();
        }
        [When(@"User clicks on the Accessories category")]
        public void WhenUserClicksOnTheAccessoriesCategory()
        {
            _homePage.ClickAccessoriesCategory();
        }

        [When(@"User clicks on the Clock subcategory")]
        public void WhenUserClicksOnTheClockSubcategory()
        {
            _homePage.ClickClockSubCategory();
        }

        [Then(@"User on selected page of subcategory")]
        public void ThenUserOnSelectedPageOfSubcategory()
        {
            IWebElement checkSubCategoryWatches = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Брендові наручні годинники')]"));
            Assert.Equal("Брендові наручні годинники", checkSubCategoryWatches.Text);
        }
        //https://kasta.ua/uk/product/13352080:615/
        [When(@"User enter on interested page")]
        public void WhenUserEnterOnInterestedPage()
        {
            _searchPage = new SearchPage();
            _searchPage.ClickFirstWatches();
        }

        [When(@"User click on filter")]
        public void WhenUserClickOnFilter()
        {
            _searchPage = new SearchPage();
            _searchPage.ClickFilterWatches();
        }
        [When(@"User click filter LedLamps")]
        public void WhenUserClickFilterLedLamps()
        {
            _searchPage = new SearchPage();
            _searchPage.ClickFilterHeadphones();
        }



        [Then(@"User on selected watch page")]
        public void ThenUserOnSelectedWatchPage()
        {
            IWebElement checkFirstWatchesPage = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Годинники WoodenWatch чорний')]"));
            Assert.Equal("Годинники WoodenWatch чорний", checkFirstWatchesPage.Text);
            Thread.Sleep(2000);
        }

        [When(@"User click on the Electronic and Technic category")]
        public void WhenUserClickOnTheElectronicAndTechnicCategory()
        {
            _homePage.ClickElectronicCategory();
        }

        [When(@"User click on the TV, Audio and Video subcategory")]
        public void WhenUserClickOnTheTVAudioAndVideoSubcategory()
        {
            _homePage.ClickAudioSubCategory();
        }

        [Then(@"User on selected subcategory")]
        public void ThenUserOnSelectedSubcategory()
        {
            IWebElement checkSubCategoryAudio = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Каталог tv, аудіо та відео техніки')]"));
            Assert.Equal("Каталог tv, аудіо та відео техніки", checkSubCategoryAudio.Text);
        }


        [When(@"User enter in selected product")]
        public void WhenUserEnterInSelectedProduct()
        {
            _searchPage=new SearchPage();
            _searchPage.ClickLedLamp();
        }

        [Then(@"User on selected page")]
        public void ThenUserOnSelectedPage()
        {
            IWebElement checkLedLamp = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Диско-куля лампа для дискотеки Magic Ball світлодіодний світловий ефект (43959900-В) Francesco Marconi чорна')]"));
            Assert.Equal("Диско-куля лампа для дискотеки Magic Ball світлодіодний світловий ефект (43959900-В) Francesco Marconi чорна", checkLedLamp.Text);
            Thread.Sleep(2000);
        }
    }
}
