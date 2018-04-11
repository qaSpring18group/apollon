using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using apollonLaunch;

namespace Pool_5.Tests.Cherednichenko
{
    class SearchMainPageTutBy
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
            IWebElement searchButton = driver.FindElement(By.XPath(mainPage.searchButton));
            searchField.SendKeys("Новости");
            searchButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(d => d.FindElement(By.XPath(mainPage.wholeSearchLabel)));
            System.Threading.Thread.Sleep(1000);
            IWebElement wholeSearch = driver.FindElement(By.XPath(mainPage.wholeSearchLabel));
        }
    }
}
