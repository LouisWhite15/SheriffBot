using Newtonsoft.Json;

namespace SheriffBot.Models
{
    public class DiscordEmoji
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("char")]
        public string Emoji { get; set; }
    }
}
