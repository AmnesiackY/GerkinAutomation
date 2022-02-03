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
            IWebElement checkSubCategoryWatches = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'������� ������ ���������')]"));
            Assert.Equal("������� ������ ���������", checkSubCategoryWatches.Text);
        }
        //https://kasta.ua/uk/product/13352080:615/
        [When(@"User enter on interested page")]
        public void WhenUserEnterOnInterestedPage()
        {
            _searchPage = new SearchPage();
            _searchPage.ClickFirstWatches();
        }

        [Then(@"User on selected watch page")]
        public void ThenUserOnSelectedWatchPage()
        {
            IWebElement checkFirstWatchesPage = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'�������� Jacques Lemans 1-1907ZC ���������� ������� ����������')]"));
            Assert.Equal("�������� Jacques Lemans 1-1907ZC ���������� ������� ����������", checkFirstWatchesPage.Text);
            Thread.Sleep(2000);
        }


        //[When(@"User enter on the second page")]
        //public void WhenUserEnterOnTheSecondPage()
        //{
        //    _searchPage.ClickSecondWatches();
        //}

        //[Then(@"User on second selected page")]
        //public void ThenUserOnSecondSelectedPage()
        //{
        //    IWebElement checkSecondWatchesPage = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'�������� Guess MENS DRESS ���������� ������ �������')]"));
        //    Assert.Equal("�������� Guess MENS DRESS ���������� ������ �������", checkSecondWatchesPage.Text);
        //}


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
            IWebElement checkSubCategoryAudio = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'������� tv, ���� �� ���� ������')]"));
            Assert.Equal("������� tv, ���� �� ���� ������", checkSubCategoryAudio.Text);
        }


        [When(@"User enter in selected product")]
        public void WhenUserEnterInSelectedProduct()
        {
            _searchPage=new SearchPage();
            _searchPage.ClickHeadphones();
        }

        [Then(@"User on selected page")]
        public void ThenUserOnSelectedPage()
        {
            IWebElement checkHeadphones = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'��������� T1C Black QCY ����')]"));
            Assert.Equal("��������� T1C Black QCY ����", checkHeadphones.Text);
            Thread.Sleep(2000);
        }
    }
}
