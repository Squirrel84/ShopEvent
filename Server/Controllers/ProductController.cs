using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopEvent.Domain;
using ShopEvent.Domain.Services;
using System;
using System.Collections.Generic;

namespace ShopEvent.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;

        public IProductService ProductService { get; }

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            this.logger = logger;
            this.ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return this.ProductService.GetTopSellingProducts(20);
        }

        [HttpPost]
        public void Buy(Guid productId)
        {
            this.ProductService.Buy(productId);
        }
        
    }
}
