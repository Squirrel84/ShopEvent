using System;
using System.Collections.Generic;
using System.Text;

namespace ShopEvent.Domain.Services
{
    public interface IMembershipService
    {
        void Activate(Guid membershipId);
    }
}
