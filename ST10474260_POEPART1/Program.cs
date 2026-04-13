using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        AudioPlayer player = new AudioPlayer();
        player.PlayGreeting();

        ChatBot bot = new ChatBot();
        User user = new User();

        bot.ShowAsciiArt();

        Console.WriteLine("\nWelcome to the Cybersecurity Awareness Bot!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        user.Name = name;

        Console.WriteLine($"\nHello, {user.Name}! Ask me anything about online safety (type 'exit' to quit).\n");

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a valid question.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye! Stay safe online.");
                break;
            }

            string response = bot.GetResponse(input);
            Console.WriteLine(response);
        }
    }
}


