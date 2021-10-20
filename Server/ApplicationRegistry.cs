using Lamar;
using ShopEvent.Data;
using ShopEvent.Domain.Services;
using ShopEvent.Events;
using ShopEvent.Services;
using ShopEvent.Services.EventHandlers;

namespace ShopEvent.Server
{
    public class ApplicationRegistry : ServiceRegistry
    {
        public ApplicationRegistry()
        {
            For<IMembershipRepository>().Use<MembershipRepository>();
            For<IOrderRepository>().Use<OrderRepository>();
            For<IProductRepository>().Use<ProductRepository>();

            For<IMembershipService>().Use<MembershipService>();
            For<IProductService>().Use<ProductService>();

            For<IEventHandler<ActivateMembershipEvent>>().Use<ActivateMembershipEventHandler>();

            For<IEventHandler>().Use<ActivateMembershipEventHandler>();
        }
    }
}
