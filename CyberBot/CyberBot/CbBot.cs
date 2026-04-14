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


        public void Respond(string input, string name)
        {
            input = input.ToLower().Trim();

            if (input.Contains("how are you") || input.Contains("how are u") || input.Contains("are you okay"))
            {
                ConsoleUI.TypeEffect(
                    $" I'm doing great, {name}! Thanks for asking.\n" +
                    "I'm here to help you learn about staying safe online.\n\n" +
                    " You can ask me things like:\n" +
                    "- What is phishing?\n" +
                    "- What is a strong password?\n" +
                    "- How do I browse safely?"
                );
            }

            if (input.Contains("phishing"))
            {
                ConsoleUI.TypeEffect(
                    " What is Phishing?\n" +
                    "Phishing is a type of cyber attack where attackers try to trick you into giving personal information like passwords or bank details.\n\n" +

                    " How it works:\n" +
                    "Attackers pretend to be trusted companies (like banks or email providers) and send fake messages.\n\n" +

                    " Example:\n" +
                    "You receive an email saying 'Your account has been locked. Click here to reset your password', but the link is fake.\n\n" +

                    " How to stay safe:\n" +
                    "- Never click suspicious links\n" +
                    "- Check the sender's email\n" +
                    "- Do not share personal information"
                );
            }
            if (input.Contains("password"))
            {
                ConsoleUI.TypeEffect(
                    " What is a Strong Password?\n" +
                    "A strong password is one that is difficult for others to guess or crack.\n\n" +

                    " Why it matters:\n" +
                    "Weak passwords can be easily hacked, giving attackers access to your accounts.\n\n" +

                    " Example:\n" +
                    "'123456' is weak, but 'T!g3r#2026$' is strong.\n\n" +

                    " Tips:\n" +
                    "- Use 8–12+ characters\n" +
                    "- Mix letters, numbers, and symbols\n" +
                    "- Avoid personal info like names or birthdays"
                );
            }
            if (input.Contains("safe browsing") || input.Contains("browse"))
            {
                ConsoleUI.TypeEffect(
                    " What is Safe Browsing?\n" +
                    "Safe browsing means using the internet in a way that protects you from threats like viruses, scams, and hackers.\n\n" +

                    " How risks happen:\n" +
                    "Malicious websites can trick you into downloading harmful files or stealing your data.\n\n" +

                    " Example:\n" +
                    "Clicking a pop-up that says 'Download now to fix your PC' may install malware.\n\n" +

                    "How to stay safe:\n" +
                    "- Only visit trusted websites\n" +
                    "- Check for HTTPS 🔒\n" +
                    "- Avoid unknown downloads"
                );
            }
            if (input.Contains("malware") || input.Contains("virus"))
            {
                ConsoleUI.TypeEffect(
                    " What is Malware?\n" +
                    "Malware is harmful software designed to damage or gain unauthorized access to your device.\n\n" +

                    " How it spreads:\n" +
                    "Through downloads, email attachments, or infected websites.\n\n" +

                    " Example:\n" +
                    "Downloading a cracked game may install spyware without you knowing.\n\n" +

                    " How to stay safe:\n" +
                    "- Install antivirus software\n" +
                    "- Avoid pirated content\n" +
                    "- Don't open unknown attachments"
                );
            }

            if (input.Contains("links") || input.Contains("url"))
            {
                ConsoleUI.TypeEffect(
                    " What is a Suspicious Link?\n" +
                    "A suspicious link is a URL that may lead to a harmful or fake website.\n\n" +

                    " Why it's dangerous:\n" +
                    "Clicking it can steal your data or install malware.\n\n" +

                    " Example:\n" +
                    "'www.paypaI.com' (with a capital i instead of L) is fake.\n\n" +

                    " How to stay safe:\n" +
                    "- Check spelling carefully\n" +
                    "- Hover before clicking\n" +
                    "- Avoid shortened links"
                );
            }
            if (input.Contains("privacy") || input.Contains("personal information"))
            {
                ConsoleUI.TypeEffect(
                    " What is Online Privacy?\n" +
                    "Online privacy means protecting your personal information on the internet.\n\n" +

                    " Why it matters:\n" +
                    "Sharing too much can lead to identity theft or scams.\n\n" +

                    " Example:\n" +
                    "Posting your ID number or location publicly can be risky.\n\n" +

                    " How to stay safe:\n" +
                    "- Limit what you share online\n" +
                    "- Use privacy settings\n" +
                    "- Avoid public Wi-Fi for sensitive info"
                );
            }
            if (input.Contains("help"))
            {
                ConsoleUI.TypeEffect(
                    " Ask me questions like:\n\n" +
                    "- What is phishing?\n" +
                    "- What is a strong password?\n" +
                    "- What is malware?\n" +
                    "- How do I browse safely?\n" +
                    "- How do I know if a link is safe?\n\n" +
                    " Try asking full questions for better answers!"
                );
            }
            if 
            {
                ConsoleUI.TypeEffect(
                    "I didn't understand that.\n" +
                    "Try asking something like 'What is phishing?' or type 'help'."
                );
            }
        }
    }
}

    

