using EventBus.Base.Event;

namespace NotificationService.IntegrationEvents.Events
{
    public class UserCreateSucceededIntegrationEvent : IntegrationEvent
    {
        public int UserId { get; }

        public UserCreateSucceededIntegrationEvent(int userId)
        {
            UserId = userId;
        }

    }
}
