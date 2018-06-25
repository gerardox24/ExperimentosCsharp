using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelefonosCRUD.Test
{
    public class Driver
    {
        Driver()
        {

        }
        public static IWebDriver inicializarDriver()
        {
            IWebDriver iwebDriver = new ChromeDriver();
            iwebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return iwebDriver;
        }

        public static void cerrarPagina(IWebDriver iwebDriver)
        {
            iwebDriver.Close();
        }
    }
}