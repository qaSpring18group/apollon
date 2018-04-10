using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using apollonLaunch;


namespace apollonLaunch

{
    [TestClass]
    public class FT_6M_Gaydayenko

    {
        private const string XpathMainMenu = "//*[@id='mainmenu']/ul/li[1]/a[contains (text(), 'Разделы')]";
        private const string XpathToSite = "//a[contains(text(),'Rebenok.by')]";

        [TestMethod]

        public void TestMethod1()
        {
            IWebDriver browser;

            browser = new OpenQA.Selenium.Chrome.ChromeDriver();

            browser.Manage().Window.Maximize();

            browser.Url= "https://tut.by";

            IWebElement searchLink = browser.FindElement(By.XPath(XpathMainMenu));

            searchLink.Click();

            IWebElement searchLinkToSite = browser.FindElement(By.XPath(XpathToSite));
            searchLinkToSite.Click();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(browser.FindElement(By.XPath(XpathToSite)).Displayed);

            browser.Quit();
        }


    }


}
