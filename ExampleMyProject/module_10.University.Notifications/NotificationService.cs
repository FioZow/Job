using System;
using module_10.University.Domain.DomainNotificationService;

namespace module_10.University.Notifications
{
    internal class NotificationService : INotificationService
    {
        public void SendSms(string message)
        {
            Console.WriteLine(message);
        }

        public void SendEmail(string message)
        {
            Console.WriteLine(message);
        }
    }
}