using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace apollonLaunch
{
    class MuzykaTestFT_10M
    {
        private IWebDriver MyDriver;

        [SetUp]
        public void InitializeBrowser()
        {
            MyDriver = new ChromeDriver();       // open the browser
            MyDriver.Manage().Window.Maximize(); // maximize window

        }

        [Test]
        public void FT_10M()
        {
            MainPage mainPage = new MainPage(); // connecting xpath on the main page
            Site.Page42 page42 = new Site.Page42(); 
            MyDriver.Url = UsefullMethods.OpenTytbySite; // go to URL https://www.tut.by/ (UsefullMethods.OpenTytbySite)
            MyDriver.FindElement(By.XPath(mainPage.headerResourses)).Click(); // serch the "Разделы" element and click on it
            MyDriver.FindElement(By.XPath(page42.section42)).Click(); // serch the "42" element in "Разделы" and go to "42"
            MyDriver.FindElement(By.XPath(page42.linkToMainPage)).Click(); // back to the main page by clicking link "tut.by"
            MyDriver.FindElement(By.XPath(mainPage.headerResourses)).Click(); // serch the element "Разделы" and click on it
            MyDriver.FindElement(By.XPath(mainPage.CloseheaderResourses)).Click(); // clicking on "Разделы" element for closing
            string ClassOfElement = MyDriver.FindElement(By.XPath(mainPage.statusFlag)).GetAttribute("class"); // geting the attribute "class"
            Assert.AreEqual("b-topbar-more", ClassOfElement, "Test failed: The list of sections is not close"); // comparison of the attribute "class" with the class of the closed "Разделы"
        }

        [TearDown]
        public void CloseBrowser()
        {
            MyDriver.Quit();   // close the browser
        }
    }
}
