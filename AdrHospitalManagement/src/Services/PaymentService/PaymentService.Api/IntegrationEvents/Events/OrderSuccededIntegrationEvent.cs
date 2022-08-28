using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Api.IntegrationEvents.Events
{
    public class OrderSuccededIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; set; }

        public OrderSuccededIntegrationEvent(int orderId)
        {
            OrderId = orderId;
        }
    }
}
