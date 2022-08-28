using EventBus.Base.Abstaction;
using Microsoft.Extensions.Logging;
using NotificationService.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.IntegrationEvents.EventHandler
{
    public class DoctorCreateFailedIntegrationEventHandler : IIntegrationEventHandler<DoctorCreateFailedIntegrationEvent>
    {
        private readonly ILogger<DoctorCreateFailedIntegrationEventHandler> _logger;

        public DoctorCreateFailedIntegrationEventHandler(ILogger<DoctorCreateFailedIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(DoctorCreateFailedIntegrationEvent @event)
        {
            // Send Fail Notification ( Email, Sms )

            _logger.LogInformation($"Doctor create Failed with DoctorID:{@event.DoctorId}, ErrorMessage:{@event.ErrorMessage}");

            return Task.CompletedTask;
        }
    }
}
