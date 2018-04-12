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
        private ChromeDriver driver;
       
        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void FT_15M_Test()
        {
            MainPage mainPage = new MainPage();
            RealtyPage realty = new RealtyPage();
            driver.Url = UsefullMethods.OpenTytbySite;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.FindElement(By.XPath(mainPage.headerResourses)).Click();
            driver.FindElement(By.XPath(mainPage.resourceRealty)).Click();
            IWebElement Header = driver.FindElement(By.XPath(realty.HeaderRealty));
            NUnit.Framework.Assert.IsTrue(Header.Displayed);
            driver.FindElement(By.XPath(mainPage.resourceRealty)).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            IWebElement realtyElement = driver.FindElement(By.XPath(realty.HeaderRealty));
            NUnit.Framework.Assert.IsTrue(realtyElement.Displayed, "Header Realty is not displayed");
            driver.FindElement(By.XPath(realty.ToMainPage)).Click();
        }

        [TearDown]

        public void Close()
        {
            driver.Close();
        }
    }
}
