using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.IntegrationEvents.Events
{
    public class UserCreateFailedIntegrationEvent : IntegrationEvent
    {
        public int UserId { get; }
        public string ErrorMessage { get;}

        public UserCreateFailedIntegrationEvent(int userId, string errorMessage)
        {
            UserId = userId;
            ErrorMessage = errorMessage;
        }

    }
}
