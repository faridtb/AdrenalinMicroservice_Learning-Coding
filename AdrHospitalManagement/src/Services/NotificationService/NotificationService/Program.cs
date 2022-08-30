using EventBus.Base;
using EventBus.Base.Abstaction;
using EventBus.Factory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NotificationService.IntegrationEvents.EventHandler;
using NotificationService.IntegrationEvents.Events;
using System;

namespace NotificationService
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceCollection services = new ServiceCollection();

            ConfigureServices(services);

            var sp = services.BuildServiceProvider();

            IEventBus eventBus = sp.GetRequiredService<IEventBus>();

            eventBus.Subscribe<UserCreateSucceededIntegrationEvent, UserCreateSucceededIntegrationEventHandler>();
            eventBus.Subscribe<UserCreateFailedIntegrationEvent, UserCreateFailedIntegrationEventHandler>();

            Console.WriteLine("App is running....");

            Console.ReadLine();

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure =>
            {
                configure.AddConsole();
            });


            services.AddTransient<UserCreateFailedIntegrationEventHandler>();
            services.AddTransient<UserCreateSucceededIntegrationEventHandler>();

            services.AddSingleton<IEventBus>(sp =>
            {
                EventBusConfig config = new EventBusConfig
                {
                    ConnectionRetryCount = 5,
                    EventNameSuffix = "IntegrationEvent",
                    SubscriberClientAppName = "NotificationService",
                    EventBusType = EventBusType.RabbitMQ
                };
                return EventBusFactory.Create(config, sp);
            });


        }
    }
}
