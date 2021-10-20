using System;

namespace ShopEvent.Events
{
    public class ActivateMembershipEvent : IEvent
    {
        public Guid MembershipId { get; set; }
    }
}
