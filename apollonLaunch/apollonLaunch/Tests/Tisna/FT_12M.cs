using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace apollonLaunch.Tests.Tisna
{
    [TestFixture]
    class FT_12M
    {
        private IWebDriver webDriver;
        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }
        [Test]
        public void FT_12M_main()
        {
            MainPage mainPage = new MainPage();
            FinancePage financePage = new FinancePage();
            webDriver.Url = UsefullMethods.OpenTytbySite;
            webDriver.FindElement(By.XPath(mainPage.headerResourses)).Click();
            webDriver.FindElement(By.XPath(mainPage.resourceFinance)).Click();
            IWebElement FinElement = webDriver.FindElement(By.XPath(financePage.asideMenu));
            Assert.IsTrue(FinElement.Displayed);
            webDriver.FindElement(By.XPath(financePage.returnToMainPage)).Click();
            webDriver.FindElement(By.XPath(mainPage.headerResourses)).Click();
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}
