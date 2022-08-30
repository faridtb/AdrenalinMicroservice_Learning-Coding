using EventBus.Base.Abstaction;
using EventBus.Base.Event;
using IdentityService.Api.Data;
using IdentityService.Api.IntegrationEvents.Events;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Api.IntegrationEvents.EventHandler
{
    public class UserCreatedIntegrationEventHandler : IIntegrationEventHandler<UserCreateStartedIntegrationEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly AppDbContext _context;
        private readonly ILogger<UserCreatedIntegrationEventHandler> _logger;


        public UserCreatedIntegrationEventHandler(IEventBus eventBus,
            ILogger<UserCreatedIntegrationEventHandler> logger, AppDbContext context)
        {
            _eventBus = eventBus;
            _logger = logger;
            _context = context;
        }

        public Task Handle(UserCreateStartedIntegrationEvent @event)
        {
            var result = _context.Users.Any(u => u.Id == @event.UserId);

            IntegrationEvent createEvent;

            if (result)
            {
                createEvent = new UserCreateFailedIntegrationEvent(@event.UserId, "Error occured while creating User");
                _logger.LogInformation("Failed Event Published");
            }
            else
            {
                createEvent = new UserCreateSucceededIntegrationEvent(@event.UserId);
                _logger.LogInformation("Succedeed Event Published");
            }
                
            _eventBus.Publish(createEvent);

            return Task.CompletedTask;
        }
    }
}
