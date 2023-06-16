using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class AddToCart : BasePage
    {
        By item1 = By.Id("Godzilla Milkshake");
        By item2 = By.Id("Oreo Dream");
        By item3 = By.Id("Quarantine Buddy");
        By item4 = By.Id("Bison Steak");
        public void Additems()
        {
            driver.FindElement(item1).Click();
            driver.FindElement(item2).Click();
            driver.FindElement(item3).Click();
            WebElement element = (WebElement)driver.FindElement(item4);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
            executor.ExecuteScript("arguments[0].click();", element);
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element).Click().Perform();
            //driver.FindElement(item4).Click();
        }
    }
}
