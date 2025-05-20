using CatsAndCastles1.Text;

namespace CatsAndCastles1.DisplayingText;

public static class Animation
{
    public static void PrintWelcome()
    {
        var height = Console.WindowHeight/2;
        var x = Console.CursorLeft;
        
        Console.SetCursorPosition(x, height -6);
        Screen.Print(TextGeneral.WelcomeTo, -20, ConsoleColor.White);
        Thread.Sleep(300);
        
        Console.SetCursorPosition(x, height - 4);
        Screen.Print(TextGeneral.Welcome1, 0, ConsoleColor.White);
        Screen.Print(TextGeneral.Welcome2, 0, ConsoleColor.White);
        Screen.Print(TextGeneral.Welcome3, 0, ConsoleColor.White);
        Screen.Print(TextGeneral.Welcome4, 0, ConsoleColor.White);
        Screen.Print(TextGeneral.Welcome5, 0, ConsoleColor.White);
        Thread.Sleep(300);
        
        Console.SetCursorPosition(x, height +3);
        Screen.Print(TextGeneral.ByMe, +20, ConsoleColor.White);
    }

    public static void CatIntroAnimation()
    {
        PrintSegment("=^.^=",ConsoleColor.Blue);
        PrintSegment("-   =^.^=   -", ConsoleColor.DarkCyan);
        PrintSegment("*   -   =^.^=   -   *",ConsoleColor.Cyan, 150);
        PrintSegment("-   *   -   =^.^=   -   *   -", ConsoleColor.DarkCyan, 150);
        PrintSegment("-   -   *   -   =^.^=   -   *   -   -", ConsoleColor.Blue);
        PrintSegment("*   -   -   *   -   =^.^=   -   *   -   -   *", ConsoleColor.DarkBlue,150);
        PrintSegment("-   *   -   -   *   -   =^.^=   -   *   -   -   *   -", ConsoleColor.Blue);
        PrintSegment("-   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -", ConsoleColor.DarkCyan);
        PrintSegment("-   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   -",ConsoleColor.Cyan);
        PrintSegment("*   -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   -   *", ConsoleColor.DarkCyan, 150);
        PrintSegment("`  *   -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   -   *  .", ConsoleColor.Blue, 170);
        PrintSegment("` `* . -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   - .`*  `", ConsoleColor.DarkBlue, 120);
        PrintSegment(" .`* . -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   - .`* . ", ConsoleColor.Blue, 150);
        PrintSegment("  `*   -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   - . *   ", ConsoleColor.DarkCyan, 200);
        PrintSegment("*   -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   -   *", ConsoleColor.DarkBlue, 200);
    }

    public static void ContinueAnimation()
    {
        while (true)
        {
            Screen.Print(TextGeneral.PressEnter);
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
            }

            PrintSegment("`  *   -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   -   *  .",
                ConsoleColor.Blue, 170);
            PrintSegment("` `* . -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   - .`*  `",
                ConsoleColor.DarkBlue, 120);
            PrintSegment(" .`* . -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   - .`* . ",
                ConsoleColor.Blue, 150);
            PrintSegment("  `*   -   -   -   *   -   -   *   -   =^.^=   -   *   -   -   *   -   -   - . *   ",
                ConsoleColor.DarkCyan, 200);
        }
    }

    private static void PrintSegment(string text, ConsoleColor color, int sleepTime=100)
    {
        var height = Console.WindowHeight;
        var top = height / 4 -1;
        var bottom = (height / 4)*3-2;
        var x = Console.CursorLeft;
        Console.SetCursorPosition(x, top);
        Screen.Print(text, 0, color);
        Console.SetCursorPosition(x, bottom);
        Screen.Print(text, 0, color);
        Thread.Sleep(sleepTime);
    }
    
}