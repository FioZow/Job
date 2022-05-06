using System;

namespace module_10.University.Domain.DomainNotificationService
{
    public interface INotificationService
    {
        void SendSms(string message);

        void SendEmail(string message);

    }
}