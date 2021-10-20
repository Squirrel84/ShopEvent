using System.Collections.Generic;

namespace ShopEvent.Domain
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderReference { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
