using System;
using System.Linq;
using NUnit.Framework;

namespace TwitchWrapper.Tests
{
    [TestFixture]
    class UserClientTests
    {
        private User _user;

        [SetUp]
        public void GivenACallToTheUserEndpoint()
        {
            var client = new UserClient(new TwitchClient());
            _user = client.GetUser("test_user1");
        }

        [Test]
        public void ThenTheCorrectIdShouldBeReturned()
        {
            Assert.That(_user.Id, Is.EqualTo(22747064));
        }

        [Test]
        public void ThenTheCorrectNameShouldBeReturned()
        {
            Assert.That(_user.Name, Is.EqualTo("test_user1"));
        }

        [Test]
        public void ThenTheCorrectDisplayNameShouldBeReturned()
        {
            Assert.That(_user.DisplayName, Is.EqualTo("Test_user1"));
        }
        
        [Test]
        public void ThenTheCorrectUserTypeShouldBeReturned()
        {
            Assert.That(_user.Type, Is.EqualTo("user"));
        }

        [Test]
        public void ThenIfNoBioIsSetThenBioShouldBeNull()
        {
            Assert.That(_user.Bio, Is.Null);
        }

        [Test]
        public void ThenTheDateCreatedAtDateIsReturnedAsTheCorrectDateTime()
        {
            Assert.That(_user.CreatedAt, Is.EqualTo(new DateTime(2011, 6, 2, 20, 4, 3)));
        }

        [Test]
        public void ThenTheDateUpdatedAtDateIsReturnedAsTheCorrectDateTime()
        {
            Assert.That(_user.UpdatedAt, Is.EqualTo(new DateTime(2015, 9, 16, 1, 15, 11)));
        }

        [Test]
        public void ThenTheLogoUrlIsReturned()
        {
            Assert.That(_user.Logo, Is.EqualTo("http://static-cdn.jtvnw.net/jtv_user_pictures/test_user1-profile_image-ac0a2f0d39dda770-300x300.jpeg"));
        }
    }
}
