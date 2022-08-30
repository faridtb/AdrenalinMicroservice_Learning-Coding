using EventBus.Base.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorService.Api.IntegrationEvents.Events
{
    public class DoctorCreateFailedIntegrationEvent : IntegrationEvent
    {
        public int DoctorId { get; }
        public string ErrorMessage { get;}

        public DoctorCreateFailedIntegrationEvent(int doctorId, string errorMessage)
        {
            DoctorId = doctorId;
            ErrorMessage = errorMessage;
        }

    }
}
