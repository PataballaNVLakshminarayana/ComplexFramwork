using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TestPro2_ComplexFramwork.Utilities;

namespace TestPro2_ComplexFramwork
{
    [TestClass]
    public class Testcases
    {
        [TestMethod]
        public void TC_LoginPass()
        {
            var _driver = DriverInit.InitWebDriver(ConfigReader.GetBrowser());
            _driver.Navigate().GoToUrl(ConfigReader.GetUrl());
            ComplexFramwork _corepage = new ComplexFramwork(_driver);
            _corepage.TM_LoginPage("nagalakshmin", "l@kshmin");
            string actualtxt = _driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual(actualtxt, "Welcome to Adactin Group of Hotels");
            Thread.Sleep(10000);
            _driver.Quit();
        }
        public void TC_LoginFaild()
        {
            var _driver = DriverInit.InitWebDriver(ConfigReader.GetBrowser());
            _driver.Navigate().GoToUrl(ConfigReader.GetUrl());
            ComplexFramwork _corepage = new ComplexFramwork(_driver);
            _corepage.TM_LoginPage("nagalakshmin", "l@kshmi");
            string actualfaildtxt = _driver.FindElement(By.ClassName("auth_error")).Text;
            Assert.AreEqual(actualfaildtxt, "Invalid Login details or Your Password might have expired.Click here to reset your password");
            Thread.Sleep(10000);
            _driver.Quit();
        }
    }
}