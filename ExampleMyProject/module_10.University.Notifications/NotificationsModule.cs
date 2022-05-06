using Autofac;
using module_10.University.Domain.DomainNotificationService;

namespace module_10.University.Notifications
{
    public class NotificationsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NotificationService>().As<INotificationService>();
        }
    }
}