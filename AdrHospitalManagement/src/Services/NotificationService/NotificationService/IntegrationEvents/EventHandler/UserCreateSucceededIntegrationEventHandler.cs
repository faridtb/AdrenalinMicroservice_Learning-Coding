using EventBus.Base.Abstraction;
using Microsoft.Extensions.Logging;
using NotificationService.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.IntegrationEvents.EventHandler
{
    public class UserCreateSucceededIntegrationEventHandler : IIntegrationEventHandler<UserCreateSucceededIntegrationEvent>
    {
        private readonly ILogger<UserCreateSucceededIntegrationEventHandler> _logger;

        public UserCreateSucceededIntegrationEventHandler(ILogger<UserCreateSucceededIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(UserCreateSucceededIntegrationEvent @event)
        {
            // Send Fail Notification ( Email, Sms )

            Console.WriteLine("Succese girdin");
            _logger.LogInformation($"Doctor create successed with DoctorID:{@event.UserId}");

            return Task.CompletedTask;
        }
    }
}
