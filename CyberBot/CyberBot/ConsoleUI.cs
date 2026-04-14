using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot
{
    internal class ConsoleUI
    {

        public static void DrawHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========================================");
            Console.WriteLine($"   {title}");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }


        public static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }


        public static void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }


        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();
        }


        public static string GetInput(string prompt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(prompt);
            Console.ResetColor();
            return Console.ReadLine();
        }

       
        public static void TypeEffect(string text, int speed = 25)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

    
        public static void Clear()
        {
            Console.Clear();
        }

 
        public static void SetTitle(string title)
        {
            Console.Title = title;
        }

        public static void DrawBox(string message, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;

            string border = new string('─', message.Length + 4);

            Console.WriteLine($"┌{border}┐");
            Console.WriteLine($"│  {message}  │");
            Console.WriteLine($"└{border}┘");

            Console.ResetColor();
        }
    }
}
    

