using System;

class AsciiArt
{
    public static String CyberSecLogo()
    {
        String logo = @"
        
_________        ___.                    _________                          .__  __          
\_   ___ \___.__.\_ |__   ___________   /   _____/ ____   ____  __ _________|__|/  |_ ___.__.
/    \  \<   |  | | __ \_/ __ \_  __ \  \_____  \_/ __ \_/ ___\|  |  \_  __ \  \   __<   |  |
\     \___\___  | | \_\ \  ___/|  | \/  /        \  ___/\  \___|  |  /|  | \/  ||  |  \___  |
 \______  / ____| |___  /\___  >__|    /_______  /\___  >\___  >____/ |__|  |__||__|  / ____|
        \/\/          \/     \/                \/     \/     \/                       \/     ";


        return logo;
    }

    public static String idleBot()
    {
        String logo = @"     
       __
   _  |@@|
  / \ \--/ __
  ) O|----|  |   __
 / / \ }{ /\ )_ / _\
 )/  /\__/\ \__O (__
|/  (--/\--)    \__/
/   _)(  )(_
   `---''---`
";

        return logo;
    }

    public static String thinkingBot()
    {
        String logo = @"
        
   __,_,
  [_|_/ 
   //
 _//    __
(_|)   |@@|
 \ \__ \--/ __
  \o__|----|  |   __
      \ }{ /\ )_ / _\
      /\__/\ \__O (__
     (--/\--)    \__/
     _)(  )(_
    `---''---`


        ";

        return logo;
    }

    public static String answerBot()
    {
        String logo = @"
         __
 _(\    |@@|
(__/\__ \--/ __
   \___|----|  |   __
       \ }{ /\ )_ / _\
       /\__/\ \__O (__
      (--/\--)    \__/
      _)(  )(_
     `---''---`

        ";

        return logo;
    }

    public static void DrawEmptyBox(string text)
    {
        string horizontal = new string('═', text.Length + 2);
        
        // Print the frame structure
        Console.WriteLine("╒" + horizontal + "╕");
        Console.WriteLine("│" + new string(' ', text.Length + 2) + "│"); // Empty middle line
        Console.WriteLine("╘" + horizontal + "╛");
    }

    public static void TypeEffect(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(40);
        }
        Console.WriteLine();
    }
    public static void TypeEffectInBox(String inp)
    {
        // 1. Move the cursor up 2 lines (to get inside the box)
        // 2. Move the cursor right 2 spaces (to skip '│ ')
        Console.SetCursorPosition(2, Console.CursorTop - 2);

        foreach (char c in inp)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(40);
        }
        
        // Move the cursor back to the bottom so the program doesn't 
        // start typing next lines inside our box
        Console.SetCursorPosition(0, Console.CursorTop + 2);
    }

    public static void PrintInBox(String inp)
    {
        Console.SetCursorPosition(2, Console.CursorTop - 2);
        Console.Write(inp);
        Console.SetCursorPosition(0, Console.CursorTop + 2);
    }
}