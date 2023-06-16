using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class BasePage
    {
        public static IWebDriver driver;
        public static IWebDriver InitDriver()
        {
            IWebDriver chrome_driver = new ChromeDriver();
            driver = chrome_driver;
            //IWebDriver edge_driver = new EdgeDriver();
            //driver = edge_driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
