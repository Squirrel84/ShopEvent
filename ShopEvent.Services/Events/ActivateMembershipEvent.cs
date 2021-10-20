using System;
using System.Collections.Generic;
using System.Text;

namespace ShopEvent.Services.Events
{
    public class ActivateMembershipEvent : IEvent
    {
        public Guid MembershipId { get; set; }
    }
}
