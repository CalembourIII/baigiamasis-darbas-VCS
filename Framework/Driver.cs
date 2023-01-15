﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Driver
    {
       private static IWebDriver driver;

        public static void CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-notifications");
            options.AddArgument("start-maximized");
            //options.AddArgument("headless");  --start-maximized    start-maximized
            //options.AddArgument("window-size=1920,1080");
            driver = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

        public static void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
