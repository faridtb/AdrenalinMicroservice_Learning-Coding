using EventBus.Base.Abstaction;
using EventBus.Tests.Events.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Tests.Events.EventsHandler
{
    public class RegistrationCreatedIntegrationEventHandler : IIntegrationEventHandler<RegistrationCreatedIntegrationEvent>
    {
        public Task Handle(RegistrationCreatedIntegrationEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
