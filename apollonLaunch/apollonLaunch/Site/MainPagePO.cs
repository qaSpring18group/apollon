using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollonLaunch.Site
{
    public class MainPagePO : BasePagePO
    {
        public MainPagePO(IWebDriver driver)
            : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='https://www.tut.by/resource/']")]
            public IWebElement CategoriesTab { get; }
            
        [FindsBy(How = How.XPath, Using = "//a[@class=\"topbar__link\" and contains(text(),'Новости')]")]
            public IWebElement NewsLink { get; }

    }
}
