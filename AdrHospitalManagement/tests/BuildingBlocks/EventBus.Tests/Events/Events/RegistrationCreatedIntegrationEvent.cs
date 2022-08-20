using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus.Tests.Events.Events
{
    public class RegistrationCreatedIntegrationEvent : IntegrationEvent
    {
        public int Id { get; set; }

        public RegistrationCreatedIntegrationEvent(int id)
        {
            Id = id;
        }
    }
}
