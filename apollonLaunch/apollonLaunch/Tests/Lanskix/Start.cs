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

namespace apollonLaunch

{

    [TestFixture]

    class Start
    {
        private ChromeDriver chrome;
        [SetUp]
        public void SetUp()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
        }
        [Test]
        public void Start.links()
        }
          MainPage mp = new MainPage()
         = UsefullMethods.Start
}
    
 }               
           // chrome
        //    chrome.FindElement(By.XPath.main);
        
    }
        
    

    
        
  
