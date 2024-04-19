using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmailNotificationService : INotificationService
    {
        private string _token;
        private ValidateEmail _validateEmail;

        public EmailNotificationService(string token, string email)
        {
            _validateEmail = new ValidateEmail(email);
            _token = token;
        }

        public bool Send(string msg, string email)
        {
            if (_token == "1234" && _validateEmail.Validate())
            {
                Console.WriteLine($"{msg} para: {email}");
                return true;
            }

            return false;
        }
    }

    public class SMSNotificationService : INotificationService
    {
        private string _token;
        private ValidateEmail _validateEmail;

        public SMSNotificationService(string token, string email)
        {
            _validateEmail = new ValidateEmail(email);
            _token = token;
        }

        public bool Send(string msg, string email)
        {
            Console.WriteLine("teste de envio de SMS");
            if (_token == "1234" && _validateEmail.Validate())
            {
                Console.WriteLine($"{msg} para: {email}");
                return true;
            }

            return false;
        }
    }

    public class ValidateEmail
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
