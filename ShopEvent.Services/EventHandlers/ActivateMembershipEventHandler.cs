using ShopEvent.Domain.Services;
using ShopEvent.Services.Events;
using System;
using System.Collections.Generic;
using System.Text;

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
