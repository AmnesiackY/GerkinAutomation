using OpenQA.Selenium;

namespace AutoGerkin5
{
    public class SearchPage : BaseTest
    {
        public SearchPage()
        {
            _driver = DriverHolder.driver;
        }

        public void ChooseDiscountProduct()
        {
            IWebElement discountProduct = DriverHolder.driver.FindElement(By.XPath("//article[@id='9914165:674']/div/div/div/form/div/a/span/img"));
            discountProduct.Click();
        }
        public void ClickFirstWatches()
        {
            IWebElement firstWatches = DriverHolder.driver.FindElement(By.XPath("//img[@title='Годинник Jacques Lemans 1-1907ZC однотонний зелений спортивний']"));
            firstWatches.Click();
        }
        public void ClickSecondWatches()
        {
            IWebElement secondWatches = DriverHolder.driver.FindElement(By.XPath("//img[@title='Годинник Guess MENS DRESS однотонний срібний класика']"));
            secondWatches.Click();
        }
        public void ClickHeadphones()
        {
            IWebElement headphones = DriverHolder.driver.FindElement(By.XPath("//img[@title='Навушники T1C Black QCY чорні']"));
            headphones.Click();
        }
    }
}
