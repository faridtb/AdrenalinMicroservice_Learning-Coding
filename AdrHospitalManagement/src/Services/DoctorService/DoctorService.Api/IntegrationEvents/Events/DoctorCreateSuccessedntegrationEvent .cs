
using EventBus.Base.Event;

namespace DoctorService.Api.IntegrationEvents.Events
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
