using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagheeraBot.commands
{
    public class Maths :BaseCommandModule
    {
        [Command("add")]
        public async Task Add (CommandContext ctx, int num1, int num2)
        {
            int result = num1 + num2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }

        [Command("sub")]
        public async Task Sub (CommandContext ctx, int num1, int num2)
        {
            int result = num1 - num2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }

        [Command("mul")]
        public async Task Mul (CommandContext ctx, int num1, int num2)
        {
            int result = num1 * num2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }

        [Command("div")]
        public async Task Del (CommandContext ctx, double num1, double num2)
        {
            double result = num1 / num2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }
    }
}
