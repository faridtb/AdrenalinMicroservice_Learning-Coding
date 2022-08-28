using EventBus.Base.Event;

namespace NotificationService.IntegrationEvents.Events
{
    public class DoctorCreateSuccessedIntegrationEvent : IntegrationEvent
    {
        public int DoctorId { get; }

        public DoctorCreateSuccessedIntegrationEvent(int doctorId)
        {
            DoctorId = doctorId;
        }

    }
}
