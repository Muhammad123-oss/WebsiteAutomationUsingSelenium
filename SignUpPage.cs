using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class SignUpPage : BasePage
    {
        #region locators
        By username_txt = By.Id("username");
        By password_txt = By.Id("password");
        By email_txt = By.Id("email");
        By confirm_password_txt = By.Id("confirm_password");
        By form_submit = By.Id("form_submit");
        By sms_txt = By.Id("sms");
        #endregion

        public void SignUp(string username,string email,string password,string confirm_password,string message)
        {
            driver.Url = "http://localhost/food_ordering/other_files/_signup.php";
            //driver.FindElement(By.Id("signup")).Click();
            driver.FindElement(username_txt).SendKeys(username);
            driver.FindElement(email_txt).SendKeys(email);
            driver.FindElement(password_txt).SendKeys(password);
            driver.FindElement(confirm_password_txt).SendKeys(confirm_password);
            driver.FindElement(form_submit).Click();
            string success_sms = driver.FindElement(sms_txt).Text;
            Assert.AreEqual(message, success_sms, "Fail To Register");
        }
    }
}
