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
    class MuzykaTestFT10M
    {
        IWebDriver driver;

        public void InitializeBrowser()
        {
            driver = new ChromeDriver(); // открываем браузер

        }
        [Test]
        public void FT10M()
        {
            driver.Url = UsefullMethods.OpenTytbySite; // переходим по адресу https://www.tut.by/
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();   // закрываем браузер
        }
    }
}
