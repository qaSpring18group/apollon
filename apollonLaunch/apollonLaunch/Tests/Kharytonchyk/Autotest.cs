﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace apollonLaunch
{
    [TestFixture]
    class Autotest
    {
        private static IWebDriver _driver = new ChromeDriver();
        MainPage mainPage = new MainPage();
        
        [SetUp]
        public void SetUp()
        {
            _driver.Manage().Window.Maximize();
            _driver.Url = UsefullMethods.OpenTytbySite;
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void FT_11M()
        {
            _driver.FindElement(By.XPath(mainPage.SECTION)).Click();
            _driver.FindElement(By.XPath(mainPage.WEATHER)).Click();
            _driver.FindElement(By.XPath(mainPage.LOGOTOHOME)).Click();

            Assert.IsTrue(_driver.FindElement(By.XPath(mainPage.UNDROPPEDSECTION)).Displayed);
        }
    }
}