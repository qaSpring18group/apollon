using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace apollonLaunch.Site
{
    class NewsPagePO : BasePagePO
    {
        public NewsPagePO(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How =How.XPath, Using = "//a[contains(text(),'НОВОСТИ')]")]
        public IWebElement LogoNews { get; }

        [FindsBy(How = How.XPath, Using = "//img[contains(@alt, 'Белорусский портал TUT.BY')]")]
        public IWebElement LogoPicture { get; }
    }
}
