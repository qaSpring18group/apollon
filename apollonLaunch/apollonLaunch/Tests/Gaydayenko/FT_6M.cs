using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using apollonLaunch;
using apollonLaunch.Site;

namespace apollonLaunch

{
    [TestClass]
    public class FT_6M

    {
        //private const string XpathMainMenu = "//*[@id='mainmenu']/ul/li[1]/a[contains (text(), 'Разделы')]";
        //private const string XpathToSite = "//a[contains(text(),'Rebenok.by')]";

        [TestMethod]

        public void FT_6M_test()
        {
            IWebDriver browser;
            MainPage mainPage = new MainPage();
            Rebenok rebenok_byPage = new Rebenok();
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();

            //browser.Url= "https://tut.by";
            browser.Url = UsefullMethods.OpenTytbySite;

            IWebElement searchLink = browser.FindElement(By.XPath(mainPage.headerResourses));

            searchLink.Click();

            IWebElement searchLinkToSite = browser.FindElement(By.XPath(rebenok_byPage.XpathRebenok));
            searchLinkToSite.Click();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(browser.FindElement(By.XPath(rebenok_byPage.XpathRebenok)).Displayed);

            browser.SwitchTo().Window(browser.WindowHandles[0]);
            browser.FindElement(By.XPath(mainPage.CloseheaderResourses)).Click();
            browser.Quit();
        }


    }


}
