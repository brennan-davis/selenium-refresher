using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class SeleniumTest
    {
        public string test_url = "https://aptitude8.com/";

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(test_url);

            driver.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(2000);

            IWebElement contactUsButton = driver.FindElement(By.XPath("//*[@id=\"hs_cos_wrapper_module_16106654906244\"]/div/div/div/div/div/a/button"));
            contactUsButton.Click();

            IWebElement firstNameInput = driver.FindElement(By.XPath("//*[@id=\"firstname-21744f0f-c39d-4622-ad8c-9aac3b93d0a3_8281\"]"));
            firstNameInput.SendKeys("Brennan");

            IWebElement lastNameInput = driver.FindElement(By.XPath("//*[@id=\"lastname-21744f0f-c39d-4622-ad8c-9aac3b93d0a3_8281\"]"));
            lastNameInput.SendKeys("Davis");


            IWebElement header = driver.FindElement(By.XPath("//*[@id=\"hs_cos_wrapper_section-1-module-2_\"]/p/span/span"));
            string headerText = header.Text;
            Assert.IsTrue(headerText.ToLower().Contains("contact"));

            System.Threading.Thread.Sleep(4000);

            // Success
            Console.WriteLine("Contact Us Page Reached!");
            driver.Quit();
        }
    }
}
