using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollonLaunch
{
    public class MainPage
    {
        internal string headerResourses = "//*[@id='mainmenu']/ul/li[1]/a";    //a[@class='topbar-burger']//span     //a[contains(.,'Разделы')] - находит 2 елемента
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
        internal string searchField = "//input [@id=\"search_from_str\"]";
        internal string searchLabel = "//a [contains(text(), 'Афиша')]";
        internal string ensureLabelOnPage = "//a [contains(contains(text(), 'Афиша')]";
        internal string headerMaps = "//*[@id='mainmenu']/div/div/div/div/ul[2]/li[9]/a";

        internal string resourceFinance = "//*[@class='b-topbar-more-list']/li[4]/a";
        internal string statusFlag = "//div[@id='mainmenu']/div";
        // internal string CloseheaderResourses;
        // internal string hosterbyelement;
        // internal string hosterby;




        //internal string CloseheaderResourses;
        //internal string hosterbyelement;
        //internal string hosterby;

        internal string uCanHelpHim = "//*[@id='mainmenu']/div/div/div/div/ul[1]/li[6]/a";
		internal string uCanHelpHimElement = "//*[@id='header']/h1/a";



        internal string SECTION = "//div[@id='mainmenu']//ul//li[@class='topbar__li b-topbar-aside']//a[@class='topbar-burger']";
        internal string WEATHER = "//div[@id='mainmenu']//div[@class='topbarmore-i']//ul//li[@class='topbar__li']//a[@title='Погода']";
        internal string LOGOTOHOME = "//div[@class='outer']//div[@class='logo']//img[@src='https://img.tyt.by/i/logo.png']";
        internal string UNDROPPEDSECTION = "//div[@id='mainmenu']//a[@class='topbar-burger']";
        internal string resourseCinema = "//*[@class='b-topbar-more-list']/li[15]/a";


        //geoTag
        internal string popUpGeoTagCherven = "//*[@id='geotarget_top_selector']/span/span";
        internal string popUpGeoTag = "//*[@id='geoselector']/div";
        internal string popUpGeoTagModalHeader = "//*[@id='geoselector']/div/div/div[1]";
        internal string opUpGeoTagModalHeaderText = "//*[@id='geoselector']/div/div/div[1]/div/p";
        internal string popUpGeoTagSityTable = "//*[@id='geoselector']/div/div/div[3]/div/table";
        internal string popUpGeoTagSityTDMinskDist = "//*[@id='geoselector']/div/div/div[3]/div/table/tbody/tr/td[1]/div";
        internal string popUpGeoTagSityTDMinskDistMinsk = "//*[@id='gtgt15800']/a";
        internal string popUpGeoTagSityTDMinskDistBorisov = "//*[@id='gtgt21059']/a";
        internal string popUpGeoTagSityTDMinskDistCherven = "//*[@id='gtgt20860']/a";

         internal string popUpGeoTagChervenString =  "Червень";
    }
}
