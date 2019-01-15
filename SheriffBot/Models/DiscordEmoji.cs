using Newtonsoft.Json;

namespace SheriffBot.Models
{
    public class DiscordEmoji
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }
    }
}
