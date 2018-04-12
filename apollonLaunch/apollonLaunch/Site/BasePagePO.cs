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
            PageFactory.InitElements(driver, this);
        }
    }
}
