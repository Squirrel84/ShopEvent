using ShopEvent.Events;

namespace ShopEvent.Domain.Services
{
    public interface IService
    {
        void RaiseEvent(IEvent @event);
    }
}