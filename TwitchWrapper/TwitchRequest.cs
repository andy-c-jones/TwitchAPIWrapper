namespace TwitchWrapper
{
    public class TwitchRequest
    {
        public string Resource { get; set; }

        public TwitchRequest(string resource)
        {
            Resource = resource;
        }
    }
}