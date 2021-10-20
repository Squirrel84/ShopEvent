using ShopEvent.Domain.Services;
using ShopEvent.Events;

namespace ShopEvent.Services.EventHandlers
{
    public class ActivateMembershipEventHandler : IEventHandler, IEventHandler<ActivateMembershipEvent>
    {
        private readonly IMembershipService _membershipService;

        public ActivateMembershipEventHandler(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        public void Handle(ActivateMembershipEvent @event)
        {
            _membershipService.Activate(@event.MembershipId);
        }

        public void Handle(IEvent @event)
        {
            Handle((ActivateMembershipEvent)@event);
        }
    }
}
