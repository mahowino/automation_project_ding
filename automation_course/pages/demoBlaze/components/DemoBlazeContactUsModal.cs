
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using automation_course.infrastructure;

namespace automation_course.pages.demoBlaze.components
{
    internal class DemoBlazeContactUsModal:BasePage
    {
        private string demoBlazeUrl = "https://www.demoblaze.com/";
       

        private static By contactUsEmailInput = By.Id("recipient-email");
        private static By contactUsNameInput = By.Id("recipient-name");
        private static By contactUsMessageInput = By.Id("message-text");
        private static By contactUsModal = By.ClassName("modal-content");


        public DemoBlazeContactUsModal()
        {
            webDriverWait.Until(driv => driv.FindElement(contactUsModal).Displayed);
        }


        public void fillEmailInput(string email)
        {
            webDriver.FindElement(contactUsEmailInput).SendKeys(email);
        }

        public void fillNameInput(string name)
        {
            webDriver.FindElement(contactUsNameInput).SendKeys(name);
        }

        public void fillMessageInput(string message)
        {
            webDriver.FindElement(contactUsMessageInput).SendKeys(message);
        }

        public void submitContactUsForm()
        {
            webDriver.FindElement(contactUsMessageInput).Submit();
        }
     
    }
}
