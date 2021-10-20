using Lamar;
using ShopEvent.Events;
using ShopEvent.Services.EventHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShopEvent.Services
{
    public class EventDispatcher
    {
        public static EventDispatcher Instance { get { return _instance; } }

        public IContainer Container { get; private set; }

        private static EventDispatcher _instance = new EventDispatcher();

        public void Configure(IContainer containerRegistry)
        {
            Container = containerRegistry;
        }

        public void DispatchEvents(IEnumerable<IEvent> events)
        {
            foreach (var @event in events)
            {
                Type integrationEventType = @event.GetType();

                var eventHandlers = Container.GetAllInstances<IEventHandler>();

                eventHandlers = eventHandlers
                                    .Where(handler => ((TypeInfo)handler.GetType()).ImplementedInterfaces
                                        .Any(i => i.GenericTypeArguments.FirstOrDefault() == integrationEventType))
                                    .ToList();

                foreach (var eventHandler in eventHandlers)
                {
                    eventHandler.Handle(@event);
                }
            }
        }

        
    }
}
