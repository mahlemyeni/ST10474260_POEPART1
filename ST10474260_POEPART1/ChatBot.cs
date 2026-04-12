using System;

public class ChatBot
{
    public void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
**********************************************
* ______     __                            *
* / ____/_  _/ /_  ___  ________  __        *
* / /   / / / / __ \/ _ \/ ___/ / / /        *
* / /___/ /_/ / /_/ /  __/ /  / /_/ /         *
* \____/\__, /_.___/\___/_/   \__, /          *
*       /____/                /____/           *
*         AWARENESS BOT                     *
**********************************************");
        Console.ResetColor();
    }

    public string GetResponse(string input)
    {
        input = input.ToLower();

        if (input.Contains("how are you"))
            return "I'm just code, but I'm here to help you stay safe online!";

        else if (input.Contains("purpose"))
            return "My purpose is to teach you about cybersecurity and safe browsing.";

        else if (input.Contains("password"))
            return "Use strong passwords with a mix of letters, numbers, and symbols. Never reuse passwords.";

        else if (input.Contains("phishing"))
            return "Be cautious of emails asking for personal info. Always verify the sender.";

        else if (input.Contains("safe browsing"))
            return "Always check URLs, avoid suspicious links, and keep your browser updated.";

        else
            return "I didn't quite understand that. Could you rephrase?";
    }
}