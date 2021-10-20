using System;

namespace ShopEvent.Domain
{
    public class Product
    {
        public Product()
        { }


        public Product(string productSku, string productTitle, ProductType productType, decimal price)
        {
            ProductId = Guid.NewGuid();
            ProductSKU = productSku;
            ProductTitle = productTitle;
            ProductType = productType.ToString();
            Price = price;
        }

        public Guid ProductId { get; set; }

        public string ProductTitle { get; set; }

        public string ProductSKU { get; set; }

        public bool IsVirtual { get; set; }

        public bool RequiresRoyalty { get; set; }

        public string ProductType { get; set; }

        public decimal Price { get; set; }

        public bool GeneratesCommission { get; set; }
    }
}
