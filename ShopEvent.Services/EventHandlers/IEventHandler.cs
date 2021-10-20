using ShopEvent.Services.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopEvent.Services.EventHandlers
{
    public interface IEventHandler
    {
        public void Handle(IEvent integrationEvent);
    }

    public interface IEventHandler<E> where E : IEvent
    {
        public void Handle(E integrationEvent);
    }
}
