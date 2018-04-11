using System;
using NUnit.Framework;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace apollonLaunch.Tests.Kovalenko
{
    [TestFixture]
    class FT_13M
    {
        private IWebDriver webDriver;
        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }
        [Test]
        public void FT_13M_t()
        {
            MainPage mp = new MainPage();
            Site.AfishaPage af = new Site.AfishaPage();
            webDriver.Url = UsefullMethods.OpenTytbySite;
            webDriver.FindElement(By.XPath(mp.headerResourses)).Click();
            webDriver.FindElement(By.XPath(mp.headerAfisha)).Click();
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
            IWebElement afishaElement = webDriver.FindElement(By.XPath(af.headerAfishaElement));
            Assert.IsTrue(afishaElement.Displayed);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            webDriver.FindElement(By.XPath(mp.CloseheaderResourses)).Click();
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}