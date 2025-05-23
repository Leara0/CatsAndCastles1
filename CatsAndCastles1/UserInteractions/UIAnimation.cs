using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text;

namespace CatsAndCastles1.UserInteractions;

public class UIAnimation
{
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

            Animation.PrintSegment(TextGeneral.AnimationIntro11,
                ConsoleColor.Blue, 170);
            Animation.PrintSegment(TextGeneral.AnimationIntro12,
                ConsoleColor.DarkBlue, 120);
            Animation.PrintSegment(TextGeneral.AnimationIntro13,
                ConsoleColor.Blue, 150);
            Animation.PrintSegment(TextGeneral.AnimationIntro14,
                ConsoleColor.DarkCyan, 200);
        }
    }
}