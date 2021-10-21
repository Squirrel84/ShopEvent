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

        public MembershipService(ILogger<MembershipService> logger, IMembershipRepository membershipRepository)
        {
            this.logger = logger;
            MembershipRepository = membershipRepository;
        }

        public IMembershipRepository MembershipRepository { get; }

        public void Activate(Guid membershipId)
        {
            Membership membership = MembershipRepository.GetMembershipById(membershipId);

            if (membership.IsActive)
            {
                logger.LogWarning($"Membership [{membership.MembershipId}] is already active. Noting to do here.");
                return;
            }

            membership.Activate();

            MembershipRepository.Save(membership);
        }
    }
}
