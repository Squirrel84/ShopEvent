namespace ShopEvent.Domain
{
    public class Product
    {
        public Product(string productSku, ProductType productType, decimal price)
        { 
        
        }

        public int ProductId { get; private set; }

        public string ProductSKU { get; private set; }

        public bool IsVirtual { get; set; }

        public bool RequiresRoyalty { get; set; }

        public ProductType ProductCategory { get; private set; }

        public decimal Price { get; set; }

        public bool GeneratesCommission { get; set; }
    }
}
