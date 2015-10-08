using System;
using System.Collections.Generic;

namespace TwitchWrapper
{
    public class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Bio { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Logo { get; set; }
        public Dictionary<string,string> Links { get; set; }
    }
}