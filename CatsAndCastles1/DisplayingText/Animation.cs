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
        PrintSegment(TextGeneral.AnimationIntro1,ConsoleColor.Blue);
        PrintSegment(TextGeneral.AnimationIntro2, ConsoleColor.DarkCyan);
        PrintSegment(TextGeneral.AnimationIntro3,ConsoleColor.Cyan, 150);
        PrintSegment(TextGeneral.AnimationIntro4, ConsoleColor.DarkCyan, 150);
        PrintSegment(TextGeneral.AnimationIntro5, ConsoleColor.Blue);
        PrintSegment(TextGeneral.AnimationIntro6, ConsoleColor.DarkBlue,150);
        PrintSegment(TextGeneral.AnimationIntro7, ConsoleColor.Blue);
        PrintSegment(TextGeneral.AnimationIntro8, ConsoleColor.DarkCyan);
        PrintSegment(TextGeneral.AnimationIntro9,ConsoleColor.Cyan);
        PrintSegment(TextGeneral.AnimationIntro10, ConsoleColor.DarkCyan, 150);
        PrintSegment(TextGeneral.AnimationIntro11, ConsoleColor.Blue, 170);
        PrintSegment(TextGeneral.AnimationIntro12, ConsoleColor.DarkBlue, 120);
        PrintSegment(TextGeneral.AnimationIntro13, ConsoleColor.Blue, 150);
        PrintSegment(TextGeneral.AnimationIntro14, ConsoleColor.DarkCyan, 200);
        PrintSegment(TextGeneral.AnimationIntro10, ConsoleColor.DarkBlue, 200);
    }

    

    public static void PrintSegment(string text, ConsoleColor color, int sleepTime=100)
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