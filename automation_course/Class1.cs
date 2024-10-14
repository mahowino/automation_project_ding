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

    }
}
