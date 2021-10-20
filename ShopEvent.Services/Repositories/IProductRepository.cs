using ShopEvent.Domain;
using System;
using System.Collections.Generic;

namespace ShopEvent.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetTopProductsBySales(int productCount);
        Product GetById(Guid productId);
    }
}