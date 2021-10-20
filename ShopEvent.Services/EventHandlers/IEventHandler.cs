using ShopEvent.Events;

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
