using ShopEvent.Domain.Services;
using ShopEvent.Events;
using System.Collections.Generic;

namespace ShopEvent.Services
{
    public class BaseService : IService
    {
        private readonly List<IEvent> events = new List<IEvent>();

        public void RaiseEvent(IEvent @event)
        {
            events.Add(@event);
        }

        protected void DispatchEvents()
        {
            EventDispatcher.Instance.DispatchEvents(this.events);
        }
    }
}