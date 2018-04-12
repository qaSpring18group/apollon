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

     //   private IWebDriver driver;

        public MainPagePO(IWebDriver driver):base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = ".//*/ul/li[1]/a[@href='https://www.tut.by/resource/']")]
         public IWebElement CategoriesTab { get; set; }
            
        [FindsBy(How = How.XPath, Using = "//a[@class='topbar__link' and contains(text(),'Новости')]")]
        public IWebElement NewsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='header-logo' and @title='TUT.BY - Белорусский портал']")]
        public IWebElement LogoPicture { get; set; }

    }
}
