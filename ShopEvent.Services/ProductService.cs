using ShopEvent.Domain;
using ShopEvent.Domain.Services;
using ShopEvent.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopEvent.Services
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(
            IProductRepository productRepository,
            IOrderService orderService)
        {
            ProductRepository = productRepository;

            OrderService = orderService;
        }

        public IProductRepository ProductRepository { get; }
        public IOrderService OrderService { get; }

        public void Buy(Guid productId)
        {
            Product product = ProductRepository.GetById(productId);

            CheckProductStockLevel(product);

            OrderService.PlaceOrder(new Order() { Products = new[] { product } });

            if (product.GeneratesCommission)
            {
                RaiseEvent(new GenerateCommissionPaymentEvent());
            }


        }

        private void CheckProductStockLevel(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetTopSellingProducts(int productCount)
        {
            return ProductRepository.GetTopProductsBySales(productCount).ToList();
        }

        public void RaiseEvent(IEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
