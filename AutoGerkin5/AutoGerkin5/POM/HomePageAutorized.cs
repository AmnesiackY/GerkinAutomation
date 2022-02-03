using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGerkin5
{
    public class HomePageAutorized : BaseTest
    {
        public HomePageAutorized()
        {
            _driver = DriverHolder.driver;
        }
        private IWebElement SearchField = DriverHolder.driver.FindElement(By.XPath("//input"));

        public void ClickSearchFieldAuth()
        {
            SearchField.Click();
        }
    }
}
