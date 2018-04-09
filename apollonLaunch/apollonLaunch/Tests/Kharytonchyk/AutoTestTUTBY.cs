using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pool_5
{
    [TestFixture]
    public class AutotestTUTBY
    {
        private const string SECTION = "//div[@id='mainmenu']//ul//li[@class='topbar__li b-topbar-aside']//a[@class='topbar-burger']";
        private const string WEATHER = "//div[@id='mainmenu']//div[@class='topbarmore-i']//ul//li[@class='topbar__li']//a[@title='Погода']";
        private const string LOGOTOHOME = "//div[@class='outer']//div[@class='logo']//img[@src='https://img.tyt.by/i/logo.png']";
        private const string UNDROPPEDSECTION = "//div[@id='mainmenu']//a[@class='topbar-burger']";

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