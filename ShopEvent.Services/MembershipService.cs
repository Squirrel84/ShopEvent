using Microsoft.Extensions.Logging;
using ShopEvent.Domain;
using ShopEvent.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopEvent.Services
{
    public class MembershipService : IMembershipService
    {
        private readonly ILogger<MembershipService> logger;

        public MembershipService(IMembershipRepository membershipRepository)
        {
            MembershipRepository = membershipRepository;
        }

        public IMembershipRepository MembershipRepository { get; }

        public void Activate(Guid membershipId)
        {
            Membership membership = MembershipRepository.GetMembershipById(membershipId);

            if (membership.IsActive)
            {
                logger.LogWarning($"Membership [{membership.MembershipId}] is already active. Noting to do here.");
            }

            membership.Activate();

            MembershipRepository.Save(membership);
        }
    }
}
