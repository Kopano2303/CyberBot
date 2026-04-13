using Bot;
using CyberBot;
using System;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            CbBot bot = new CbBot("User");
            bot.ShowHeader();
            BotUI.Run();
        }
    }
}
