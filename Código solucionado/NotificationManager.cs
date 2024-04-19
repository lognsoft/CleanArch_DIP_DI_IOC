    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        //Princípio da Inversão de Dependência (DIP)
        // Injeção de Dependência (DI),
        //Inversão de Controle (IOC)
        public class NotificationManager
        {
            private INotificationService _notificationService;

            public NotificationManager(INotificationService notificationService)
            {
                _notificationService = notificationService;
            }

            public bool Notify(string msg, string email, string token)
            {
                return _notificationService.Send(msg, email, token);
            }
        }

        public class Teste
        {
            private INotificationService _notificationService;

            public Teste(INotificationService notificationService)
            {
                _notificationService = notificationService;
            }
        }

        public class Teste1
        {
            private INotificationService _notificationService;

            public Teste1(INotificationService notificationService)
            {
                _notificationService = notificationService;
            }
        }


    }
