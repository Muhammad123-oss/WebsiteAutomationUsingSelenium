using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class LogOut : BasePage
    {
        By logout_user = By.Id("logout_btn");
        By sms = By.Id("login_pg");

        public void LogOutUser()
        {
            driver.FindElement(logout_user).Click();
            string login_page = driver.FindElement(sms).Text;
            Assert.AreEqual("SSF Ordering LogIn", login_page, "Failed To LogOut");
        }
    }
}
