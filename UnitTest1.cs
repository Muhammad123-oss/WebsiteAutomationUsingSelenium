using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ST_Project
{
    [TestClass]
    public class UnitTest1
    {
        LogInPage lgp = new LogInPage();
        WelcomePage wp = new WelcomePage();
        SignUpPage sgnp = new SignUpPage();
        AddToCart atc = new AddToCart();
        DeleteItem dlt = new DeleteItem();
        PaymentProceed pmtp = new PaymentProceed();
        LogOut logOut_user = new LogOut();

        // We are not initializing driver here in class initiaizer bcz in case of large number of test cases it may cause cache issue
        //[ClassInitialize]
        //public void ClassInit()
        //{
        //}

        [TestInitialize]
        public void TestInit()
        {
            BasePage.InitDriver();
        }

        [TestMethod]
        [DataRow("Faiz_Tester_2", "Faiz_Tester_2@gmail.com", "Faiz_Tester123456789", "Faiz_Tester123456789", "Success!")]
        [TestCategory ("Signup")]
        public void SignUp_TestCase(string username, string email, string password, string confirm_password, string message)
        {
            sgnp.SignUp(username, email, password, confirm_password, message);
        }

        [TestMethod]
        [DataRow("Faiz_Tester", "Faiz_Tester@gmail.com", "Faiz_Tester123")]
        [TestCategory("LogIn")]
        public void LogIn_TestCase(string username, string email, string password)
        {
            lgp.LogIn(username, email, password);
        }

        [TestMethod]
        [DataRow("McDonald\'s", "Welcome TO McDonalds")]
        [TestCategory("select_resturant")]
        public void Select_Resturant_TestCase(string resturant_name, string welcome_heading)
        {
            lgp.LogIn("Faiz_Tester", "Faiz_Tester@gmail.com", "Faiz_Tester123");
            wp.Select_Resturant(resturant_name, welcome_heading);
        }

        [TestMethod]
        [DataRow("McDonald\'s", "Welcome TO McDonalds")]
        [TestCategory("AddToCart")]
        public void AddtoCart_TestCase(string resturant_name,string welcome_heading)
        {
            lgp.LogIn("Faiz_Tester", "Faiz_Tester@gmail.com", "Faiz_Tester123");
            wp.Select_Resturant(resturant_name, welcome_heading);
            atc.Additems();
        }

        [TestMethod]
        [DataRow("McDonald\'s", "Welcome TO McDonalds")]
        [TestCategory("DeleteItem")]
        public void DeleteItem_TestCase(string resturant_name, string welcome_heading)
        {
            lgp.LogIn("Faiz_Tester", "Faiz_Tester@gmail.com", "Faiz_Tester123");
            wp.Select_Resturant(resturant_name, welcome_heading);
            atc.Additems();
            dlt.delete_item();
        }

        [TestMethod]
        [DataRow("McDonald\'s", "Welcome TO McDonalds")]
        [TestCategory("PaymentProceed")]
        public void PaymentProceed_TestCase(string resturant_name, string welcome_heading)
        {
            lgp.LogIn("Faiz_Tester", "Faiz_Tester@gmail.com", "Faiz_Tester123");
            wp.Select_Resturant(resturant_name, welcome_heading);
            atc.Additems();
            pmtp.select_mode();
            pmtp.fill_details("Faiz_Tester@gmail.com", "129");
            pmtp.confirm_order();
            logOut_user.LogOutUser();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            BasePage.driver.Close();
        }

        //[ClassCleanup]
        //public void ClassCleanUp()
        //{
        //}
    }
}
