using BagheeraBot.commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BagheeraBot
{
    internal class Program
    {
        private static DiscordClient client { get; set; }
        private static CommandsNextExtension commands {  get; set; }
        public static async Task Main(string[] args)
        {
            var jsonReader = new JsonReader();
            await jsonReader.ReadJson();

            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                AlwaysCacheMembers = true,
            };
            //new instance of discord client with our configuration in it//
            client = new DiscordClient(discordConfig);

            //Setup the client ready event which occurs when the bot has succesfully connected and operational and wwill reset eveytime a task is complete
            client.Ready += Client_Ready;

            #region
            var commandConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { jsonReader.prefix },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = true
            };

            commands = client.UseCommandsNext(commandConfig);

            commands.RegisterCommands<TestCommands>();
            commands.RegisterCommands<Maths>();
            #endregion
            await client.ConnectAsync();
            await Task.Delay(-1); //This keeps the bot running infinitely as long as program is running
        }
        
        private static Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The Bot is connected and running \n");
            return Task.CompletedTask;
        }
    }
}
