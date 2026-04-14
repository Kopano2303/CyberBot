
using System;

namespace CyberBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.SetTitle("CyberBot - Security Assistant");

            CbBot bot = new CbBot("User");
            bot.ShowHeader();
            BotUI.Run();
        }
    }
}
