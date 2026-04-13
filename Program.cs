using System;
namespace ProgAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            UIHelper.ShowHeader();

            AudioPlayer.PlayGreeting();

            Chatbot bot = new Chatbot();
            bot.Start();

            Console.ReadLine();
        }
    }
}
