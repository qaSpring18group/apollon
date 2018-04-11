using System;
using NUnit.Framework;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace apollonLaunch.Tests.Nykonenko
{
    [TestFixture]
    class FT_5M
    {
        private IWebDriver webDriver;
        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }
        [Test]
        public void FT_5M_test()
        {
            MainPage mp = new MainPage();
            Hoster hbp = new Hoster();
            webDriver.Url = UsefullMethods.OpenTytbySite;
            webDriver.FindElement(By.XPath(mp.headerResourses)).Click();
            webDriver.FindElement(By.XPath(hbp.hosterby)).Click();
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
            IWebElement HosterbyElement = webDriver.FindElement(By.XPath(hbp.hosterbyelement));
            Assert.IsTrue(HosterbyElement.Displayed);
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
