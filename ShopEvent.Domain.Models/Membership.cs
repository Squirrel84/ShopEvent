using System;

namespace ShopEvent.Domain
{
    public class Membership
    {
        public bool IsActive { get; set; }
        public object MembershipId { get; set; }

        public void Activate()
        {
            IsActive = true;
        }
    }
}