using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopEvent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopEvent.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };

        private readonly ILogger<ProductController> logger;

        public IProductRepository ProductRepository { get; }

        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            this.logger = logger;
            this.ProductRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            this.ProductRepository.GetTopSellingProducts(20);

            var random = new Random(DateTime.UtcNow.Second);

            List<Product> products = new List<Product>();

            for (int x = 1; x < 20; x++)
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

        [HttpPost]
        public void Buy(Guid productId)
        {
            
        }
        
    }
}
