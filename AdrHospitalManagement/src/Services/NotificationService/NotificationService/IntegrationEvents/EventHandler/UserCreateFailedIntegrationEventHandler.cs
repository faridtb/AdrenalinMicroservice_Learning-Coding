using EventBus.Base.Abstaction;
using Microsoft.Extensions.Logging;
using NotificationService.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.IntegrationEvents.EventHandler
{
    public class UserCreateFailedIntegrationEventHandler : IIntegrationEventHandler<UserCreateFailedIntegrationEvent>
    {
        private readonly ILogger<UserCreateFailedIntegrationEventHandler> _logger;

        public UserCreateFailedIntegrationEventHandler(ILogger<UserCreateFailedIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(UserCreateFailedIntegrationEvent @event)
        {
            // Send Fail Notification ( Email, Sms )

            _logger.LogInformation($"User create Failed with UserID:{@event.UserId}, ErrorMessage:{@event.ErrorMessage}");

            return Task.CompletedTask;
        }
    }
}
