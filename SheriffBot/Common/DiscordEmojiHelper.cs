using SheriffBot.Models;

namespace SheriffBot.Helpers
{
    public static class DiscordEmojiHelper
    {
        public static DiscordEmoji GetEmoji()
        {
            return new DiscordEmoji
            {
                Name = "Cowboy",
                ShortName = "cowboy"
            };
        }
    }
}
