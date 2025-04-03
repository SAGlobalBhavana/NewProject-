using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{
    [TestClass]
    public class LoginTest
    {
      IWebDriver driver;

        // Initialize the driver before each test
        [TestInitialize]
        public void SetUp()
        {
            // Initialize ChromeDriver (Ensure ChromeDriver is installed in the correct path)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Maximize the browser window
        }

        // Test method to verify login functionality
         // Test method to verify login functionality
        [TestMethod]
        public void TestLogin()
        {
            // Navigate to the login page of the application
            driver.Navigate().GoToUrl("https://yourwebsite.com/login");

            // Find the username input field and enter a valid username
            var usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys("yourUsername");

            // Find the password input field and enter a valid password
            var passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("yourPassword");

            // Find the login button and click on it
            var loginButton = driver.FindElement(By.Id("loginButton"));
            loginButton.Click();

            // Clean up by closing the browser after each test
            [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
