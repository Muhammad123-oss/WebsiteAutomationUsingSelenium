using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class PaymentProceed : BasePage
    {
        By payment_button = By.Id("payment_btn");
        By payment_mode = By.Id("online");
        By btn = By.Id("mode_confirm");
        By payment_details = By.Id("payment_details");
        By email = By.Id("email");
        By code = By.Id("code");
        By payment_gateway = By.Id("paypal");
        By submit_details = By.Id("submit_details");
        By confirm_page = By.Id("confirm_order");
        By place_order_btn = By.Id("done");
        By sms = By.ClassName("alert-heading");
        By home_page = By.Id("home_page");

        public void select_mode()
        {
            driver.FindElement(payment_button).Click();
            driver.FindElement(payment_mode).Click();
            driver.FindElement(btn).Click();
            string details_page = driver.FindElement(payment_details).Text;
            Assert.AreEqual("Fill Out The Form", details_page, "Failed To Proceed");
        }

        public void fill_details(string user_email,string user_code)
        {
            driver.FindElement(email).SendKeys(user_email);
            driver.FindElement(code).SendKeys(user_code);
            driver.FindElement(payment_gateway).Click();
            driver.FindElement(submit_details).Click();
            string confirm_order = driver.FindElement(confirm_page).Text;
            Assert.AreEqual("Order Confirmation", confirm_order, "Failed To Confirm");
        }

        public void confirm_order()
        {
            driver.FindElement(place_order_btn).Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            string message = driver.FindElement(sms).Text;
            Assert.AreEqual("Order Placed!", message, "Not Displayed");
            driver.FindElement(home_page).Click();
        }
    }
}
