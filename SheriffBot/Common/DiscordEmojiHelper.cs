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
        public static DiscordEmoji GetRandomEmoji()
        {
            var discordEmojis = GetAllAvailableEmojis();
            Random rand = new Random();
            var rng = rand.Next(0, discordEmojis.Count());

            return discordEmojis.ElementAt(rng);
        }

        //TODO: Put this in its own class
        //TODO: Make this work
        public static IEnumerable<DiscordEmoji> GetAllAvailableEmojis()
        {
            JObject emojis = JObject.Parse(File.ReadAllText(@"../../../emoji.json"));

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
