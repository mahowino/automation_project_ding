using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using static System.Net.WebRequestMethods;

namespace automation_course
{
    public class Class1
    {
        [Fact]
        [Trait("Category","Smoke")]
        public void loadApplicationPage()
        { 
            using(IWebDriver webDriver=new ChromeDriver())
            {
                String url = "https://www.saucedemo.com/";
                webDriver.Navigate().GoToUrl(url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void shouldBeAbleToLogInSuccessfully()
        {
            using (IWebDriver webDriver = new ChromeDriver())
            {
                String url = "https://www.saucedemo.com/";
                webDriver.Navigate().GoToUrl(url);
                IWebElement usernameInput = webDriver.FindElement(By.Id("user-name"));
                IWebElement passwordInput = webDriver.FindElement(By.Id("password"));
                IWebElement loginInput = webDriver.FindElement(By.Name("login-button"));

                usernameInput.SendKeys("standard_user");
                passwordInput.SendKeys("secret_sauce");
                loginInput.Click();
                Assert.Equal("https://www.saucedemo.com/inventory.html", webDriver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void shouldNotBeAbleToLogInWithoutPassword()
        {
            using (IWebDriver webDriver = new ChromeDriver())
            {
                String url = "https://www.saucedemo.com/";
                webDriver.Navigate().GoToUrl(url);
                IWebElement usernameInput = webDriver.FindElement(By.Id("user-name"));
                IWebElement loginInput = webDriver.FindElement(By.Name("login-button"));

                usernameInput.SendKeys("standard_user");
                IWebElement errorMessage = webDriver.FindElement(By.CssSelector("h3[data-test='error']"));
                loginInput.Click();
                bool isErrorMessageVisible = errorMessage.Displayed;
                String errorMessageText=errorMessage.Text;
                Assert.True(isErrorMessageVisible);
                Assert.Equal("https://www.saucedemo.com/", webDriver.Url);
                Assert.Equal(errorMessageText, "Epic sadface: Password is required");
            }
        }

    }
}
