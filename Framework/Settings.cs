using System;
using System.Configuration;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;


namespace HT_6.Framework
{
    class Settings
    {
        public static IWebDriver GetDriver()
        {

            
            return new ChromeDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Drivers"));


        }

        public static string GetBrowserType()
        {
            return ConfigurationManager.AppSettings["browserType"];
        }

        public static string GetCsvTable() // если чё, то ошибка тут
        {
            string table = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/table.csv");
            return table;
        }
        
    }
}
