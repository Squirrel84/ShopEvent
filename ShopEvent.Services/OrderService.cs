using ShopEvent.Domain;
using ShopEvent.Domain.Services;
using System;

namespace ShopEvent.Services
{
    public class OrderService : BaseService, IOrderService
    {
        public OrderService(IOrderRepository orderRepository)
        { 
        
        }

        public void PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
