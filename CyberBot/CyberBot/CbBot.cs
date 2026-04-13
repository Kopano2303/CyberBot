using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot
{
    internal class CbBot
    {
        public string Name;
        public CbBot(string name)
        {
            Name = name;
        }
        public void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
   ____  __   __   ____  U _____ u   ____     ____   U _____ u   ____    _   _    ____                 _____   __   __        _                      _       ____     _   _   U _____ u ____    ____     
U /""___| \ \ / /U | __"")u\| ___""|/U |  _""\ u / __""| u\| ___""|/U /""___|U |""|u| |U |  _""\ u     ___     |_ "" _|  \ \ / /    U  /""\  u __        __ U  /""\  uU |  _""\ u | \ |""|  \| ___""|// __""| u/ __""| u  
\| | u    \ V /  \|  _ \/ |  _|""   \| |_) |/<\___ \/  |  _|""  \| | u   \| |\| | \| |_) |/    |_""_|      | |     \ V /      \/ _ \/  \""\      /""/  \/ _ \/  \| |_) |/<|  \| |>  |  _|"" <\___ \/<\___ \/   
 | |/__  U_|""|_u  | |_) | | |___    |  _ <   u___) |  | |___   | |/__   | |_| |  |  _ <       | |      /| |\   U_|""|_u     / ___ \  /\ \ /\ / /\  / ___ \   |  _ <  U| |\  |u  | |___  u___) | u___) |   
  \____|   |_|    |____/  |_____|   |_| \_\  |____/>> |_____|   \____| <<\___/   |_| \_\    U/| |\u   u |_|U     |_|      /_/   \_\U  \ V  V /  U/_/   \_\  |_| \_\  |_| \_|   |_____| |____/>>|____/>>  
 _// \\.-,//|(_  _|| \\_  <<   >>   //   \\_  )(  (__)<<   >>  _// \\ (__) )(    //   \\_.-,_|___|_,-._// \\_.-,//|(_      \\    >>.-,_\ /\ /_,-. \\    >>  //   \\_ ||   \\,-.<<   >>  )(  (__))(  (__) 
(__)(__)\_) (__)(__) (__)(__) (__) (__)  (__)(__)    (__) (__)(__)(__)    (__)  (__)  (__)\_)-' '-(_/(__) (__)\_) (__)    (__)  (__)\_)-'  '-(_/ (__)  (__)(__)  (__)(_"")  (_/(__) (__)(__)    (__)      
  ");

            Console.ResetColor();
        }


        public void Respond(String input, String name)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("Im Good thanks for asking" +" "+ name);
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to help you stay safe online.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask about passwords, phishing, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with letters, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Be careful of suspicious emails or links asking for personal info.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Always check website URLs and avoid unknown downloads.");
            }
            else
            {
                Console.WriteLine("I don't understand that yet. Try asking about cybersecurity topics.");
            }
        }
    }
}

    

