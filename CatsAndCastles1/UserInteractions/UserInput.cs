using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text;

namespace CatsAndCastles1.UserInteractions;

public class UserInput
{
  

    public static void DramaticPause()
    {
        Screen.Print(TextGeneral.PressEnter);
        Console.ReadLine();
    }

    public static void DramaticPauseClrScreen()
    {
        Console.WriteLine();
        Screen.Print(TextGeneral.PressEnter);
        Console.ReadLine();
        Console.Clear();
    }

    public int GetChoice(List<string> choiceOptions, String extraChoice)
    {
        return UserInteractiveMenu.GiveChoices(choiceOptions, extraChoice);
    }
}