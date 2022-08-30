using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorService.Api.IntegrationEvents.Events
{
    public class DoctorCreateStartedIntegrationEvent : IntegrationEvent
    {
        public int DoctorId { get; set; }

        public DoctorCreateStartedIntegrationEvent()
        {

        }

        public DoctorCreateStartedIntegrationEvent(int doctorId)
        {
            DoctorId = doctorId;
        }
    }
}
