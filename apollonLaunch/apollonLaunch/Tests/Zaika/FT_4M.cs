using OpenQA.Selenium;
using System;
using System.Linq;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;


namespace apollonLaunch.Tests
{
    [TestFixture]
    public class SimpleTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void FT_4M()
        {
            MainPage mainPage = new MainPage();
            ProbusinessPage probusinessPage = new ProbusinessPage();
            driver.Url = UsefullMethods.OpenTytbySite;
            driver.FindElement(By.XPath(mainPage.headerResourses)).Click();
            driver.FindElement(By.XPath(probusinessPage.externalProbusiness)).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string URL = driver.Url;
            string expectedRedirectUrl = "https://probusiness.io/";
            Assert.AreEqual(URL, expectedRedirectUrl, "The external link isn't the correct one.");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
