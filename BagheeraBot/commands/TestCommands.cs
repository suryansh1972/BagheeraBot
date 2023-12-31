using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagheeraBot.commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command ("intro")]
        public async Task MyFirstCommand (CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Hello {ctx.User.Username} \n this is Bagheera rawwwr :) ");
        }
    }
}
