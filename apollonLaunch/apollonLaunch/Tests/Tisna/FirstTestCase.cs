using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace apollonLaunch.Tests.Tisna
{
    [TestFixture]
    class FirstTestCase
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void FirstTestCaseTisna()
        {
            driver.Url = "https://www.google.com.ua";
            IWebElement element = driver.FindElement(By.XPath("//input[@id='lst-ib']"));
            element.SendKeys("автотесты");
            element.Submit();
            IWebElement element1 = driver.FindElement(By.PartialLinkText("Заметки Автоматизатора"));
            element1.Click();
            IWebElement element2 = driver.FindElement(By.XPath("//*[@class='post-title']"));
            string res = element2.Text;
            Assert.AreEqual("Как писать автотесты быстро", res);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
