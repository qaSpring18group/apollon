using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace apollon
{
    [TestFixture]
    class AutotestTUTBY
    {        
        private static IWebDriver _driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://tut.by";
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void FT_11M()
        {
            _driver.FindElement(By.XPath(SECTION)).Click();
            _driver.FindElement(By.XPath(WEATHER)).Click();
            _driver.FindElement(By.XPath(LOGOTOHOME)).Click();

            Assert.IsTrue(_driver.FindElement(By.XPath(UNDROPPEDSECTION)).Displayed);
        }
    }
}




