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
            IWebElement searchButton = driver.FindElement(By.XPath(mainPage.searchLabel));
            searchButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(d => d.FindElement(By.XPath(mainPage.ensureLabelOnPage)));
            IWebElement wholeSearch = driver.FindElement(By.XPath(mainPage.ensureLabelOnPage));
        }
    }
}
