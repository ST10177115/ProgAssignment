using System;
using System.Media;
using System.Collections.Generic;
using System.Text;

namespace ProgAssignment
{
    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            AskName();
            ChatLoop();
        }

        private void AskName()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Try again: ");
                userName = Console.ReadLine();
            }

            UIHelper.TypingEffect($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot.");
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                    continue;
                }

                if (input.Contains("exit"))
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online!");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I'm just code, but I'm here to help you!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to help you stay safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong passwords with letters, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Be careful of suspicious emails asking for personal info.");
            }
            else if (input.Contains("browsing"))
            {
                Console.WriteLine("Bot: Always check if a website uses HTTPS before entering data.");
            }
            else
            {
                Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
            }

            Console.ResetColor();
        }
    }
}

