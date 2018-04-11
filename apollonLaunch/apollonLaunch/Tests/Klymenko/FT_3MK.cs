using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using apollonLaunch.Site;

namespace apollonLaunch.Tests.Klymenko
{
    [TestFixture]
    class FT_3MK
    {
        IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void FT_3M()
        {
            MainPage mainPage = new MainPage();
            TamByPage tamBy = new TamByPage();
            driver.Url = UsefullMethods.OpenTytbySite;
            driver.FindElement(By.XPath(mainPage.headerResourses)).Click();
            driver.FindElement(By.XPath(tamBy.externalTamBy)).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            IWebElement elevent = driver.FindElement(By.XPath(mainPage.CloseheaderResourses));
            Assert.IsTrue(elevent.Displayed);
            elevent.Click();
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
