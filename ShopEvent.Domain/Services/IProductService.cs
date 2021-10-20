using System;
using System.Collections.Generic;
using System.Text;

namespace ShopEvent.Domain.Services
{
    public interface IProductService : IService
    {
        IEnumerable<Product> GetTopSellingProducts(int v);
        void Buy(Guid productId);
    }
}
