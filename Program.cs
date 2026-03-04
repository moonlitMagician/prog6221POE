using System;
using System.Text;
using Classwork;

class Program
{

    static void Main()
    {
        Greeting();
        while (true)
        {
            Thread.Sleep(1000);
            initScreen();
            Console.WriteLine(AsciiArt.idleBot());
            Console.WriteLine($"{Texts.GetRandomHelp()}, {_name}?");
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
        AudioNamespace.Audio.PlayGreeting();
        Console.WriteLine(AsciiArt.CyberSecLogo());
        Console.WriteLine(AsciiArt.idleBot());

        AsciiArt.DrawEmptyBox(Texts.WelcomeMessage);
        AsciiArt.TypeEffectInBox(Texts.WelcomeMessage);

        AsciiArt.DrawEmptyBox(Texts.introductionMessage);
        AsciiArt.TypeEffectInBox(Texts.introductionMessage);

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

    }

    static void Interaction()
{
    string userInput = (Console.ReadLine() ?? "").ToLower();

    foreach (var command in _commands)
    {
        if (userInput.Contains(command.Key))
        {
            Thinking();
            Console.WriteLine(AsciiArt.answerBot());
            command.Value.Invoke();
            return;
        }
    }

    if (userInput.Contains("help"))
    {
        Thinking();
        Console.WriteLine(AsciiArt.answerBot());
        AsciiArt.TypeEffect(Texts.helpText);
    }
    else if (userInput.Contains("how are you"))
    {
        Thinking();
        Console.WriteLine(AsciiArt.answerBot());
        AsciiArt.DrawEmptyBox(Texts.GetRandomFeeling());
        AsciiArt.TypeEffectInBox($"{Texts.GetRandomFeeling()}, Thanks for asking {_name}!");
    }
    else if (userInput.Contains("what") && userInput.Contains("purpose"))
        {
            Thinking();
            Console.WriteLine(AsciiArt.answerBot());
            AsciiArt.DrawEmptyBox(Texts.purposeText);
            AsciiArt.TypeEffectInBox(Texts.purposeText);
        }
    else
    {
        Console.WriteLine(AsciiArt.answerBot());
        AsciiArt.TypeEffect(Texts.GetRandomConfused());
    }
}

static void Thinking()
    {
        Console.Clear();
        Console.WriteLine(AsciiArt.thinkingBot());
        Console.WriteLine("\n");
        Console.Write("Thinking");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Console.WriteLine("");
        Thread.Sleep(1000);
        initScreen();
    }

static void initScreen()
    {
        Console.Clear();
            Console.WriteLine(AsciiArt.CyberSecLogo());
            AsciiArt.DrawEmptyBox(Texts.WelcomeMessage);
            AsciiArt.PrintInBox(Texts.WelcomeMessage);
            AsciiArt.DrawEmptyBox(Texts.introductionMessage);
            AsciiArt.PrintInBox(Texts.introductionMessage);
            Console.WriteLine("\n");
    }
}