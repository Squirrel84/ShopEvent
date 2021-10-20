using ShopEvent.Domain;
using System;

namespace ShopEvent.Services
{
    public interface IMembershipRepository
    {
        Membership GetMembershipById(Guid membershipId);
        void Save(Membership membership);
    }
}