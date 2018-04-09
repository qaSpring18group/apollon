﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollonLaunch
{
    public class MainPage
    {
        string headerResourses = "//*[@id='mainmenu']/ul/li[1]/a";       //  //a[contains(.,'Разделы')] - находит 2 елемента
        string headerGoeTag = "//*[@id='geotarget_top_selector']"; 
        string headerEmail = "//*[@id='mainmenu']/ul/li[3]/a";           // //a[contains(.,'Почта')] - находит 2 елемеента
        string headerFinance = "//*[@id='mainmenu']/ul/li[4]/a[1]";
        string headerFinanceKurs = "//*[@id='mainmenu']/ul/li[4]/a[2]";
        string headerAfisha = "//*[@id='mainmenu']/ul/li[5]/a";
        string headerWork = "//*[@id='mainmenu']/ul/li[6]/a";
        string headerWeather = "//*[@id='mainmenu']/ul/li[7]/a";
        string headerTVset = "//*[@id='mainmenu']/ul/li[8]/a";
        string headerShops = "//*[@id='mainmenu']/ul/li[9]/a";
        string headerAutorize = "//*[@id='authorize']/div/a";
    }
}