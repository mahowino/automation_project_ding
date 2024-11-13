using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automation_course.infrastructure;
using NUnit.Framework;
using OpenQA.Selenium;

namespace automation_course.pages.demoQa.elements
{
    internal class TextBox:BasePage
    {
        private readonly string textBoxUrl = "https://demoqa.com/text-box";
        private readonly By fullNameInput = By.Id("userName");
        private readonly By emailInput = By.Id("userEmail");
        private readonly By currentAdressInput = By.Id("currentAddress");
        private readonly By permanentAdressInput = By.Id("permanentAddress");
        private readonly By submitButton = By.Id("submit");
        private readonly By userForm = By.Id("userForm");
        private readonly By submittedNameParagraph = By.Id("name");
        private readonly By submittedEmailParagraph = By.Id("email");
        private readonly By submittedCurrentAdressParagraph = By.Id("currentAddress");
        private readonly By submittedPermanentAdressParagraph = By.Id("permanentAddress");
        public void loadTextBoxPage()
        {
            webDriver.Navigate().GoToUrl(textBoxUrl);
           
        }

        internal void validatePageHasLoaded()
        {
            Assert.That(webDriver.FindElement(userForm).Displayed);
        }

        internal void enterFullName(string fullName)
        {
            scrollUntilElementIsVisible(fullNameInput);
            webDriver.FindElement(fullNameInput).SendKeys(fullName);
        }

        internal void enterEmail(string email)
        {
            scrollUntilElementIsVisible(emailInput);
            webDriver.FindElement(emailInput).SendKeys(email);
        }

        internal void enterCurrentAddress(string currentAdress)
        {
            scrollUntilElementIsVisible(currentAdressInput);
            webDriver.FindElement(currentAdressInput).SendKeys(currentAdress);
        }

        internal void enterPermanentAddress(string permanentAdress)
        {
            scrollUntilElementIsVisible(permanentAdressInput);
            webDriver.FindElement(permanentAdressInput).SendKeys(permanentAdress);
        }

        internal void submitForm()
        {
            scrollUntilElementIsVisible(submitButton);
            webDriver.FindElement(submitButton).Click();
        }

        internal void validateFormHasBeenSubmitted()
        {
            Assert.That(webDriver.FindElement(submittedNameParagraph).Displayed);
            Assert.That(webDriver.FindElement(submittedEmailParagraph).Displayed);
            Assert.That(webDriver.FindElement(submittedPermanentAdressParagraph).Displayed);
            Assert.That(webDriver.FindElement(submittedPermanentAdressParagraph).Displayed);

        }
    }
}
