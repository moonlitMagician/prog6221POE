using System;
using Classwork;

class Program
{

    static void Main()
    {
        Greeting();
        while (true)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(AsciiArt.CyberSecLogo());
            Console.WriteLine("\n");
            Interaction();
        }
    }

    static string _name = "";

    static readonly Dictionary<string, Action> _commands = new()
{
    { "password security", () => AsciiArt.TypeEffect(Texts.passwordSec) },
    { "phishing", () => AsciiArt.TypeEffect(Texts.phishingSec) },
    { "safe browsing", () => AsciiArt.TypeEffect(Texts.safeBrowseSec) }
};

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

        AsciiArt.TypeEffect(Texts.introductionMessage);
        AsciiArt.TypeEffect(Texts.introductionMessage);

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
    string userInput = (Console.ReadLine() ?? "").ToLower();

    foreach (var command in _commands)
    {
        if (userInput.Contains(command.Key))
        {
            command.Value.Invoke();
            return;
        }
    }

    if (userInput.Contains("help"))
    {
        AsciiArt.TypeEffect(Texts.helpText);
    }
    else if (userInput.Contains("how are you"))
    {
        AsciiArt.DrawEmptyBox(Texts.GetRandomFeeling());
        AsciiArt.TypeEffectInBox($"{Texts.GetRandomFeeling()}, Thanks for asking {_name}!");
    }
    else
    {
        AsciiArt.TypeEffect(Texts.GetRandomConfused());
    }
}
}