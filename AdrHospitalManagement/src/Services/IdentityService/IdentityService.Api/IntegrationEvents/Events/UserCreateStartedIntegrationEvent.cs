using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Api.IntegrationEvents.Events
{
    public class UserCreateStartedIntegrationEvent : IntegrationEvent
    {
        public int UserId { get; set; }

        public UserCreateStartedIntegrationEvent(int userId)
        {
            UserId = userId;
        }
    }
}
