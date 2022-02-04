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
            IWebElement firstWatches = DriverHolder.driver.FindElement(By.XPath("//article[@id='10085540:702']/div/div/div/form/div/a/span/img"));
            firstWatches.Click();
        }
        public void ClickSecondWatches()
        {
            IWebElement secondWatches = DriverHolder.driver.FindElement(By.XPath("//img[@title='Годинник Guess MENS DRESS однотонний срібний класика']"));
            secondWatches.Click();
        }
        public void ClickLedLamp()
        {
            IWebElement LedLamp = DriverHolder.driver.FindElement(By.XPath("//img[@title='Диско-куля лампа для дискотеки Magic Ball світлодіодний світловий ефект (43959900-В) Francesco Marconi чорна']"));
            LedLamp.Click();
        }
        public void ClickFilterWatches()
        {
            IWebElement filter = DriverHolder.driver.FindElement(By.XPath("//a[contains(.,'Дерево7')]"));
            filter.Click();
        }
        public void ClickFilterHeadphones()
        {
            IWebElement filterheadphones = DriverHolder.driver.FindElement(By.XPath("//a[contains(.,'LED лампа1')]"));
            filterheadphones.Click();
        }
    }
}
