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
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> logger;

        public OrderController(ILogger<OrderController> logger)
        {
            this.logger = logger;
        }

        public void PlaceOrder(Order order)
        { 
            
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Order
            {

            })
            .ToArray();
        }
    }
}
