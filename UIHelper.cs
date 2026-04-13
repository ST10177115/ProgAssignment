using System;
using System.Media;
using System.Collections.Generic;
using System.Text;

namespace ProgAssignment
{
    public static class UIHelper
    {
        public static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("========================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
   [🔒]   Stay Safe Online   [🔒]

      ___
     /       \
    |  SAFE  |
    |  NET   |
     \___/
        | |
        | |
    ");

            Console.ResetColor();
        }

        public static void TypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}

