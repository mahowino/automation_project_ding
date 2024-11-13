using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automation_course.pages.demoQa.elements;
using NUnit.Framework;

namespace automation_course.tests.demoQA_tests
{
    internal class TextBoxTests
    {
        private TextBox textBox=new();
        [Test]
        public void shouldAcceptValidInput()
        {
            textBox.setUpBeforeEachTest();
            textBox.loadTextBoxPage();

            textBox.validatePageHasLoaded();
            textBox.enterEmail("testemail@email.com");
            textBox.enterFullName("tester name");
            textBox.enterCurrentAddress("tester location");
            textBox.enterPermanentAddress("tester permanent location");
            textBox.submitForm();
            textBox.validateFormHasBeenSubmitted();
            textBox.cleanUpAfterTest();

        }

    }
}
