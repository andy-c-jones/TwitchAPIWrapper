using NUnit.Framework;

namespace TwitchWrapper.Tests
{
    [TestFixture]
    class UserClientTests
    {
        [Test]
        public void GetUserShouldReturnAUserWithAName()
        {
            var client = new UserClient(new TwitchClient());

            var user = client.GetUser("test_user1");

            Assert.That(user.Display_name, Is.EqualTo("Test_user1"));
        }
    }
}
