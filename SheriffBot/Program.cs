using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Newtonsoft.Json.Linq;
using SheriffBot.Helpers;
using SheriffBot.Models;

namespace SheriffBot
{
    public class Program
    {
        private static DiscordSocketClient _client;
        private DiscordEmoji _emoji;
        private IEnumerable<DiscordEmoji> _discordEmojis;

        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;

            var token = JObject.Parse(File.ReadAllText(@"../../../../config.json"))["token"].ToString();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            _discordEmojis = DiscordEmojiHelper.GetAllAvailableEmojis();

            SetRandomEmoji();

            _client.MessageReceived += MessageRecieved;

            // Block this task until the program is closed
            await Task.Delay(-1);
        }

        private Task Log(LogMessage message)
        {
            Console.WriteLine(message.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageRecieved(SocketMessage message)
        {
            if (message.Content == "!pingSheriff")
            {
                await message.Channel.SendMessageAsync($"My ping is: {_client.Latency}ms :ping_pong:");
            }

            if (message.Content == "!sheriff")
            {
                await message.Channel.SendMessageAsync(Constants.SheriffString(_emoji.Emoji, $"howdy. im the sheriff of {_emoji.Name}"));
                SetRandomEmoji();
            }

            if (message.Content == "!daddy")
            {
                await message.Channel.SendMessageAsync(Constants.Daddy);
            }
        }

        private void SetRandomEmoji()
        {
            _emoji = DiscordEmojiHelper.GetRandomEmoji(_discordEmojis);
        }
    }
}
