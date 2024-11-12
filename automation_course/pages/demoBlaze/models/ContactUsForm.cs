using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_course.pages.demoBlaze.models
{
    internal class ContactUsForm
    {
        public String nameInput ;
        public String emailInput;
        public String messageInput;

        public ContactUsForm(String nameInput, String emailInput, String messageInput)
        {
            this.nameInput = nameInput;
            this.emailInput = emailInput;
            this.messageInput = messageInput;
        }



      
    }
}
