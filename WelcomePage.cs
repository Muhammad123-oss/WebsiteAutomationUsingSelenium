using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class WelcomePage : BasePage
    {
        public void Select_Resturant(string resturant_name, string welcome_heading)
        {
            driver.FindElement(By.Id(resturant_name)).Click();
            string heading = driver.FindElement(By.Id("welcome")).Text;
            Assert.AreEqual(welcome_heading, heading, "SomeThing Went Wrong");
        }
    }
}
