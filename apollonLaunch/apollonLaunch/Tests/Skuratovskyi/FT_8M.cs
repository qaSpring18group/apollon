using System;
using NUnit.Framework;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;

namespace apollonLaunch.Tests.Skuratovskyi
{
    [TestFixture(Author = "Vadim Skuratovskyi")]
    public class FT_8M
    {
        private IWebDriver webDriver;

        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void FT_8M_Skuratovskyi()
        {
            MainPage mp = new MainPage(); // connect XPath
            Site.YouCanHelpPage you = new Site.YouCanHelpPage();

            webDriver.Url = UsefullMethods.OpenTytbySite; // Open website
            webDriver.FindElement(By.XPath(mp.headerResourses)).Click(); // find "Разделы" element and click on it
            webDriver.FindElement(By.XPath(mp.uCanHelpHim)).Click(); // find and click on "ты можешь помочь им" element
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last()); // switch to the opened link

            IWebElement ucanHelpHimElement = webDriver.FindElement(By.XPath(you.uCanHelpHimElement)); // find main text on the page
            Assert.IsTrue(ucanHelpHimElement.Displayed); // check if this text is shown on the page
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]); // switck to the main website link
            webDriver.FindElement(By.XPath(mp.CloseheaderResourses)).Click(); // click on the "Разделы" element
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}
