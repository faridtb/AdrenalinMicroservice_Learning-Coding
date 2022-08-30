using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Api.IntegrationEvents.Events
{
    public class UserCreateSucceededIntegrationEvent : IntegrationEvent
    {
        public int UserId { get; set; }
        public UserCreateSucceededIntegrationEvent(int userId)
        {
            UserId = userId;
        }
    }
}
