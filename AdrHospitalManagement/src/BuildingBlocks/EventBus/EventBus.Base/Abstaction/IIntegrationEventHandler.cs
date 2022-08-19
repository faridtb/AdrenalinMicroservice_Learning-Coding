using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstaction
{
    public interface IIntegrationEventHandler<TIntegrationEvent>: IntegrationEventHandler where TIntegrationEvent: IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);

    }
    public interface IntegrationEventHandler
    {

    }
}
