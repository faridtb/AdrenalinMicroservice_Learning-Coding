﻿using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus.Base.Abstaction
{
    public interface IEventBus
    {
        void Publish(IntegrationEvent @event);

        void Subscribe<T, TH>() where T: IntegrationEvent where TH: IIntegrationEventHandler<T>;

        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

    }
}
