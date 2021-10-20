namespace ShopEvent.Domain.Services
{
    public interface IOrderService : IService
    {
        void PlaceOrder(Order order);
    }
}
