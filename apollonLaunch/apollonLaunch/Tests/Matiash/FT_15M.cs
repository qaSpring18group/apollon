using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using apollonLaunch;
using apollonLaunch.Site;



namespace apollonLaunch
{
    class FT_15M
    {
        private IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void Test()
        {
            MainPage mainPage = new MainPage();
            RealtyPage realty = new RealtyPage();
            driver.Url = UsefullMethods.OpenTytbySite;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(mainPage.headerResourses)).Click();
         //   driver.FindElement(By.XPath(mainPage.headerRealty)).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement realtyElement = driver.FindElement(By.XPath(realty.HeaderRealty));
            NUnit.Framework.Assert.IsTrue(realtyElement.Displayed);
            driver.FindElement(By.XPath(realty.ToMainPage)).Click();
        }

        [TearDown]

        public void Close()
        {
            driver.Close();
        }
    }
}
