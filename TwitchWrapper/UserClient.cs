namespace TwitchWrapper
{
    public class UserClient
    {
        private readonly TwitchClient _client;
        private const string UserResource = "users/{0}";

        public UserClient(TwitchClient client)
        {
            _client = client;
        }

        public User GetUser(string username)
        {
            var resource = string.Format(UserResource, username);
            var request = new TwitchRequest(resource);
            return _client.ExecuteRequest<User>(request);
        }
    }
}