using System;
using Classwork;

class Program
{

    static void Main()
    {
        Greeting();
        while (0 == 0)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(AsciiArt.CyberSecLogo());
            Console.WriteLine("\n");
            Interaction();
        }
    }

    static string _name = "";

    static string GetName()
    {
        return _name;
    }

    static void Greeting()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(AsciiArt.CyberSecLogo());

        AsciiArt.DrawEmptyBox(Texts.WelcomeMessage);
        AsciiArt.TypeEffectInBox(Texts.WelcomeMessage);

        AsciiArt.TypeEffect("\nCan I Get your name?");
        _name = Console.ReadLine() ?? "Guest";

        if (!string.IsNullOrEmpty(_name))
        {
            AsciiArt.TypeEffect($"\nLovely to meet you, {_name}!");
        }
        else
        {
            AsciiArt.TypeEffect("\nMysterious? I like that. I will refer to you as Guest from now on!");
        }

        AsciiArt.TypeEffect($"\nWhat can i help you with today {_name}?");

    }

    static void Interaction()
    {

        string userInput = Console.ReadLine() ?? "";
        userInput.ToLower();

        if (userInput.Contains("password") && userInput.Contains("security"))
        {
            AsciiArt.TypeEffect(Texts.passwordSec);
        }
        else if (userInput.Contains("phishing"))
        {
            AsciiArt.TypeEffect(Texts.phishingSec);
        } 
        else if (userInput.Contains("safe") && userInput.Contains("browsing"))
        {
             AsciiArt.TypeEffect(Texts.safeBrowseSec);
        }
        else if (userInput.Contains("help") && !userInput.Contains("browsing") && !userInput.Contains("safe") && !userInput.Contains("phishing") && !userInput.Contains("security") && !userInput.Contains("password"))
        {
            AsciiArt.TypeEffect(Texts.helpText);
        }
        else if (userInput.Contains("how") && userInput.Contains("are") && userInput.Contains("you"))
        {
            AsciiArt.TypeEffect(Texts.GetRandomFeeling());
        }
        else
        {
            AsciiArt.TypeEffect(Texts.GetRandomConfused());
        }
    }
}