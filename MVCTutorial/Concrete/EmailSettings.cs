using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTutorial.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "tobennanwokike@gmail.com";
        public string MailFromAddress = "tobennanwokike@gmail.com";
        public bool UseSsl = true;
        public string Username = "tobennanwokike@gmail.com";
        public string Password = "Omoenugu2#"; // Create your own google app password, In the video I have shown you how to create app password.
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
