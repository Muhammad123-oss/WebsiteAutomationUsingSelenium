using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class LogInPage : BasePage
    {
        By username_txt = By.Id("username");
        By password_txt = By.Id("password");
        By email_txt = By.Id("email");
        
        public void LogIn(string username, string email, string password)
        {
            driver.Url = "http://localhost/food_ordering/other_files/_login.php";
            driver.FindElement(username_txt).SendKeys(username);
            driver.FindElement(email_txt).SendKeys(email);
            driver.FindElement(password_txt).SendKeys(password);
            driver.FindElement(By.Id("user_login")).Click();
            string welcome_page = driver.Url;
            Assert.AreEqual("http://localhost/food_ordering/other_files/_food_welcome.php", welcome_page, "Fail To Login");
        }
    }
}
