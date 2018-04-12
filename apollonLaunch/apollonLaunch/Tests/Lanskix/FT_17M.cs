using System;
using System.Collections.Generic;
using System.Linq;
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

    class FT_17M_test
    {
        private ChromeDriver chrome;
        [SetUp]
        public void SetUp()
        {
            chrome = new ChromeDriver();
        }
        [Test]
        public void FT_17M()
        {          
            chrome.Url = UsefullMethods.OpenTytbySite;
            WebDriverWait wait = new WebDriverWait(chrome, new TimeSpan(0, 0, 5));
            MainPage mp = new MainPage();
            chrome.FindElementByXPath(mp.headerResourses).Click();
            chrome.FindElementByXPath(mp.headerMaps).Click();
            chrome.Navigate().Back();          
        }
        
    [TearDown]

    public void TearDown()
    {
       chrome.Quit();
    }
}
}
                
           // chrome
        //    chrome.FindElement(By.XPath.main);
        
    
        
    

    
        
  
