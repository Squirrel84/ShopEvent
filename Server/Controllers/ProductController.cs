using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopEvent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopEvent.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;

        public ProductController(ILogger<ProductController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var rng = new Random();

            Product product = new Product()

            return Enumerable.Range(1, 5).Select(index => new Product
            {

            })
            .ToArray();
        }
    }
}
