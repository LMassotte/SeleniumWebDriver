using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Selenium.Utils
{
    public static class ScenariHelper
    {
        public static string ConnectionAsChiefScenario()
        {
            IWebDriver driver = BrowserHelper.GetFirefoxDriver();
            BrowserHelper.ConnectAsChief(driver);
            return driver.Url;
        }

        public static string ConnectionAsDataScientistScenario()
        {
            IWebDriver driver = BrowserHelper.GetFirefoxDriver();
            BrowserHelper.ConnectAsDataScientist(driver);
            return driver.Url;
        }

        public static string TryingToNavigateToChiefPageAsDataScientistScenario()
        {
            IWebDriver driver = BrowserHelper.GetFirefoxDriver();
            BrowserHelper.ConnectAsDataScientist(driver);

            driver.Url = "http://localhost:3001/Chief";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(BrowserHelper.UrlContains("/DataScience"));
            return driver.Url;

        }

        public static string TryingToNavigateToChiefPageAsChiefScenario()
        {
            IWebDriver driver = BrowserHelper.GetFirefoxDriver();
            BrowserHelper.ConnectAsChief(driver);

            driver.Url = "http://localhost:3001/Chief";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(BrowserHelper.UrlContains("/Chief"));
            return driver.Url;

        }
    }
}
