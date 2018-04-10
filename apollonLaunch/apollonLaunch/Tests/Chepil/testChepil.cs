using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using apollonLaunch;


namespace apollonLaunch

{

    [TestFixture]

    class chepil
    {
        private ChromeDriver chrome;
        [SetUp]
        public void SetUp()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
        }
        [Test]
        public void chepilTest()
        {
            MainPage mp = new MainPage();
            chrome.Url = UsefullMethods.OpenTytbySite;
            chrome.FindElementByXPath(mp.headerResourses).Click();
            chrome.FindElementByXPath(mp.headerGoeTag).Click();
            chrome.FindElementByXPath(mp.popUpGeoTagSityTDMinskDistCherven).Click();
            chrome.FindElementByXPath(mp.popUpGeoTagCherven).Equals("×åðâåíü");

        }
        [TestCleanup]
        public void CloseBrowser()
        {
            chrome.Close();
        }

    }
}