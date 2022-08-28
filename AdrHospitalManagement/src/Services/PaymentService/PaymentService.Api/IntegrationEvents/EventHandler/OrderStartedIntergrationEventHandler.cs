using EventBus.Base.Abstaction;
using EventBus.Base.Event;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PaymentService.Api.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Api.IntegrationEvents.EventHandler
{
    public class OrderStartedIntegrationEventHandler : IIntegrationEventHandler<OrderStartedIntegrationEvent>
    {
        private readonly IConfiguration _config;
        private readonly IEventBus _eventbus;
        private readonly ILogger<OrderStartedIntegrationEventHandler> _logger;

        public OrderStartedIntegrationEventHandler(IConfiguration config, IEventBus eventbus, ILogger<OrderStartedIntegrationEventHandler> logger)
        {
            _config = config;
            _eventbus = eventbus;
            _logger = logger;
        }

        public Task Handle(OrderStartedIntegrationEvent @event)
        {
            string keyword = "PaymentSuccess";

            bool paymentSuccesFlag = _config.GetValue<bool>(keyword);

            IntegrationEvent paymentEvent;

            if (paymentSuccesFlag)
            {
                 paymentEvent = new OrderSuccededIntegrationEvent(@event.OrderId);
            }
            else
            {
                 paymentEvent = new OrderFailedIntegrationEvent(@event.OrderId, "Error");
            }

            _logger.LogInformation($"Nelerse bash verdi");

            _eventbus.Publish(paymentEvent);

            return Task.CompletedTask;
        }
    }
}
