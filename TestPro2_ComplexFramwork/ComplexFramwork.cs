using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPro2_ComplexFramwork
{
    public class ComplexFramwork
    {
        private static IWebDriver _driver;
        public ComplexFramwork(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement _usernametxt => _driver.FindElement(By.Id("username"));
        private IWebElement _passwordtxt => _driver.FindElement(By.Id("password"));
        private IWebElement _loginbtn => _driver.FindElement(By.Id("login"));
        public void TM_LoginPage(string Username, string Password)
        {
            _usernametxt.SendKeys(Username);
            _passwordtxt.SendKeys(Password);
            _loginbtn.Click();
        }
    }
}
