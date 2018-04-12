using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace apollonLaunch.Site
{
    public class BasePagePO
    {
       private IWebDriver driver;

        public  BasePagePO(IWebDriver driver)
        {
            this.driver = driver;
#pragma warning disable CS0618 // Тип или член устарел
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Тип или член устарел
        }
    }
}
