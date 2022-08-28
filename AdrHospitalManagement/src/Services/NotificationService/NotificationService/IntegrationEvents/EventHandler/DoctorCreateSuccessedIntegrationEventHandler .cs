using EventBus.Base.Abstaction;
using Microsoft.Extensions.Logging;
using NotificationService.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.IntegrationEvents.EventHandler
{
    public class DoctorCreateSuccessedIntegrationEventHandler : IIntegrationEventHandler<DoctorCreateSuccessedIntegrationEvent>
    {
        private readonly ILogger<DoctorCreateSuccessedIntegrationEventHandler> _logger;

        public DoctorCreateSuccessedIntegrationEventHandler(ILogger<DoctorCreateSuccessedIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(DoctorCreateSuccessedIntegrationEvent @event)
        {
            // Send Fail Notification ( Email, Sms )

            _logger.LogInformation($"Doctor create successed with DoctorID:{@event.DoctorId}");

            return Task.CompletedTask;
        }
    }
}
