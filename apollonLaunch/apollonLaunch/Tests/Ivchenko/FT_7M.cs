using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace apollonLaunch//.Tests.Ivchenko
{
    [TestFixture(Author = "Olena Ivchenko")]
    class FT_7M
    {
        private IWebDriver webDriver;
        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }



        [Test]
        public void FT_7M_test()
        {
            MainPage mainPage = new MainPage();
            AvByPage avByPage = new AvByPage();
            webDriver.Url = UsefullMethods.OpenTytbySite;
            webDriver.FindElement(By.XPath(mainPage.headerResourses)).Click();
            webDriver.FindElement(By.XPath(avByPage.avBy)).Click();
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
            IWebElement avByElement = webDriver.FindElement(By.XPath(avByPage.avByElement));
            Assert.IsTrue(avByElement.Displayed);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            webDriver.FindElement(By.XPath(mainPage.CloseheaderResourses)).Click();
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}
