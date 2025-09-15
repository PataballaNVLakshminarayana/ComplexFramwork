using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestPro2_ComplexFramwork
{
    public class DriverInit
    {
        public static IWebDriver InitWebDriver(string driver)
        {
            IWebDriver _driver=null;
            switch (driver.ToLower())
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "fireforx":
                    _driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentException("Unsupported browser");
            }
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
    }
}
