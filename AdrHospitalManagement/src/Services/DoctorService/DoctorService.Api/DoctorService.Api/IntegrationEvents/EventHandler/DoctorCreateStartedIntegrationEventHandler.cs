using DoctorService.Api.IntegrationEvents.Events;
using EventBus.Base.Abstaction;
using EventBus.Base.Event;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorService.Api.IntegrationEvents.EventHandler
{
    public class DoctorCreateStartedIntegrationEventHandler : IIntegrationEventHandler<DoctorCreateStartedIntegrationEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly ILogger<DoctorCreateStartedIntegrationEventHandler> _logger;


        public DoctorCreateStartedIntegrationEventHandler(IEventBus eventBus,
            ILogger<DoctorCreateStartedIntegrationEventHandler> logger)
        {
            _eventBus = eventBus;
            _logger = logger;
        }

        public Task Handle(DoctorCreateStartedIntegrationEvent @event)
        {
            var result = true;
            //IntegrationEvent createEvent = result
            //    ? new DoctorCreateSuccessedIntegrationEvent(@event.DoctorId)
            //    : new DoctorCreateFailedIntegrationEvent(@event.DoctorId,"Error");

            IntegrationEvent createEvent = new DoctorCreateSuccessedIntegrationEvent(@event.DoctorId);

            if (result == true)
            {
                createEvent = new DoctorCreateSuccessedIntegrationEvent(@event.DoctorId);
            }
            else
            {
                 createEvent = new DoctorCreateFailedIntegrationEvent(@event.DoctorId,"Error Occured");
            }

            _logger.LogInformation($"DoctorCreatedIntegrationEventHandler worked ");

            _eventBus.Publish(createEvent);

            return Task.CompletedTask;







        }
    }
}
