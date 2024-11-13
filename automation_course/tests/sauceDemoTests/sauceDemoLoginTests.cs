using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Xunit.Sdk;
using automation_course.pages.sauceDemo;
using automation_course.pages.demoBlaze;

namespace automation_course.tests.sauceDemoTests
{

    public class sauceDemoLoginTests
    {
        private static SauceDemoHomePage sauceDemoHomePage = new SauceDemoHomePage();

        private readonly string sauceDemoInventoryUrl = "https://www.saucedemo.com/inventory.html";
        private readonly string testEmail = "standard_user";
        private readonly string testPassword = "secret_sauce";




        [Test]
        public void shouldBeAbleToLogInSuccessfully()
        {
            sauceDemoHomePage.setUpBeforeEachTest();
            sauceDemoHomePage.loadHomePage();
            sauceDemoHomePage.inputUsername(testEmail);
            sauceDemoHomePage.inputPassword(testPassword);
            sauceDemoHomePage.submitLoginForm();
            sauceDemoHomePage.cleanUpAfterTest();

        }

        [Test]
        public void shouldNotBeAbleToLogInWithoutPassword()
        {
            sauceDemoHomePage.setUpBeforeEachTest();

            sauceDemoHomePage.loadHomePage();

            sauceDemoHomePage.inputUsername(testEmail);
            sauceDemoHomePage.submitLoginForm();
            Assert.That(sauceDemoHomePage.isErrorIsShown);
            sauceDemoHomePage.cleanUpAfterTest();

        }


        [Test]
        public void shouldNotBeAbleToLogInWithoutUsername()
        {
            sauceDemoHomePage.setUpBeforeEachTest();

            sauceDemoHomePage.loadHomePage();

            sauceDemoHomePage.inputPassword(testPassword);
            sauceDemoHomePage.submitLoginForm();
            Assert.That(sauceDemoHomePage.isErrorIsShown);
            sauceDemoHomePage.cleanUpAfterTest();

        }



    }
}
