using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ShopEvent.Domain;
using ShopEvent.Domain.Services;
using System;

namespace ShopEvent.Services.Tests
{
    public class Tests
    {
        Mock<IMembershipRepository> mockMembershipRepository = null;
        Mock<ILogger<MembershipService>> mockLogger = null;
        IMembershipService MembershipService = null;

        [OneTimeSetUp]
        public void Setup()
        {
            mockMembershipRepository = new Mock<IMembershipRepository>();
            mockLogger = new Mock<ILogger<MembershipService>>();

            MembershipService = new MembershipService(mockLogger.Object, mockMembershipRepository.Object);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            mockMembershipRepository = null;
            MembershipService = null;
        }

        [Test]
        public void MembershipService_Activate_MembershipNotActive_IsActivated()
        {
            //Arrange
            var membership = new Domain.Membership() { IsActive = false, MembershipId = Guid.NewGuid() };

            mockMembershipRepository.Setup(x => x.GetMembershipById(It.IsAny<Guid>())).Returns(membership);

            //Act 
            MembershipService.Activate(Guid.NewGuid());

            //Assert
            mockMembershipRepository.Verify(x => x.Save(membership), Times.Once);

            Assert.IsTrue(membership.IsActive);
        }

        [Test]
        public void MembershipService_Activate_MembershipIsActive_IsNotActivated()
        {
            //Arrange
            var membership = new Domain.Membership() { IsActive = true, MembershipId = Guid.NewGuid() };

            mockMembershipRepository.Setup(x => x.GetMembershipById(It.IsAny<Guid>())).Returns(membership);

            //Act 
            MembershipService.Activate(Guid.NewGuid());

            //Assert
            mockMembershipRepository.Verify(x => x.Save(It.IsAny<Membership>()), Times.Never);

            Assert.IsTrue(membership.IsActive);
        }
    }
}