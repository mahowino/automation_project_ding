
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using automation_course.pages.demoBlaze;
using automation_course.pages.demoBlaze.models;
namespace automation_course.tests
{
    [TestFixture]

    public class DemoBlaze
    {
        DemoBlazeHomePage demoBlazeHomePage = new();

    

        [Test]
        public void shouldBeAbleToSendAContactUsMessage()
        {
            demoBlazeHomePage.setUpBeforeEachTest();
            demoBlazeHomePage.loadHomePage();
            demoBlazeHomePage.clickContactUsFromNavigationBar();
            ContactUsForm contactUsForm = new ContactUsForm("mahowino@gmail.com", "mahowino", "test");
            demoBlazeHomePage.submitContactUsModal(contactUsForm);
            demoBlazeHomePage.cleanUpAfterTest();
            demoBlazeHomePage.cleanUpAfterTest();
        }

    }
}
