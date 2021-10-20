using ShopEvent.Domain;
using ShopEvent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopEvent.Data
{
    public class ProductRepository : IProductRepository
    {
        private string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };

        private static List<Product> products = new List<Product>();

        public Product GetById(Guid productId)
        {
            return products.FirstOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> GetTopProductsBySales(int productCount)
        {
            var random = new Random(DateTime.UtcNow.Second);

            

            for (int x = 1; x < productCount+1; x++)
            {
                StringBuilder sbSkuCode = new StringBuilder();
                for (int c = 0; c < 5; c++)
                {
                    sbSkuCode.Append(letters[random.Next(0, 10)]);
                }

                for (int c = 0; c < 5; c++)
                {
                    sbSkuCode.Append(random.Next(0, 9));
                }

                var productTypeNumber = random.Next(0, Enum.GetNames(typeof(ProductType)).Length);

                ProductType productType = (ProductType)productTypeNumber;

                Product product = new Product(sbSkuCode.ToString(), $"Product {productType} {x}", productType, random.Next(1, 99));

                products.Add(product);
            }

            return products;
        }
    }
}
