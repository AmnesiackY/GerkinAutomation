using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoGerkin5
{
    public class HomePage : BaseTest
    {
        public HomePage()
        {
            _driver = DriverHolder.driver;
        }

        private IWebElement searchField = DriverHolder.driver.FindElement(By.XPath("//input"));
        private IWebElement profile = DriverHolder.driver.FindElement(By.XPath("//div[4]/div/span"));
        private IWebElement brandsCategory = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Бренди')]"));
        private IWebElement shoesCategory = DriverHolder.driver.FindElement(By.XPath("//a[6]/div/img"));

        private IWebElement accessoriesCategory = DriverHolder.driver.FindElement(By.XPath("//li[8]/label"));
        private IWebElement clockSubCategory = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Годинники')]"));
        private IWebElement electronicCategory = DriverHolder.driver.FindElement(By.XPath("//li[11]/label"));
        private IWebElement audioSubCategory = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'ТВ, аудіо та відео')]"));


        public void ClickFavouriteSection()
        {
            IWebElement favorite_section = DriverHolder.driver.FindElement(By.XPath("//span[contains(.,'Обране')]"));
            favorite_section.Click();
        }
        public void ClickProfile()
        {
            profile.Click();
        }
        public void EnterEmail()
        {
            IWebElement email = DriverHolder.driver.FindElement(By.XPath("/html/body/div/div/div[4]/div/div/div[2]/div/div/form/div/div[1]/div[5]/input"));
            email.Click();
            email.SendKeys("gustavfergusson@gmail.com");
        }
        public void SubmitEmail()
        {
            IWebElement submitButtonPopUp = DriverHolder.driver.FindElement(By.XPath("//button[contains(.,'Увійти')]"));
            submitButtonPopUp.Click();
            Thread.Sleep(200);
        }
        public void EnterPassword()
        {
            IWebElement password = DriverHolder.driver.FindElement(By.XPath("//input[@id='password']"));
            password.Click();
            password.SendKeys("12345678yarik");
            Thread.Sleep(500);
        }
        public void ClickSubmitButton()
        {
            IWebElement submitButton = DriverHolder.driver.FindElement(By.XPath("//button[contains(.,'Увійти')]"));
            submitButton.Click();
        }
        public void EnterSearchRequest(string request)
        {
            searchField.SendKeys(request);
            Thread.Sleep(800);
            searchField.SendKeys(Keys.Enter);
            Thread.Sleep(200);
        }
        public void ClickSearchField()
        {
            searchField.Click();
        }
        public void ClickBrands()
        {
            brandsCategory.Click();
        }
        public void ClickShoesCategory()
        {
            shoesCategory.Click();
        }
        public void ClickButtonActual()
        {
            IWebElement buttonActual = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/div/div/div/div/a/div/div"));
            buttonActual.Click();
        }
        public void ClickFavourites()
        {
            IWebElement favorite_section = DriverHolder.driver.FindElement(By.XPath("//span[contains(.,'Обране')]"));
            favorite_section.Click();
        }

        public void ClickAccessoriesCategory()
        {
            accessoriesCategory.Click();
        }
        public void ClickClockSubCategory()
        {
            clockSubCategory.Click();
        }
        public void ClickElectronicCategory()
        {
            electronicCategory.Click();
        }
        public void ClickAudioSubCategory()
        {
            audioSubCategory.Click();
        }
    }
}
