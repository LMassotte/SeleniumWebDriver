using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Utils
{
    public static class BrowserHelper
    {
        public static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }

        public static IWebDriver ConnectAsChief(IWebDriver driver)
        {
            driver.Url = "http://localhost:3001";

            IWebElement usernameInput = driver.FindElement(By.Id("styledTextFieldUsername"));
            IWebElement passwordInput = driver.FindElement(By.Id("styledTextFieldPassword"));

            usernameInput.SendKeys("Loic");
            passwordInput.SendKeys("aaaaa");

            IWebElement loginButton = driver.FindElement(By.Id("buttonConnect"));
            loginButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(BrowserHelper.UrlContains("/Results"));
            return driver;
        }

        public static IWebDriver ConnectAsDataScientist(IWebDriver driver)
        {
            driver.Url = "http://localhost:3001";

            IWebElement usernameInput = driver.FindElement(By.Id("styledTextFieldUsername"));
            IWebElement passwordInput = driver.FindElement(By.Id("styledTextFieldPassword"));

            usernameInput.SendKeys("DataScientist");
            passwordInput.SendKeys("Tigrou008");

            IWebElement loginButton = driver.FindElement(By.Id("buttonConnect"));
            loginButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(BrowserHelper.UrlContains("/Results"));
            return driver;
        }

        public static Func<IWebDriver, bool> UrlContains(string partialUrl)
        {
            return (driver) => driver.Url.Contains(partialUrl);
        }
    }
}
