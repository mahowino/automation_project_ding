using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using automation_course.pages.demoBlaze.components;
using automation_course.pages.demoBlaze.models;
using automation_course.infrastructure;
using System.Collections.ObjectModel;

namespace automation_course.pages.demoBlaze
{
    internal class DemoBlazeHomePage:BasePage
    {

        private string demoBlazeUrl = "https://www.demoblaze.com/";
       
        public DemoBlazeHomePage()
        {
            
            
        }

        public void loadHomePage()
        {
            webDriver.Navigate().GoToUrl(demoBlazeUrl);
        }


        public void clickContactUsFromNavigationBar()
        {

            ReadOnlyCollection<IWebElement> navigationLink = webDriverWait.Until(driver => driver.FindElements(By.ClassName("nav-link")));
            foreach (IWebElement navigationItem in navigationLink)
            {
                if (navigationItem.Text == "Contact")
                {
                    navigationItem.Click();
                }
            }

        }

        public void submitContactUsModal(ContactUsForm form)
        {
            DemoBlazeContactUsModal contactUsModal = new DemoBlazeContactUsModal();
            contactUsModal.fillNameInput(form.nameInput);
            contactUsModal.fillEmailInput(form.emailInput);
            contactUsModal.fillMessageInput(form.messageInput);
            contactUsModal.submitContactUsForm();

        }

      

    }
}
