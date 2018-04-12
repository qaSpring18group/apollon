using apollonLaunch.Site;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace apollonLaunch
{
    [TestFixture]
    public class FT_9M
    {
        private static readonly string URL = "https://www.tut.by/";
        private static readonly string EXPECTED_TEXT_NEWS = "НОВОСТИ";
        private static readonly string EXPECTED_TEXT_LOGO = "TUT.BY - Белорусский портал";

        public static IWebDriver driver;

        [SetUp]
        public static void SetUp()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",
                @"C:\Users\makarola\Documents\Epam\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.Navigate().GoToUrl(URL);
            
            
        }

        [Test]
        public void NewsPageTest()
        {
            MainPagePO mainPagePO = new MainPagePO(driver);
            mainPagePO.CategoriesTab.Click();
            mainPagePO.NewsLink.Click();
            NewsPagePO newsPagePO = new NewsPagePO(driver);
            string text = newsPagePO.LogoPicture.Text;
            Assert.AreEqual(text, EXPECTED_TEXT_NEWS, "It's not the NewsPage");
            newsPagePO.LogoNews.Click();
            string textLogo = mainPagePO.LogoPicture.Text;
            Assert.AreEqual(textLogo, EXPECTED_TEXT_LOGO, "It's not the MainPage");
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}