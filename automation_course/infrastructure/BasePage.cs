using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automation_course.infrastructure
{
    public class BasePage
    {
        public static IWebDriver webDriver;
        public static WebDriverWait webDriverWait;
        public int explicitWaitTime = 10;

        public BasePage() 
        {
           

        }

        public void setUpBeforeEachTest()
        {
            webDriver = new ChromeDriver();
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(explicitWaitTime));
            webDriver.Manage().Window.Maximize();

        }

        public void scrollUntilElementIsVisible(By by)
        {
            IWebElement element = webDriverWait.Until(driver=>driver.FindElement(by));
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            webDriverWait.Until(driver=>driver.FindElement(by).Displayed);
        }

        public void cleanUpAfterTest()
        {
            webDriver.Quit();
        }

    }
}
