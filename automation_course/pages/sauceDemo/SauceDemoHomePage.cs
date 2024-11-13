using automation_course.infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace automation_course.pages.sauceDemo
{
    internal class SauceDemoHomePage :BasePage
    {

        private readonly string sauceDemoUrl = "https://www.saucedemo.com/";
        private readonly By username = By.Id("user-name");
        private readonly By password = By.Id("password");
        private readonly By login = By.Name("login-button");
        private readonly By error = By.CssSelector("h3[data-test='error']");


        public SauceDemoHomePage()
        {
           

        }

        public void loadHomePage()
        {
            
            webDriver.Navigate().GoToUrl(sauceDemoUrl);
        }
    


        public void inputUsername(string myUsername)
        {
            webDriver.FindElement(username).SendKeys(myUsername);
        }

        public void inputPassword(string myPassword)
        {
            webDriver.FindElement(password).SendKeys(myPassword);
        }

        public void submitLoginForm()
        {
            webDriver.FindElement(login).Click();
        }

        public bool isErrorIsShown()
        {
            return webDriverWait.Until(driver => driver.FindElement(error)).Displayed;
        }


    }
}
