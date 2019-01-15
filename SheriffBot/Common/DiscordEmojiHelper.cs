using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using SheriffBot.Models;

namespace SheriffBot.Helpers
{
    public static class DiscordEmojiHelper
    {
        public static DiscordEmoji GetRandomEmoji(IEnumerable<DiscordEmoji> discordEmojis)
        {
            var rng = new Random(Guid.NewGuid().GetHashCode()).Next(0, discordEmojis.Count());

            return discordEmojis.ElementAt(rng);
        }

        public static IEnumerable<DiscordEmoji> GetAllAvailableEmojis()
        {
            JArray emojis = JArray.Parse(File.ReadAllText(@"../../../../emoji.json"));

            //Get JSON result objects into a list
            IList<JToken> allDiscordEmojis = emojis.Children().ToList();

            //Serialize JSON results into DiscordEmojis
            IList<DiscordEmoji> discordEmojis = new List<DiscordEmoji>();
            foreach (JToken emoji in allDiscordEmojis)
            {
                DiscordEmoji discordEmoji = emoji.ToObject<DiscordEmoji>();
                discordEmojis.Add(discordEmoji);
            }

            return discordEmojis;
        }
    }
}
