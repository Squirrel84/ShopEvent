namespace ShopEvent.Server.Controllers
{
    public interface IProductRepository
    {
        void GetTopSellingProducts(int v);
    }
}