using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CyberBot
{
    internal class BotUI
    {
        public static void Run()
        {
            ConsoleUI.SetTitle("CyberBot - Security Assistant");
            PlayGreeting();
            
            ConsoleUI.DrawHeader("CyberSecurity Awareness");
            Console.WriteLine("Stay safe online! \n",  ConsoleColor.Yellow);

            //Console.WriteLine("Enter your Name:", ConsoleColor.Cyan);
            string Name = ConsoleUI.GetInput("Enter your name: ", ConsoleColor.Cyan); 

            if (string.IsNullOrWhiteSpace(Name))
                Name = "User";

            ConsoleUI.Clear();

            CbBot bot = new CbBot(Name);

            ConsoleUI.DrawHeader($"WELCOME, {Name.ToUpper()}"); 
            Console.WriteLine("Welcome to Cybersecurity Awareness!");
            ConsoleUI.WriteLine("1 → Start Chat", ConsoleColor.Green); 
            ConsoleUI.WriteLine("0 → Exit\n", ConsoleColor.Red); 



            while (true)
            {
                //Console.Write("Choice: ");
                string choice = ConsoleUI.GetInput("Choice: ", ConsoleColor.Cyan);
                //string choice = Console.ReadLine()?.ToLower();

                if (choice == "1")
                {
                    ConsoleUI.Clear();

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
                            ConsoleUI.Clear();
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
