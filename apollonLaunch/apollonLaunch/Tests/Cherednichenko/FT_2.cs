using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace apollonLaunch
{
    class FT_2
    {
        IWebDriver driver = new ChromeDriver();
        MainPage mainPage = new MainPage();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl(UsefullMethods.OpenTytbySite);
        }

        [Test]
        public void SearchFormTest()
        {
            IWebElement searchField = driver.FindElement(By.XPath(mainPage.searchField));
           // IWebElement searchButton = driver.FindElement(By.XPath(mainPage.searchButton));
            searchField.SendKeys("Новости");
           // searchButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
          //  wait.Until(d => d.FindElement(By.XPath(mainPage.wholeSearch)));
          //  IWebElement wholeSearch = driver.FindElement(By.XPath(mainPage.wholeSearch));
        }
    }
}