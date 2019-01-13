using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using SheriffBot.Helpers;

namespace SheriffBot
{
    public class Program
    {
        private static DiscordSocketClient _client = new DiscordSocketClient();

        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client.Log += Log;

            var token = "NTMzNjQwNDcxOTYwODc5MTE3.DxuCrg.4_px2sh1-_PALKdj-63jRmPUpwc";  //TODO: Store this in an external file
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

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
                await message.Channel.SendMessageAsync($":{DiscordEmojiHelper.GetEmoji().ShortName}:");
            }
        }
    }
}
