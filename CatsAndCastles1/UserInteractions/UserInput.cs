namespace CatsAndCastles1.UserInteractions;

public class UserInput()
{
  

    public static void DramaticPause()
    {
        Screen.Print("Please press 'Enter' to continue...");
        Console.ReadLine();
    }

    public static void DramaticPauseClrScreen()
    {
        Console.WriteLine();
        Screen.Print("Please press 'Enter' to continue...");
        Console.ReadLine();
        Console.Clear();
    }

    public int GetChoice(List<string> choiceOptions, String extraChoice)
    {
        return UserInteractiveMenu.GiveChoices(choiceOptions, extraChoice);
    }
}