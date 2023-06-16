using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class DeleteItem : BasePage
    {
        By cart_button = By.Id("cart_btn");
        By close_btn = By.Id("close_btn");
        By del_item1 = By.Id("Godzilla Milkshake");

        public object ExpectedConditions { get; private set; }

        public void delete_item()
        {
            driver.FindElement(cart_button).Click();
            driver.FindElement(del_item1).Click();
            handle_alert();
            driver.FindElement(cart_button).Click();
            driver.FindElement(close_btn).Click();
        }
        public void handle_alert()
        {
            //Wait for the alert to be displayed
            //wait.Until(ExpectedConditions.AlertIsPresent());
            //Store the alert in a variable
            IAlert alert = driver.SwitchTo().Alert();
            //Store the alert in a variable for reuse
            //string text = alert.Text;
            //Press the OK button
            alert.Accept();
            //Press the Cancel button
            //alert.Dismiss();
        }
    }
}
