using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CyberBot
{
    internal class BotUI
    {
        public static void Run()
        {
            PlayGreeting();
            Console.Title = "CyberBot - Security Assistant";
            Console.WriteLine("CyberSecurity Awareness");
            Console.WriteLine("Stay safe online!");

            Console.WriteLine("Enter your Name:");
            string Name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Name))
                Name = "User";

            Console.Clear();

            CbBot bot = new CbBot(Name);

            Console.WriteLine("Hey" +" "+ Name);
            Console.WriteLine("Welcome to Cybersecurity Awareness!");
            Console.WriteLine("Enter 1 to continue");
            Console.WriteLine("Enter 0 or Exit to Quit");


            while (true)
            {
                Console.Write("Choice: ");
                string choice = Console.ReadLine()?.ToLower();

                if (choice == "1")
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine("Ask a question:");
                        Console.Write(Name + " : ");
                        string input = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Please write something");
                            continue;
                        }

                        bot.Respond(input, Name);


                        Console.WriteLine("\nEnter 1 to ask another question");
                        Console.WriteLine("Enter 0 to go back to menu");
                        Console.WriteLine("Enter Exit to quit");

                        string next = Console.ReadLine()?.ToLower();

                        if (next == "1")
                        {
                            continue;
                        }
                        else if (next == "0")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (next == "exit")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option, returning to menu...");
                            break;
                        }
                    }
                }
                else if (choice == "0" || choice == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Enter (1) or (0/Exit).");
                }
            }

        }
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Student\Desktop\CyberBot\CyberBot\welcome.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Could not play audio.");
            }
        }
    }
}
