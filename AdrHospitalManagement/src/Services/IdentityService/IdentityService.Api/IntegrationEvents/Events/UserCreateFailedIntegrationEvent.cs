using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Api.IntegrationEvents.Events
{
    public class UserCreateFailedIntegrationEvent : IntegrationEvent
    {
        public int UserId { get; set; }
        public string ErrorMessage { get; set; }
        public UserCreateFailedIntegrationEvent(int userId,string errorMessage)
        {
            UserId = userId;
            ErrorMessage = errorMessage;
        }
    }
}
