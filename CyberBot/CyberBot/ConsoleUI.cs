using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot
{
    internal class ConsoleUI
    {
        // ================= HEADER =================
        public static void DrawHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========================================");
            Console.WriteLine($"   {title}");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        // ================= WRITE (NO NEW LINE) =================
        public static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        // ================= WRITELINE =================
        public static void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        // ================= DIVIDER =================
        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();
        }

        // ================= INPUT PROMPT =================
        public static string GetInput(string prompt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(prompt);
            Console.ResetColor();
            return Console.ReadLine();
        }

        // ================= TYPE EFFECT =================
        public static void TypeEffect(string text, int speed = 25)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        // ================= CLEAR SCREEN =================
        public static void Clear()
        {
            Console.Clear();
        }

        // ================= TITLE =================
        public static void SetTitle(string title)
        {
            Console.Title = title;
        }
    }
}
    

