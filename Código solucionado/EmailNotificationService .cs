using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch_DIP_DI_IOC;

namespace ConsoleApp1
{
    public class EmailNotificationService : INotificationService
    {
        private IValidate _validateEmail;

        public EmailNotificationService(IValidate validateEmail)
        {
            _validateEmail = validateEmail;
        }

        public bool Send(string msg, string email, string token)
        {
            if (token == "1234" && _validateEmail.Validate())
            {
                Console.WriteLine($"{msg} para: {email}");
                return true;
            }

            return false;
        }
    }

    public class ValidateEmail : IValidate
    {
        public ValidateEmail(string email)
        {
            
        }

        public bool Validate()
        {
            return true;
        }
    }

}
