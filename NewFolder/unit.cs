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
        
    }
    
        // Clean up by closing the browser after each test
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
}
