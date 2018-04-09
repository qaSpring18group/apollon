using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollonLaunch
{
    public class MainPage
    {
        internal string headerResourses = "//*[@id='mainmenu']/ul/li[1]/a";       //  //a[contains(.,'Разделы')] - находит 2 елемента
        internal string hosterby = "//*[@class='b-topbar-more-aside']/li[3]/a";
        internal string hosterbyelement = "//*[@class='tCell middle']/label";
        internal string CloseheaderResourses = "//*[@class='topbar-close__text']";
        internal string headerGoeTag = "//*[@id='geotarget_top_selector']";
        internal string headerEmail = "//*[@id='mainmenu']/ul/li[3]/a";           // //a[contains(.,'Почта')] - находит 2 елемеента
        internal string headerFinance = "//*[@id='mainmenu']/ul/li[4]/a[1]";
        internal string headerFinanceKurs = "//*[@id='mainmenu']/ul/li[4]/a[2]";
        internal string headerAfisha = "//*[@id='mainmenu']/ul/li[5]/a";
        internal string headerWork = "//*[@id='mainmenu']/ul/li[6]/a";
        internal string headerWeather = "//*[@id='mainmenu']/ul/li[7]/a";
        internal string headerTVset = "//*[@id='mainmenu']/ul/li[8]/a";
        internal string headerShops = "//*[@id='mainmenu']/ul/li[9]/a";
        internal string headerAutorize = "//*[@id='authorize']/div/a";
        internal string CloseheaderResourses;
        internal string hosterbyelement;
        internal string hosterby;
        internal string resourseCinema;
    }
}
