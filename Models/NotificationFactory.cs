using Microsoft.Extensions.DependencyInjection;

namespace SolidOrderProcessing.Models
{
    
        public interface INotificationFactory
        {
            INotificationService GetNotificationService(string type);
        }

        public class NotificationFactory : INotificationFactory
        {
            private readonly IServiceProvider _serviceProvider;

            public NotificationFactory(IServiceProvider serviceProvider)
            {
                _serviceProvider = serviceProvider;
            }

            public INotificationService GetNotificationService(string type)
            {
                if (type?.ToLower() == "sms")
                    return _serviceProvider.GetService<SmsNotificationService>();
                else
                    return _serviceProvider.GetService<EmailNotificationService>();
            }
        }
    }
